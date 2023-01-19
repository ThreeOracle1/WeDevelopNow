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
            this.btnHomeBrandType = new System.Windows.Forms.Button();
            this.btnHomeBrand = new System.Windows.Forms.Button();
            this.btnHomeGirls = new System.Windows.Forms.Button();
            this.btnHomeBoys = new System.Windows.Forms.Button();
            this.btnHomeWomen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHomepage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnHomeMen
            // 
            this.btnHomeMen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnHomeMen.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnHomeMen.Location = new System.Drawing.Point(129, 308);
            this.btnHomeMen.Name = "btnHomeMen";
            this.btnHomeMen.Size = new System.Drawing.Size(120, 120);
            this.btnHomeMen.TabIndex = 3;
            this.btnHomeMen.Text = "Men";
            this.btnHomeMen.UseVisualStyleBackColor = false;
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
            // btnHomeBrandType
            // 
            this.btnHomeBrandType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.btnHomeBrandType.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnHomeBrandType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.btnHomeBrandType.Location = new System.Drawing.Point(306, 582);
            this.btnHomeBrandType.Name = "btnHomeBrandType";
            this.btnHomeBrandType.Size = new System.Drawing.Size(120, 120);
            this.btnHomeBrandType.TabIndex = 8;
            this.btnHomeBrandType.Text = "Brand Type";
            this.btnHomeBrandType.UseVisualStyleBackColor = false;
            this.btnHomeBrandType.Click += new System.EventHandler(this.btnHomeBrandType_Click);
            // 
            // btnHomeBrand
            // 
            this.btnHomeBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.btnHomeBrand.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnHomeBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.btnHomeBrand.Location = new System.Drawing.Point(129, 582);
            this.btnHomeBrand.Name = "btnHomeBrand";
            this.btnHomeBrand.Size = new System.Drawing.Size(120, 120);
            this.btnHomeBrand.TabIndex = 7;
            this.btnHomeBrand.Text = "Brand";
            this.btnHomeBrand.UseVisualStyleBackColor = false;
            this.btnHomeBrand.Click += new System.EventHandler(this.btnHomeBrand_Click);
            // 
            // btnHomeGirls
            // 
            this.btnHomeGirls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.btnHomeGirls.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnHomeGirls.Location = new System.Drawing.Point(306, 447);
            this.btnHomeGirls.Name = "btnHomeGirls";
            this.btnHomeGirls.Size = new System.Drawing.Size(120, 120);
            this.btnHomeGirls.TabIndex = 6;
            this.btnHomeGirls.Text = "Girls";
            this.btnHomeGirls.UseVisualStyleBackColor = false;
            this.btnHomeGirls.Click += new System.EventHandler(this.btnHomeGirls_Click);
            // 
            // btnHomeBoys
            // 
            this.btnHomeBoys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.btnHomeBoys.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnHomeBoys.Location = new System.Drawing.Point(129, 447);
            this.btnHomeBoys.Name = "btnHomeBoys";
            this.btnHomeBoys.Size = new System.Drawing.Size(120, 120);
            this.btnHomeBoys.TabIndex = 5;
            this.btnHomeBoys.Text = "Boys";
            this.btnHomeBoys.UseVisualStyleBackColor = false;
            this.btnHomeBoys.Click += new System.EventHandler(this.btnHomeBoys_Click);
            // 
            // btnHomeWomen
            // 
            this.btnHomeWomen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnHomeWomen.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnHomeWomen.Location = new System.Drawing.Point(306, 308);
            this.btnHomeWomen.Name = "btnHomeWomen";
            this.btnHomeWomen.Size = new System.Drawing.Size(120, 120);
            this.btnHomeWomen.TabIndex = 4;
            this.btnHomeWomen.Text = "Women";
            this.btnHomeWomen.UseVisualStyleBackColor = false;
            this.btnHomeWomen.Click += new System.EventHandler(this.btnHomeWomen_Click);
            // 
            // UserControlHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnlHomepage);
            this.Name = "UserControlHomepage";
            this.Size = new System.Drawing.Size(580, 750);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHomepage.ResumeLayout(false);
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
