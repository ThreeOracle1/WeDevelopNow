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
            this.btnHomeWomen = new System.Windows.Forms.Button();
            this.btnHomeBoys = new System.Windows.Forms.Button();
            this.btnHomeGirls = new System.Windows.Forms.Button();
            this.btnHomeBrand = new System.Windows.Forms.Button();
            this.btnHomeBrandType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHomepage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnHomeMen
            // 
            this.btnHomeMen.Location = new System.Drawing.Point(129, 339);
            this.btnHomeMen.Name = "btnHomeMen";
            this.btnHomeMen.Size = new System.Drawing.Size(125, 79);
            this.btnHomeMen.TabIndex = 3;
            this.btnHomeMen.Text = "Men";
            this.btnHomeMen.UseVisualStyleBackColor = true;
            this.btnHomeMen.Click += new System.EventHandler(this.btnHomeMen_Click);
            // 
            // pnlHomepage
            // 
            this.pnlHomepage.Controls.Add(this.btnHomeBrandType);
            this.pnlHomepage.Controls.Add(this.btnHomeBrand);
            this.pnlHomepage.Controls.Add(this.btnHomeGirls);
            this.pnlHomepage.Controls.Add(this.btnHomeBoys);
            this.pnlHomepage.Controls.Add(this.btnHomeWomen);
            this.pnlHomepage.Controls.Add(this.pictureBox1);
            this.pnlHomepage.Controls.Add(this.btnHomeMen);
            this.pnlHomepage.Location = new System.Drawing.Point(0, 0);
            this.pnlHomepage.Name = "pnlHomepage";
            this.pnlHomepage.Size = new System.Drawing.Size(580, 750);
            this.pnlHomepage.TabIndex = 4;
            // 
            // btnHomeWomen
            // 
            this.btnHomeWomen.Location = new System.Drawing.Point(306, 339);
            this.btnHomeWomen.Name = "btnHomeWomen";
            this.btnHomeWomen.Size = new System.Drawing.Size(114, 79);
            this.btnHomeWomen.TabIndex = 4;
            this.btnHomeWomen.Text = "Women";
            this.btnHomeWomen.UseVisualStyleBackColor = true;
            this.btnHomeWomen.Click += new System.EventHandler(this.btnHomeWomen_Click);
            // 
            // btnHomeBoys
            // 
            this.btnHomeBoys.Location = new System.Drawing.Point(129, 442);
            this.btnHomeBoys.Name = "btnHomeBoys";
            this.btnHomeBoys.Size = new System.Drawing.Size(125, 79);
            this.btnHomeBoys.TabIndex = 5;
            this.btnHomeBoys.Text = "Boys";
            this.btnHomeBoys.UseVisualStyleBackColor = true;
            // 
            // btnHomeGirls
            // 
            this.btnHomeGirls.Location = new System.Drawing.Point(306, 442);
            this.btnHomeGirls.Name = "btnHomeGirls";
            this.btnHomeGirls.Size = new System.Drawing.Size(114, 79);
            this.btnHomeGirls.TabIndex = 6;
            this.btnHomeGirls.Text = "Girls";
            this.btnHomeGirls.UseVisualStyleBackColor = true;
            // 
            // btnHomeBrand
            // 
            this.btnHomeBrand.Location = new System.Drawing.Point(129, 539);
            this.btnHomeBrand.Name = "btnHomeBrand";
            this.btnHomeBrand.Size = new System.Drawing.Size(125, 79);
            this.btnHomeBrand.TabIndex = 7;
            this.btnHomeBrand.Text = "Brand";
            this.btnHomeBrand.UseVisualStyleBackColor = true;
            // 
            // btnHomeBrandType
            // 
            this.btnHomeBrandType.Location = new System.Drawing.Point(306, 539);
            this.btnHomeBrandType.Name = "btnHomeBrandType";
            this.btnHomeBrandType.Size = new System.Drawing.Size(114, 79);
            this.btnHomeBrandType.TabIndex = 8;
            this.btnHomeBrandType.Text = "Brand Type";
            this.btnHomeBrandType.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btnHomeWomen;
        private System.Windows.Forms.Button btnHomeGirls;
        private System.Windows.Forms.Button btnHomeBoys;
        private System.Windows.Forms.Button btnHomeBrandType;
        private System.Windows.Forms.Button btnHomeBrand;
    }
}
