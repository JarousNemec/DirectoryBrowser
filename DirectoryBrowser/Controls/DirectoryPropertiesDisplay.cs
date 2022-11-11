using System;
using System.Windows.Forms;

namespace DirectoryBrowser.Controls
{
    public partial class DirectoryPropertiesDisplay : UserControl
    {
        public DirectoryPropertiesDisplay()
        {
            InitializeComponent();
        }

        public void SetDirectoryProperties(int dirsCount, int filesCount)
        {
            _lblFilesCount.Text = filesCount.ToString();
            _lblDirsCount.Text = dirsCount.ToString();
        }
    }
}