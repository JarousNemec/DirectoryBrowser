using System.Windows.Forms;

namespace DirectoryBrowser
{
    public partial class ItemPropertiesForm : Form
    {
        public ItemPropertiesForm(BrowserItem item)
        {
            InitializeComponent();
            itemPropertiesControl.ListProperties(item);
        }
    }
}