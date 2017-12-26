namespace Bophanbanhangtaichinhanh
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_MaCN = new System.Windows.Forms.Label();
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
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã chi nhánh:";
            // 
            // lb_MaCN
            // 
            this.lb_MaCN.AutoSize = true;
            this.lb_MaCN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lb_MaCN.Location = new System.Drawing.Point(128, 45);
            this.lb_MaCN.Name = "lb_MaCN";
            this.lb_MaCN.Size = new System.Drawing.Size(32, 18);
            this.lb_MaCN.TabIndex = 6;
            this.lb_MaCN.Text = "___";
            // 
            // Frm_KTDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 306);
            this.Controls.Add(this.lb_MaCN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnDH);
            this.Controls.Add(this.ribbon);
            this.Name = "Frm_KTDH";
            this.Ribbon = this.ribbon;
            this.Text = "Đơn hàng";
            this.Load += new System.EventHandler(this.Frm_KTDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private System.Windows.Forms.Panel pnDH;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_MaCN;
    }
}