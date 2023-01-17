namespace WeDevelopNowApplicationMain
{
    partial class UserControlHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHomepage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHomeMen = new System.Windows.Forms.Button();
            this.pnlHomepage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHomepage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnHomeMen
            // 
            this.btnHomeMen.Location = new System.Drawing.Point(68, 339);
            this.btnHomeMen.Name = "btnHomeMen";
            this.btnHomeMen.Size = new System.Drawing.Size(125, 79);
            this.btnHomeMen.TabIndex = 3;
            this.btnHomeMen.Text = "Men";
            this.btnHomeMen.UseVisualStyleBackColor = true;
            this.btnHomeMen.Click += new System.EventHandler(this.btnHomeMen_Click);
            // 
            // pnlHomepage
            // 
            this.pnlHomepage.Controls.Add(this.pictureBox1);
            this.pnlHomepage.Controls.Add(this.btnHomeMen);
            this.pnlHomepage.Location = new System.Drawing.Point(0, 0);
            this.pnlHomepage.Name = "pnlHomepage";
            this.pnlHomepage.Size = new System.Drawing.Size(580, 750);
            this.pnlHomepage.TabIndex = 4;
            // 
            // UserControlHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHomepage);
            this.Name = "UserControlHomepage";
            this.Size = new System.Drawing.Size(580, 750);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHomepage.ResumeLayout(false);
            this.pnlHomepage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHomeMen;
        private System.Windows.Forms.Panel pnlHomepage;
    }
}
