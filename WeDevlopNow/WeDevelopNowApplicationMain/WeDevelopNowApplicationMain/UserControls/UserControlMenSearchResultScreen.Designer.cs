namespace WeDevelopNowApplicationMain
{
    partial class UserControlMenSearchResultScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMenSearchResultScreen));
            this.pnlMenSearchResult = new System.Windows.Forms.Panel();
            this.btnMenResultToHome = new System.Windows.Forms.Button();
            this.btnBackToMen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvwMenResults = new System.Windows.Forms.DataGridView();
            this.pnlMenSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwMenResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenSearchResult
            // 
            this.pnlMenSearchResult.Controls.Add(this.dgvwMenResults);
            this.pnlMenSearchResult.Controls.Add(this.btnMenResultToHome);
            this.pnlMenSearchResult.Controls.Add(this.btnBackToMen);
            this.pnlMenSearchResult.Controls.Add(this.pictureBox1);
            this.pnlMenSearchResult.Controls.Add(this.label1);
            this.pnlMenSearchResult.Location = new System.Drawing.Point(0, 0);
            this.pnlMenSearchResult.Name = "pnlMenSearchResult";
            this.pnlMenSearchResult.Size = new System.Drawing.Size(580, 750);
            this.pnlMenSearchResult.TabIndex = 6;
            // 
            // btnMenResultToHome
            // 
            this.btnMenResultToHome.Location = new System.Drawing.Point(320, 602);
            this.btnMenResultToHome.Name = "btnMenResultToHome";
            this.btnMenResultToHome.Size = new System.Drawing.Size(220, 90);
            this.btnMenResultToHome.TabIndex = 7;
            this.btnMenResultToHome.Text = "Home";
            this.btnMenResultToHome.UseVisualStyleBackColor = true;
            this.btnMenResultToHome.Click += new System.EventHandler(this.btnMenResultToHome_Click);
            // 
            // btnBackToMen
            // 
            this.btnBackToMen.Location = new System.Drawing.Point(61, 602);
            this.btnBackToMen.Name = "btnBackToMen";
            this.btnBackToMen.Size = new System.Drawing.Size(220, 90);
            this.btnBackToMen.TabIndex = 8;
            this.btnBackToMen.Text = "<< Back";
            this.btnBackToMen.UseVisualStyleBackColor = true;
            this.btnBackToMen.Click += new System.EventHandler(this.btnBackToMen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Men results";
            // 
            // dgvwMenResults
            // 
            this.dgvwMenResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwMenResults.Location = new System.Drawing.Point(61, 233);
            this.dgvwMenResults.Name = "dgvwMenResults";
            this.dgvwMenResults.RowHeadersWidth = 51;
            this.dgvwMenResults.RowTemplate.Height = 24;
            this.dgvwMenResults.Size = new System.Drawing.Size(479, 343);
            this.dgvwMenResults.TabIndex = 9;
            // 
            // UserControlMenSearchResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMenSearchResult);
            this.Name = "UserControlMenSearchResultScreen";
            this.Size = new System.Drawing.Size(580, 750);
            this.pnlMenSearchResult.ResumeLayout(false);
            this.pnlMenSearchResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwMenResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenSearchResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenResultToHome;
        private System.Windows.Forms.Button btnBackToMen;
        private System.Windows.Forms.DataGridView dgvwMenResults;
    }
}
