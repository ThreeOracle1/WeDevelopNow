namespace WeDevelopNowApplication
{
    partial class FormApplicationWeDevelopNow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApplicationWeDevelopNow));
            this.lblHomePage = new System.Windows.Forms.Label();
            this.btnMensHomepage = new System.Windows.Forms.Button();
            this.btnLadiesHomepage = new System.Windows.Forms.Button();
            this.btnBoysHomepage = new System.Windows.Forms.Button();
            this.btnGirlsHomepage = new System.Windows.Forms.Button();
            this.btnBrandHomepage = new System.Windows.Forms.Button();
            this.btnBrandTypeHomepage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHomePage.Location = new System.Drawing.Point(596, 22);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(174, 41);
            this.lblHomePage.TabIndex = 0;
            this.lblHomePage.Text = "Home page";
            // 
            // btnMensHomepage
            // 
            this.btnMensHomepage.Location = new System.Drawing.Point(175, 309);
            this.btnMensHomepage.Name = "btnMensHomepage";
            this.btnMensHomepage.Size = new System.Drawing.Size(135, 56);
            this.btnMensHomepage.TabIndex = 1;
            this.btnMensHomepage.Text = "Mens";
            this.btnMensHomepage.UseVisualStyleBackColor = true;
            this.btnMensHomepage.Click += new System.EventHandler(this.btnMensHomepage_Click);
            // 
            // btnLadiesHomepage
            // 
            this.btnLadiesHomepage.Location = new System.Drawing.Point(321, 309);
            this.btnLadiesHomepage.Name = "btnLadiesHomepage";
            this.btnLadiesHomepage.Size = new System.Drawing.Size(127, 56);
            this.btnLadiesHomepage.TabIndex = 2;
            this.btnLadiesHomepage.Text = "Ladies";
            this.btnLadiesHomepage.UseVisualStyleBackColor = true;
            this.btnLadiesHomepage.Click += new System.EventHandler(this.btnLadiesHomepage_Click);
            // 
            // btnBoysHomepage
            // 
            this.btnBoysHomepage.Location = new System.Drawing.Point(175, 381);
            this.btnBoysHomepage.Name = "btnBoysHomepage";
            this.btnBoysHomepage.Size = new System.Drawing.Size(126, 60);
            this.btnBoysHomepage.TabIndex = 3;
            this.btnBoysHomepage.Text = "Boys";
            this.btnBoysHomepage.UseVisualStyleBackColor = true;
            this.btnBoysHomepage.Click += new System.EventHandler(this.btnBoysHomepage_Click);
            // 
            // btnGirlsHomepage
            // 
            this.btnGirlsHomepage.Location = new System.Drawing.Point(321, 381);
            this.btnGirlsHomepage.Name = "btnGirlsHomepage";
            this.btnGirlsHomepage.Size = new System.Drawing.Size(127, 60);
            this.btnGirlsHomepage.TabIndex = 4;
            this.btnGirlsHomepage.Text = "Girls";
            this.btnGirlsHomepage.UseVisualStyleBackColor = true;
            this.btnGirlsHomepage.Click += new System.EventHandler(this.btnGirlsHomepage_Click);
            // 
            // btnBrandHomepage
            // 
            this.btnBrandHomepage.Location = new System.Drawing.Point(175, 463);
            this.btnBrandHomepage.Name = "btnBrandHomepage";
            this.btnBrandHomepage.Size = new System.Drawing.Size(126, 60);
            this.btnBrandHomepage.TabIndex = 5;
            this.btnBrandHomepage.Text = "Brand";
            this.btnBrandHomepage.UseVisualStyleBackColor = true;
            this.btnBrandHomepage.Click += new System.EventHandler(this.btnBrandHomepage_Click);
            // 
            // btnBrandTypeHomepage
            // 
            this.btnBrandTypeHomepage.Location = new System.Drawing.Point(321, 463);
            this.btnBrandTypeHomepage.Name = "btnBrandTypeHomepage";
            this.btnBrandTypeHomepage.Size = new System.Drawing.Size(127, 60);
            this.btnBrandTypeHomepage.TabIndex = 6;
            this.btnBrandTypeHomepage.Text = "Brand Type";
            this.btnBrandTypeHomepage.UseVisualStyleBackColor = true;
            this.btnBrandTypeHomepage.Click += new System.EventHandler(this.btnBrandTypeHomepage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormApplicationWeDevelopNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrandTypeHomepage);
            this.Controls.Add(this.btnBrandHomepage);
            this.Controls.Add(this.btnGirlsHomepage);
            this.Controls.Add(this.btnBoysHomepage);
            this.Controls.Add(this.btnLadiesHomepage);
            this.Controls.Add(this.btnMensHomepage);
            this.Controls.Add(this.lblHomePage);
            this.Name = "FormApplicationWeDevelopNow";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHomePage;
        private Button btnMensHomepage;
        private Button btnLadiesHomepage;
        private Button btnBoysHomepage;
        private Button btnGirlsHomepage;
        private Button btnBrandHomepage;
        private Button btnBrandTypeHomepage;
        private PictureBox pictureBox1;
    }
}