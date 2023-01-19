namespace WeDevelopNowApplicationMain
{
    partial class UserControlWomenSearchResultScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlWomenSearchResultScreen));
            this.pnlWomenSearchResult = new System.Windows.Forms.Panel();
            this.dgvwWomenResults = new System.Windows.Forms.DataGridView();
            this.btnWomenResultToHome = new System.Windows.Forms.Button();
            this.btnBackToWomen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoMatchesWomen = new System.Windows.Forms.Label();
            this.pnlWomenSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWomenResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWomenSearchResult
            // 
            this.pnlWomenSearchResult.Controls.Add(this.dgvwWomenResults);
            this.pnlWomenSearchResult.Controls.Add(this.btnWomenResultToHome);
            this.pnlWomenSearchResult.Controls.Add(this.btnBackToWomen);
            this.pnlWomenSearchResult.Controls.Add(this.pictureBox1);
            this.pnlWomenSearchResult.Controls.Add(this.label1);
            this.pnlWomenSearchResult.Location = new System.Drawing.Point(0, 0);
            this.pnlWomenSearchResult.Name = "pnlWomenSearchResult";
            this.pnlWomenSearchResult.Size = new System.Drawing.Size(580, 750);
            this.pnlWomenSearchResult.TabIndex = 6;
            // 
            // dgvwWomenResults
            // 
            this.dgvwWomenResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwWomenResults.Location = new System.Drawing.Point(61, 233);
            this.dgvwWomenResults.Name = "dgvwWomenResults";
            this.dgvwWomenResults.RowHeadersWidth = 51;
            this.dgvwWomenResults.RowTemplate.Height = 24;
            this.dgvwWomenResults.Size = new System.Drawing.Size(480, 345);
            this.dgvwWomenResults.TabIndex = 9;
            // 
            // btnWomenResultToHome
            // 
            this.btnWomenResultToHome.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnWomenResultToHome.Location = new System.Drawing.Point(326, 618);
            this.btnWomenResultToHome.Name = "btnWomenResultToHome";
            this.btnWomenResultToHome.Size = new System.Drawing.Size(220, 90);
            this.btnWomenResultToHome.TabIndex = 7;
            this.btnWomenResultToHome.Text = "Home";
            this.btnWomenResultToHome.UseVisualStyleBackColor = true;
            this.btnWomenResultToHome.Click += new System.EventHandler(this.btnWomenResultToHome_Click);
            // 
            // btnBackToWomen
            // 
            this.btnBackToWomen.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnBackToWomen.Location = new System.Drawing.Point(48, 618);
            this.btnBackToWomen.Name = "btnBackToWomen";
            this.btnBackToWomen.Size = new System.Drawing.Size(220, 90);
            this.btnBackToWomen.TabIndex = 8;
            this.btnBackToWomen.Text = "<< Back";
            this.btnBackToWomen.UseVisualStyleBackColor = true;
            this.btnBackToWomen.Click += new System.EventHandler(this.btnBackToWomen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, -51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Women results";
            // 
            // lblNoMatchesWomen
            // 
            this.lblNoMatchesWomen.AutoSize = true;
            this.lblNoMatchesWomen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.lblNoMatchesWomen.Font = new System.Drawing.Font("Verdana", 16F);
            this.lblNoMatchesWomen.Location = new System.Drawing.Point(115, 430);
            this.lblNoMatchesWomen.Name = "lblNoMatchesWomen";
            this.lblNoMatchesWomen.Size = new System.Drawing.Size(400, 32);
            this.lblNoMatchesWomen.TabIndex = 11;
            this.lblNoMatchesWomen.Text = "No items match search filter";
            // 
            // UserControlWomenSearchResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.lblNoMatchesWomen);
            this.Controls.Add(this.pnlWomenSearchResult);
            this.Name = "UserControlWomenSearchResultScreen";
            this.Size = new System.Drawing.Size(580, 750);
            this.pnlWomenSearchResult.ResumeLayout(false);
            this.pnlWomenSearchResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWomenResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWomenSearchResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackToWomen;
        private System.Windows.Forms.Button btnWomenResultToHome;
        private System.Windows.Forms.DataGridView dgvwWomenResults;
        private System.Windows.Forms.Label lblNoMatchesWomen;
    }
}
