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
            this.barMaCN = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barTime = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
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
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTraLai = new System.Windows.Forms.Label();
            this.txtKhachDua = new DevExpress.XtraEditors.TextEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnMangve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachDua.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barMaCN,
            this.barStaticItem1,
            this.barTime});
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
            this.ribbon.Size = new System.Drawing.Size(1286, 32);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barMaCN
            // 
            this.barMaCN.Caption = "CN1";
            this.barMaCN.Id = 1;
            this.barMaCN.Name = "barMaCN";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Mã chi nhánh: ";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barTime
            // 
            this.barTime.Caption = "22/11/2017";
            this.barTime.Id = 3;
            this.barTime.Name = "barTime";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barMaCN);
            this.ribbonStatusBar.ItemLinks.Add(this.barTime);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 676);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1286, 21);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Khách đưa:";
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Location = new System.Drawing.Point(265, 549);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(75, 23);
            this.btn_HoaDon.TabIndex = 21;
            this.btn_HoaDon.Text = "Xuất hóa đơn";
            // 
            // lbMHD
            // 
            this.lbMHD.AutoSize = true;
            this.lbMHD.Location = new System.Drawing.Point(99, 452);
            this.lbMHD.Name = "lbMHD";
            this.lbMHD.Size = new System.Drawing.Size(25, 13);
            this.lbMHD.TabIndex = 25;
            this.lbMHD.Text = "___";
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Location = new System.Drawing.Point(102, 478);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(26, 13);
            this.lbMNV.TabIndex = 26;
            this.lbMNV.Text = "NV1";
            // 
            // lbMKH
            // 
            this.lbMKH.AutoSize = true;
            this.lbMKH.Location = new System.Drawing.Point(98, 507);
            this.lbMKH.Name = "lbMKH";
            this.lbMKH.Size = new System.Drawing.Size(26, 13);
            this.lbMKH.TabIndex = 27;
            this.lbMKH.Text = "KH1";
            // 
            // btnCPPS
            // 
            this.btnCPPS.Location = new System.Drawing.Point(346, 549);
            this.btnCPPS.Name = "btnCPPS";
            this.btnCPPS.Size = new System.Drawing.Size(90, 23);
            this.btnCPPS.TabIndex = 33;
            this.btnCPPS.Text = "Chi phí phát sinh";
            // 
            // pnUC
            // 
            this.pnUC.AutoScroll = true;
            this.pnUC.Location = new System.Drawing.Point(482, 65);
            this.pnUC.Name = "pnUC";
            this.pnUC.Size = new System.Drawing.Size(804, 438);
            this.pnUC.TabIndex = 36;
            this.pnUC.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(1067, 36);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(75, 23);
            this.btnVisible.TabIndex = 37;
            this.btnVisible.Text = "Thực đơn";
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
            this.pnHD.Location = new System.Drawing.Point(12, 65);
            this.pnHD.Name = "pnHD";
            this.pnHD.Size = new System.Drawing.Size(464, 374);
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
            this.btn_TaoHD.Location = new System.Drawing.Point(12, 36);
            this.btn_TaoHD.Name = "btn_TaoHD";
            this.btn_TaoHD.Size = new System.Drawing.Size(96, 23);
            this.btn_TaoHD.TabIndex = 43;
            this.btn_TaoHD.Text = "Tạo hóa đơn mới";
            this.btn_TaoHD.UseVisualStyleBackColor = true;
            this.btn_TaoHD.Click += new System.EventHandler(this.btn_TaoHD_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(299, 452);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(25, 13);
            this.lbTongTien.TabIndex = 47;
            this.lbTongTien.Text = "___";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(227, 507);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Trả lại:";
            // 
            // lbTraLai
            // 
            this.lbTraLai.AutoSize = true;
            this.lbTraLai.Location = new System.Drawing.Point(299, 507);
            this.lbTraLai.Name = "lbTraLai";
            this.lbTraLai.Size = new System.Drawing.Size(25, 13);
            this.lbTraLai.TabIndex = 50;
            this.lbTraLai.Text = "___";
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Location = new System.Drawing.Point(302, 475);
            this.txtKhachDua.MenuManager = this.ribbon;
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(100, 20);
            this.txtKhachDua.TabIndex = 51;
            this.txtKhachDua.EditValueChanged += new System.EventHandler(this.txtKhachDua_EditValueChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 602);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMangve
            // 
            this.btnMangve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangve.Location = new System.Drawing.Point(401, 36);
            this.btnMangve.Name = "btnMangve";
            this.btnMangve.Size = new System.Drawing.Size(75, 23);
            this.btnMangve.TabIndex = 58;
            this.btnMangve.Text = "Mang về";
            this.btnMangve.UseVisualStyleBackColor = true;
            this.btnMangve.Click += new System.EventHandler(this.btnMangve_Click);
            // 
            // Frm_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 697);
            this.Controls.Add(this.btnMangve);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtKhachDua);
            this.Controls.Add(this.lbTraLai);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbTongTien);
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
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbTraLai;
        private DevExpress.XtraEditors.TextEdit txtKhachDua;
        private DevExpress.XtraBars.BarStaticItem barMaCN;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barTime;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Timer timerClock;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Button btnMangve;
    }
}