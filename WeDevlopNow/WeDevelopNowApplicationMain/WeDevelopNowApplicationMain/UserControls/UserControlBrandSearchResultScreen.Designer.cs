namespace WeDevelopNowApplicationMain
{
    partial class UserControlBrandSearchResultScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBrandSearchResultScreen));
            this.pnlBrandSearchResult = new System.Windows.Forms.Panel();
            this.dgvwBrandResults = new System.Windows.Forms.DataGridView();
            this.btnBrandResultToHome = new System.Windows.Forms.Button();
            this.btnBrandResultBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNoMatchesBrand = new System.Windows.Forms.Label();
            this.pnlBrandSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBrandResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBrandSearchResult
            // 
            this.pnlBrandSearchResult.Controls.Add(this.dgvwBrandResults);
            this.pnlBrandSearchResult.Controls.Add(this.btnBrandResultToHome);
            this.pnlBrandSearchResult.Controls.Add(this.btnBrandResultBack);
            this.pnlBrandSearchResult.Controls.Add(this.pictureBox1);
            this.pnlBrandSearchResult.Location = new System.Drawing.Point(0, 0);
            this.pnlBrandSearchResult.Name = "pnlBrandSearchResult";
            this.pnlBrandSearchResult.Size = new System.Drawing.Size(580, 750);
            this.pnlBrandSearchResult.TabIndex = 6;
            // 
            // dgvwBrandResults
            // 
            this.dgvwBrandResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwBrandResults.Location = new System.Drawing.Point(61, 233);
            this.dgvwBrandResults.Name = "dgvwBrandResults";
            this.dgvwBrandResults.RowHeadersWidth = 51;
            this.dgvwBrandResults.RowTemplate.Height = 24;
            this.dgvwBrandResults.Size = new System.Drawing.Size(480, 345);
            this.dgvwBrandResults.TabIndex = 9;
            // 
            // btnBrandResultToHome
            // 
            this.btnBrandResultToHome.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnBrandResultToHome.Location = new System.Drawing.Point(336, 639);
            this.btnBrandResultToHome.Name = "btnBrandResultToHome";
            this.btnBrandResultToHome.Size = new System.Drawing.Size(220, 90);
            this.btnBrandResultToHome.TabIndex = 7;
            this.btnBrandResultToHome.Text = "Home";
            this.btnBrandResultToHome.UseVisualStyleBackColor = true;
            this.btnBrandResultToHome.Click += new System.EventHandler(this.btnBrandResultToHome_Click);
            // 
            // btnBrandResultBack
            // 
            this.btnBrandResultBack.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnBrandResultBack.Location = new System.Drawing.Point(29, 639);
            this.btnBrandResultBack.Name = "btnBrandResultBack";
            this.btnBrandResultBack.Size = new System.Drawing.Size(220, 90);
            this.btnBrandResultBack.TabIndex = 8;
            this.btnBrandResultBack.Text = "<< Back";
            this.btnBrandResultBack.UseVisualStyleBackColor = true;
            this.btnBrandResultBack.Click += new System.EventHandler(this.btnBrandResultBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNoMatchesBrand
            // 
            this.lblNoMatchesBrand.AutoSize = true;
            this.lblNoMatchesBrand.Font = new System.Drawing.Font("Verdana", 16F);
            this.lblNoMatchesBrand.Location = new System.Drawing.Point(115, 430);
            this.lblNoMatchesBrand.Name = "lblNoMatchesBrand";
            this.lblNoMatchesBrand.Size = new System.Drawing.Size(400, 32);
            this.lblNoMatchesBrand.TabIndex = 13;
            this.lblNoMatchesBrand.Text = "No items match search filter";
            // 
            // UserControlBrandSearchResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.lblNoMatchesBrand);
            this.Controls.Add(this.pnlBrandSearchResult);
            this.Name = "UserControlBrandSearchResultScreen";
            this.Size = new System.Drawing.Size(580, 750);
            this.pnlBrandSearchResult.ResumeLayout(false);
            this.pnlBrandSearchResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBrandResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrandSearchResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrandResultToHome;
        private System.Windows.Forms.Button btnBrandResultBack;
        private System.Windows.Forms.DataGridView dgvwBrandResults;
        private System.Windows.Forms.Label lblNoMatchesBrand;
    }
}
