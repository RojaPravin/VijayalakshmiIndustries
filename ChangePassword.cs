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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void change_Pwd_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (setPwd_tb.Text.Trim().Length >= 8)
                {
                    if (setPwd_tb.Text.Trim() == reEnter_Tb.Text.Trim())
                    {

                        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_pwdchange", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                        cmd.Parameters.Add(p1).Value = uName_Tb.Text.Trim();
                        SqlParameter p4 = new SqlParameter("@pwd", SqlDbType.VarChar);
                        cmd.Parameters.Add(p4).Value = setPwd_tb.Text.Trim();
                        SqlParameter p5 = new SqlParameter("@cpwd", SqlDbType.VarChar);
                        cmd.Parameters.Add(p5).Value = reEnter_Tb.Text.Trim();

                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Password Updated Successfully");
                            Loginpage lp = new Loginpage();
                            lp.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password Updation Failed !!!!");
                            uName_Tb.Clear();
                            setPwd_tb.Clear();
                            reEnter_Tb.Clear();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        

        }
    }
}
