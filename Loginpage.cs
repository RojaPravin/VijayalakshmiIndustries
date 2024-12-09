using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vijayalakshmi_Industries
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void log_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void log_login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (loguname_tb.Text.Trim() == "" || logpwd_tb.Text.Trim() == "")
                {
                    MessageBox.Show("Fill all the datas");
                }
                else if (loguname_tb.Text.Trim() == "Admin" && logpwd_tb.Text.Trim() == "admin123")
                {
                    MessageBox.Show("Welcome Back , Admin");
                    EmpDashboard ed = new EmpDashboard();
                    ed.Show();
                    this.Hide();

                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_loginpage", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = loguname_tb.Text.Trim();
                    SqlParameter p2 = new SqlParameter("@cpwd", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = logpwd_tb.Text.Trim();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    int a = Convert.ToInt32(ds.Tables[0].Rows.Count);
                    if (a > 0)
                    {
                        MessageBox.Show("Welcome Back");
                        DashBoard d = new DashBoard();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");
                    }
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void log_signup_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void logreset_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loguname_tb.Clear();
            logpwd_tb.Clear();
        }

        private void logspwd_cb_CheckedChanged(object sender, EventArgs e)
        {
            logpwd_tb.PasswordChar = logspwd_cb.Checked ? '\0' : '*';
        }

        private void logfpwd_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }

        private void regexit_pb_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void log_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logpwd_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginpage_Load(object sender, EventArgs e)
        {

        }
    }
}
