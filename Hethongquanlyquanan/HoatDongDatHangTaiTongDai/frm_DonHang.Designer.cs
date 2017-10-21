namespace HoatDongDatHangTaiTongDai
{
    partial class frm_DonHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_chiNhanh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_nguoiNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbo_chuyenPhat = new System.Windows.Forms.GroupBox();
            this.rdochuyenphatNhanh = new System.Windows.Forms.RadioButton();
            this.rdo_nhanochiNhanh = new System.Windows.Forms.RadioButton();
            this.gbo_DH = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_Tonghoadon = new System.Windows.Forms.Label();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtg_DonHang = new System.Windows.Forms.DataGridView();
            this.txt_Tonghoadon = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbo_chuyenPhat.SuspendLayout();
            this.gbo_DH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_chiNhanh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Sdt);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.txt_nguoiNhan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Người nhận";
            // 
            // cbo_chiNhanh
            // 
            this.cbo_chiNhanh.FormattingEnabled = true;
            this.cbo_chiNhanh.Location = new System.Drawing.Point(124, 107);
            this.cbo_chiNhanh.Name = "cbo_chiNhanh";
            this.cbo_chiNhanh.Size = new System.Drawing.Size(100, 21);
            this.cbo_chiNhanh.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chi nhánh:";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(124, 73);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(100, 20);
            this.txt_Sdt.TabIndex = 5;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(124, 44);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(100, 20);
            this.txt_diaChi.TabIndex = 4;
            // 
            // txt_nguoiNhan
            // 
            this.txt_nguoiNhan.Location = new System.Drawing.Point(124, 12);
            this.txt_nguoiNhan.Name = "txt_nguoiNhan";
            this.txt_nguoiNhan.Size = new System.Drawing.Size(100, 20);
            this.txt_nguoiNhan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người nhận:";
            // 
            // gbo_chuyenPhat
            // 
            this.gbo_chuyenPhat.Controls.Add(this.rdochuyenphatNhanh);
            this.gbo_chuyenPhat.Controls.Add(this.rdo_nhanochiNhanh);
            this.gbo_chuyenPhat.Location = new System.Drawing.Point(29, 183);
            this.gbo_chuyenPhat.Name = "gbo_chuyenPhat";
            this.gbo_chuyenPhat.Size = new System.Drawing.Size(414, 71);
            this.gbo_chuyenPhat.TabIndex = 1;
            this.gbo_chuyenPhat.TabStop = false;
            this.gbo_chuyenPhat.Text = "Chuyển phát";
            this.gbo_chuyenPhat.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdochuyenphatNhanh
            // 
            this.rdochuyenphatNhanh.AutoSize = true;
            this.rdochuyenphatNhanh.Location = new System.Drawing.Point(16, 42);
            this.rdochuyenphatNhanh.Name = "rdochuyenphatNhanh";
            this.rdochuyenphatNhanh.Size = new System.Drawing.Size(177, 17);
            this.rdochuyenphatNhanh.TabIndex = 1;
            this.rdochuyenphatNhanh.TabStop = true;
            this.rdochuyenphatNhanh.Text = "Chuyển phát nhanh (24 - 48 giờ)";
            this.rdochuyenphatNhanh.UseVisualStyleBackColor = true;
            // 
            // rdo_nhanochiNhanh
            // 
            this.rdo_nhanochiNhanh.AutoSize = true;
            this.rdo_nhanochiNhanh.Location = new System.Drawing.Point(16, 19);
            this.rdo_nhanochiNhanh.Name = "rdo_nhanochiNhanh";
            this.rdo_nhanochiNhanh.Size = new System.Drawing.Size(138, 17);
            this.rdo_nhanochiNhanh.TabIndex = 0;
            this.rdo_nhanochiNhanh.TabStop = true;
            this.rdo_nhanochiNhanh.Text = "Nhận tại chi nhánh số 1";
            this.rdo_nhanochiNhanh.UseVisualStyleBackColor = true;
            // 
            // gbo_DH
            // 
            this.gbo_DH.Controls.Add(this.dtg_DonHang);
            this.gbo_DH.Controls.Add(this.button3);
            this.gbo_DH.Location = new System.Drawing.Point(29, 269);
            this.gbo_DH.Name = "gbo_DH";
            this.gbo_DH.Size = new System.Drawing.Size(481, 179);
            this.gbo_DH.TabIndex = 2;
            this.gbo_DH.TabStop = false;
            this.gbo_DH.Text = "Đơn hàng";
            this.gbo_DH.Enter += new System.EventHandler(this.gbo_DH_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thêm món ăn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbl_Tonghoadon
            // 
            this.lbl_Tonghoadon.AutoSize = true;
            this.lbl_Tonghoadon.Location = new System.Drawing.Point(279, 452);
            this.lbl_Tonghoadon.Name = "lbl_Tonghoadon";
            this.lbl_Tonghoadon.Size = new System.Drawing.Size(78, 13);
            this.lbl_Tonghoadon.TabIndex = 1;
            this.lbl_Tonghoadon.Text = "Tổng hóa đơn:";
            this.lbl_Tonghoadon.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.Location = new System.Drawing.Point(121, 472);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_xacNhan.TabIndex = 3;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtg_DonHang
            // 
            this.dtg_DonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DonHang.Location = new System.Drawing.Point(6, 26);
            this.dtg_DonHang.Name = "dtg_DonHang";
            this.dtg_DonHang.Size = new System.Drawing.Size(469, 150);
            this.dtg_DonHang.TabIndex = 4;
            // 
            // txt_Tonghoadon
            // 
            this.txt_Tonghoadon.Location = new System.Drawing.Point(363, 449);
            this.txt_Tonghoadon.Name = "txt_Tonghoadon";
            this.txt_Tonghoadon.Size = new System.Drawing.Size(100, 20);
            this.txt_Tonghoadon.TabIndex = 5;
            // 
            // frm_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 507);
            this.Controls.Add(this.txt_Tonghoadon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_Tonghoadon);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.gbo_DH);
            this.Controls.Add(this.gbo_chuyenPhat);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_DonHang";
            this.Text = "Đơn hàng";
            this.Load += new System.EventHandler(this.frm_DonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbo_chuyenPhat.ResumeLayout(false);
            this.gbo_chuyenPhat.PerformLayout();
            this.gbo_DH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_nguoiNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbo_chuyenPhat;
        private System.Windows.Forms.RadioButton rdochuyenphatNhanh;
        private System.Windows.Forms.RadioButton rdo_nhanochiNhanh;
        private System.Windows.Forms.GroupBox gbo_DH;
        private System.Windows.Forms.Label lbl_Tonghoadon;
        private System.Windows.Forms.ComboBox cbo_chiNhanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtg_DonHang;
        private System.Windows.Forms.TextBox txt_Tonghoadon;
    }
}