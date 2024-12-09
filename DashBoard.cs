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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void ed_Dept_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ed_Role_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Intime_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_atn_Intime", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@Emp_Id", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ID_Atn.Text.Trim();
            SqlParameter p2 = new SqlParameter("@Emp_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p2).Value = txt_Name_Atn.Text.Trim();
            SqlParameter p3 = new SqlParameter("@Emp_Dept", SqlDbType.VarChar);
            cmd.Parameters.Add(p3).Value = txt_Dept_Atn.SelectedItem.ToString(); 
            SqlParameter p4 = new SqlParameter("@Emp_Role", SqlDbType.VarChar);
            cmd.Parameters.Add(p4).Value = txt_Role_Atn.SelectedItem.ToString(); 

            
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Have a good day");
            }
            else
            {
                MessageBox.Show("Oops..Failed!!!");
                con.Close();
            }
        }

        private void edId_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_outtime_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_atn_Outtime", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@Emp_Id", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = txt_ID_Atn.Text.Trim();
            SqlParameter p2 = new SqlParameter("@Emp_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(p2).Value = txt_Name_Atn.Text.Trim();
            SqlParameter p3 = new SqlParameter("@Emp_Dept", SqlDbType.VarChar);
            cmd.Parameters.Add(p3).Value = txt_Dept_Atn.SelectedItem.ToString();
            SqlParameter p4 = new SqlParameter("@Emp_Role", SqlDbType.VarChar);
            cmd.Parameters.Add(p4).Value = txt_Role_Atn.SelectedItem.ToString();


            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Regards for your good work");
            }
            else
            {
                MessageBox.Show("Oops..Failed!!!");
                con.Close();
            }
        }
    }
}
