using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vijayalakshmi_Industries
{
    public partial class EmpDashboard : Form
    {
        public EmpDashboard()
        {
            InitializeComponent();
        }

        private void EmpDashboard_Load(object sender, EventArgs e)
        {

        }

        private void reguname_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void regexit_pb_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ed_Add_btn_Click(object sender, EventArgs e)
        {
          try
          {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_emp_register", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@Emp_Id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = edId_tb.Text.Trim();
                SqlParameter p2 = new SqlParameter("@Emp_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = edName_tb.Text.Trim();
                SqlParameter p3 = new SqlParameter("@Emp_Salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = edSalary_tb.Text.Trim();
                SqlParameter p4 = new SqlParameter("@Emp_Dept", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = ed_Dept_cb.SelectedItem.ToString();
                SqlParameter p5 = new SqlParameter("@Emp_Role", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = ed_Role_cb.SelectedItem.ToString();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Employee details added ");
                }
                else
                {
                    MessageBox.Show("!!!Failed!!!");
                    con.Close();
                }
          }
            
          catch ( Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }

        private void ed_Fetch_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_fetch", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ed_dataGridView.DataSource = ds.Tables[0];
                con.Close();

            }
            catch(Exception ex ) 
            {
                MessageBox.Show(ex.Message);  
            }
        }

        private void ed_Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@Emp_Id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = edId_tb.Text.Trim();
                SqlParameter p2 = new SqlParameter("@Emp_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = edName_tb.Text.Trim();
                SqlParameter p3 = new SqlParameter("@Emp_Salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = edSalary_tb.Text.Trim();
                SqlParameter p4 = new SqlParameter("@Emp_Dept", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = ed_Dept_cb.SelectedItem.ToString();
                SqlParameter p5 = new SqlParameter("@Emp_Role", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = ed_Role_cb.SelectedItem.ToString();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Employee details updated");
                }
                else
                {
                    MessageBox.Show("Updation Failed!!!");
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ed_Del_btn_Click(object sender, EventArgs e)
        {
            
              
            DialogResult check = MessageBox.Show("Are you sure want to delete?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@Emp_Id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = edId_tb.Text.Trim();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data deleted successfully");
                }
                con.Close();
            }
            
        }

        private void ed_Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@searchdata", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = ed_SearchBox.Text.Trim();


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ed_dataGridView.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ed_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap B = new Bitmap(ed_dataGridView.Width, ed_dataGridView.Height);
            ed_dataGridView.DrawToBitmap(B,new Rectangle(0,0,ed_dataGridView.Width,ed_dataGridView.Height));
            e.Graphics.DrawImage(B, 120, 120);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void ed_Print_btn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            {
                printDocument1.Print();
            }
        }

        private void ed_dataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                edId_tb.Text = ed_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                edName_tb.Text = ed_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                edSalary_tb.Text = ed_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                ed_Dept_cb.Text = ed_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                ed_Role_cb.Text = ed_dataGridView.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reg_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ed_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
