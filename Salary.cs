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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void log_lbl_Click(object sender, EventArgs e)
        {

        }

        private void RadioMan_Btn_CheckedChanged(object sender, EventArgs e)
        {
            RadioMan_Btn.ForeColor = Color.Green;
            RadioEmp_Btn.ForeColor = Color.Red;
            sal_Id_Cb.Items.Clear();
            sal_Id_Cb.Items.Add("MAN001");
            sal_Id_Cb.Items.Add("MAN002");
            sal_Id_Cb.Items.Add("MAN003");
            sal_Id_Cb.Items.Add("MAN004");
        }

        private void RadioEmp_Btn_CheckedChanged(object sender, EventArgs e)
        {
            RadioEmp_Btn.ForeColor = Color.Green;
            RadioMan_Btn.ForeColor = Color.Red;
            sal_Id_Cb.Items.Clear();
            sal_Id_Cb.Items.Add("EMP001");
            sal_Id_Cb.Items.Add("EMP002");
            sal_Id_Cb.Items.Add("EMP003");
            sal_Id_Cb.Items.Add("EMP004");
        }

        private void regexit_pb_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sal_Id_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Sal_Bonus_Tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void salAdd_Btn_Click(object sender, EventArgs e)
        {   try
            {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_addsalary", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@Id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = sal_Id_Cb.SelectedItem.ToString();
                SqlParameter p2 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = Sal_Name_tb.Text.Trim();
                SqlParameter p3 = new SqlParameter("@Salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = salary_tb.Text.Trim();
                SqlParameter p4 = new SqlParameter("@Pf", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = Sal_Pf_Tb.Text.Trim();
                SqlParameter p5 = new SqlParameter("@Total", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = Sal_Total_Tb.Text.Trim();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Salary Added Successfully");
                }
                else
                {
                    MessageBox.Show("Failed");
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void salFetch_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RNPM1SO; Initial Catalog = Vijayalakshmi_Industries; Integrated Security =True ");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_fetch_Salary", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                sal_dataGridView.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sal_Browse_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog z = new OpenFileDialog();
            z.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            z.Title = "Select an Image";
            if(z.ShowDialog() == DialogResult.OK)
            {
                sal_PictureBox.Image = Image.FromFile(z.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void id_Sal_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pf = 12;
            int d = 100;
            if (sal_Id_Cb.SelectedItem.ToString() == "MAN001")
            {
                Sal_Name_tb.Text = "Mathi";
                salary_tb.Text = "200000";
                Sal_Pf_Tb.Text = (Convert.ToInt32(salary_tb.Text) * pf / d).ToString();
                Sal_Total_Tb.Text = (Convert.ToInt32(salary_tb.Text) - Convert.ToInt32(Sal_Pf_Tb.Text)).ToString();
            }
            else if (sal_Id_Cb.SelectedItem.ToString() == "MAN002")
            {

                Sal_Name_tb.Text = "Vijaya";
                salary_tb.Text = "150000";
                Sal_Pf_Tb.Text = (Convert.ToInt32(salary_tb.Text) * pf / d).ToString();
                Sal_Total_Tb.Text = (Convert.ToInt32(salary_tb.Text) - Convert.ToInt32(Sal_Pf_Tb.Text)).ToString();

            }
            else if (sal_Id_Cb.SelectedItem.ToString() == "MAN003")
            {

                Sal_Name_tb.Text = "Praveen";
                salary_tb.Text = "120000";
                Sal_Pf_Tb.Text = (Convert.ToInt32(salary_tb.Text) * pf / d).ToString();
                Sal_Total_Tb.Text = (Convert.ToInt32(salary_tb.Text) - Convert.ToInt32(Sal_Pf_Tb.Text)).ToString();

            }
            else if (sal_Id_Cb.SelectedItem.ToString() == "MAN004")
            {

                Sal_Name_tb.Text = "Roja";
                salary_tb.Text = "100000";
                Sal_Pf_Tb.Text = (Convert.ToInt32(salary_tb.Text) * pf / d).ToString();
                Sal_Total_Tb.Text = (Convert.ToInt32(salary_tb.Text) - Convert.ToInt32(Sal_Pf_Tb.Text)).ToString();

            }
            else if (sal_Id_Cb.SelectedItem.ToString() == "EMP001")
            {

                Sal_Name_tb.Text = "Vanan";
                salary_tb.Text = "70000";
                Sal_Pf_Tb.Text = (Convert.ToInt32(salary_tb.Text) * pf / d).ToString();
                Sal_Total_Tb.Text = (Convert.ToInt32(salary_tb.Text) - Convert.ToInt32(Sal_Pf_Tb.Text)).ToString();

            }
            else if (sal_Id_Cb.SelectedItem.ToString() == "EMP002")
            {

                Sal_Name_tb.Text = "Lakshmi";
                salary_tb.Text = "60000";
                Sal_Pf_Tb.Text = (Convert.ToInt32(salary_tb.Text) * pf / d).ToString();
                Sal_Total_Tb.Text = (Convert.ToInt32(salary_tb.Text) - Convert.ToInt32(Sal_Pf_Tb.Text)).ToString();

            }
            else if (sal_Id_Cb.SelectedItem.ToString() == "EMP003")
            {

                Sal_Name_tb.Text = "Kumar";
                salary_tb.Text = "50000";
                Sal_Pf_Tb.Text = (Convert.ToInt32(salary_tb.Text) * pf / d).ToString();
                Sal_Total_Tb.Text = (Convert.ToInt32(salary_tb.Text) - Convert.ToInt32(Sal_Pf_Tb.Text)).ToString();

            }
            else if (sal_Id_Cb.SelectedItem.ToString() == "EMP004")
            {

                Sal_Name_tb.Text = "Sri";
                salary_tb.Text = "40000";
                Sal_Pf_Tb.Text = (Convert.ToInt32(salary_tb.Text) * pf / d).ToString();
                Sal_Total_Tb.Text = (Convert.ToInt32(salary_tb.Text) - Convert.ToInt32(Sal_Pf_Tb.Text)).ToString();
            }

            else
            {

                Sal_Name_tb.Text = "0";
                salary_tb.Text = "0";

            }
        }

        private void fp_SendOtp_btn_Click(object sender, EventArgs e)
        {

            PaySlip ps = new PaySlip();
            ps.img = sal_PictureBox.Image;
            if (sal_Id_Cb.SelectedIndex == -1)
            {
                ps.Id = "";
            }
            else 
            {
                ps.Id = sal_Id_Cb.SelectedItem.ToString();
            }
            ps.Name = Sal_Name_tb.Text;
            ps.Salary = salary_tb.Text;
            ps.Pf = Sal_Pf_Tb.Text;
            ps.Total = Sal_Total_Tb.Text;
            ps.Show();
            this.Hide();
            

        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }
    }
}
