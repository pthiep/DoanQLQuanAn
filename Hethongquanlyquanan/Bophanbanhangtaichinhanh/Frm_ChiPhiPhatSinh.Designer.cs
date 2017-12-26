namespace Bophanbanhangtaichinhanh
{
    partial class Frm_ChiPhiPhatSinh
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.tb_Chiphi = new System.Windows.Forms.TextBox();
            this.tb_TenCP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_MaCP = new System.Windows.Forms.Label();
            this.btnThemNgay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_MaCN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Loai = new System.Windows.Forms.ComboBox();
            this.lb_Ngay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_MaNV = new System.Windows.Forms.Label();
=======
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txtTenCP = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
>>>>>>> 808c8447e350a6f3785fc3951d494528cb32c8e7
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(524, 32);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(242, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày phát sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên chi phí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chi phí:";
            // 
            // tb_Chiphi
            // 
            this.tb_Chiphi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tb_Chiphi.Location = new System.Drawing.Point(57, 153);
            this.tb_Chiphi.Name = "tb_Chiphi";
            this.tb_Chiphi.Size = new System.Drawing.Size(140, 25);
            this.tb_Chiphi.TabIndex = 9;
            this.tb_Chiphi.TextChanged += new System.EventHandler(this.tb_Chiphi_TextChanged);
            this.tb_Chiphi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Chiphi_KeyPress);
            // 
            // tb_TenCP
            // 
            this.tb_TenCP.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tb_TenCP.Location = new System.Drawing.Point(57, 87);
            this.tb_TenCP.Name = "tb_TenCP";
            this.tb_TenCP.Size = new System.Drawing.Size(140, 25);
            this.tb_TenCP.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã chi phí:";
            // 
            // lb_MaCP
            // 
            this.lb_MaCP.AutoSize = true;
            this.lb_MaCP.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_MaCP.Location = new System.Drawing.Point(127, 32);
            this.lb_MaCP.Name = "lb_MaCP";
            this.lb_MaCP.Size = new System.Drawing.Size(32, 18);
            this.lb_MaCP.TabIndex = 15;
            this.lb_MaCP.Text = "___";
            // 
            // btnThemNgay
            // 
            this.btnThemNgay.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnThemNgay.Location = new System.Drawing.Point(281, 223);
            this.btnThemNgay.Name = "btnThemNgay";
            this.btnThemNgay.Size = new System.Drawing.Size(148, 36);
            this.btnThemNgay.TabIndex = 16;
            this.btnThemNgay.Text = "Thêm chi phí";
            this.btnThemNgay.UseVisualStyleBackColor = true;
            this.btnThemNgay.Click += new System.EventHandler(this.btnThemNgay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_MaNV);
            this.groupBox1.Controls.Add(this.lb_Ngay);
            this.groupBox1.Controls.Add(this.cb_Loai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_MaCN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnThemNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Chiphi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_MaCP);
            this.groupBox1.Controls.Add(this.tb_TenCP);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 292);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chi phí phát sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(242, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã chi nhánh:";
            // 
            // lb_MaCN
            // 
            this.lb_MaCN.AutoSize = true;
            this.lb_MaCN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_MaCN.Location = new System.Drawing.Point(354, 32);
            this.lb_MaCN.Name = "lb_MaCN";
            this.lb_MaCN.Size = new System.Drawing.Size(32, 18);
            this.lb_MaCN.TabIndex = 18;
            this.lb_MaCN.Text = "___";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(31, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Loại chi phí:";
            // 
            // cb_Loai
            // 
            this.cb_Loai.FormattingEnabled = true;
            this.cb_Loai.Location = new System.Drawing.Point(57, 229);
            this.cb_Loai.Name = "cb_Loai";
            this.cb_Loai.Size = new System.Drawing.Size(121, 26);
            this.cb_Loai.TabIndex = 20;
            // 
            // lb_Ngay
            // 
            this.lb_Ngay.AutoSize = true;
            this.lb_Ngay.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_Ngay.Location = new System.Drawing.Point(278, 160);
            this.lb_Ngay.Name = "lb_Ngay";
            this.lb_Ngay.Size = new System.Drawing.Size(32, 18);
            this.lb_Ngay.TabIndex = 21;
            this.lb_Ngay.Text = "___";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(242, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mã nhân viên:";
            // 
            // lb_MaNV
            // 
<<<<<<< HEAD
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_MaNV.Location = new System.Drawing.Point(354, 66);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(32, 18);
            this.lb_MaNV.TabIndex = 23;
            this.lb_MaNV.Text = "___";
=======
            this.txtCP.Location = new System.Drawing.Point(111, 103);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(140, 21);
            this.txtCP.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(324, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
>>>>>>> 808c8447e350a6f3785fc3951d494528cb32c8e7
            // 
            // Frm_ChiPhiPhatSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(524, 346);
            this.Controls.Add(this.groupBox1);
=======
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtTenCP);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
>>>>>>> 808c8447e350a6f3785fc3951d494528cb32c8e7
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_ChiPhiPhatSinh";
            this.Ribbon = this.ribbon;
            this.Text = "Quản lý chi phí phát sinh";
            this.Load += new System.EventHandler(this.Frm_ChiPhiPhatSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox tb_Chiphi;
        private System.Windows.Forms.TextBox tb_TenCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_MaCP;
        private System.Windows.Forms.Button btnThemNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_MaCN;
        private System.Windows.Forms.ComboBox cb_Loai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_Ngay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_MaNV;
=======
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.TextBox txtTenCP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Button btnSave;
>>>>>>> 808c8447e350a6f3785fc3951d494528cb32c8e7
    }
}