namespace HoatDongDatHangTaiTongDai
{
    partial class Frm_Quanly
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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMaNV = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btn_TaoHD = new System.Windows.Forms.Button();
            this.pnHD = new System.Windows.Forms.Panel();
            this.pnUC = new System.Windows.Forms.Panel();
            this.lbMHD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barMaCN = new DevExpress.XtraBars.BarStaticItem();
            this.barTime = new DevExpress.XtraBars.BarStaticItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_CN = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_TimkiemKH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_CN.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barMaNV,
            this.barHeaderItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1309, 32);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barMaNV
            // 
            this.barMaNV.Caption = "NV1";
            this.barMaNV.Id = 1;
            this.barMaNV.Name = "barMaNV";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Mã nhân viên:";
            this.barHeaderItem1.Id = 2;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barHeaderItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barMaNV);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 689);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1309, 21);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbTongTien.Location = new System.Drawing.Point(120, 61);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(32, 18);
            this.lbTongTien.TabIndex = 74;
            this.lbTongTien.Text = "___";
            // 
            // btn_TaoHD
            // 
            this.btn_TaoHD.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_TaoHD.Location = new System.Drawing.Point(4, 33);
            this.btn_TaoHD.Name = "btn_TaoHD";
            this.btn_TaoHD.Size = new System.Drawing.Size(155, 31);
            this.btn_TaoHD.TabIndex = 73;
            this.btn_TaoHD.Text = "Tạo hóa đơn mới";
            this.btn_TaoHD.UseVisualStyleBackColor = true;
            // 
            // pnHD
            // 
            this.pnHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnHD.Location = new System.Drawing.Point(4, 67);
            this.pnHD.Name = "pnHD";
            this.pnHD.Size = new System.Drawing.Size(464, 374);
            this.pnHD.TabIndex = 72;
            // 
            // pnUC
            // 
            this.pnUC.AutoScroll = true;
            this.pnUC.Location = new System.Drawing.Point(474, 67);
            this.pnUC.Name = "pnUC";
            this.pnUC.Size = new System.Drawing.Size(828, 521);
            this.pnUC.TabIndex = 71;
            // 
            // lbMHD
            // 
            this.lbMHD.AutoSize = true;
            this.lbMHD.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbMHD.Location = new System.Drawing.Point(120, 24);
            this.lbMHD.Name = "lbMHD";
            this.lbMHD.Size = new System.Drawing.Size(32, 18);
            this.lbMHD.TabIndex = 68;
            this.lbMHD.Text = "___";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mã KH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Mã chi nhánh: ";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barMaCN
            // 
            this.barMaCN.Caption = "CN1";
            this.barMaCN.Id = 1;
            this.barMaCN.Name = "barMaCN";
            // 
            // barTime
            // 
            this.barTime.Caption = "22/11/2017";
            this.barTime.Id = 3;
            this.barTime.Name = "barTime";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(422, 447);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(46, 23);
            this.simpleButton2.TabIndex = 85;
            this.simpleButton2.Text = "Tạo KH";
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_MaKH.Location = new System.Drawing.Point(82, 32);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(32, 18);
            this.lb_MaKH.TabIndex = 83;
            this.lb_MaKH.Text = "___";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(247, 63);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(158, 23);
            this.simpleButton1.TabIndex = 86;
            this.simpleButton1.Text = "Lịch sử giao dịch";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(345, 61);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 87;
            this.simpleButton3.Text = "Báo hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(205, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "Chi nhánh:";
            // 
            // cb_CN
            // 
            this.cb_CN.Location = new System.Drawing.Point(297, 26);
            this.cb_CN.MenuManager = this.ribbon;
            this.cb_CN.Name = "cb_CN";
            this.cb_CN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_CN.Size = new System.Drawing.Size(142, 20);
            this.cb_CN.TabIndex = 89;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(1082, 38);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(167, 23);
            this.simpleButton4.TabIndex = 90;
            this.simpleButton4.Text = "Quản lý danh sách đơn hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Đơn hàng đang chờ duyệt : 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(905, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Đơn hàng đang chờ duyệt : 0";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_TenKH.Location = new System.Drawing.Point(229, 32);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(32, 18);
            this.lb_TenKH.TabIndex = 99;
            this.lb_TenKH.Text = "___";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(161, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 98;
            this.label9.Text = "Tên KH:";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_SDT.Location = new System.Drawing.Point(82, 63);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(32, 18);
            this.lb_SDT.TabIndex = 101;
            this.lb_SDT.Text = "___";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(15, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 100;
            this.label11.Text = "Số ĐT:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_MaKH);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.lb_SDT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lb_TenKH);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox1.Location = new System.Drawing.Point(7, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 98);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin KH";
            // 
            // tb_TimkiemKH
            // 
            this.tb_TimkiemKH.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_TimkiemKH.Location = new System.Drawing.Point(13, 447);
            this.tb_TimkiemKH.Name = "tb_TimkiemKH";
            this.tb_TimkiemKH.Size = new System.Drawing.Size(384, 21);
            this.tb_TimkiemKH.TabIndex = 115;
            this.tb_TimkiemKH.Text = "Nhập tên, sđt hoặc mã khách hàng để tìm !!!";
            this.tb_TimkiemKH.TextChanged += new System.EventHandler(this.tb_TimkiemKH_TextChanged);
            this.tb_TimkiemKH.Enter += new System.EventHandler(this.tb_TimkiemKH_Enter);
            this.tb_TimkiemKH.Leave += new System.EventHandler(this.tb_TimkiemKH_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Controls.Add(this.lbTongTien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbMHD);
            this.groupBox2.Controls.Add(this.cb_CN);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox2.Location = new System.Drawing.Point(7, 580);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 100);
            this.groupBox2.TabIndex = 116;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Hóa đơn";
            // 
            // Frm_Quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 710);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_TimkiemKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btn_TaoHD);
            this.Controls.Add(this.pnHD);
            this.Controls.Add(this.pnUC);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_Quanly";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Frm_Quanly";
            this.Load += new System.EventHandler(this.Frm_Quanly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_CN.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barMaCN;
        private DevExpress.XtraBars.BarStaticItem barTime;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button btn_TaoHD;
        private System.Windows.Forms.Panel pnHD;
        private System.Windows.Forms.Panel pnUC;
        private System.Windows.Forms.Label lbMHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraBars.BarHeaderItem barMaNV;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private System.Windows.Forms.Label lb_MaKH;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cb_CN;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_TimkiemKH;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}