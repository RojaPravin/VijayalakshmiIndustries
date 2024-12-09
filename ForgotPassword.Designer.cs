namespace Vijayalakshmi_Industries
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.log_panel = new System.Windows.Forms.Panel();
            this.fp_Logo = new System.Windows.Forms.PictureBox();
            this.fpTitle_lbl2 = new System.Windows.Forms.Label();
            this.fpTitle_lbl = new System.Windows.Forms.Label();
            this.fp_Title = new System.Windows.Forms.Label();
            this.regexit_pb = new System.Windows.Forms.PictureBox();
            this.fp_Otp_Lbl = new System.Windows.Forms.Label();
            this.fpEmail_tb = new System.Windows.Forms.TextBox();
            this.fp_Verify = new System.Windows.Forms.Label();
            this.fp_SendOtp_btn = new System.Windows.Forms.Button();
            this.fp_VerifyOtp_Btn = new System.Windows.Forms.Button();
            this.fpOtp_Tb = new System.Windows.Forms.TextBox();
            this.log_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fp_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexit_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // log_panel
            // 
            this.log_panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.log_panel.Controls.Add(this.fp_Logo);
            this.log_panel.Controls.Add(this.fpTitle_lbl2);
            this.log_panel.Controls.Add(this.fpTitle_lbl);
            this.log_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.log_panel.Location = new System.Drawing.Point(0, 0);
            this.log_panel.Name = "log_panel";
            this.log_panel.Size = new System.Drawing.Size(342, 777);
            this.log_panel.TabIndex = 2;
            // 
            // fp_Logo
            // 
            this.fp_Logo.Image = ((System.Drawing.Image)(resources.GetObject("fp_Logo.Image")));
            this.fp_Logo.Location = new System.Drawing.Point(12, 279);
            this.fp_Logo.Name = "fp_Logo";
            this.fp_Logo.Size = new System.Drawing.Size(293, 197);
            this.fp_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fp_Logo.TabIndex = 40;
            this.fp_Logo.TabStop = false;
            // 
            // fpTitle_lbl2
            // 
            this.fpTitle_lbl2.AutoSize = true;
            this.fpTitle_lbl2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpTitle_lbl2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fpTitle_lbl2.Location = new System.Drawing.Point(59, 205);
            this.fpTitle_lbl2.Name = "fpTitle_lbl2";
            this.fpTitle_lbl2.Size = new System.Drawing.Size(205, 32);
            this.fpTitle_lbl2.TabIndex = 1;
            this.fpTitle_lbl2.Text = "INDUSTRIES";
            // 
            // fpTitle_lbl
            // 
            this.fpTitle_lbl.AutoSize = true;
            this.fpTitle_lbl.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpTitle_lbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fpTitle_lbl.Location = new System.Drawing.Point(30, 173);
            this.fpTitle_lbl.Name = "fpTitle_lbl";
            this.fpTitle_lbl.Size = new System.Drawing.Size(275, 32);
            this.fpTitle_lbl.TabIndex = 0;
            this.fpTitle_lbl.Text = "VIJAYALAKSHMI";
            // 
            // fp_Title
            // 
            this.fp_Title.AutoSize = true;
            this.fp_Title.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_Title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fp_Title.Location = new System.Drawing.Point(522, 83);
            this.fp_Title.Name = "fp_Title";
            this.fp_Title.Size = new System.Drawing.Size(279, 32);
            this.fp_Title.TabIndex = 28;
            this.fp_Title.Text = "Email Verification";
            this.fp_Title.Click += new System.EventHandler(this.log_lbl_Click);
            // 
            // regexit_pb
            // 
            this.regexit_pb.Image = ((System.Drawing.Image)(resources.GetObject("regexit_pb.Image")));
            this.regexit_pb.Location = new System.Drawing.Point(929, 0);
            this.regexit_pb.Name = "regexit_pb";
            this.regexit_pb.Size = new System.Drawing.Size(45, 44);
            this.regexit_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regexit_pb.TabIndex = 40;
            this.regexit_pb.TabStop = false;
            this.regexit_pb.Click += new System.EventHandler(this.regexit_pb_Click);
            // 
            // fp_Otp_Lbl
            // 
            this.fp_Otp_Lbl.AutoSize = true;
            this.fp_Otp_Lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_Otp_Lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fp_Otp_Lbl.Location = new System.Drawing.Point(392, 461);
            this.fp_Otp_Lbl.Name = "fp_Otp_Lbl";
            this.fp_Otp_Lbl.Size = new System.Drawing.Size(136, 27);
            this.fp_Otp_Lbl.TabIndex = 43;
            this.fp_Otp_Lbl.Text = "Enter OTP";
            // 
            // fpEmail_tb
            // 
            this.fpEmail_tb.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpEmail_tb.Location = new System.Drawing.Point(397, 282);
            this.fpEmail_tb.Name = "fpEmail_tb";
            this.fpEmail_tb.Size = new System.Drawing.Size(510, 30);
            this.fpEmail_tb.TabIndex = 42;
            this.fpEmail_tb.TextChanged += new System.EventHandler(this.fpEmail_tb_TextChanged);
            // 
            // fp_Verify
            // 
            this.fp_Verify.AutoSize = true;
            this.fp_Verify.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_Verify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fp_Verify.Location = new System.Drawing.Point(392, 235);
            this.fp_Verify.Name = "fp_Verify";
            this.fp_Verify.Size = new System.Drawing.Size(287, 27);
            this.fp_Verify.TabIndex = 41;
            this.fp_Verify.Text = "Enter Registered Email";
            // 
            // fp_SendOtp_btn
            // 
            this.fp_SendOtp_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.fp_SendOtp_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_SendOtp_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fp_SendOtp_btn.Location = new System.Drawing.Point(702, 340);
            this.fp_SendOtp_btn.Name = "fp_SendOtp_btn";
            this.fp_SendOtp_btn.Size = new System.Drawing.Size(190, 54);
            this.fp_SendOtp_btn.TabIndex = 45;
            this.fp_SendOtp_btn.Text = "Send OTP";
            this.fp_SendOtp_btn.UseVisualStyleBackColor = false;
            this.fp_SendOtp_btn.Click += new System.EventHandler(this.fp_SendOtp_btn_Click);
            // 
            // fp_VerifyOtp_Btn
            // 
            this.fp_VerifyOtp_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.fp_VerifyOtp_Btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_VerifyOtp_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fp_VerifyOtp_Btn.Location = new System.Drawing.Point(702, 574);
            this.fp_VerifyOtp_Btn.Name = "fp_VerifyOtp_Btn";
            this.fp_VerifyOtp_Btn.Size = new System.Drawing.Size(190, 54);
            this.fp_VerifyOtp_Btn.TabIndex = 46;
            this.fp_VerifyOtp_Btn.Text = "Verify OTP";
            this.fp_VerifyOtp_Btn.UseVisualStyleBackColor = false;
            this.fp_VerifyOtp_Btn.Click += new System.EventHandler(this.fp_VerifyOtp_Btn_Click);
            // 
            // fpOtp_Tb
            // 
            this.fpOtp_Tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.fpOtp_Tb.Location = new System.Drawing.Point(397, 512);
            this.fpOtp_Tb.Name = "fpOtp_Tb";
            this.fpOtp_Tb.Size = new System.Drawing.Size(510, 30);
            this.fpOtp_Tb.TabIndex = 47;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(977, 777);
            this.Controls.Add(this.fpOtp_Tb);
            this.Controls.Add(this.fp_VerifyOtp_Btn);
            this.Controls.Add(this.fp_SendOtp_btn);
            this.Controls.Add(this.fp_Otp_Lbl);
            this.Controls.Add(this.fpEmail_tb);
            this.Controls.Add(this.fp_Verify);
            this.Controls.Add(this.regexit_pb);
            this.Controls.Add(this.fp_Title);
            this.Controls.Add(this.log_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.log_panel.ResumeLayout(false);
            this.log_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fp_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexit_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel log_panel;
        private System.Windows.Forms.PictureBox fp_Logo;
        private System.Windows.Forms.Label fpTitle_lbl2;
        private System.Windows.Forms.Label fpTitle_lbl;
        private System.Windows.Forms.Label fp_Title;
        private System.Windows.Forms.PictureBox regexit_pb;
        private System.Windows.Forms.Label fp_Otp_Lbl;
        private System.Windows.Forms.TextBox fpEmail_tb;
        private System.Windows.Forms.Label fp_Verify;
        private System.Windows.Forms.Button fp_SendOtp_btn;
        private System.Windows.Forms.Button fp_VerifyOtp_Btn;
        private System.Windows.Forms.TextBox fpOtp_Tb;
    }
}