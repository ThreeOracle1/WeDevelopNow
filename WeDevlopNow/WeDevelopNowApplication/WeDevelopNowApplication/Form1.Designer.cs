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
            this.lblHomePage = new System.Windows.Forms.Label();
            this.btnMensHomepage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHomePage.Location = new System.Drawing.Point(205, 64);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(174, 41);
            this.lblHomePage.TabIndex = 0;
            this.lblHomePage.Text = "Home page";
            // 
            // btnMensHomepage
            // 
            this.btnMensHomepage.Location = new System.Drawing.Point(156, 142);
            this.btnMensHomepage.Name = "btnMensHomepage";
            this.btnMensHomepage.Size = new System.Drawing.Size(145, 110);
            this.btnMensHomepage.TabIndex = 1;
            this.btnMensHomepage.Text = "Mens";
            this.btnMensHomepage.UseVisualStyleBackColor = true;
            this.btnMensHomepage.Click += new System.EventHandler(this.btnMensHomepage_Click);
            // 
            // FormApplicationWeDevelopNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnMensHomepage);
            this.Controls.Add(this.lblHomePage);
            this.Name = "FormApplicationWeDevelopNow";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHomePage;
        private Button btnMensHomepage;
    }
}