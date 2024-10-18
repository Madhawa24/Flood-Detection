namespace project1
{
    partial class Homepage
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_selectedp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_port = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_ststustime = new System.Windows.Forms.Label();
            this.lbl_statsens = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_connect.Location = new System.Drawing.Point(194, 76);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(88, 25);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(83, 139);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 16);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Click += new System.EventHandler(this.lbl_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl_selectedp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_port);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.btn_connect);
            this.panel1.Location = new System.Drawing.Point(27, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 181);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Port Selection";
            // 
            // lbl_selectedp
            // 
            this.lbl_selectedp.AutoSize = true;
            this.lbl_selectedp.Location = new System.Drawing.Point(191, 116);
            this.lbl_selectedp.Name = "lbl_selectedp";
            this.lbl_selectedp.Size = new System.Drawing.Size(85, 16);
            this.lbl_selectedp.TabIndex = 5;
            this.lbl_selectedp.Text = "Not Selected";
            this.lbl_selectedp.Click += new System.EventHandler(this.lbl_selectedp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Port  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmb_port
            // 
            this.cmb_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Location = new System.Drawing.Point(86, 77);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(102, 24);
            this.cmb_port.TabIndex = 2;
            this.cmb_port.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.lbl_temp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(11, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 157);
            this.panel2.TabIndex = 7;
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Location = new System.Drawing.Point(58, 89);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(90, 16);
            this.lbl_temp.TabIndex = 1;
            this.lbl_temp.Text = "temp_reading";
            this.lbl_temp.Click += new System.EventHandler(this.lbl_temp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Temperature";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(24, 298);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(737, 242);
            this.panel5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Real Time Readings";
            // 
            // lbl_ststustime
            // 
            this.lbl_ststustime.AutoSize = true;
            this.lbl_ststustime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ststustime.Location = new System.Drawing.Point(41, 59);
            this.lbl_ststustime.Name = "lbl_ststustime";
            this.lbl_ststustime.Size = new System.Drawing.Size(0, 42);
            this.lbl_ststustime.TabIndex = 13;
            // 
            // lbl_statsens
            // 
            this.lbl_statsens.AutoSize = true;
            this.lbl_statsens.Location = new System.Drawing.Point(364, 265);
            this.lbl_statsens.Name = "lbl_statsens";
            this.lbl_statsens.Size = new System.Drawing.Size(44, 16);
            this.lbl_statsens.TabIndex = 9;
            this.lbl_statsens.Text = "label5";
            this.lbl_statsens.Click += new System.EventHandler(this.lbl_statsens_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lbl_ststustime);
            this.panel6.Location = new System.Drawing.Point(414, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(346, 182);
            this.panel6.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Connected for :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1269, 569);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbl_statsens);
            this.Controls.Add(this.panel1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_port;
        private System.Windows.Forms.Label lbl_selectedp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_ststustime;
        private System.Windows.Forms.Label lbl_statsens;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
    }
}