using System.ComponentModel;

namespace DirectoryBrowser.Controls
{
    partial class DirectoryPropertiesDisplay
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
            this._lblFilesCount = new System.Windows.Forms.Label();
            this._lblDirsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblFilesCount
            // 
            this._lblFilesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFilesCount.Location = new System.Drawing.Point(56, 0);
            this._lblFilesCount.Name = "_lblFilesCount";
            this._lblFilesCount.Size = new System.Drawing.Size(51, 23);
            this._lblFilesCount.TabIndex = 0;
            this._lblFilesCount.Text = "0";
            this._lblFilesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblDirsCount
            // 
            this._lblDirsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDirsCount.Location = new System.Drawing.Point(173, 0);
            this._lblDirsCount.Name = "_lblDirsCount";
            this._lblDirsCount.Size = new System.Drawing.Size(50, 23);
            this._lblDirsCount.TabIndex = 1;
            this._lblDirsCount.Text = "0";
            this._lblDirsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirs: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Files: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DirectoryPropertiesDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._lblDirsCount);
            this.Controls.Add(this._lblFilesCount);
            this.Name = "DirectoryPropertiesDisplay";
            this.Size = new System.Drawing.Size(308, 23);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label _lblFilesCount;
        private System.Windows.Forms.Label _lblDirsCount;

        #endregion
    }
}