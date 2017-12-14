namespace Bophanbanhangtaichinhanh
{
    partial class Frm_DangNhap
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
           // this.ribbonLabel1 = new System.Windows.Forms.RibbonLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenDN = new MetroFramework.Controls.MetroTextBox();
            this.txt_MK = new MetroFramework.Controls.MetroTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_DN = new MetroFramework.Controls.MetroButton();
            this.btn_Thoat = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
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
            this.ribbon.Size = new System.Drawing.Size(390, 32);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 285);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(390, 21);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(99, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(188, 99);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(135, 23);
            this.txt_TenDN.TabIndex = 3;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(188, 151);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(135, 23);
            this.txt_MK.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(127, 161);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // btn_DN
            // 
            this.btn_DN.Location = new System.Drawing.Point(117, 202);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(88, 23);
            this.btn_DN.TabIndex = 6;
            this.btn_DN.Text = "Đăng nhập";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(248, 202);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_DangNhap";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Frm_DangNhap";
            this.Load += new System.EventHandler(this.Frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
       // private System.Windows.Forms.RibbonLabel ribbonLabel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MetroFramework.Controls.MetroTextBox txt_TenDN;
        private MetroFramework.Controls.MetroTextBox txt_MK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private MetroFramework.Controls.MetroButton btn_DN;
        private MetroFramework.Controls.MetroButton btn_Thoat;
        private System.Windows.Forms.Label label1;
    }
}