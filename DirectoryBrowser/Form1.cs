using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryBrowser
{
    public partial class Form1 : Form
    {
        private const string ROOT_DIR = "c:/";
        private string _actualOpenedDir = string.Empty;
        public Form1()
        {
            InitializeComponent();
            
            ImageList icons = LoadIcons("./icons/");
            _lvBrowser.LargeImageList = icons;
            _lvBrowser.SmallImageList = icons;
            
            
        }

        private void LoadDir(string dirToLoad)
        {
            _actualOpenedDir = dirToLoad;
            string[] filePaths = Directory.GetFiles(dirToLoad);
            string[] dirPaths = Directory.GetDirectories(dirToLoad);
            foreach (var dirPath in dirPaths)
            {
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                AddItemToBrowser(new BrowserItem(){Date = dir.LastWriteTime, Extension = "", Name = dir.Name, Type = "folder"});
            }
            
        }

        private void AddItemToBrowser(BrowserItem item)
        {
            ListViewItem item3 = new ListViewItem("item3","file");
            // Place a check mark next to the item.
            // item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
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
            test testForm = new test();
            testForm.Show();
        }

        private void _lvBrowser_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("ahoj");
        }

        private void _lvBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}