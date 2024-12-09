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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                text_lbl.Text = progressBar1.Value.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Loading Completed");
                Register r = new Register();
                r.Show();
                this.Hide();
            }
        }

        private void loading_Load_Click(object sender, EventArgs e)
        {
           
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
