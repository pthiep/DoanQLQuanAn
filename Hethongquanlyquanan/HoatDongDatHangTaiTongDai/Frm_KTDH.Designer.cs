namespace HoatDongDatHangTaiTongDai
{
    partial class Frm_KTDH
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
            this.pnDH = new System.Windows.Forms.Panel();
            this.tb_TimkiemMaDH = new System.Windows.Forms.TextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
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
            this.ribbon.Size = new System.Drawing.Size(857, 32);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // pnDH
            // 
            this.pnDH.AutoScroll = true;
            this.pnDH.Location = new System.Drawing.Point(12, 70);
            this.pnDH.Name = "pnDH";
            this.pnDH.Size = new System.Drawing.Size(840, 227);
            this.pnDH.TabIndex = 2;
            // 
            // tb_TimkiemMaDH
            // 
            this.tb_TimkiemMaDH.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tb_TimkiemMaDH.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_TimkiemMaDH.Location = new System.Drawing.Point(12, 39);
            this.tb_TimkiemMaDH.Name = "tb_TimkiemMaDH";
            this.tb_TimkiemMaDH.Size = new System.Drawing.Size(813, 25);
            this.tb_TimkiemMaDH.TabIndex = 3;
            this.tb_TimkiemMaDH.Text = "Nhập mã đơn hàng để tìm !!!";
            this.tb_TimkiemMaDH.TextChanged += new System.EventHandler(this.tb_TimkiemMaDH_TextChanged);
            this.tb_TimkiemMaDH.Enter += new System.EventHandler(this.tb_TimkiemMaDH_Enter);
            this.tb_TimkiemMaDH.Leave += new System.EventHandler(this.tb_TimkiemMaDH_Leave);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Frm_KTDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 306);
            this.Controls.Add(this.tb_TimkiemMaDH);
            this.Controls.Add(this.pnDH);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_KTDH";
            this.Ribbon = this.ribbon;
            this.Text = "Frm_KTDH";
            this.Load += new System.EventHandler(this.Frm_KTDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private System.Windows.Forms.Panel pnDH;
        private System.Windows.Forms.TextBox tb_TimkiemMaDH;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}