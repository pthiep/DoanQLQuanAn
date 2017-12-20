namespace Boquanquanly
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tb_Tencn = new DevExpress.XtraEditors.TextEdit();
            this.tb_Macn = new DevExpress.XtraEditors.TextEdit();
            this.tb_Diachi = new DevExpress.XtraEditors.TextEdit();
            this.tb_Sdt = new DevExpress.XtraEditors.TextEdit();
            this.cb_tinhthanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tb_Slban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Menu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Trove = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tencn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Macn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Sdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_tinhthanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Slban.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(525, 32);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(350, 149);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Tỉnh thành";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 194);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(350, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Mã chi nhánh";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Tên chi nhánh";
            // 
            // tb_Tencn
            // 
            this.tb_Tencn.Location = new System.Drawing.Point(42, 123);
            this.tb_Tencn.MenuManager = this.ribbon;
            this.tb_Tencn.Name = "tb_Tencn";
            this.tb_Tencn.Size = new System.Drawing.Size(287, 20);
            this.tb_Tencn.TabIndex = 16;
            // 
            // tb_Macn
            // 
            this.tb_Macn.Enabled = false;
            this.tb_Macn.Location = new System.Drawing.Point(386, 123);
            this.tb_Macn.MenuManager = this.ribbon;
            this.tb_Macn.Name = "tb_Macn";
            this.tb_Macn.Size = new System.Drawing.Size(117, 20);
            this.tb_Macn.TabIndex = 17;
            // 
            // tb_Diachi
            // 
            this.tb_Diachi.Location = new System.Drawing.Point(42, 168);
            this.tb_Diachi.MenuManager = this.ribbon;
            this.tb_Diachi.Name = "tb_Diachi";
            this.tb_Diachi.Size = new System.Drawing.Size(287, 20);
            this.tb_Diachi.TabIndex = 18;
            // 
            // tb_Sdt
            // 
            this.tb_Sdt.Location = new System.Drawing.Point(42, 213);
            this.tb_Sdt.MenuManager = this.ribbon;
            this.tb_Sdt.Name = "tb_Sdt";
            this.tb_Sdt.Size = new System.Drawing.Size(287, 20);
            this.tb_Sdt.TabIndex = 19;
            // 
            // cb_tinhthanh
            // 
            this.cb_tinhthanh.Location = new System.Drawing.Point(386, 171);
            this.cb_tinhthanh.MenuManager = this.ribbon;
            this.cb_tinhthanh.Name = "cb_tinhthanh";
            this.cb_tinhthanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_tinhthanh.Size = new System.Drawing.Size(117, 20);
            this.cb_tinhthanh.TabIndex = 20;
            // 
            // tb_Slban
            // 
            this.tb_Slban.Location = new System.Drawing.Point(42, 319);
            this.tb_Slban.MenuManager = this.ribbon;
            this.tb_Slban.Name = "tb_Slban";
            this.tb_Slban.Size = new System.Drawing.Size(163, 20);
            this.tb_Slban.TabIndex = 22;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(24, 300);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Số lượng bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Thông tin cơ bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(82, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Danh mục và bàn";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(273, 317);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(163, 23);
            this.btn_Menu.TabIndex = 26;
            this.btn_Menu.Text = "Quản lý Menu";
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(250, 300);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 13);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Menu";
            // 
            // bt_Luu
            // 
            this.bt_Luu.Location = new System.Drawing.Point(335, 382);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 23);
            this.bt_Luu.TabIndex = 27;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Trove
            // 
            this.bt_Trove.Location = new System.Drawing.Point(416, 382);
            this.bt_Trove.Name = "bt_Trove";
            this.bt_Trove.Size = new System.Drawing.Size(75, 23);
            this.bt_Trove.TabIndex = 28;
            this.bt_Trove.Text = "Trở về";
            this.bt_Trove.Click += new System.EventHandler(this.bt_Trove_Click);
            // 
            // Frm_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 427);
            this.Controls.Add(this.bt_Trove);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Slban);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cb_tinhthanh);
            this.Controls.Add(this.tb_Sdt);
            this.Controls.Add(this.tb_Diachi);
            this.Controls.Add(this.tb_Macn);
            this.Controls.Add(this.tb_Tencn);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_ChiNhanh";
            this.Ribbon = this.ribbon;
            this.Text = "Frm_ChiNhanh";
            this.Load += new System.EventHandler(this.Frm_ChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tencn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Macn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Sdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_tinhthanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Slban.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tb_Tencn;
        private DevExpress.XtraEditors.TextEdit tb_Macn;
        private DevExpress.XtraEditors.TextEdit tb_Diachi;
        private DevExpress.XtraEditors.TextEdit tb_Sdt;
        private DevExpress.XtraEditors.ComboBoxEdit cb_tinhthanh;
        private DevExpress.XtraEditors.TextEdit tb_Slban;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_Menu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_Trove;
    }
}