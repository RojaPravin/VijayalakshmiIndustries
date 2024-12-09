using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vijayalakshmi_Industries
{
    public partial class PaySlip : Form
    {
        public string Date, Id, Name, Salary, Pf, Total ;
        public Image img = null;
        public Bitmap bm;

        private void salary_Colon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

       

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea  = e.PageBounds;
            e.Graphics.DrawImage(bm,(pagearea.Width /2) - (this.panel1.Width /2),this.panel1.Location.Y);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void paySlip_picBox_Click(object sender, EventArgs e)
        {

        }

        private void Print(Panel a)
        {
            PrinterSettings p = new PrinterSettings();
            panel1 = a;

            bm = new Bitmap(a.Width, a.Height);
            a.DrawToBitmap(bm,new Rectangle(0,0,a.Width,a.Height));
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private void PaySlip_Load(object sender, EventArgs e)
        {
            paySlip_picBox.Image = img ;
            date_Lbl.Text = Date;
            id_Colon.Text = Id;
            name_Colon.Text = Name;
            salary_Colon.Text = Salary;
            pf_Colon.Text = Pf;
            total_Colon.Text = Total;

        }

        public PaySlip()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString();
        }

        private void sal_Id_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

