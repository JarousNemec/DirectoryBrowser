using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryBrowser
{
    public partial class Form1 : Form
    {
        private const string ROOT_DIR = "c:\\";
        private string _actualOpenedDir = string.Empty;
        private ContextMenuStrip _cmsBrowserItem;

        public Form1()
        {
            InitializeComponent();

            ImageList icons = LoadIcons("./icons/");
            _lvBrowser.LargeImageList = icons;
            _lvBrowser.SmallImageList = icons;

            _cmsBrowserItem = new ContextMenuStrip();
            var itemProperties = new ToolStripMenuItem("Properties");
            itemProperties.Click += itemPropertiesOnClick;
            _cmsBrowserItem.Items.Add(itemProperties);

            LoadDir(ROOT_DIR);
        }

        private void itemPropertiesOnClick(object sender, EventArgs e)
        {
            if (_lvBrowser.FocusedItem == null)
                return;

            BrowserItem item = (BrowserItem)_lvBrowser.FocusedItem.Tag;

            ItemPropertiesForm propertiesForm = new ItemPropertiesForm(item);
            propertiesForm.Show();
        }

        private void LoadDir(string dirToLoad)
        {
            string[] filePaths;
            string[] dirPaths;

            try
            {
                filePaths = Directory.GetFiles(dirToLoad);
                dirPaths = Directory.GetDirectories(dirToLoad);
            }
            catch (Exception e)
            {
                return;
            }


            ActualizeInfo(dirToLoad, filePaths.Length, dirPaths.Length);
            InsertFilesAndDirsToList(dirPaths, filePaths);
        }

        private void InsertFilesAndDirsToList(string[] dirPaths, string[] filePaths)
        {
            _lvBrowser.Items.Clear();
            foreach (var dirPath in dirPaths)
            {
                DirectoryInfo dir = new DirectoryInfo(dirPath);

                AddItemToBrowser(new BrowserItem()
                {
                    Date = dir.LastWriteTime, Extension = "", Name = dir.Name, Type = BrowserItemType.Folder,
                    Path = dirPath
                });
            }

            foreach (var filePath in filePaths)
            {
                FileInfo file = new FileInfo(filePath);
                AddItemToBrowser(new BrowserItem()
                {
                    Date = file.LastWriteTime, Extension = file.Extension,
                    Name = file.Name.Substring(0, file.Name.Length - file.Extension.Length),
                    Type = BrowserItemType.File,
                    Path = filePath
                });
            }
        }

        private void ActualizeInfo(string path, int fileCount, int dirCount)
        {
            _actualOpenedDir = path;
            _lblPath.Text = path;
            _directoryProperties.SetDirectoryProperties(dirCount, fileCount);
        }

        private void AddItemToBrowser(BrowserItem item)
        {
            string type = string.Empty;
            switch (item.Type)
            {
                case BrowserItemType.File:
                    type = "file";
                    break;
                case BrowserItemType.Folder:
                    type = "folder";
                    break;
            }

            var listViewItem = new ListViewItem(item.Name, type);
            listViewItem.SubItems.Add(item.Extension);
            listViewItem.SubItems.Add(item.Date.ToString());
            listViewItem.Name = item.Name;
            listViewItem.Tag = item;
            listViewItem.ToolTipText = item.Path;
            _lvBrowser.Items.Add(listViewItem);
        }

        private ImageList LoadIcons(string path)
        {
            ImageList icons = new ImageList();
            string[] filePaths = Directory.GetFiles(path);
            foreach (var filePath in filePaths)
            {
                string imageKey = Path.GetFileNameWithoutExtension(filePath);
                icons.Images.Add(imageKey, Image.FromFile(filePath));
            }

            return icons;
        }

        private void _btnUpperDir_Click(object sender, EventArgs e)
        {
            DirectoryInfo parrentDir = Directory.GetParent(_actualOpenedDir);
            if (parrentDir != null)
            {
                LoadDir(parrentDir.FullName);
            }
        }

        public delegate void FileChooseNotify(string filePath);

        public event FileChooseNotify FileChoose;

        private void _lvBrowser_DoubleClick(object sender, EventArgs e)
        {
            if (_lvBrowser.FocusedItem == null)
                return;

            BrowserItem item = (BrowserItem)_lvBrowser.FocusedItem.Tag;
            if (item.Type == BrowserItemType.Folder)
            {
                LoadDir(item.Path);
            }
            else if (item.Type == BrowserItemType.File)
            {
                ChooseFile();
            }
        }

        private void ChooseFile()
        {
            if (_lvBrowser.FocusedItem == null)
                return;

            BrowserItem item = (BrowserItem)_lvBrowser.FocusedItem.Tag;
            MessageBox.Show($@"File: {item.Path} was chosen", @"File chosen event");
            FileChoose?.Invoke(item.Path);
        }

        private void _btnChoose_Click(object sender, EventArgs e)
        {
            if (_lvBrowser.FocusedItem == null)
                return;

            BrowserItem item = (BrowserItem)_lvBrowser.FocusedItem.Tag;

            if (item.Type == BrowserItemType.File)
            {
                ChooseFile();
            }
        }

        private void _lvBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvBrowser.FocusedItem == null)
                return;

            BrowserItem item = (BrowserItem)_lvBrowser.FocusedItem.Tag;
            _lblPath.Text = item.Path;
        }

        private void _lvBrowser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = _lvBrowser.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    _cmsBrowserItem.Show(Cursor.Position);
                }
            }
        }

        private void _lblProperties_Click(object sender, EventArgs e)
        {
            if (_lvBrowser.FocusedItem == null)
                return;

            BrowserItem item = (BrowserItem)_lvBrowser.FocusedItem.Tag;

            ItemPropertiesForm propertiesForm = new ItemPropertiesForm(item);
            propertiesForm.Show();
        }
    }
}