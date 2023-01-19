namespace WeDevelopNowApplicationMain
{
    partial class UserControlBrandTypeSearchResultScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBrandTypeSearchResultScreen));
            this.pnlBrandTypeSearchResult = new System.Windows.Forms.Panel();
            this.dgvwBrandTypeResults = new System.Windows.Forms.DataGridView();
            this.btnBrandTypeResultBack = new System.Windows.Forms.Button();
            this.btnBrandTypeToHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNoMatchesBrandType = new System.Windows.Forms.Label();
            this.pnlBrandTypeSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBrandTypeResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBrandTypeSearchResult
            // 
            this.pnlBrandTypeSearchResult.Controls.Add(this.dgvwBrandTypeResults);
            this.pnlBrandTypeSearchResult.Controls.Add(this.btnBrandTypeResultBack);
            this.pnlBrandTypeSearchResult.Controls.Add(this.btnBrandTypeToHome);
            this.pnlBrandTypeSearchResult.Controls.Add(this.pictureBox1);
            this.pnlBrandTypeSearchResult.Location = new System.Drawing.Point(0, 0);
            this.pnlBrandTypeSearchResult.Name = "pnlBrandTypeSearchResult";
            this.pnlBrandTypeSearchResult.Size = new System.Drawing.Size(580, 750);
            this.pnlBrandTypeSearchResult.TabIndex = 6;
            // 
            // dgvwBrandTypeResults
            // 
            this.dgvwBrandTypeResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwBrandTypeResults.Location = new System.Drawing.Point(61, 233);
            this.dgvwBrandTypeResults.Name = "dgvwBrandTypeResults";
            this.dgvwBrandTypeResults.RowHeadersWidth = 51;
            this.dgvwBrandTypeResults.RowTemplate.Height = 24;
            this.dgvwBrandTypeResults.Size = new System.Drawing.Size(480, 345);
            this.dgvwBrandTypeResults.TabIndex = 8;
            // 
            // btnBrandTypeResultBack
            // 
            this.btnBrandTypeResultBack.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnBrandTypeResultBack.Location = new System.Drawing.Point(45, 607);
            this.btnBrandTypeResultBack.Name = "btnBrandTypeResultBack";
            this.btnBrandTypeResultBack.Size = new System.Drawing.Size(220, 90);
            this.btnBrandTypeResultBack.TabIndex = 7;
            this.btnBrandTypeResultBack.Text = "<< Back";
            this.btnBrandTypeResultBack.UseVisualStyleBackColor = true;
            this.btnBrandTypeResultBack.Click += new System.EventHandler(this.btnBrandTypeResultBack_Click);
            // 
            // btnBrandTypeToHome
            // 
            this.btnBrandTypeToHome.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnBrandTypeToHome.Location = new System.Drawing.Point(291, 607);
            this.btnBrandTypeToHome.Name = "btnBrandTypeToHome";
            this.btnBrandTypeToHome.Size = new System.Drawing.Size(220, 90);
            this.btnBrandTypeToHome.TabIndex = 7;
            this.btnBrandTypeToHome.Text = "Home";
            this.btnBrandTypeToHome.UseVisualStyleBackColor = true;
            this.btnBrandTypeToHome.Click += new System.EventHandler(this.btnBrandTypeToHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNoMatchesBrandType
            // 
            this.lblNoMatchesBrandType.AutoSize = true;
            this.lblNoMatchesBrandType.Font = new System.Drawing.Font("Verdana", 16F);
            this.lblNoMatchesBrandType.Location = new System.Drawing.Point(115, 430);
            this.lblNoMatchesBrandType.Name = "lblNoMatchesBrandType";
            this.lblNoMatchesBrandType.Size = new System.Drawing.Size(400, 32);
            this.lblNoMatchesBrandType.TabIndex = 14;
            this.lblNoMatchesBrandType.Text = "No items match search filter";
            // 
            // UserControlBrandTypeSearchResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.lblNoMatchesBrandType);
            this.Controls.Add(this.pnlBrandTypeSearchResult);
            this.Name = "UserControlBrandTypeSearchResultScreen";
            this.Size = new System.Drawing.Size(580, 750);
            this.pnlBrandTypeSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBrandTypeResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrandTypeSearchResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrandTypeToHome;
        private System.Windows.Forms.Button btnBrandTypeResultBack;
        private System.Windows.Forms.DataGridView dgvwBrandTypeResults;
        private System.Windows.Forms.Label lblNoMatchesBrandType;
    }
}
