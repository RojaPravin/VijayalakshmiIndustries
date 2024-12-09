namespace Vijayalakshmi_Industries
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.log_panel = new System.Windows.Forms.Panel();
            this.fp_Logo = new System.Windows.Forms.PictureBox();
            this.fpTitle_lbl2 = new System.Windows.Forms.Label();
            this.fpTitle_lbl = new System.Windows.Forms.Label();
            this.txt_Role_Atn = new System.Windows.Forms.ComboBox();
            this.ed_Role_lbl = new System.Windows.Forms.Label();
            this.txt_Dept_Atn = new System.Windows.Forms.ComboBox();
            this.ed_Dept_lbl = new System.Windows.Forms.Label();
            this.txt_Name_Atn = new System.Windows.Forms.TextBox();
            this.ed_Name_lbl = new System.Windows.Forms.Label();
            this.txt_ID_Atn = new System.Windows.Forms.TextBox();
            this.ed_Id_lbl = new System.Windows.Forms.Label();
            this.btn_Intime = new System.Windows.Forms.Button();
            this.btn_outtime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fp_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // log_panel
            // 
            this.log_panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.log_panel.Controls.Add(this.fp_Logo);
            this.log_panel.Controls.Add(this.fpTitle_lbl2);
            this.log_panel.Controls.Add(this.fpTitle_lbl);
            this.log_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.log_panel.Location = new System.Drawing.Point(0, 0);
            this.log_panel.Name = "log_panel";
            this.log_panel.Size = new System.Drawing.Size(342, 777);
            this.log_panel.TabIndex = 3;
            // 
            // fp_Logo
            // 
            this.fp_Logo.Image = ((System.Drawing.Image)(resources.GetObject("fp_Logo.Image")));
            this.fp_Logo.Location = new System.Drawing.Point(12, 279);
            this.fp_Logo.Name = "fp_Logo";
            this.fp_Logo.Size = new System.Drawing.Size(293, 197);
            this.fp_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fp_Logo.TabIndex = 40;
            this.fp_Logo.TabStop = false;
            // 
            // fpTitle_lbl2
            // 
            this.fpTitle_lbl2.AutoSize = true;
            this.fpTitle_lbl2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpTitle_lbl2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fpTitle_lbl2.Location = new System.Drawing.Point(59, 205);
            this.fpTitle_lbl2.Name = "fpTitle_lbl2";
            this.fpTitle_lbl2.Size = new System.Drawing.Size(205, 32);
            this.fpTitle_lbl2.TabIndex = 1;
            this.fpTitle_lbl2.Text = "INDUSTRIES";
            // 
            // fpTitle_lbl
            // 
            this.fpTitle_lbl.AutoSize = true;
            this.fpTitle_lbl.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpTitle_lbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fpTitle_lbl.Location = new System.Drawing.Point(30, 173);
            this.fpTitle_lbl.Name = "fpTitle_lbl";
            this.fpTitle_lbl.Size = new System.Drawing.Size(275, 32);
            this.fpTitle_lbl.TabIndex = 0;
            this.fpTitle_lbl.Text = "VIJAYALAKSHMI";
            // 
            // txt_Role_Atn
            // 
            this.txt_Role_Atn.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_Role_Atn.FormattingEnabled = true;
            this.txt_Role_Atn.Items.AddRange(new object[] {
            "Junior",
            "Senior"});
            this.txt_Role_Atn.Location = new System.Drawing.Point(410, 517);
            this.txt_Role_Atn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Role_Atn.Name = "txt_Role_Atn";
            this.txt_Role_Atn.Size = new System.Drawing.Size(464, 32);
            this.txt_Role_Atn.TabIndex = 29;
            this.txt_Role_Atn.SelectedIndexChanged += new System.EventHandler(this.ed_Role_cb_SelectedIndexChanged);
            // 
            // ed_Role_lbl
            // 
            this.ed_Role_lbl.AutoSize = true;
            this.ed_Role_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Role_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Role_lbl.Location = new System.Drawing.Point(405, 471);
            this.ed_Role_lbl.Name = "ed_Role_lbl";
            this.ed_Role_lbl.Size = new System.Drawing.Size(189, 27);
            this.ed_Role_lbl.TabIndex = 28;
            this.ed_Role_lbl.Text = "Employee Role";
            // 
            // txt_Dept_Atn
            // 
            this.txt_Dept_Atn.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_Dept_Atn.FormattingEnabled = true;
            this.txt_Dept_Atn.Items.AddRange(new object[] {
            "HR",
            "Manager",
            "Development",
            "Testing",
            "Marketing",
            "Sales",
            ""});
            this.txt_Dept_Atn.Location = new System.Drawing.Point(410, 404);
            this.txt_Dept_Atn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Dept_Atn.Name = "txt_Dept_Atn";
            this.txt_Dept_Atn.Size = new System.Drawing.Size(464, 32);
            this.txt_Dept_Atn.TabIndex = 27;
            this.txt_Dept_Atn.SelectedIndexChanged += new System.EventHandler(this.ed_Dept_cb_SelectedIndexChanged);
            // 
            // ed_Dept_lbl
            // 
            this.ed_Dept_lbl.AutoSize = true;
            this.ed_Dept_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Dept_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Dept_lbl.Location = new System.Drawing.Point(405, 358);
            this.ed_Dept_lbl.Name = "ed_Dept_lbl";
            this.ed_Dept_lbl.Size = new System.Drawing.Size(278, 27);
            this.ed_Dept_lbl.TabIndex = 26;
            this.ed_Dept_lbl.Text = "Employee Department";
            // 
            // txt_Name_Atn
            // 
            this.txt_Name_Atn.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_Name_Atn.Location = new System.Drawing.Point(410, 286);
            this.txt_Name_Atn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name_Atn.Name = "txt_Name_Atn";
            this.txt_Name_Atn.Size = new System.Drawing.Size(464, 30);
            this.txt_Name_Atn.TabIndex = 23;
            // 
            // ed_Name_lbl
            // 
            this.ed_Name_lbl.AutoSize = true;
            this.ed_Name_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Name_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Name_lbl.Location = new System.Drawing.Point(405, 245);
            this.ed_Name_lbl.Name = "ed_Name_lbl";
            this.ed_Name_lbl.Size = new System.Drawing.Size(204, 27);
            this.ed_Name_lbl.TabIndex = 22;
            this.ed_Name_lbl.Text = "Employee Name";
            // 
            // txt_ID_Atn
            // 
            this.txt_ID_Atn.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_ID_Atn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ID_Atn.Location = new System.Drawing.Point(410, 183);
            this.txt_ID_Atn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ID_Atn.Name = "txt_ID_Atn";
            this.txt_ID_Atn.Size = new System.Drawing.Size(464, 30);
            this.txt_ID_Atn.TabIndex = 21;
            this.txt_ID_Atn.TextChanged += new System.EventHandler(this.edId_tb_TextChanged);
            // 
            // ed_Id_lbl
            // 
            this.ed_Id_lbl.AutoSize = true;
            this.ed_Id_lbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_Id_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ed_Id_lbl.Location = new System.Drawing.Point(405, 142);
            this.ed_Id_lbl.Name = "ed_Id_lbl";
            this.ed_Id_lbl.Size = new System.Drawing.Size(164, 27);
            this.ed_Id_lbl.TabIndex = 20;
            this.ed_Id_lbl.Text = "Employee ID";
            // 
            // btn_Intime
            // 
            this.btn_Intime.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Intime.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Intime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Intime.Location = new System.Drawing.Point(445, 620);
            this.btn_Intime.Name = "btn_Intime";
            this.btn_Intime.Size = new System.Drawing.Size(173, 54);
            this.btn_Intime.TabIndex = 46;
            this.btn_Intime.Text = "InTime";
            this.btn_Intime.UseVisualStyleBackColor = false;
            this.btn_Intime.Click += new System.EventHandler(this.btn_Intime_Click);
            // 
            // btn_outtime
            // 
            this.btn_outtime.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_outtime.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_outtime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_outtime.Location = new System.Drawing.Point(650, 620);
            this.btn_outtime.Name = "btn_outtime";
            this.btn_outtime.Size = new System.Drawing.Size(173, 54);
            this.btn_outtime.TabIndex = 47;
            this.btn_outtime.Text = "OutTime";
            this.btn_outtime.UseVisualStyleBackColor = false;
            this.btn_outtime.Click += new System.EventHandler(this.btn_outtime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(481, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 35);
            this.label1.TabIndex = 48;
            this.label1.Text = "Attendance Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(405, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 49;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 777);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_outtime);
            this.Controls.Add(this.btn_Intime);
            this.Controls.Add(this.txt_Role_Atn);
            this.Controls.Add(this.ed_Role_lbl);
            this.Controls.Add(this.txt_Dept_Atn);
            this.Controls.Add(this.ed_Dept_lbl);
            this.Controls.Add(this.txt_Name_Atn);
            this.Controls.Add(this.ed_Name_lbl);
            this.Controls.Add(this.txt_ID_Atn);
            this.Controls.Add(this.ed_Id_lbl);
            this.Controls.Add(this.log_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.log_panel.ResumeLayout(false);
            this.log_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fp_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel log_panel;
        private System.Windows.Forms.PictureBox fp_Logo;
        private System.Windows.Forms.Label fpTitle_lbl2;
        private System.Windows.Forms.Label fpTitle_lbl;
        private System.Windows.Forms.ComboBox txt_Role_Atn;
        private System.Windows.Forms.Label ed_Role_lbl;
        private System.Windows.Forms.ComboBox txt_Dept_Atn;
        private System.Windows.Forms.Label ed_Dept_lbl;
        private System.Windows.Forms.TextBox txt_Name_Atn;
        private System.Windows.Forms.Label ed_Name_lbl;
        private System.Windows.Forms.TextBox txt_ID_Atn;
        private System.Windows.Forms.Label ed_Id_lbl;
        private System.Windows.Forms.Button btn_Intime;
        private System.Windows.Forms.Button btn_outtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}