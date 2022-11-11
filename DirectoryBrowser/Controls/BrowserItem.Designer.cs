using System.ComponentModel;

namespace DirectoryBrowser.Controls
{
    partial class BrowserItem
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
            this._picItemIcon = new System.Windows.Forms.PictureBox();
            this._lblItemName = new System.Windows.Forms.Label();
            this._lblItemType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._picItemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // _picItemIcon
            // 
            this._picItemIcon.Location = new System.Drawing.Point(0, 0);
            this._picItemIcon.Name = "_picItemIcon";
            this._picItemIcon.Size = new System.Drawing.Size(23, 23);
            this._picItemIcon.TabIndex = 0;
            this._picItemIcon.TabStop = false;
            // 
            // _lblItemName
            // 
            this._lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblItemName.Location = new System.Drawing.Point(29, 0);
            this._lblItemName.Name = "_lblItemName";
            this._lblItemName.Size = new System.Drawing.Size(280, 23);
            this._lblItemName.TabIndex = 1;
            this._lblItemName.Text = "Browser item name";
            this._lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblItemType
            // 
            this._lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblItemType.Location = new System.Drawing.Point(320, 0);
            this._lblItemType.Name = "_lblItemType";
            this._lblItemType.Size = new System.Drawing.Size(132, 23);
            this._lblItemType.TabIndex = 2;
            this._lblItemType.Text = "Browser item type";
            this._lblItemType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Browser item datetime";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BrowserItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblItemType);
            this.Controls.Add(this._lblItemName);
            this.Controls.Add(this._picItemIcon);
            this.Name = "BrowserItem";
            this.Size = new System.Drawing.Size(1042, 23);
            ((System.ComponentModel.ISupportInitialize)(this._picItemIcon)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label _lblItemName;

        private System.Windows.Forms.PictureBox _picItemIcon;
        private System.Windows.Forms.Label _lblItemType;

        #endregion
    }
}