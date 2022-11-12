using System.ComponentModel;

namespace DirectoryBrowser
{
    partial class ItemPropertiesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPropertiesControl = new DirectoryBrowser.Controls.ItemPropertiesControl();
            this.SuspendLayout();
            // 
            // itemPropertiesControl
            // 
            this.itemPropertiesControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.itemPropertiesControl.Location = new System.Drawing.Point(0, 1);
            this.itemPropertiesControl.Name = "itemPropertiesControl";
            this.itemPropertiesControl.Size = new System.Drawing.Size(446, 579);
            this.itemPropertiesControl.TabIndex = 0;
            // 
            // ItemPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 580);
            this.Controls.Add(this.itemPropertiesControl);
            this.Name = "ItemPropertiesForm";
            this.Text = "Properties";
            this.ResumeLayout(false);
        }

        private DirectoryBrowser.Controls.ItemPropertiesControl itemPropertiesControl;

        #endregion
    }
}