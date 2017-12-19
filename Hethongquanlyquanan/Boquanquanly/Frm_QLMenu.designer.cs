namespace Boquanquanly
{
    partial class Frm_QLMenu
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnBan = new System.Windows.Forms.Panel();
            this.lb_Tencn = new System.Windows.Forms.Label();
            this.lb_Macn = new System.Windows.Forms.Label();
            this.btn_Themtang = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(640, 32);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Tên chi nhánh";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(200, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Mã chi nhánh";
            // 
            // pnBan
            // 
            this.pnBan.AutoScroll = true;
            this.pnBan.Location = new System.Drawing.Point(12, 91);
            this.pnBan.Name = "pnBan";
            this.pnBan.Size = new System.Drawing.Size(620, 446);
            this.pnBan.TabIndex = 12;
            // 
            // lb_Tencn
            // 
            this.lb_Tencn.AutoSize = true;
            this.lb_Tencn.Location = new System.Drawing.Point(96, 55);
            this.lb_Tencn.Name = "lb_Tencn";
            this.lb_Tencn.Size = new System.Drawing.Size(27, 13);
            this.lb_Tencn.TabIndex = 13;
            this.lb_Tencn.Text = "CN1";
            // 
            // lb_Macn
            // 
            this.lb_Macn.AutoSize = true;
            this.lb_Macn.Location = new System.Drawing.Point(280, 55);
            this.lb_Macn.Name = "lb_Macn";
            this.lb_Macn.Size = new System.Drawing.Size(27, 13);
            this.lb_Macn.TabIndex = 14;
            this.lb_Macn.Text = "CN1";
            // 
            // btn_Themtang
            // 
            this.btn_Themtang.Location = new System.Drawing.Point(557, 50);
            this.btn_Themtang.Name = "btn_Themtang";
            this.btn_Themtang.Size = new System.Drawing.Size(75, 23);
            this.btn_Themtang.TabIndex = 16;
            this.btn_Themtang.Text = "Thêm tầng";
            this.btn_Themtang.Click += new System.EventHandler(this.btn_Themtang_Click);
            // 
            // Frm_QLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 549);
            this.Controls.Add(this.btn_Themtang);
            this.Controls.Add(this.lb_Macn);
            this.Controls.Add(this.lb_Tencn);
            this.Controls.Add(this.pnBan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_QLBan";
            this.Ribbon = this.ribbon;
            this.Text = "Frm_QLBan";
            this.Load += new System.EventHandler(this.Frm_QLBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel pnBan;
        private System.Windows.Forms.Label lb_Tencn;
        private System.Windows.Forms.Label lb_Macn;
        private DevExpress.XtraEditors.SimpleButton btn_Themtang;
    }
}