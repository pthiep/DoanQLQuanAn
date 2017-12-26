namespace Boquanquanly
{
    partial class uc_doanhthu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbQuy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTuan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbNgay = new System.Windows.Forms.ComboBox();
            this.cbbChonLich = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSLdonhang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDoanhthu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnBaocaodoanhthu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpKT = new System.Windows.Forms.DateTimePicker();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXem);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbNam);
            this.panel1.Controls.Add(this.cbbNam);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbbQuy);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbThang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbbTuan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbbNgay);
            this.panel1.Controls.Add(this.cbbChonLich);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnBaocaodoanhthu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpKT);
            this.panel1.Controls.Add(this.dtpBD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 435);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(439, 109);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(75, 23);
            this.btXem.TabIndex = 14;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.Xem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Lịch làm việc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Lịch năm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Chọn lịch";
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.Location = new System.Drawing.Point(449, 73);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(32, 13);
            this.cbNam.TabIndex = 25;
            this.cbNam.Text = "Năm";
            // 
            // cbbNam
            // 
            this.cbbNam.Enabled = false;
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(484, 69);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(61, 21);
            this.cbbNam.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(369, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quý";
            // 
            // cbbQuy
            // 
            this.cbbQuy.Enabled = false;
            this.cbbQuy.FormattingEnabled = true;
            this.cbbQuy.Location = new System.Drawing.Point(404, 69);
            this.cbbQuy.Name = "cbbQuy";
            this.cbbQuy.Size = new System.Drawing.Size(39, 21);
            this.cbbQuy.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tháng";
            // 
            // cbbThang
            // 
            this.cbbThang.Enabled = false;
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(324, 69);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(39, 21);
            this.cbbThang.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tuần";
            // 
            // cbbTuan
            // 
            this.cbbTuan.Enabled = false;
            this.cbbTuan.FormattingEnabled = true;
            this.cbbTuan.Location = new System.Drawing.Point(230, 70);
            this.cbbTuan.Name = "cbbTuan";
            this.cbbTuan.Size = new System.Drawing.Size(39, 21);
            this.cbbTuan.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày";
            // 
            // cbbNgay
            // 
            this.cbbNgay.Enabled = false;
            this.cbbNgay.FormattingEnabled = true;
            this.cbbNgay.Location = new System.Drawing.Point(143, 69);
            this.cbbNgay.Name = "cbbNgay";
            this.cbbNgay.Size = new System.Drawing.Size(39, 21);
            this.cbbNgay.TabIndex = 16;
            // 
            // cbbChonLich
            // 
            this.cbbChonLich.FormattingEnabled = true;
            this.cbbChonLich.Items.AddRange(new object[] {
            "Theo lịch làm việc",
            "Theo lịch năm"});
            this.cbbChonLich.Location = new System.Drawing.Point(108, 18);
            this.cbbChonLich.Name = "cbbChonLich";
            this.cbbChonLich.Size = new System.Drawing.Size(82, 21);
            this.cbbChonLich.TabIndex = 15;
            this.cbbChonLich.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtSLdonhang);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(757, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 79);
            this.panel3.TabIndex = 7;
            // 
            // txtSLdonhang
            // 
            this.txtSLdonhang.Location = new System.Drawing.Point(72, 25);
            this.txtSLdonhang.Name = "txtSLdonhang";
            this.txtSLdonhang.ReadOnly = true;
            this.txtSLdonhang.Size = new System.Drawing.Size(112, 20);
            this.txtSLdonhang.TabIndex = 4;
            this.txtSLdonhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lượng đơn hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDoanhthu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(551, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 78);
            this.panel2.TabIndex = 6;
            // 
            // txtDoanhthu
            // 
            this.txtDoanhthu.Location = new System.Drawing.Point(70, 25);
            this.txtDoanhthu.Name = "txtDoanhthu";
            this.txtDoanhthu.ReadOnly = true;
            this.txtDoanhthu.Size = new System.Drawing.Size(108, 20);
            this.txtDoanhthu.TabIndex = 4;
            this.txtDoanhthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng doanh thu";
            // 
            // pnBaocaodoanhthu
            // 
            this.pnBaocaodoanhthu.Location = new System.Drawing.Point(0, 138);
            this.pnBaocaodoanhthu.Name = "pnBaocaodoanhthu";
            this.pnBaocaodoanhthu.Size = new System.Drawing.Size(960, 297);
            this.pnBaocaodoanhthu.TabIndex = 8;
            this.pnBaocaodoanhthu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBaocaodoanhthu_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "From ";
            // 
            // dtpKT
            // 
            this.dtpKT.Enabled = false;
            this.dtpKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKT.Location = new System.Drawing.Point(303, 44);
            this.dtpKT.Name = "dtpKT";
            this.dtpKT.Size = new System.Drawing.Size(95, 20);
            this.dtpKT.TabIndex = 1;
            // 
            // dtpBD
            // 
            this.dtpBD.Enabled = false;
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBD.Location = new System.Drawing.Point(160, 44);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(99, 20);
            this.dtpBD.TabIndex = 0;
            this.dtpBD.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // uc_doanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_doanhthu";
            this.Size = new System.Drawing.Size(960, 435);
            this.Load += new System.EventHandler(this.uc_doanhthu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDoanhthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpKT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSLdonhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnBaocaodoanhthu;
        private System.Windows.Forms.Label cbNam;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.ComboBox cbbChonLich;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbQuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbNgay;


    }
}
