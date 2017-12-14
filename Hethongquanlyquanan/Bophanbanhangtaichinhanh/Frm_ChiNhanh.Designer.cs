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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChiNhanh));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.btn_ThemHD = new MetroFramework.Controls.MetroButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SoDonHang = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_HoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbo_chuyenPhat = new System.Windows.Forms.GroupBox();
            this.rdochuyenphatNhanh = new System.Windows.Forms.RadioButton();
            this.rdo_nhanochiNhanh = new System.Windows.Forms.RadioButton();
            this.btnCPPS = new DevExpress.XtraEditors.SimpleButton();
            this.pnThucDon = new System.Windows.Forms.Panel();
            this.btnVisible = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1117, 27);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 666);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1117, 31);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã hóa đơn";
            this.gridColumn1.FieldName = "mahoadon";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên món ăn";
            this.gridColumn2.FieldName = "tenmonan";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn giá";
            this.gridColumn3.FieldName = "dongia";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Danh mục";
            this.gridColumn4.FieldName = "danhmuc";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Xóa";
            this.gridColumn5.ColumnEdit = this.btnXoa;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Appearance.Image")));
            this.btnXoa.Appearance.Options.UseImage = true;
            this.btnXoa.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            serializableAppearanceObject5.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject5.Image")));
            serializableAppearanceObject5.Options.UseImage = true;
            serializableAppearanceObject6.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject6.Image")));
            serializableAppearanceObject6.Options.UseImage = true;
            serializableAppearanceObject7.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject7.Image")));
            serializableAppearanceObject7.Options.UseImage = true;
            serializableAppearanceObject8.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject8.Image")));
            serializableAppearanceObject8.Options.UseImage = true;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 95);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa});
            this.gridControl1.Size = new System.Drawing.Size(411, 359);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.Location = new System.Drawing.Point(28, 52);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(103, 23);
            this.btn_ThemHD.TabIndex = 5;
            this.btn_ThemHD.Text = "Thêm hóa đơn";
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
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
            // SoDonHang
            // 
            this.SoDonHang.AutoSize = true;
            this.SoDonHang.Location = new System.Drawing.Point(578, 52);
            this.SoDonHang.Name = "SoDonHang";
            this.SoDonHang.Size = new System.Drawing.Size(81, 19);
            this.SoDonHang.TabIndex = 8;
            this.SoDonHang.Text = "metroLabel1";
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
            this.label4.Location = new System.Drawing.Point(520, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Thanh toán:";
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Location = new System.Drawing.Point(667, 595);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(75, 23);
            this.btn_HoaDon.TabIndex = 21;
            this.btn_HoaDon.Text = "Xuất hóa đơn";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(75, 23);
            this.xtraScrollableControl1.TabIndex = 24;
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
            this.gbo_chuyenPhat.Location = new System.Drawing.Point(12, 470);
            this.gbo_chuyenPhat.Name = "gbo_chuyenPhat";
            this.gbo_chuyenPhat.Size = new System.Drawing.Size(762, 58);
            this.gbo_chuyenPhat.TabIndex = 30;
            this.gbo_chuyenPhat.TabStop = false;
            this.gbo_chuyenPhat.Text = "Chuyển phát";
            // 
            // rdochuyenphatNhanh
            // 
            this.rdochuyenphatNhanh.AutoSize = true;
            this.rdochuyenphatNhanh.Location = new System.Drawing.Point(320, 19);
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
            this.btnCPPS.Location = new System.Drawing.Point(395, 595);
            this.btnCPPS.Name = "btnCPPS";
            this.btnCPPS.Size = new System.Drawing.Size(90, 23);
            this.btnCPPS.TabIndex = 33;
            this.btnCPPS.Text = "Chi phí phát sinh";
            // 
            // pnThucDon
            // 
            this.pnThucDon.AutoScroll = true;
            this.pnThucDon.Location = new System.Drawing.Point(482, 104);
            this.pnThucDon.Name = "pnThucDon";
            this.pnThucDon.Size = new System.Drawing.Size(505, 369);
            this.pnThucDon.TabIndex = 36;
            this.pnThucDon.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(839, 51);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(265, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 40;
            // 
            // Frm_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.pnThucDon);
            this.Controls.Add(this.btnCPPS);
            this.Controls.Add(this.gbo_chuyenPhat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.btn_HoaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoDonHang);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_ThemHD);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_ChiNhanh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.Frm_ChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.gbo_chuyenPhat.ResumeLayout(false);
            this.gbo_chuyenPhat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private MetroFramework.Controls.MetroButton btn_ThemHD;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroLabel SoDonHang;
 //       private System.Windows.Forms.RibbonLabel ribbonLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.RibbonButton ribbonButton1;
        private DevExpress.XtraEditors.SimpleButton btn_HoaDon;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private System.Windows.Forms.GroupBox gbo_chuyenPhat;
        private System.Windows.Forms.RadioButton rdochuyenphatNhanh;
        private System.Windows.Forms.RadioButton rdo_nhanochiNhanh;
        private DevExpress.XtraEditors.SimpleButton btnCPPS;
        private System.Windows.Forms.Panel pnThucDon;
        private DevExpress.XtraEditors.SimpleButton btnVisible;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}