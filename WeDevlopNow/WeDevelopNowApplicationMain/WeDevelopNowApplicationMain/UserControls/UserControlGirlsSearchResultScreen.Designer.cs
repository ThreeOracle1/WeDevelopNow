﻿namespace WeDevelopNowApplicationMain
{
    partial class UserControlGirlsSearchResultScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlGirlsSearchResultScreen));
            this.pnlGirlsSearchResult = new System.Windows.Forms.Panel();
            this.btnBackToGirls = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirlsResultsToHome = new System.Windows.Forms.Button();
            this.pnlGirlsSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGirlsSearchResult
            // 
            this.pnlGirlsSearchResult.Controls.Add(this.btnGirlsResultsToHome);
            this.pnlGirlsSearchResult.Controls.Add(this.btnBackToGirls);
            this.pnlGirlsSearchResult.Controls.Add(this.pictureBox1);
            this.pnlGirlsSearchResult.Controls.Add(this.label1);
            this.pnlGirlsSearchResult.Location = new System.Drawing.Point(0, 0);
            this.pnlGirlsSearchResult.Name = "pnlGirlsSearchResult";
            this.pnlGirlsSearchResult.Size = new System.Drawing.Size(580, 750);
            this.pnlGirlsSearchResult.TabIndex = 6;
            // 
            // btnBackToGirls
            // 
            this.btnBackToGirls.Location = new System.Drawing.Point(29, 642);
            this.btnBackToGirls.Name = "btnBackToGirls";
            this.btnBackToGirls.Size = new System.Drawing.Size(220, 90);
            this.btnBackToGirls.TabIndex = 8;
            this.btnBackToGirls.Text = "<< Back";
            this.btnBackToGirls.UseVisualStyleBackColor = true;
            this.btnBackToGirls.Click += new System.EventHandler(this.btnBackToGirls_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Girls results";
            // 
            // btnGirlsResultsToHome
            // 
            this.btnGirlsResultsToHome.Location = new System.Drawing.Point(304, 642);
            this.btnGirlsResultsToHome.Name = "btnGirlsResultsToHome";
            this.btnGirlsResultsToHome.Size = new System.Drawing.Size(220, 90);
            this.btnGirlsResultsToHome.TabIndex = 7;
            this.btnGirlsResultsToHome.Text = "Home";
            this.btnGirlsResultsToHome.UseVisualStyleBackColor = true;
            this.btnGirlsResultsToHome.Click += new System.EventHandler(this.btnGirlsResultsToHome_Click);
            // 
            // UserControlGirlsSearchResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGirlsSearchResult);
            this.Name = "UserControlGirlsSearchResultScreen";
            this.Size = new System.Drawing.Size(580, 750);
            this.pnlGirlsSearchResult.ResumeLayout(false);
            this.pnlGirlsSearchResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGirlsSearchResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirlsResultsToHome;
        private System.Windows.Forms.Button btnBackToGirls;
    }
}
