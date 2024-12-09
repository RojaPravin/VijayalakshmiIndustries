using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Vijayalakshmi_Industries
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public bool IsEmailValid(String email)
        {
            String pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9+_.-]+$";
            Regex r = new Regex(pattern);
            return r.IsMatch(email);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reg_uname_Click(object sender, EventArgs e)
        {

        }

        private void reg_cpwd_Click(object sender, EventArgs e)
        {

        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (reguname_tb.Text.Trim() != "" && regemail_tb.Text.Trim() != "" && regmbno_tb.Text.Trim() != "" && regpwd_tb.Text.Trim() != "" && regcpwd_tb.Text.Trim() != "")
            {
                if(reguname_tb.Text.Trim().Length >2)
                {
                    String emailaddress = regemail_tb.Text.Trim();
                    bool IsValid = IsEmailValid(emailaddress);
                    if (IsValid)
                    {
                        if (regmbno_tb.Text.Trim().Length == 10 || regmbno_tb.Text.Trim().Length == 12)
                        {
                          if(regpwd_tb.Text.Trim().Length >= 8)
                          {
                              if(regpwd_tb.Text.Trim() == regcpwd_tb.Text.Trim())
                              {
                                
                                    SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand("sp_register", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p1).Value = reguname_tb.Text.Trim();
                                    SqlParameter p2 = new SqlParameter("@email", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p2).Value = regemail_tb.Text.Trim();
                                    SqlParameter p3 = new SqlParameter("@mbno", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p3).Value = regmbno_tb.Text.Trim();
                                    SqlParameter p4 = new SqlParameter("@pwd", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p4).Value = regpwd_tb.Text.Trim();
                                    SqlParameter p5 = new SqlParameter("@cpwd", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p5).Value = regcpwd_tb.Text.Trim();

                                    int a = cmd.ExecuteNonQuery();
                                    if (a > 0)
                                    {
                                        MessageBox.Show("Registered Successfully");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Registration Failed");
                                        con.Close();
                                    }
                               
                                
                              }
                              else
                              {
                                MessageBox.Show("Password and Confirm Password should be Same");
                              }
                          }
                          else
                          {
                            MessageBox.Show("Password should be more than 7 characters");
                          }
                        
                        }
                        else
                        {
                        MessageBox.Show("Please enter a valid Mobile Number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Email in correct format");
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter a valid Name");
                }
                
            }
            else 
            {
                MessageBox.Show("Fill all the datas");
            }



        }

        private void regpwd_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to exit ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void reg_email_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void reguname_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void regemail_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void regreset_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reguname_tb.Clear();
            regemail_tb.Clear();
            regmbno_tb.Clear();
            regpwd_tb.Clear();
            regcpwd_tb.Clear();
        }

        private void reg_reset_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reg_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loginpage r = new Loginpage();
            r.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else 
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void regMin_Pb_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
