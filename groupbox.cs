using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vijayalakshmi_Industries
{
    public partial class groupbox : Form
    {
        public groupbox()
        {
            InitializeComponent();
        }

        private void groupbox_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            reg_btn_Click(sender, e);
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
           
                groupBox2.Visible = false;
                groupBox1.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
            
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
