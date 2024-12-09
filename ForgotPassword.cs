using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Vijayalakshmi_Industries
{
    public partial class ForgotPassword : Form
    {
        string randomcode;
        public ForgotPassword()
        {
            
            InitializeComponent();
            
        }

        private void log_lbl_Click(object sender, EventArgs e)
        {

        }

        private void regexit_pb_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to exit ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void fp_SendOtp_btn_Click(object sender, EventArgs e)
        {
            string from, to, messagebody, pass ;
            Random random = new Random();
            randomcode = (random.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (fpEmail_tb.Text).ToString();
            from = "mroja1412@gmail.com";
            pass = "epvr nbos xvze dnjw";
            messagebody = "Your OTP Verification Code : " + randomcode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "VI Management Verification";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("OTP sent successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fp_VerifyOtp_Btn_Click(object sender, EventArgs e)
        {
            if (randomcode == (fpOtp_Tb.Text).ToString())
            {
                MessageBox.Show("OTP verified successfully");
                ChangePassword cp = new ChangePassword();
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid OTP");
            }
        }

        private void fpEmail_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
