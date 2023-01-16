namespace WeDevelopNowApplicationMain
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlHomepage2 = new WeDevelopNowApplicationMain.UserControlHomepage();
            this.SuspendLayout();
            // 
            // userControlHomepage2
            // 
            this.userControlHomepage2.Location = new System.Drawing.Point(0, 0);
            this.userControlHomepage2.Name = "userControlHomepage2";
            this.userControlHomepage2.Size = new System.Drawing.Size(580, 750);
            this.userControlHomepage2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.userControlHomepage2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControlHomepage userControlHomepage2;
    }
}

