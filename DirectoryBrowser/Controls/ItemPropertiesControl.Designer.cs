using System.ComponentModel;

namespace DirectoryBrowser.Controls
{
    partial class ItemPropertiesControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._pnlProperties = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _pnlProperties
            // 
            this._pnlProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlProperties.AutoScroll = true;
            this._pnlProperties.Location = new System.Drawing.Point(0, 0);
            this._pnlProperties.Name = "_pnlProperties";
            this._pnlProperties.Size = new System.Drawing.Size(395, 496);
            this._pnlProperties.TabIndex = 0;
            // 
            // ItemPropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pnlProperties);
            this.Name = "ItemPropertiesControl";
            this.Size = new System.Drawing.Size(395, 496);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel _pnlProperties;

        #endregion
    }
}