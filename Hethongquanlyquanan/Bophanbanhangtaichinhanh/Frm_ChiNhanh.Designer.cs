namespace Bophanbanhangtaichinhanh
{
    partial class Frm_ChiNhanh
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
            this.barTenCN = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barNgay = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_HoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.lbMHD = new System.Windows.Forms.Label();
            this.lbMNV = new System.Windows.Forms.Label();
            this.lbMKH = new System.Windows.Forms.Label();
            this.btnCPPS = new DevExpress.XtraEditors.SimpleButton();
            this.pnUC = new System.Windows.Forms.Panel();
            this.btnVisible = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pnHD = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_TaoHD = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rdMangVe = new System.Windows.Forms.RadioButton();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTraLai = new System.Windows.Forms.Label();
            this.txtKhachDua = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new System.Windows.Forms.Button();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachDua.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barTenCN,
            this.barStaticItem1,
            this.barNgay});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1240, 32);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barTenCN
            // 
            this.barTenCN.Caption = "CN1";
            this.barTenCN.Id = 1;
            this.barTenCN.Name = "barTenCN";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Mã chi nhánh: ";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barNgay
            // 
            this.barNgay.Caption = "22/11/2017";
            this.barNgay.Id = 3;
            this.barNgay.Name = "barNgay";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barTenCN);
            this.ribbonStatusBar.ItemLinks.Add(this.barNgay);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 676);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1240, 21);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(664, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đơn hàng chờ duyệt?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Khách đưa:";
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Location = new System.Drawing.Point(631, 590);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(75, 23);
            this.btn_HoaDon.TabIndex = 21;
            this.btn_HoaDon.Text = "Xuất hóa đơn";
            // 
            // lbMHD
            // 
            this.lbMHD.AutoSize = true;
            this.lbMHD.Location = new System.Drawing.Point(112, 545);
            this.lbMHD.Name = "lbMHD";
            this.lbMHD.Size = new System.Drawing.Size(25, 13);
            this.lbMHD.TabIndex = 25;
            this.lbMHD.Text = "___";
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Location = new System.Drawing.Point(115, 571);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(26, 13);
            this.lbMNV.TabIndex = 26;
            this.lbMNV.Text = "NV1";
            // 
            // lbMKH
            // 
            this.lbMKH.AutoSize = true;
            this.lbMKH.Location = new System.Drawing.Point(111, 600);
            this.lbMKH.Name = "lbMKH";
            this.lbMKH.Size = new System.Drawing.Size(26, 13);
            this.lbMKH.TabIndex = 27;
            this.lbMKH.Text = "KH1";
            // 
            // btnCPPS
            // 
            this.btnCPPS.Location = new System.Drawing.Point(1034, 590);
            this.btnCPPS.Name = "btnCPPS";
            this.btnCPPS.Size = new System.Drawing.Size(90, 23);
            this.btnCPPS.TabIndex = 33;
            this.btnCPPS.Text = "Chi phí phát sinh";
            // 
            // pnUC
            // 
            this.pnUC.AutoScroll = true;
            this.pnUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnUC.Location = new System.Drawing.Point(482, 104);
            this.pnUC.Name = "pnUC";
            this.pnUC.Size = new System.Drawing.Size(671, 438);
            this.pnUC.TabIndex = 36;
            this.pnUC.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(814, 47);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(75, 23);
            this.btnVisible.TabIndex = 37;
            this.btnVisible.Text = "Bàn";
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnHD
            // 
            this.pnHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHD.Location = new System.Drawing.Point(12, 104);
            this.pnHD.Name = "pnHD";
            this.pnHD.Size = new System.Drawing.Size(425, 374);
            this.pnHD.TabIndex = 40;
            this.pnHD.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHD_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(310, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "120000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "x  120000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhân viên 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = " Giờ vào:   10:00";
            // 
            // btn_TaoHD
            // 
            this.btn_TaoHD.Location = new System.Drawing.Point(12, 75);
            this.btn_TaoHD.Name = "btn_TaoHD";
            this.btn_TaoHD.Size = new System.Drawing.Size(96, 23);
            this.btn_TaoHD.TabIndex = 43;
            this.btn_TaoHD.Text = "Tạo hóa đơn mới";
            this.btn_TaoHD.UseVisualStyleBackColor = true;
            this.btn_TaoHD.Click += new System.EventHandler(this.btn_TaoHD_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(459, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rdMangVe
            // 
            this.rdMangVe.AutoSize = true;
            this.rdMangVe.Location = new System.Drawing.Point(28, 499);
            this.rdMangVe.Name = "rdMangVe";
            this.rdMangVe.Size = new System.Drawing.Size(66, 17);
            this.rdMangVe.TabIndex = 0;
            this.rdMangVe.TabStop = true;
            this.rdMangVe.Text = "Mang về";
            this.rdMangVe.UseVisualStyleBackColor = true;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(377, 545);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(25, 13);
            this.lbTongTien.TabIndex = 47;
            this.lbTongTien.Text = "___";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(305, 600);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Trả lại:";
            // 
            // lbTraLai
            // 
            this.lbTraLai.AutoSize = true;
            this.lbTraLai.Location = new System.Drawing.Point(377, 600);
            this.lbTraLai.Name = "lbTraLai";
            this.lbTraLai.Size = new System.Drawing.Size(25, 13);
            this.lbTraLai.TabIndex = 50;
            this.lbTraLai.Text = "___";
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Location = new System.Drawing.Point(380, 568);
            this.txtKhachDua.MenuManager = this.ribbon;
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(100, 20);
            this.txtKhachDua.TabIndex = 51;
            this.txtKhachDua.EditValueChanged += new System.EventHandler(this.txtKhachDua_EditValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Frm_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 697);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtKhachDua);
            this.Controls.Add(this.lbTraLai);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rdMangVe);
            this.Controls.Add(this.btn_TaoHD);
            this.Controls.Add(this.pnHD);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.pnUC);
            this.Controls.Add(this.btnCPPS);
            this.Controls.Add(this.lbMKH);
            this.Controls.Add(this.lbMNV);
            this.Controls.Add(this.lbMHD);
            this.Controls.Add(this.btn_HoaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_ChiNhanh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.Frm_ChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachDua.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
       
        private System.Windows.Forms.LinkLabel linkLabel1;
       
 //       private System.Windows.Forms.RibbonLabel ribbonLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.RibbonButton ribbonButton1;
        private DevExpress.XtraEditors.SimpleButton btn_HoaDon;
        private System.Windows.Forms.Label lbMHD;
        private System.Windows.Forms.Label lbMNV;
        private System.Windows.Forms.Label lbMKH;
        private DevExpress.XtraEditors.SimpleButton btnCPPS;
        private System.Windows.Forms.Panel pnUC;
        private DevExpress.XtraEditors.SimpleButton btnVisible;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnHD;
        
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_TaoHD;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rdMangVe;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbTraLai;
        private DevExpress.XtraEditors.TextEdit txtKhachDua;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraBars.BarStaticItem barTenCN;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barNgay;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}