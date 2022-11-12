namespace DirectoryBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this._lblPath = new System.Windows.Forms.Label();
            this._btnUpperDir = new System.Windows.Forms.Button();
            this._directoryProperties = new DirectoryBrowser.Controls.DirectoryPropertiesDisplay();
            this._colHName = new System.Windows.Forms.ColumnHeader();
            this._colHType = new System.Windows.Forms.ColumnHeader();
            this._colHDate = new System.Windows.Forms.ColumnHeader();
            this._lvBrowser = new System.Windows.Forms.ListView();
            this._btnChoose = new System.Windows.Forms.Button();
            this._lblProperties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblPath
            // 
            this._lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._lblPath.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._lblPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPath.Location = new System.Drawing.Point(4, 0);
            this._lblPath.Name = "_lblPath";
            this._lblPath.Size = new System.Drawing.Size(1575, 23);
            this._lblPath.TabIndex = 0;
            this._lblPath.Text = "c:/";
            this._lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _btnUpperDir
            // 
            this._btnUpperDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnUpperDir.Location = new System.Drawing.Point(3, 31);
            this._btnUpperDir.Name = "_btnUpperDir";
            this._btnUpperDir.Size = new System.Drawing.Size(34, 25);
            this._btnUpperDir.TabIndex = 1;
            this._btnUpperDir.Text = "⬑\r\n";
            this._btnUpperDir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnUpperDir.UseVisualStyleBackColor = true;
            this._btnUpperDir.Click += new System.EventHandler(this._btnUpperDir_Click);
            // 
            // _directoryProperties
            // 
            this._directoryProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._directoryProperties.BackColor = System.Drawing.SystemColors.ControlLight;
            this._directoryProperties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._directoryProperties.Location = new System.Drawing.Point(4, 836);
            this._directoryProperties.Name = "_directoryProperties";
            this._directoryProperties.Size = new System.Drawing.Size(1575, 23);
            this._directoryProperties.TabIndex = 2;
            // 
            // _colHName
            // 
            this._colHName.Text = "Name";
            this._colHName.Width = 400;
            // 
            // _colHType
            // 
            this._colHType.Text = "Type";
            this._colHType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._colHType.Width = 200;
            // 
            // _colHDate
            // 
            this._colHDate.Text = "Date";
            this._colHDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._colHDate.Width = 200;
            // 
            // _lvBrowser
            // 
            this._lvBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._lvBrowser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this._colHName, this._colHType, this._colHDate });
            this._lvBrowser.FullRowSelect = true;
            this._lvBrowser.Location = new System.Drawing.Point(4, 64);
            this._lvBrowser.Name = "_lvBrowser";
            this._lvBrowser.Size = new System.Drawing.Size(1575, 769);
            this._lvBrowser.TabIndex = 3;
            this._lvBrowser.UseCompatibleStateImageBehavior = false;
            this._lvBrowser.View = System.Windows.Forms.View.Details;
            this._lvBrowser.SelectedIndexChanged += new System.EventHandler(this._lvBrowser_SelectedIndexChanged);
            this._lvBrowser.DoubleClick += new System.EventHandler(this._lvBrowser_DoubleClick);
            this._lvBrowser.MouseClick += new System.Windows.Forms.MouseEventHandler(this._lvBrowser_MouseClick);
            // 
            // _btnChoose
            // 
            this._btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnChoose.Location = new System.Drawing.Point(1504, 31);
            this._btnChoose.Name = "_btnChoose";
            this._btnChoose.Size = new System.Drawing.Size(75, 25);
            this._btnChoose.TabIndex = 4;
            this._btnChoose.Text = "Choose";
            this._btnChoose.UseVisualStyleBackColor = true;
            this._btnChoose.Click += new System.EventHandler(this._btnChoose_Click);
            // 
            // _lblProperties
            // 
            this._lblProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblProperties.Location = new System.Drawing.Point(1404, 31);
            this._lblProperties.Name = "_lblProperties";
            this._lblProperties.Size = new System.Drawing.Size(94, 25);
            this._lblProperties.TabIndex = 5;
            this._lblProperties.Text = "Properties";
            this._lblProperties.UseVisualStyleBackColor = true;
            this._lblProperties.Click += new System.EventHandler(this._lblProperties_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this._lblProperties);
            this.Controls.Add(this._btnChoose);
            this.Controls.Add(this._lvBrowser);
            this.Controls.Add(this._directoryProperties);
            this.Controls.Add(this._btnUpperDir);
            this.Controls.Add(this._lblPath);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "Choose file";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _lblProperties;

        private System.Windows.Forms.Button _btnChoose;

        private System.Windows.Forms.Button _btnUpperDir;
        private DirectoryBrowser.Controls.DirectoryPropertiesDisplay _directoryProperties;
        private System.Windows.Forms.ColumnHeader _colHName;
        private System.Windows.Forms.ColumnHeader _colHType;
        private System.Windows.Forms.ColumnHeader _colHDate;
        private System.Windows.Forms.ListView _lvBrowser;

        private DirectoryBrowser.Controls.DirectoryPropertiesDisplay directoryPropertiesDisplay1;

        private System.Windows.Forms.Label _lblPath;

        #endregion
    }
}