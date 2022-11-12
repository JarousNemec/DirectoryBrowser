using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DirectoryBrowser.Controls
{
    public partial class ItemPropertiesControl : UserControl
    {
        public ItemPropertiesControl()
        {
            InitializeComponent();
        }

        public void ListProperties(BrowserItem item)
        {
            int count = 0;
            const int height = 25;
            if (item.Type == BrowserItemType.Folder)
            {
                var info = new DirectoryInfo(item.Path);
                PropertyInfo[] props = typeof(DirectoryInfo).GetProperties();
                foreach (var prop in props)
                {
                    var value = prop.GetValue(info, null)?.ToString();
                    var name = prop.Name;
                    DisplayProperty(height, count, name, value);
                    count++;
                }
            }
            else if (item.Type == BrowserItemType.File)
            {
                var info = new FileInfo(item.Path);
                PropertyInfo[] props = typeof(FileInfo).GetProperties();
                foreach (var prop in props)
                {
                    var value = prop.GetValue(info, null)?.ToString();
                    var name = prop.Name;
                    DisplayProperty(height, count, name, value);
                    count++;
                }
            }
        }

        private void DisplayProperty(int height, int count, string name, string value)
        {
            _pnlProperties.Controls.Add(new Label()
            {
                Location = new Point(0, height * count), Size = new Size(_pnlProperties.Width / 2, height),
                Text = name
            });
            _pnlProperties.Controls.Add(new Label()
            {
                Location = new Point(_pnlProperties.Width / 2, height * count),
                Size = new Size(_pnlProperties.Width / 2, height), Text = value
            });
        }
    }
}