namespace Boquanquanly
{
    partial class frm_Dangnhap
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.textB_Tendangnhap = new System.Windows.Forms.TextBox();
            this.textB_Matkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(328, 32);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // textB_Tendangnhap
            // 
            this.textB_Tendangnhap.Location = new System.Drawing.Point(134, 80);
            this.textB_Tendangnhap.Name = "textB_Tendangnhap";
            this.textB_Tendangnhap.Size = new System.Drawing.Size(167, 21);
            this.textB_Tendangnhap.TabIndex = 1;
            // 
            // textB_Matkhau
            // 
            this.textB_Matkhau.Location = new System.Drawing.Point(134, 119);
            this.textB_Matkhau.Name = "textB_Matkhau";
            this.textB_Matkhau.Size = new System.Drawing.Size(167, 21);
            this.textB_Matkhau.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu :";
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.Location = new System.Drawing.Point(226, 152);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(75, 23);
            this.btn_Dangnhap.TabIndex = 7;
            this.btn_Dangnhap.Text = "Đăng nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = true;
            this.btn_Dangnhap.Click += new System.EventHandler(this.btn_Dangnhap_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(134, 154);
            this.checkEdit1.MenuManager = this.ribbonControl1;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Ghi nhớ";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 9;
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(226, 181);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(73, 13);
            this.hyperlinkLabelControl1.TabIndex = 10;
            this.hyperlinkLabelControl1.Text = "Quên mật khẩu";
            // 
            // frm_Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 228);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.btn_Dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textB_Matkhau);
            this.Controls.Add(this.textB_Tendangnhap);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Dangnhap";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.TextBox textB_Tendangnhap;
        private System.Windows.Forms.TextBox textB_Matkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Dangnhap;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
    }
}