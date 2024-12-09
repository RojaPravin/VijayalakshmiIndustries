namespace Vijayalakshmi_Industries
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.reg_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regexit_pb = new System.Windows.Forms.PictureBox();
            this.reg_title = new System.Windows.Forms.Label();
            this.sal_Id_lbl = new System.Windows.Forms.Label();
            this.salary_tb = new System.Windows.Forms.TextBox();
            this.Sal_lbl = new System.Windows.Forms.Label();
            this.Sal_Name_tb = new System.Windows.Forms.TextBox();
            this.sal_Name_lbl = new System.Windows.Forms.Label();
            this.sal_dataGridView = new System.Windows.Forms.DataGridView();
            this.RadioMan_Btn = new System.Windows.Forms.RadioButton();
            this.salAdd_Btn = new System.Windows.Forms.Button();
            this.salary_Lbl = new System.Windows.Forms.Label();
            this.RadioEmp_Btn = new System.Windows.Forms.RadioButton();
            this.Sal_Total_Tb = new System.Windows.Forms.TextBox();
            this.Sal_Total_Lbl = new System.Windows.Forms.Label();
            this.Sal_Pf_Tb = new System.Windows.Forms.TextBox();
            this.Sal_Pf_Lbl = new System.Windows.Forms.Label();
            this.salFetch_Btn = new System.Windows.Forms.Button();
            this.sal_Id_Cb = new System.Windows.Forms.ComboBox();
            this.sal_PictureBox = new System.Windows.Forms.PictureBox();
            this.sal_Browse_Btn = new System.Windows.Forms.Button();
            this.Generate_PaySlip_Btn = new System.Windows.Forms.Button();
            this.reg_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexit_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal_PictureBox)).BeginInit();
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
            this.reg_panel.TabIndex = 2;
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
            // sal_Id_lbl
            // 
            this.sal_Id_lbl.AutoSize = true;
            this.sal_Id_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_Id_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sal_Id_lbl.Location = new System.Drawing.Point(54, 220);
            this.sal_Id_lbl.Name = "sal_Id_lbl";
            this.sal_Id_lbl.Size = new System.Drawing.Size(41, 27);
            this.sal_Id_lbl.TabIndex = 18;
            this.sal_Id_lbl.Text = "ID";
            // 
            // salary_tb
            // 
            this.salary_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.salary_tb.Location = new System.Drawing.Point(57, 450);
            this.salary_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salary_tb.Name = "salary_tb";
            this.salary_tb.Size = new System.Drawing.Size(359, 30);
            this.salary_tb.TabIndex = 25;
            // 
            // Sal_lbl
            // 
            this.Sal_lbl.AutoSize = true;
            this.Sal_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sal_lbl.Location = new System.Drawing.Point(52, 406);
            this.Sal_lbl.Name = "Sal_lbl";
            this.Sal_lbl.Size = new System.Drawing.Size(88, 27);
            this.Sal_lbl.TabIndex = 24;
            this.Sal_lbl.Text = "Salary";
            // 
            // Sal_Name_tb
            // 
            this.Sal_Name_tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.Sal_Name_tb.Location = new System.Drawing.Point(57, 361);
            this.Sal_Name_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sal_Name_tb.Name = "Sal_Name_tb";
            this.Sal_Name_tb.Size = new System.Drawing.Size(359, 30);
            this.Sal_Name_tb.TabIndex = 23;
            // 
            // sal_Name_lbl
            // 
            this.sal_Name_lbl.AutoSize = true;
            this.sal_Name_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_Name_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sal_Name_lbl.Location = new System.Drawing.Point(52, 320);
            this.sal_Name_lbl.Name = "sal_Name_lbl";
            this.sal_Name_lbl.Size = new System.Drawing.Size(81, 27);
            this.sal_Name_lbl.TabIndex = 22;
            this.sal_Name_lbl.Text = "Name";
            // 
            // sal_dataGridView
            // 
            this.sal_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sal_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sal_dataGridView.Location = new System.Drawing.Point(489, 246);
            this.sal_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sal_dataGridView.Name = "sal_dataGridView";
            this.sal_dataGridView.RowHeadersWidth = 51;
            this.sal_dataGridView.RowTemplate.Height = 24;
            this.sal_dataGridView.Size = new System.Drawing.Size(446, 421);
            this.sal_dataGridView.TabIndex = 26;
            // 
            // RadioMan_Btn
            // 
            this.RadioMan_Btn.AutoSize = true;
            this.RadioMan_Btn.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioMan_Btn.Location = new System.Drawing.Point(61, 152);
            this.RadioMan_Btn.Name = "RadioMan_Btn";
            this.RadioMan_Btn.Size = new System.Drawing.Size(139, 31);
            this.RadioMan_Btn.TabIndex = 27;
            this.RadioMan_Btn.TabStop = true;
            this.RadioMan_Btn.Text = "Manager";
            this.RadioMan_Btn.UseVisualStyleBackColor = true;
            this.RadioMan_Btn.CheckedChanged += new System.EventHandler(this.RadioMan_Btn_CheckedChanged);
            // 
            // salAdd_Btn
            // 
            this.salAdd_Btn.BackColor = System.Drawing.Color.LightCyan;
            this.salAdd_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salAdd_Btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salAdd_Btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.salAdd_Btn.Location = new System.Drawing.Point(116, 690);
            this.salAdd_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salAdd_Btn.Name = "salAdd_Btn";
            this.salAdd_Btn.Size = new System.Drawing.Size(112, 54);
            this.salAdd_Btn.TabIndex = 52;
            this.salAdd_Btn.Text = "ADD";
            this.salAdd_Btn.UseVisualStyleBackColor = false;
            this.salAdd_Btn.Click += new System.EventHandler(this.salAdd_Btn_Click);
            // 
            // salary_Lbl
            // 
            this.salary_Lbl.AutoSize = true;
            this.salary_Lbl.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_Lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.salary_Lbl.Location = new System.Drawing.Point(385, 70);
            this.salary_Lbl.Name = "salary_Lbl";
            this.salary_Lbl.Size = new System.Drawing.Size(136, 32);
            this.salary_Lbl.TabIndex = 54;
            this.salary_Lbl.Text = "SALARY";
            this.salary_Lbl.Click += new System.EventHandler(this.log_lbl_Click);
            // 
            // RadioEmp_Btn
            // 
            this.RadioEmp_Btn.AutoSize = true;
            this.RadioEmp_Btn.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioEmp_Btn.Location = new System.Drawing.Point(231, 152);
            this.RadioEmp_Btn.Name = "RadioEmp_Btn";
            this.RadioEmp_Btn.Size = new System.Drawing.Size(150, 31);
            this.RadioEmp_Btn.TabIndex = 55;
            this.RadioEmp_Btn.TabStop = true;
            this.RadioEmp_Btn.Text = "Employee";
            this.RadioEmp_Btn.UseVisualStyleBackColor = true;
            this.RadioEmp_Btn.CheckedChanged += new System.EventHandler(this.RadioEmp_Btn_CheckedChanged);
            // 
            // Sal_Total_Tb
            // 
            this.Sal_Total_Tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.Sal_Total_Tb.Location = new System.Drawing.Point(61, 637);
            this.Sal_Total_Tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sal_Total_Tb.Name = "Sal_Total_Tb";
            this.Sal_Total_Tb.Size = new System.Drawing.Size(359, 30);
            this.Sal_Total_Tb.TabIndex = 59;
            // 
            // Sal_Total_Lbl
            // 
            this.Sal_Total_Lbl.AutoSize = true;
            this.Sal_Total_Lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_Total_Lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sal_Total_Lbl.Location = new System.Drawing.Point(58, 595);
            this.Sal_Total_Lbl.Name = "Sal_Total_Lbl";
            this.Sal_Total_Lbl.Size = new System.Drawing.Size(74, 27);
            this.Sal_Total_Lbl.TabIndex = 58;
            this.Sal_Total_Lbl.Text = "Total";
            // 
            // Sal_Pf_Tb
            // 
            this.Sal_Pf_Tb.Font = new System.Drawing.Font("Georgia", 12F);
            this.Sal_Pf_Tb.Location = new System.Drawing.Point(57, 538);
            this.Sal_Pf_Tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sal_Pf_Tb.Name = "Sal_Pf_Tb";
            this.Sal_Pf_Tb.Size = new System.Drawing.Size(359, 30);
            this.Sal_Pf_Tb.TabIndex = 57;
            this.Sal_Pf_Tb.TextChanged += new System.EventHandler(this.Sal_Bonus_Tb_TextChanged);
            // 
            // Sal_Pf_Lbl
            // 
            this.Sal_Pf_Lbl.AutoSize = true;
            this.Sal_Pf_Lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_Pf_Lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sal_Pf_Lbl.Location = new System.Drawing.Point(54, 500);
            this.Sal_Pf_Lbl.Name = "Sal_Pf_Lbl";
            this.Sal_Pf_Lbl.Size = new System.Drawing.Size(37, 27);
            this.Sal_Pf_Lbl.TabIndex = 56;
            this.Sal_Pf_Lbl.Text = "Pf";
            // 
            // salFetch_Btn
            // 
            this.salFetch_Btn.BackColor = System.Drawing.Color.LightCyan;
            this.salFetch_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salFetch_Btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salFetch_Btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.salFetch_Btn.Location = new System.Drawing.Point(234, 690);
            this.salFetch_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salFetch_Btn.Name = "salFetch_Btn";
            this.salFetch_Btn.Size = new System.Drawing.Size(112, 54);
            this.salFetch_Btn.TabIndex = 60;
            this.salFetch_Btn.Text = "FETCH";
            this.salFetch_Btn.UseVisualStyleBackColor = false;
            this.salFetch_Btn.Click += new System.EventHandler(this.salFetch_Btn_Click);
            // 
            // sal_Id_Cb
            // 
            this.sal_Id_Cb.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_Id_Cb.FormattingEnabled = true;
            this.sal_Id_Cb.Location = new System.Drawing.Point(57, 271);
            this.sal_Id_Cb.Name = "sal_Id_Cb";
            this.sal_Id_Cb.Size = new System.Drawing.Size(359, 32);
            this.sal_Id_Cb.TabIndex = 61;
            this.sal_Id_Cb.SelectedIndexChanged += new System.EventHandler(this.id_Sal_Cb_SelectedIndexChanged);
            // 
            // sal_PictureBox
            // 
            this.sal_PictureBox.Location = new System.Drawing.Point(599, 112);
            this.sal_PictureBox.Name = "sal_PictureBox";
            this.sal_PictureBox.Size = new System.Drawing.Size(131, 115);
            this.sal_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sal_PictureBox.TabIndex = 62;
            this.sal_PictureBox.TabStop = false;
            this.sal_PictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // sal_Browse_Btn
            // 
            this.sal_Browse_Btn.BackColor = System.Drawing.Color.LightCyan;
            this.sal_Browse_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sal_Browse_Btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_Browse_Btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sal_Browse_Btn.Location = new System.Drawing.Point(746, 143);
            this.sal_Browse_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sal_Browse_Btn.Name = "sal_Browse_Btn";
            this.sal_Browse_Btn.Size = new System.Drawing.Size(130, 54);
            this.sal_Browse_Btn.TabIndex = 64;
            this.sal_Browse_Btn.Text = "BROWSE";
            this.sal_Browse_Btn.UseVisualStyleBackColor = false;
            this.sal_Browse_Btn.Click += new System.EventHandler(this.sal_Browse_Btn_Click);
            // 
            // Generate_PaySlip_Btn
            // 
            this.Generate_PaySlip_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Generate_PaySlip_Btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_PaySlip_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Generate_PaySlip_Btn.Location = new System.Drawing.Point(610, 690);
            this.Generate_PaySlip_Btn.Name = "Generate_PaySlip_Btn";
            this.Generate_PaySlip_Btn.Size = new System.Drawing.Size(239, 54);
            this.Generate_PaySlip_Btn.TabIndex = 65;
            this.Generate_PaySlip_Btn.Text = "Generate Payslip";
            this.Generate_PaySlip_Btn.UseVisualStyleBackColor = false;
            this.Generate_PaySlip_Btn.Click += new System.EventHandler(this.fp_SendOtp_btn_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(977, 777);
            this.Controls.Add(this.Generate_PaySlip_Btn);
            this.Controls.Add(this.sal_Browse_Btn);
            this.Controls.Add(this.sal_PictureBox);
            this.Controls.Add(this.sal_Id_Cb);
            this.Controls.Add(this.salFetch_Btn);
            this.Controls.Add(this.Sal_Total_Tb);
            this.Controls.Add(this.Sal_Total_Lbl);
            this.Controls.Add(this.Sal_Pf_Tb);
            this.Controls.Add(this.Sal_Pf_Lbl);
            this.Controls.Add(this.RadioEmp_Btn);
            this.Controls.Add(this.salary_Lbl);
            this.Controls.Add(this.salAdd_Btn);
            this.Controls.Add(this.RadioMan_Btn);
            this.Controls.Add(this.sal_dataGridView);
            this.Controls.Add(this.salary_tb);
            this.Controls.Add(this.Sal_lbl);
            this.Controls.Add(this.Sal_Name_tb);
            this.Controls.Add(this.sal_Name_lbl);
            this.Controls.Add(this.sal_Id_lbl);
            this.Controls.Add(this.reg_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.reg_panel.ResumeLayout(false);
            this.reg_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexit_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel reg_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox regexit_pb;
        private System.Windows.Forms.Label reg_title;
        private System.Windows.Forms.Label sal_Id_lbl;
        private System.Windows.Forms.TextBox salary_tb;
        private System.Windows.Forms.Label Sal_lbl;
        private System.Windows.Forms.TextBox Sal_Name_tb;
        private System.Windows.Forms.Label sal_Name_lbl;
        private System.Windows.Forms.DataGridView sal_dataGridView;
        private System.Windows.Forms.RadioButton RadioMan_Btn;
        private System.Windows.Forms.Button salAdd_Btn;
        private System.Windows.Forms.Label salary_Lbl;
        private System.Windows.Forms.RadioButton RadioEmp_Btn;
        private System.Windows.Forms.TextBox Sal_Total_Tb;
        private System.Windows.Forms.Label Sal_Total_Lbl;
        private System.Windows.Forms.TextBox Sal_Pf_Tb;
        private System.Windows.Forms.Label Sal_Pf_Lbl;
        private System.Windows.Forms.Button salFetch_Btn;
        private System.Windows.Forms.ComboBox sal_Id_Cb;
        private System.Windows.Forms.PictureBox sal_PictureBox;
        private System.Windows.Forms.Button sal_Browse_Btn;
        private System.Windows.Forms.Button Generate_PaySlip_Btn;
    }
}