namespace Vijayalakshmi_Industries
{
    partial class EmpDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpDashboard));
            this.reg_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regexit_pb = new System.Windows.Forms.PictureBox();
            this.reg_title = new System.Windows.Forms.Label();
            this.ed_Dept_lbl = new System.Windows.Forms.Label();
            this.edSalary_tb = new System.Windows.Forms.TextBox();
            this.ed_Slry_lbl = new System.Windows.Forms.Label();
            this.edName_tb = new System.Windows.Forms.TextBox();
            this.ed_Name_lbl = new System.Windows.Forms.Label();
            this.edId_tb = new System.Windows.Forms.TextBox();
            this.ed_Id_lbl = new System.Windows.Forms.Label();
            this.ed_Dept_cb = new System.Windows.Forms.ComboBox();
            this.ed_Role_cb = new System.Windows.Forms.ComboBox();
            this.ed_Role_lbl = new System.Windows.Forms.Label();
            this.ed_Search_lbl = new System.Windows.Forms.Label();
            this.ed_SearchBox = new System.Windows.Forms.TextBox();
            this.ed_dataGridView = new System.Windows.Forms.DataGridView();
            this.ed_Search_btn = new System.Windows.Forms.Button();
            this.ed_Print_btn = new System.Windows.Forms.Button();
            this.ed_Add_btn = new System.Windows.Forms.Button();
            this.ed_Del_btn = new System.Windows.Forms.Button();
            this.ed_Update_btn = new System.Windows.Forms.Button();
            this.ed_Fetch_btn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.reg_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexit_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_panel
            // 
            this.reg_panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.reg_panel.Controls.Add(this.pictureBox1);
            this.reg_panel.Controls.Add(this.regexit_pb);
            this.reg_panel.Controls.Add(this.reg_title);
            this.reg_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reg_panel.Location = new System.Drawing.Point(0, 0);
            this.reg_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_panel.Name = "reg_panel";
            this.reg_panel.Size = new System.Drawing.Size(977, 68);
            this.reg_panel.TabIndex = 1;
            this.reg_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.reg_panel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // regexit_pb
            // 
            this.regexit_pb.Image = ((System.Drawing.Image)(resources.GetObject("regexit_pb.Image")));
            this.regexit_pb.Location = new System.Drawing.Point(929, 0);
            this.regexit_pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regexit_pb.Name = "regexit_pb";
            this.regexit_pb.Size = new System.Drawing.Size(45, 44);
            this.regexit_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regexit_pb.TabIndex = 1;
            this.regexit_pb.TabStop = false;
            this.regexit_pb.Click += new System.EventHandler(this.regexit_pb_Click);
            // 
            // reg_title
            // 
            this.reg_title.AutoSize = true;
            this.reg_title.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reg_title.Location = new System.Drawing.Point(227, 15);
            this.reg_title.Name = "reg_title";
            this.reg_title.Size = new System.Drawing.Size(563, 38);
            this.reg_title.TabIndex = 0;
            this.reg_title.Text = "VIJAYALAKSHMI INDUSTRIES";
            // 
            // ed_Dept_lbl
            // 
            this.ed_Dept_lbl.AutoSize = true;
            this.ed_Dept_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Dept_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Dept_lbl.Location = new System.Drawing.Point(19, 481);
            this.ed_Dept_lbl.Name = "ed_Dept_lbl";
            this.ed_Dept_lbl.Size = new System.Drawing.Size(278, 27);
            this.ed_Dept_lbl.TabIndex = 15;
            this.ed_Dept_lbl.Text = "Employee Department";
            // 
            // edSalary_tb
            // 
            this.edSalary_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.edSalary_tb.Location = new System.Drawing.Point(24, 416);
            this.edSalary_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edSalary_tb.Name = "edSalary_tb";
            this.edSalary_tb.Size = new System.Drawing.Size(289, 30);
            this.edSalary_tb.TabIndex = 14;
            // 
            // ed_Slry_lbl
            // 
            this.ed_Slry_lbl.AutoSize = true;
            this.ed_Slry_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Slry_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Slry_lbl.Location = new System.Drawing.Point(21, 374);
            this.ed_Slry_lbl.Name = "ed_Slry_lbl";
            this.ed_Slry_lbl.Size = new System.Drawing.Size(211, 27);
            this.ed_Slry_lbl.TabIndex = 13;
            this.ed_Slry_lbl.Text = "Employee Salary";
            // 
            // edName_tb
            // 
            this.edName_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.edName_tb.Location = new System.Drawing.Point(24, 302);
            this.edName_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edName_tb.Name = "edName_tb";
            this.edName_tb.Size = new System.Drawing.Size(289, 30);
            this.edName_tb.TabIndex = 12;
            // 
            // ed_Name_lbl
            // 
            this.ed_Name_lbl.AutoSize = true;
            this.ed_Name_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Name_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Name_lbl.Location = new System.Drawing.Point(19, 261);
            this.ed_Name_lbl.Name = "ed_Name_lbl";
            this.ed_Name_lbl.Size = new System.Drawing.Size(204, 27);
            this.ed_Name_lbl.TabIndex = 11;
            this.ed_Name_lbl.Text = "Employee Name";
            // 
            // edId_tb
            // 
            this.edId_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.edId_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edId_tb.Location = new System.Drawing.Point(24, 199);
            this.edId_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edId_tb.Name = "edId_tb";
            this.edId_tb.Size = new System.Drawing.Size(289, 30);
            this.edId_tb.TabIndex = 10;
            this.edId_tb.TextChanged += new System.EventHandler(this.reguname_tb_TextChanged);
            // 
            // ed_Id_lbl
            // 
            this.ed_Id_lbl.AutoSize = true;
            this.ed_Id_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Id_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Id_lbl.Location = new System.Drawing.Point(19, 158);
            this.ed_Id_lbl.Name = "ed_Id_lbl";
            this.ed_Id_lbl.Size = new System.Drawing.Size(164, 27);
            this.ed_Id_lbl.TabIndex = 9;
            this.ed_Id_lbl.Text = "Employee ID";
            // 
            // ed_Dept_cb
            // 
            this.ed_Dept_cb.Font = new System.Drawing.Font("Georgia", 12F);
            this.ed_Dept_cb.FormattingEnabled = true;
            this.ed_Dept_cb.Items.AddRange(new object[] {
            "HR",
            "Manager",
            "Development",
            "Testing",
            "Marketing",
            "Sales",
            ""});
            this.ed_Dept_cb.Location = new System.Drawing.Point(24, 527);
            this.ed_Dept_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_Dept_cb.Name = "ed_Dept_cb";
            this.ed_Dept_cb.Size = new System.Drawing.Size(289, 32);
            this.ed_Dept_cb.TabIndex = 17;
            // 
            // ed_Role_cb
            // 
            this.ed_Role_cb.Font = new System.Drawing.Font("Georgia", 12F);
            this.ed_Role_cb.FormattingEnabled = true;
            this.ed_Role_cb.Items.AddRange(new object[] {
            "Junior",
            "Senior"});
            this.ed_Role_cb.Location = new System.Drawing.Point(24, 640);
            this.ed_Role_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_Role_cb.Name = "ed_Role_cb";
            this.ed_Role_cb.Size = new System.Drawing.Size(289, 32);
            this.ed_Role_cb.TabIndex = 19;
            // 
            // ed_Role_lbl
            // 
            this.ed_Role_lbl.AutoSize = true;
            this.ed_Role_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Role_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Role_lbl.Location = new System.Drawing.Point(19, 594);
            this.ed_Role_lbl.Name = "ed_Role_lbl";
            this.ed_Role_lbl.Size = new System.Drawing.Size(189, 27);
            this.ed_Role_lbl.TabIndex = 18;
            this.ed_Role_lbl.Text = "Employee Role";
            // 
            // ed_Search_lbl
            // 
            this.ed_Search_lbl.AutoSize = true;
            this.ed_Search_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Search_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Search_lbl.Location = new System.Drawing.Point(328, 112);
            this.ed_Search_lbl.Name = "ed_Search_lbl";
            this.ed_Search_lbl.Size = new System.Drawing.Size(217, 27);
            this.ed_Search_lbl.TabIndex = 20;
            this.ed_Search_lbl.Text = "Search Employee";
            // 
            // ed_SearchBox
            // 
            this.ed_SearchBox.Font = new System.Drawing.Font("Georgia", 12F);
            this.ed_SearchBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ed_SearchBox.Location = new System.Drawing.Point(576, 112);
            this.ed_SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_SearchBox.Name = "ed_SearchBox";
            this.ed_SearchBox.Size = new System.Drawing.Size(241, 30);
            this.ed_SearchBox.TabIndex = 21;
            this.ed_SearchBox.TextChanged += new System.EventHandler(this.ed_textBox_TextChanged);
            // 
            // ed_dataGridView
            // 
            this.ed_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ed_dataGridView.Location = new System.Drawing.Point(333, 159);
            this.ed_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_dataGridView.Name = "ed_dataGridView";
            this.ed_dataGridView.RowHeadersWidth = 51;
            this.ed_dataGridView.RowTemplate.Height = 24;
            this.ed_dataGridView.Size = new System.Drawing.Size(619, 507);
            this.ed_dataGridView.TabIndex = 23;
            this.ed_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ed_dataGridView_CellContentClick);
            this.ed_dataGridView.DoubleClick += new System.EventHandler(this.ed_dataGridView_DoubleClick);
            // 
            // ed_Search_btn
            // 
            this.ed_Search_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ed_Search_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Search_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ed_Search_btn.Location = new System.Drawing.Point(840, 94);
            this.ed_Search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_Search_btn.Name = "ed_Search_btn";
            this.ed_Search_btn.Size = new System.Drawing.Size(112, 54);
            this.ed_Search_btn.TabIndex = 46;
            this.ed_Search_btn.Text = "Search";
            this.ed_Search_btn.UseVisualStyleBackColor = false;
            this.ed_Search_btn.Click += new System.EventHandler(this.ed_Search_btn_Click);
            // 
            // ed_Print_btn
            // 
            this.ed_Print_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ed_Print_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Print_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ed_Print_btn.Location = new System.Drawing.Point(832, 693);
            this.ed_Print_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_Print_btn.Name = "ed_Print_btn";
            this.ed_Print_btn.Size = new System.Drawing.Size(112, 54);
            this.ed_Print_btn.TabIndex = 47;
            this.ed_Print_btn.Text = "Print";
            this.ed_Print_btn.UseVisualStyleBackColor = false;
            this.ed_Print_btn.Click += new System.EventHandler(this.ed_Print_btn_Click);
            // 
            // ed_Add_btn
            // 
            this.ed_Add_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ed_Add_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Add_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ed_Add_btn.Location = new System.Drawing.Point(341, 693);
            this.ed_Add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_Add_btn.Name = "ed_Add_btn";
            this.ed_Add_btn.Size = new System.Drawing.Size(112, 54);
            this.ed_Add_btn.TabIndex = 48;
            this.ed_Add_btn.Text = "Add";
            this.ed_Add_btn.UseVisualStyleBackColor = false;
            this.ed_Add_btn.Click += new System.EventHandler(this.ed_Add_btn_Click);
            // 
            // ed_Del_btn
            // 
            this.ed_Del_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ed_Del_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Del_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ed_Del_btn.Location = new System.Drawing.Point(715, 693);
            this.ed_Del_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_Del_btn.Name = "ed_Del_btn";
            this.ed_Del_btn.Size = new System.Drawing.Size(112, 54);
            this.ed_Del_btn.TabIndex = 49;
            this.ed_Del_btn.Text = "Delete";
            this.ed_Del_btn.UseVisualStyleBackColor = false;
            this.ed_Del_btn.Click += new System.EventHandler(this.ed_Del_btn_Click);
            // 
            // ed_Update_btn
            // 
            this.ed_Update_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ed_Update_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Update_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ed_Update_btn.Location = new System.Drawing.Point(585, 693);
            this.ed_Update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_Update_btn.Name = "ed_Update_btn";
            this.ed_Update_btn.Size = new System.Drawing.Size(112, 54);
            this.ed_Update_btn.TabIndex = 50;
            this.ed_Update_btn.Text = "Update";
            this.ed_Update_btn.UseVisualStyleBackColor = false;
            this.ed_Update_btn.Click += new System.EventHandler(this.ed_Update_btn_Click);
            // 
            // ed_Fetch_btn
            // 
            this.ed_Fetch_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ed_Fetch_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Fetch_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ed_Fetch_btn.Location = new System.Drawing.Point(460, 693);
            this.ed_Fetch_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ed_Fetch_btn.Name = "ed_Fetch_btn";
            this.ed_Fetch_btn.Size = new System.Drawing.Size(112, 54);
            this.ed_Fetch_btn.TabIndex = 51;
            this.ed_Fetch_btn.Text = "Fetch";
            this.ed_Fetch_btn.UseVisualStyleBackColor = false;
            this.ed_Fetch_btn.Click += new System.EventHandler(this.ed_Fetch_btn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // EmpDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(977, 777);
            this.Controls.Add(this.ed_Fetch_btn);
            this.Controls.Add(this.ed_Update_btn);
            this.Controls.Add(this.ed_Del_btn);
            this.Controls.Add(this.ed_Add_btn);
            this.Controls.Add(this.ed_Print_btn);
            this.Controls.Add(this.ed_Search_btn);
            this.Controls.Add(this.ed_dataGridView);
            this.Controls.Add(this.ed_SearchBox);
            this.Controls.Add(this.ed_Search_lbl);
            this.Controls.Add(this.ed_Role_cb);
            this.Controls.Add(this.ed_Role_lbl);
            this.Controls.Add(this.ed_Dept_cb);
            this.Controls.Add(this.ed_Dept_lbl);
            this.Controls.Add(this.edSalary_tb);
            this.Controls.Add(this.ed_Slry_lbl);
            this.Controls.Add(this.edName_tb);
            this.Controls.Add(this.ed_Name_lbl);
            this.Controls.Add(this.edId_tb);
            this.Controls.Add(this.ed_Id_lbl);
            this.Controls.Add(this.reg_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmpDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpDashboard";
            this.Load += new System.EventHandler(this.EmpDashboard_Load);
            this.reg_panel.ResumeLayout(false);
            this.reg_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexit_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel reg_panel;
        private System.Windows.Forms.PictureBox regexit_pb;
        private System.Windows.Forms.Label reg_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ed_Dept_lbl;
        private System.Windows.Forms.TextBox edSalary_tb;
        private System.Windows.Forms.Label ed_Slry_lbl;
        private System.Windows.Forms.TextBox edName_tb;
        private System.Windows.Forms.Label ed_Name_lbl;
        private System.Windows.Forms.TextBox edId_tb;
        private System.Windows.Forms.Label ed_Id_lbl;
        private System.Windows.Forms.ComboBox ed_Dept_cb;
        private System.Windows.Forms.ComboBox ed_Role_cb;
        private System.Windows.Forms.Label ed_Role_lbl;
        private System.Windows.Forms.Label ed_Search_lbl;
        private System.Windows.Forms.TextBox ed_SearchBox;
        private System.Windows.Forms.DataGridView ed_dataGridView;
        private System.Windows.Forms.Button ed_Search_btn;
        private System.Windows.Forms.Button ed_Print_btn;
        private System.Windows.Forms.Button ed_Add_btn;
        private System.Windows.Forms.Button ed_Del_btn;
        private System.Windows.Forms.Button ed_Update_btn;
        private System.Windows.Forms.Button ed_Fetch_btn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}