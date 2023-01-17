namespace WeDevelopNowApplicationMain
{
    partial class UserControlBoysSearchResultScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBoysSearchResultScreen));
            this.btnBoysResultToHome = new System.Windows.Forms.Button();
            this.btnBackToBoys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBoysResultToHome
            // 
            this.btnBoysResultToHome.Location = new System.Drawing.Point(326, 634);
            this.btnBoysResultToHome.Name = "btnBoysResultToHome";
            this.btnBoysResultToHome.Size = new System.Drawing.Size(220, 90);
            this.btnBoysResultToHome.TabIndex = 3;
            this.btnBoysResultToHome.Text = "Home";
            this.btnBoysResultToHome.UseVisualStyleBackColor = true;
            this.btnBoysResultToHome.Click += new System.EventHandler(this.btnBoysResultToHome_Click);
            // 
            // btnBackToBoys
            // 
            this.btnBackToBoys.Location = new System.Drawing.Point(45, 634);
            this.btnBackToBoys.Name = "btnBackToBoys";
            this.btnBackToBoys.Size = new System.Drawing.Size(220, 90);
            this.btnBackToBoys.TabIndex = 7;
            this.btnBackToBoys.Text = "<< Back";
            this.btnBackToBoys.UseVisualStyleBackColor = true;
            this.btnBackToBoys.Click += new System.EventHandler(this.btnBackToBoys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boys results";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBoysResultToHome);
            this.panel4.Controls.Add(this.btnBackToBoys);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 750);
            this.panel4.TabIndex = 6;
            // 
            // UserControlBoysSearchResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "UserControlBoysSearchResultScreen";
            this.Size = new System.Drawing.Size(580, 750);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBoysResultToHome;
        private System.Windows.Forms.Button btnBackToBoys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
    }
}
