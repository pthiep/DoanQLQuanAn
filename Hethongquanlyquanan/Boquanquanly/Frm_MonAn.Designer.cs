namespace Boquanquanly
{
    partial class Frm_MonAn
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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Luuvatt = new System.Windows.Forms.Button();
            this.btn_Trove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Mamonan = new DevExpress.XtraEditors.TextEdit();
            this.pb_Hinhanh = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Tenmonan = new DevExpress.XtraEditors.TextEdit();
            this.tb_Giaban = new DevExpress.XtraEditors.TextEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btn_Uphinh = new DevExpress.XtraEditors.ButtonEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_DM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bt_QLDM = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Mamonan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tenmonan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Giaban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Uphinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_DM.Properties)).BeginInit();
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
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(659, 32);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 504);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(659, 21);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin cơ bản";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(326, 459);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Luuvatt
            // 
            this.btn_Luuvatt.Location = new System.Drawing.Point(407, 459);
            this.btn_Luuvatt.Name = "btn_Luuvatt";
            this.btn_Luuvatt.Size = new System.Drawing.Size(108, 23);
            this.btn_Luuvatt.TabIndex = 5;
            this.btn_Luuvatt.Text = "Lưu và tiếp tục";
            this.btn_Luuvatt.UseVisualStyleBackColor = true;
            this.btn_Luuvatt.Click += new System.EventHandler(this.btn_Luuvatt_Click);
            // 
            // btn_Trove
            // 
            this.btn_Trove.Location = new System.Drawing.Point(521, 459);
            this.btn_Trove.Name = "btn_Trove";
            this.btn_Trove.Size = new System.Drawing.Size(75, 23);
            this.btn_Trove.TabIndex = 6;
            this.btn_Trove.Text = "Trở về";
            this.btn_Trove.UseVisualStyleBackColor = true;
            this.btn_Trove.Click += new System.EventHandler(this.btn_Trove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(56, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên món ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(56, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(366, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hình ảnh";
            // 
            // tb_Mamonan
            // 
            this.tb_Mamonan.EditValue = "Hệ thống tự tạo mã";
            this.tb_Mamonan.Enabled = false;
            this.tb_Mamonan.Location = new System.Drawing.Point(59, 179);
            this.tb_Mamonan.MenuManager = this.ribbon;
            this.tb_Mamonan.Name = "tb_Mamonan";
            this.tb_Mamonan.Size = new System.Drawing.Size(272, 20);
            this.tb_Mamonan.TabIndex = 12;
            // 
            // pb_Hinhanh
            // 
            this.pb_Hinhanh.Location = new System.Drawing.Point(407, 179);
            this.pb_Hinhanh.Name = "pb_Hinhanh";
            this.pb_Hinhanh.Size = new System.Drawing.Size(150, 120);
            this.pb_Hinhanh.TabIndex = 13;
            this.pb_Hinhanh.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(56, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giá bán";
            // 
            // tb_Tenmonan
            // 
            this.tb_Tenmonan.Location = new System.Drawing.Point(59, 126);
            this.tb_Tenmonan.MenuManager = this.ribbon;
            this.tb_Tenmonan.Name = "tb_Tenmonan";
            this.tb_Tenmonan.Size = new System.Drawing.Size(554, 20);
            this.tb_Tenmonan.TabIndex = 15;
            // 
            // tb_Giaban
            // 
            this.tb_Giaban.Location = new System.Drawing.Point(59, 231);
            this.tb_Giaban.MenuManager = this.ribbon;
            this.tb_Giaban.Name = "tb_Giaban";
            this.tb_Giaban.Properties.NullValuePrompt = "Hệ thống tự tạo mã nếu để trống";
            this.tb_Giaban.Size = new System.Drawing.Size(272, 20);
            this.tb_Giaban.TabIndex = 16;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // btn_Uphinh
            // 
            this.btn_Uphinh.Location = new System.Drawing.Point(407, 305);
            this.btn_Uphinh.MenuManager = this.ribbon;
            this.btn_Uphinh.Name = "btn_Uphinh";
            this.btn_Uphinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_Uphinh.Size = new System.Drawing.Size(150, 20);
            this.btn_Uphinh.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(56, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Danh mục";
            // 
            // cb_DM
            // 
            this.cb_DM.Location = new System.Drawing.Point(59, 286);
            this.cb_DM.MenuManager = this.ribbon;
            this.cb_DM.Name = "cb_DM";
            this.cb_DM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_DM.Size = new System.Drawing.Size(231, 20);
            this.cb_DM.TabIndex = 21;
            // 
            // bt_QLDM
            // 
            this.bt_QLDM.Location = new System.Drawing.Point(296, 286);
            this.bt_QLDM.Name = "bt_QLDM";
            this.bt_QLDM.Size = new System.Drawing.Size(35, 20);
            this.bt_QLDM.TabIndex = 22;
            this.bt_QLDM.Text = "...";
            this.bt_QLDM.ToolTip = "Quản lý danh mục";
            this.bt_QLDM.Click += new System.EventHandler(this.bt_QLDM_Click);
            // 
            // Frm_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 525);
            this.Controls.Add(this.bt_QLDM);
            this.Controls.Add(this.cb_DM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Uphinh);
            this.Controls.Add(this.tb_Giaban);
            this.Controls.Add(this.tb_Tenmonan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pb_Hinhanh);
            this.Controls.Add(this.tb_Mamonan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Trove);
            this.Controls.Add(this.btn_Luuvatt);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.MaximizeBox = false;
            this.Name = "Frm_MonAn";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Frm_MonAn";
            this.Load += new System.EventHandler(this.Frm_MonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Mamonan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tenmonan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Giaban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Uphinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_DM.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Luuvatt;
        private System.Windows.Forms.Button btn_Trove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit tb_Mamonan;
        private System.Windows.Forms.PictureBox pb_Hinhanh;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit tb_Tenmonan;
        private DevExpress.XtraEditors.TextEdit tb_Giaban;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.ButtonEdit btn_Uphinh;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit cb_DM;
        private DevExpress.XtraEditors.SimpleButton bt_QLDM;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}