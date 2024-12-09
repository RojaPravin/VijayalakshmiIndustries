namespace Vijayalakshmi_Industries
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.reg_panel = new System.Windows.Forms.Panel();
            this.regMin_Pb = new System.Windows.Forms.PictureBox();
            this.regMax_Pb = new System.Windows.Forms.PictureBox();
            this.regexit_pb = new System.Windows.Forms.PictureBox();
            this.reg_title = new System.Windows.Forms.Label();
            this.reg_uname = new System.Windows.Forms.Label();
            this.reguname_tb = new System.Windows.Forms.TextBox();
            this.regemail_tb = new System.Windows.Forms.TextBox();
            this.reg_email = new System.Windows.Forms.Label();
            this.regmbno_tb = new System.Windows.Forms.TextBox();
            this.reg_mbnum = new System.Windows.Forms.Label();
            this.regpwd_tb = new System.Windows.Forms.TextBox();
            this.reg_pwd = new System.Windows.Forms.Label();
            this.regcpwd_tb = new System.Windows.Forms.TextBox();
            this.reg_cpwd = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.reg_alrdy_lbl = new System.Windows.Forms.Label();
            this.reg_linklbl = new System.Windows.Forms.LinkLabel();
            this.reg_reset_btn = new System.Windows.Forms.Button();
            this.regreset_link = new System.Windows.Forms.LinkLabel();
            this.reg_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regMin_Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regMax_Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexit_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_panel
            // 
            this.reg_panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.reg_panel.Controls.Add(this.regMin_Pb);
            this.reg_panel.Controls.Add(this.regMax_Pb);
            this.reg_panel.Controls.Add(this.regexit_pb);
            this.reg_panel.Controls.Add(this.reg_title);
            this.reg_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reg_panel.Location = new System.Drawing.Point(0, 0);
            this.reg_panel.Name = "reg_panel";
            this.reg_panel.Size = new System.Drawing.Size(977, 100);
            this.reg_panel.TabIndex = 0;
            // 
            // regMin_Pb
            // 
            this.regMin_Pb.Image = ((System.Drawing.Image)(resources.GetObject("regMin_Pb.Image")));
            this.regMin_Pb.Location = new System.Drawing.Point(827, 0);
            this.regMin_Pb.Name = "regMin_Pb";
            this.regMin_Pb.Size = new System.Drawing.Size(45, 44);
            this.regMin_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regMin_Pb.TabIndex = 3;
            this.regMin_Pb.TabStop = false;
            this.regMin_Pb.Click += new System.EventHandler(this.regMin_Pb_Click);
            // 
            // regMax_Pb
            // 
            this.regMax_Pb.Image = ((System.Drawing.Image)(resources.GetObject("regMax_Pb.Image")));
            this.regMax_Pb.Location = new System.Drawing.Point(878, 0);
            this.regMax_Pb.Name = "regMax_Pb";
            this.regMax_Pb.Size = new System.Drawing.Size(45, 44);
            this.regMax_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regMax_Pb.TabIndex = 2;
            this.regMax_Pb.TabStop = false;
            this.regMax_Pb.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // regexit_pb
            // 
            this.regexit_pb.Image = ((System.Drawing.Image)(resources.GetObject("regexit_pb.Image")));
            this.regexit_pb.Location = new System.Drawing.Point(929, 0);
            this.regexit_pb.Name = "regexit_pb";
            this.regexit_pb.Size = new System.Drawing.Size(45, 44);
            this.regexit_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regexit_pb.TabIndex = 1;
            this.regexit_pb.TabStop = false;
            this.regexit_pb.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reg_title
            // 
            this.reg_title.AutoSize = true;
            this.reg_title.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reg_title.Location = new System.Drawing.Point(184, 32);
            this.reg_title.Name = "reg_title";
            this.reg_title.Size = new System.Drawing.Size(563, 38);
            this.reg_title.TabIndex = 0;
            this.reg_title.Text = "VIJAYALAKSHMI INDUSTRIES";
            // 
            // reg_uname
            // 
            this.reg_uname.AutoSize = true;
            this.reg_uname.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_uname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reg_uname.Location = new System.Drawing.Point(119, 154);
            this.reg_uname.Name = "reg_uname";
            this.reg_uname.Size = new System.Drawing.Size(143, 27);
            this.reg_uname.TabIndex = 2;
            this.reg_uname.Text = "User Name";
            this.reg_uname.Click += new System.EventHandler(this.reg_uname_Click);
            // 
            // reguname_tb
            // 
            this.reguname_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.reguname_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.reguname_tb.Location = new System.Drawing.Point(124, 195);
            this.reguname_tb.Name = "reguname_tb";
            this.reguname_tb.Size = new System.Drawing.Size(723, 30);
            this.reguname_tb.TabIndex = 3;
            this.reguname_tb.TextChanged += new System.EventHandler(this.reguname_tb_TextChanged);
            // 
            // regemail_tb
            // 
            this.regemail_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.regemail_tb.Location = new System.Drawing.Point(124, 283);
            this.regemail_tb.Name = "regemail_tb";
            this.regemail_tb.Size = new System.Drawing.Size(723, 30);
            this.regemail_tb.TabIndex = 5;
            this.regemail_tb.TextChanged += new System.EventHandler(this.regemail_tb_TextChanged);
            // 
            // reg_email
            // 
            this.reg_email.AutoSize = true;
            this.reg_email.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reg_email.Location = new System.Drawing.Point(119, 242);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(184, 27);
            this.reg_email.TabIndex = 4;
            this.reg_email.Text = "Email Address";
            this.reg_email.Click += new System.EventHandler(this.reg_email_Click);
            // 
            // regmbno_tb
            // 
            this.regmbno_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.regmbno_tb.Location = new System.Drawing.Point(124, 373);
            this.regmbno_tb.Name = "regmbno_tb";
            this.regmbno_tb.Size = new System.Drawing.Size(723, 30);
            this.regmbno_tb.TabIndex = 7;
            // 
            // reg_mbnum
            // 
            this.reg_mbnum.AutoSize = true;
            this.reg_mbnum.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_mbnum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reg_mbnum.Location = new System.Drawing.Point(119, 329);
            this.reg_mbnum.Name = "reg_mbnum";
            this.reg_mbnum.Size = new System.Drawing.Size(199, 27);
            this.reg_mbnum.TabIndex = 6;
            this.reg_mbnum.Text = "Mobile Number";
            // 
            // regpwd_tb
            // 
            this.regpwd_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.regpwd_tb.Location = new System.Drawing.Point(124, 462);
            this.regpwd_tb.Name = "regpwd_tb";
            this.regpwd_tb.Size = new System.Drawing.Size(723, 30);
            this.regpwd_tb.TabIndex = 9;
            this.regpwd_tb.TextChanged += new System.EventHandler(this.regpwd_tb_TextChanged);
            // 
            // reg_pwd
            // 
            this.reg_pwd.AutoSize = true;
            this.reg_pwd.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reg_pwd.Location = new System.Drawing.Point(119, 421);
            this.reg_pwd.Name = "reg_pwd";
            this.reg_pwd.Size = new System.Drawing.Size(128, 27);
            this.reg_pwd.TabIndex = 8;
            this.reg_pwd.Text = "Password";
            // 
            // regcpwd_tb
            // 
            this.regcpwd_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.regcpwd_tb.Location = new System.Drawing.Point(124, 559);
            this.regcpwd_tb.Name = "regcpwd_tb";
            this.regcpwd_tb.Size = new System.Drawing.Size(723, 30);
            this.regcpwd_tb.TabIndex = 11;
            // 
            // reg_cpwd
            // 
            this.reg_cpwd.AutoSize = true;
            this.reg_cpwd.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_cpwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reg_cpwd.Location = new System.Drawing.Point(119, 514);
            this.reg_cpwd.Name = "reg_cpwd";
            this.reg_cpwd.Size = new System.Drawing.Size(233, 27);
            this.reg_cpwd.TabIndex = 10;
            this.reg_cpwd.Text = "Confirm Password";
            this.reg_cpwd.Click += new System.EventHandler(this.reg_cpwd_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reg_btn.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.Location = new System.Drawing.Point(289, 619);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(176, 70);
            this.reg_btn.TabIndex = 12;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // reg_alrdy_lbl
            // 
            this.reg_alrdy_lbl.AutoSize = true;
            this.reg_alrdy_lbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_alrdy_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reg_alrdy_lbl.Location = new System.Drawing.Point(712, 703);
            this.reg_alrdy_lbl.Name = "reg_alrdy_lbl";
            this.reg_alrdy_lbl.Size = new System.Drawing.Size(237, 24);
            this.reg_alrdy_lbl.TabIndex = 13;
            this.reg_alrdy_lbl.Text = "Already have an account?";
            // 
            // reg_linklbl
            // 
            this.reg_linklbl.AutoSize = true;
            this.reg_linklbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_linklbl.LinkColor = System.Drawing.Color.Red;
            this.reg_linklbl.Location = new System.Drawing.Point(790, 727);
            this.reg_linklbl.Name = "reg_linklbl";
            this.reg_linklbl.Size = new System.Drawing.Size(74, 24);
            this.reg_linklbl.TabIndex = 14;
            this.reg_linklbl.TabStop = true;
            this.reg_linklbl.Text = "Sign In";
            this.reg_linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reg_linklbl_LinkClicked);
            // 
            // reg_reset_btn
            // 
            this.reg_reset_btn.BackColor = System.Drawing.Color.Crimson;
            this.reg_reset_btn.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_reset_btn.Location = new System.Drawing.Point(482, 619);
            this.reg_reset_btn.Name = "reg_reset_btn";
            this.reg_reset_btn.Size = new System.Drawing.Size(176, 70);
            this.reg_reset_btn.TabIndex = 15;
            this.reg_reset_btn.Text = "Cancel";
            this.reg_reset_btn.UseVisualStyleBackColor = false;
            this.reg_reset_btn.Click += new System.EventHandler(this.reg_reset_btn_Click);
            // 
            // regreset_link
            // 
            this.regreset_link.AutoSize = true;
            this.regreset_link.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regreset_link.LinkColor = System.Drawing.SystemColors.Highlight;
            this.regreset_link.Location = new System.Drawing.Point(447, 703);
            this.regreset_link.Name = "regreset_link";
            this.regreset_link.Size = new System.Drawing.Size(60, 24);
            this.regreset_link.TabIndex = 16;
            this.regreset_link.TabStop = true;
            this.regreset_link.Text = "Reset";
            this.regreset_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regreset_link_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(977, 777);
            this.Controls.Add(this.regreset_link);
            this.Controls.Add(this.reg_reset_btn);
            this.Controls.Add(this.reg_linklbl);
            this.Controls.Add(this.reg_alrdy_lbl);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.regcpwd_tb);
            this.Controls.Add(this.reg_cpwd);
            this.Controls.Add(this.regpwd_tb);
            this.Controls.Add(this.reg_pwd);
            this.Controls.Add(this.regmbno_tb);
            this.Controls.Add(this.reg_mbnum);
            this.Controls.Add(this.regemail_tb);
            this.Controls.Add(this.reg_email);
            this.Controls.Add(this.reguname_tb);
            this.Controls.Add(this.reg_uname);
            this.Controls.Add(this.reg_panel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Page";
            this.Load += new System.EventHandler(this.Register_Load);
            this.reg_panel.ResumeLayout(false);
            this.reg_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regMin_Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regMax_Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexit_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel reg_panel;
        private System.Windows.Forms.Label reg_title;
        private System.Windows.Forms.Label reg_uname;
        private System.Windows.Forms.TextBox reguname_tb;
        private System.Windows.Forms.TextBox regemail_tb;
        private System.Windows.Forms.Label reg_email;
        private System.Windows.Forms.TextBox regmbno_tb;
        private System.Windows.Forms.Label reg_mbnum;
        private System.Windows.Forms.TextBox regpwd_tb;
        private System.Windows.Forms.Label reg_pwd;
        private System.Windows.Forms.TextBox regcpwd_tb;
        private System.Windows.Forms.Label reg_cpwd;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label reg_alrdy_lbl;
        private System.Windows.Forms.LinkLabel reg_linklbl;
        private System.Windows.Forms.PictureBox regexit_pb;
        private System.Windows.Forms.Button reg_reset_btn;
        private System.Windows.Forms.LinkLabel regreset_link;
        private System.Windows.Forms.PictureBox regMin_Pb;
        private System.Windows.Forms.PictureBox regMax_Pb;
    }
}

