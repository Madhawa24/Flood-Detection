namespace project1
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbun = new System.Windows.Forms.TextBox();
            this.tbpw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginb
            // 
            this.loginb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loginb.Font = new System.Drawing.Font("Adobe Arabic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginb.Location = new System.Drawing.Point(400, 257);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(102, 32);
            this.loginb.TabIndex = 0;
            this.loginb.Text = "LOGIN";
            this.loginb.UseVisualStyleBackColor = false;
            this.loginb.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(160, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "READER 1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Arabic", 16F);
            this.label2.Location = new System.Drawing.Point(218, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Arabic", 16F);
            this.label3.Location = new System.Drawing.Point(218, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // tbun
            // 
            this.tbun.Location = new System.Drawing.Point(345, 173);
            this.tbun.Name = "tbun";
            this.tbun.Size = new System.Drawing.Size(154, 22);
            this.tbun.TabIndex = 4;
            // 
            // tbpw
            // 
            this.tbpw.Location = new System.Drawing.Point(345, 216);
            this.tbpw.Name = "tbpw";
            this.tbpw.PasswordChar = '#';
            this.tbpw.Size = new System.Drawing.Size(154, 22);
            this.tbpw.TabIndex = 5;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 402);
            this.Controls.Add(this.tbpw);
            this.Controls.Add(this.tbun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginb);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN - READER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbun;
        private System.Windows.Forms.TextBox tbpw;
    }
}

