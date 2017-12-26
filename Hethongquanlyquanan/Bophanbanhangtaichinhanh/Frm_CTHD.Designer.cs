namespace Bophanbanhangtaichinhanh
{
    partial class Frm_CTHD
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
            this.pnCTHD = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.lb_Tongtien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Baobep = new System.Windows.Forms.Button();
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
            this.ribbon.Size = new System.Drawing.Size(484, 32);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // pnCTHD
            // 
            this.pnCTHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCTHD.Location = new System.Drawing.Point(12, 82);
            this.pnCTHD.Name = "pnCTHD";
            this.pnCTHD.Size = new System.Drawing.Size(464, 355);
            this.pnCTHD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_MaHD.Location = new System.Drawing.Point(116, 51);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(32, 18);
            this.lb_MaHD.TabIndex = 4;
            this.lb_MaHD.Text = "___";
            // 
            // lb_Tongtien
            // 
            this.lb_Tongtien.AutoSize = true;
            this.lb_Tongtien.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_Tongtien.Location = new System.Drawing.Point(336, 51);
            this.lb_Tongtien.Name = "lb_Tongtien";
            this.lb_Tongtien.Size = new System.Drawing.Size(32, 18);
            this.lb_Tongtien.TabIndex = 7;
            this.lb_Tongtien.Text = "___";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(233, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng tiền:";
            // 
            // btn_Baobep
            // 
            this.btn_Baobep.Enabled = false;
            this.btn_Baobep.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Baobep.Location = new System.Drawing.Point(310, 458);
            this.btn_Baobep.Name = "btn_Baobep";
            this.btn_Baobep.Size = new System.Drawing.Size(118, 29);
            this.btn_Baobep.TabIndex = 8;
            this.btn_Baobep.Text = "Báo bếp";
            this.btn_Baobep.UseVisualStyleBackColor = true;
            this.btn_Baobep.Click += new System.EventHandler(this.btn_Duyet_Click);
            // 
            // Frm_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 499);
            this.Controls.Add(this.btn_Baobep);
            this.Controls.Add(this.lb_Tongtien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_MaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnCTHD);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_CTHD";
            this.Ribbon = this.ribbon;
            this.Text = "Duyệt chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.Frm_CTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private System.Windows.Forms.Panel pnCTHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_MaHD;
        private System.Windows.Forms.Label lb_Tongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Baobep;
    }
}