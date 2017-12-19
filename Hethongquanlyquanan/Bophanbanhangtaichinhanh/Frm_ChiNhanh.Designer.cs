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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_HoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbo_chuyenPhat = new System.Windows.Forms.GroupBox();
            this.rdochuyenphatNhanh = new System.Windows.Forms.RadioButton();
            this.rdo_nhanochiNhanh = new System.Windows.Forms.RadioButton();
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.gbo_chuyenPhat.SuspendLayout();
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
            this.ribbon.Size = new System.Drawing.Size(1232, 27);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 666);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1232, 31);
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
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Thanh toán:";
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Location = new System.Drawing.Point(308, 600);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(75, 23);
            this.btn_HoaDon.TabIndex = 21;
            this.btn_HoaDon.Text = "Xuất hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "label8";
            // 
            // gbo_chuyenPhat
            // 
            this.gbo_chuyenPhat.Controls.Add(this.rdochuyenphatNhanh);
            this.gbo_chuyenPhat.Controls.Add(this.rdo_nhanochiNhanh);
            this.gbo_chuyenPhat.Location = new System.Drawing.Point(12, 484);
            this.gbo_chuyenPhat.Name = "gbo_chuyenPhat";
            this.gbo_chuyenPhat.Size = new System.Drawing.Size(442, 58);
            this.gbo_chuyenPhat.TabIndex = 30;
            this.gbo_chuyenPhat.TabStop = false;
            this.gbo_chuyenPhat.Text = "Chuyển phát";
            // 
            // rdochuyenphatNhanh
            // 
            this.rdochuyenphatNhanh.AutoSize = true;
            this.rdochuyenphatNhanh.Location = new System.Drawing.Point(250, 19);
            this.rdochuyenphatNhanh.Name = "rdochuyenphatNhanh";
            this.rdochuyenphatNhanh.Size = new System.Drawing.Size(182, 17);
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
            this.rdo_nhanochiNhanh.Size = new System.Drawing.Size(137, 17);
            this.rdo_nhanochiNhanh.TabIndex = 0;
            this.rdo_nhanochiNhanh.TabStop = true;
            this.rdo_nhanochiNhanh.Text = "Nhận tại chi nhánh số 1";
            this.rdo_nhanochiNhanh.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // Frm_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 697);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pnHD);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.pnUC);
            this.Controls.Add(this.btnCPPS);
            this.Controls.Add(this.gbo_chuyenPhat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.gbo_chuyenPhat.ResumeLayout(false);
            this.gbo_chuyenPhat.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbo_chuyenPhat;
        private System.Windows.Forms.RadioButton rdochuyenphatNhanh;
        private System.Windows.Forms.RadioButton rdo_nhanochiNhanh;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}