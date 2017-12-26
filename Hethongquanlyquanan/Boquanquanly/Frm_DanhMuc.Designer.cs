namespace Boquanquanly
{
    partial class Frm_DanhMuc
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
            this.panel_DSDM = new System.Windows.Forms.Panel();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.tb_Tendanhmuc = new DevExpress.XtraEditors.TextEdit();
            this.tb_Madanhmuc = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TimKiem = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tendanhmuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Madanhmuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TimKiem.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(630, 32);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // panel_DSDM
            // 
            this.panel_DSDM.Location = new System.Drawing.Point(6, 20);
            this.panel_DSDM.Name = "panel_DSDM";
            this.panel_DSDM.Size = new System.Drawing.Size(587, 357);
            this.panel_DSDM.TabIndex = 2;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_DSDM);
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 383);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách danh mục";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.tb_Tendanhmuc);
            this.groupBox2.Controls.Add(this.tb_Madanhmuc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm danh mục";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(351, 81);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(175, 23);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tb_Tendanhmuc
            // 
            this.tb_Tendanhmuc.Location = new System.Drawing.Point(277, 44);
            this.tb_Tendanhmuc.MenuManager = this.ribbon;
            this.tb_Tendanhmuc.Name = "tb_Tendanhmuc";
            this.tb_Tendanhmuc.Size = new System.Drawing.Size(279, 20);
            this.tb_Tendanhmuc.TabIndex = 19;
            // 
            // tb_Madanhmuc
            // 
            this.tb_Madanhmuc.EditValue = "";
            this.tb_Madanhmuc.Enabled = false;
            this.tb_Madanhmuc.Location = new System.Drawing.Point(36, 44);
            this.tb_Madanhmuc.MenuManager = this.ribbon;
            this.tb_Madanhmuc.Name = "tb_Madanhmuc";
            this.tb_Madanhmuc.Size = new System.Drawing.Size(178, 20);
            this.tb_Madanhmuc.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(33, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mã danh mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(274, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên danh mục";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.EditValue = "Tìm kiếm";
            this.tb_TimKiem.Location = new System.Drawing.Point(12, 167);
            this.tb_TimKiem.MenuManager = this.ribbon;
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(602, 20);
            this.tb_TimKiem.TabIndex = 5;
            // 
            // Frm_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 588);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbon);
            this.MaximizeBox = false;
            this.Name = "Frm_DanhMuc";
            this.Ribbon = this.ribbon;
            this.Text = "Quản lý danh mục";
            this.Load += new System.EventHandler(this.Frm_DanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tendanhmuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Madanhmuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TimKiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private System.Windows.Forms.Panel panel_DSDM;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit tb_Tendanhmuc;
        private DevExpress.XtraEditors.TextEdit tb_Madanhmuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.TextEdit tb_TimKiem;
    }
}