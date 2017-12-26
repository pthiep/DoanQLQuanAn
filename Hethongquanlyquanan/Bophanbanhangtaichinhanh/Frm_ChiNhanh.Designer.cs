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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMaCN = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barTime = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMHD = new System.Windows.Forms.Label();
            this.lbMNV = new System.Windows.Forms.Label();
            this.lbMKH = new System.Windows.Forms.Label();
            this.pnUC = new System.Windows.Forms.Panel();
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.timerClock = new System.Windows.Forms.Timer();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnMangve = new System.Windows.Forms.Button();
            this.btnBaoBep = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Chiphiphatsinh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DuyetTD = new DevExpress.XtraEditors.SimpleButton();
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
            this.barTime,
            this.barButtonItem1,
            this.barStaticItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1317, 32);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barMaCN
            // 
            this.barMaCN.Caption = "CN2";
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
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Quản lý chi phí phát sinh";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Thời gian:";
            this.barStaticItem2.Id = 5;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barMaCN);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.ItemLinks.Add(this.barTime);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 651);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1317, 21);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(227, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(227, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Khách đưa:";
            // 
            // lbMHD
            // 
            this.lbMHD.AutoSize = true;
            this.lbMHD.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbMHD.Location = new System.Drawing.Point(139, 491);
            this.lbMHD.Name = "lbMHD";
            this.lbMHD.Size = new System.Drawing.Size(32, 18);
            this.lbMHD.TabIndex = 25;
            this.lbMHD.Text = "___";
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbMNV.Location = new System.Drawing.Point(139, 522);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(35, 18);
            this.lbMNV.TabIndex = 26;
            this.lbMNV.Text = "NV1";
            // 
            // lbMKH
            // 
            this.lbMKH.AutoSize = true;
            this.lbMKH.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbMKH.Location = new System.Drawing.Point(141, 558);
            this.lbMKH.Name = "lbMKH";
            this.lbMKH.Size = new System.Drawing.Size(35, 18);
            this.lbMKH.TabIndex = 27;
            this.lbMKH.Text = "KH1";
            // 
            // pnUC
            // 
            this.pnUC.AutoScroll = true;
            this.pnUC.Location = new System.Drawing.Point(482, 65);
            this.pnUC.Name = "pnUC";
            this.pnUC.Size = new System.Drawing.Size(828, 553);
            this.pnUC.TabIndex = 36;
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
            this.pnHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnHD.Location = new System.Drawing.Point(12, 65);
            this.pnHD.Name = "pnHD";
            this.pnHD.Size = new System.Drawing.Size(464, 413);
            this.pnHD.TabIndex = 40;
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
            this.btn_TaoHD.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_TaoHD.Location = new System.Drawing.Point(12, 36);
            this.btn_TaoHD.Name = "btn_TaoHD";
            this.btn_TaoHD.Size = new System.Drawing.Size(220, 27);
            this.btn_TaoHD.TabIndex = 43;
            this.btn_TaoHD.Text = "Tạo hóa đơn mới";
            this.btn_TaoHD.UseVisualStyleBackColor = true;
            this.btn_TaoHD.Click += new System.EventHandler(this.btn_TaoHD_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbTongTien.Location = new System.Drawing.Point(330, 491);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(32, 18);
            this.lbTongTien.TabIndex = 47;
            this.lbTongTien.Text = "___";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(227, 558);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 18);
            this.label15.TabIndex = 49;
            this.label15.Text = "Trả lại:";
            // 
            // lbTraLai
            // 
            this.lbTraLai.AutoSize = true;
            this.lbTraLai.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbTraLai.Location = new System.Drawing.Point(330, 562);
            this.lbTraLai.Name = "lbTraLai";
            this.lbTraLai.Size = new System.Drawing.Size(32, 18);
            this.lbTraLai.TabIndex = 50;
            this.lbTraLai.Text = "___";
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Enabled = false;
            this.txtKhachDua.Location = new System.Drawing.Point(333, 519);
            this.txtKhachDua.MenuManager = this.ribbon;
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtKhachDua.Properties.Appearance.Options.UseFont = true;
            this.txtKhachDua.Size = new System.Drawing.Size(124, 24);
            this.txtKhachDua.TabIndex = 51;
            this.txtKhachDua.EditValueChanged += new System.EventHandler(this.txtKhachDua_EditValueChanged);
            this.txtKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhachDua_KeyPress);
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
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(270, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 27);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Lưu và In Hóa đơn";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMangve
            // 
            this.btnMangve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangve.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnMangve.Location = new System.Drawing.Point(380, 36);
            this.btnMangve.Name = "btnMangve";
            this.btnMangve.Size = new System.Drawing.Size(96, 27);
            this.btnMangve.TabIndex = 58;
            this.btnMangve.Text = "Mang về";
            this.btnMangve.UseVisualStyleBackColor = true;
            this.btnMangve.Click += new System.EventHandler(this.btnMangve_Click);
            // 
            // btnBaoBep
            // 
            this.btnBaoBep.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnBaoBep.Appearance.Options.UseFont = true;
            this.btnBaoBep.Enabled = false;
            this.btnBaoBep.Location = new System.Drawing.Point(125, 601);
            this.btnBaoBep.Name = "btnBaoBep";
            this.btnBaoBep.Size = new System.Drawing.Size(117, 27);
            this.btnBaoBep.TabIndex = 61;
            this.btnBaoBep.Text = "Báo bếp";
            this.btnBaoBep.Click += new System.EventHandler(this.btnBaoBep_Click);
            // 
            // btn_Chiphiphatsinh
            // 
            this.btn_Chiphiphatsinh.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Chiphiphatsinh.Appearance.Options.UseFont = true;
            this.btn_Chiphiphatsinh.Location = new System.Drawing.Point(1094, 36);
            this.btn_Chiphiphatsinh.Name = "btn_Chiphiphatsinh";
            this.btn_Chiphiphatsinh.Size = new System.Drawing.Size(211, 27);
            this.btn_Chiphiphatsinh.TabIndex = 62;
            this.btn_Chiphiphatsinh.Text = "Quản lý chi phí phát sinh";
            this.btn_Chiphiphatsinh.Click += new System.EventHandler(this.btn_Chiphiphatsinh_Click);
            // 
            // btn_DuyetTD
            // 
            this.btn_DuyetTD.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_DuyetTD.Appearance.Options.UseFont = true;
            this.btn_DuyetTD.Location = new System.Drawing.Point(820, 36);
            this.btn_DuyetTD.Name = "btn_DuyetTD";
            this.btn_DuyetTD.Size = new System.Drawing.Size(268, 27);
            this.btn_DuyetTD.TabIndex = 65;
            this.btn_DuyetTD.Text = "Duyệt đơn hàng từ tổng đài";
            this.btn_DuyetTD.Click += new System.EventHandler(this.btn_DuyetTD_Click);
            // 
            // Frm_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 672);
            this.Controls.Add(this.btn_DuyetTD);
            this.Controls.Add(this.btn_Chiphiphatsinh);
            this.Controls.Add(this.btnBaoBep);
            this.Controls.Add(this.btnMangve);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtKhachDua);
            this.Controls.Add(this.lbTraLai);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.btn_TaoHD);
            this.Controls.Add(this.pnHD);
            this.Controls.Add(this.pnUC);
            this.Controls.Add(this.lbMKH);
            this.Controls.Add(this.lbMNV);
            this.Controls.Add(this.lbMHD);
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
        private System.Windows.Forms.Label lbMHD;
        private System.Windows.Forms.Label lbMNV;
        private System.Windows.Forms.Label lbMKH;
        private System.Windows.Forms.Panel pnUC;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.SimpleButton btnBaoBep;
        private DevExpress.XtraEditors.SimpleButton btn_Chiphiphatsinh;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraEditors.SimpleButton btn_DuyetTD;
    }
}