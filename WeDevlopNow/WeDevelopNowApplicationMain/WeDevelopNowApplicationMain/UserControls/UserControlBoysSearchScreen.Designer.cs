﻿namespace WeDevelopNowApplicationMain
{
    partial class UserControlBoysSearchScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBoysSearchScreen));
            this.pnlBoysSearch = new System.Windows.Forms.Panel();
            this.btnBoysToHome = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblBoysTitle1 = new System.Windows.Forms.Label();
            this.txtbProductTypeBoys = new System.Windows.Forms.TextBox();
            this.pnlBoysSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBoysSearch
            // 
            this.pnlBoysSearch.Controls.Add(this.txtbProductTypeBoys);
            this.pnlBoysSearch.Controls.Add(this.btnBoysToHome);
            this.pnlBoysSearch.Controls.Add(this.pictureBox4);
            this.pnlBoysSearch.Controls.Add(this.lblBoysTitle1);
            this.pnlBoysSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlBoysSearch.Name = "pnlBoysSearch";
            this.pnlBoysSearch.Size = new System.Drawing.Size(580, 750);
            this.pnlBoysSearch.TabIndex = 4;
            // 
            // btnBoysToHome
            // 
            this.btnBoysToHome.Location = new System.Drawing.Point(37, 642);
            this.btnBoysToHome.Name = "btnBoysToHome";
            this.btnBoysToHome.Size = new System.Drawing.Size(519, 90);
            this.btnBoysToHome.TabIndex = 5;
            this.btnBoysToHome.Text = "<< Home";
            this.btnBoysToHome.UseVisualStyleBackColor = true;
            this.btnBoysToHome.Click += new System.EventHandler(this.btnBoysToHome_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(210, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(181, 191);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // lblBoysTitle1
            // 
            this.lblBoysTitle1.AutoSize = true;
            this.lblBoysTitle1.Location = new System.Drawing.Point(34, 37);
            this.lblBoysTitle1.Name = "lblBoysTitle1";
            this.lblBoysTitle1.Size = new System.Drawing.Size(38, 16);
            this.lblBoysTitle1.TabIndex = 0;
            this.lblBoysTitle1.Text = "Boys";
            // 
            // txtbProductTypeBoys
            // 
            this.txtbProductTypeBoys.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtbProductTypeBoys.Location = new System.Drawing.Point(37, 255);
            this.txtbProductTypeBoys.Name = "txtbProductTypeBoys";
            this.txtbProductTypeBoys.Size = new System.Drawing.Size(519, 41);
            this.txtbProductTypeBoys.TabIndex = 6;
            // 
            // UserControlBoysSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBoysSearch);
            this.Name = "UserControlBoysSearchScreen";
            this.Size = new System.Drawing.Size(580, 750);
            this.pnlBoysSearch.ResumeLayout(false);
            this.pnlBoysSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoysSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblBoysTitle1;
        private System.Windows.Forms.Button btnBoysToHome;
        private System.Windows.Forms.TextBox txtbProductTypeBoys;
    }
}
