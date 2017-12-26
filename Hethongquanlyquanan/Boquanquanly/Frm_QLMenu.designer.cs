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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lb_Tencn = new System.Windows.Forms.Label();
            this.lb_Macn = new System.Windows.Forms.Label();
            this.btn_Themmonan = new DevExpress.XtraEditors.SimpleButton();
            this.cb_DM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_DM.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMA.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(644, 32);
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
            this.labelControl1.Location = new System.Drawing.Point(12, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Tên chi nhánh";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Mã chi nhánh";
            // 
            // pnMenu
            // 
            this.pnMenu.AutoScroll = true;
            this.pnMenu.Location = new System.Drawing.Point(12, 141);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(620, 396);
            this.pnMenu.TabIndex = 12;
            // 
            // lb_Tencn
            // 
            this.lb_Tencn.AutoSize = true;
            this.lb_Tencn.Location = new System.Drawing.Point(96, 79);
            this.lb_Tencn.Name = "lb_Tencn";
            this.lb_Tencn.Size = new System.Drawing.Size(25, 13);
            this.lb_Tencn.TabIndex = 13;
            this.lb_Tencn.Text = "___";
            // 
            // lb_Macn
            // 
            this.lb_Macn.AutoSize = true;
            this.lb_Macn.Location = new System.Drawing.Point(96, 106);
            this.lb_Macn.Name = "lb_Macn";
            this.lb_Macn.Size = new System.Drawing.Size(25, 13);
            this.lb_Macn.TabIndex = 14;
            this.lb_Macn.Text = "___";
            // 
            // btn_Themmonan
            // 
            this.btn_Themmonan.Location = new System.Drawing.Point(262, 29);
            this.btn_Themmonan.Name = "btn_Themmonan";
            this.btn_Themmonan.Size = new System.Drawing.Size(43, 40);
            this.btn_Themmonan.TabIndex = 16;
            this.btn_Themmonan.Text = "Thêm";
            this.btn_Themmonan.Click += new System.EventHandler(this.btn_Themmonan_Click);
            // 
            // cb_DM
            // 
            this.cb_DM.Location = new System.Drawing.Point(106, 26);
            this.cb_DM.MenuManager = this.ribbon;
            this.cb_DM.Name = "cb_DM";
            this.cb_DM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_DM.Size = new System.Drawing.Size(126, 20);
            this.cb_DM.TabIndex = 18;
            this.cb_DM.SelectedIndexChanged += new System.EventHandler(this.cb_DM_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chọn danh mục :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMA);
            this.groupBox1.Controls.Add(this.btn_Themmonan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_DM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(314, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 85);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm món ăn";
            // 
            // cbMA
            // 
            this.cbMA.Location = new System.Drawing.Point(106, 53);
            this.cbMA.MenuManager = this.ribbon;
            this.cbMA.Name = "cbMA";
            this.cbMA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMA.Size = new System.Drawing.Size(126, 20);
            this.cbMA.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chọn món ăn :";
            // 
            // Frm_QLMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Macn);
            this.Controls.Add(this.lb_Tencn);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_QLMenu";
            this.Ribbon = this.ribbon;
            this.Text = "Frm_QLBan";
            this.Load += new System.EventHandler(this.Frm_QLBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_DM.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMA.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label lb_Tencn;
        private System.Windows.Forms.Label lb_Macn;
        private DevExpress.XtraEditors.SimpleButton btn_Themmonan;
        private DevExpress.XtraEditors.ComboBoxEdit cb_DM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit cbMA;
        private System.Windows.Forms.Label label2;
    }
}