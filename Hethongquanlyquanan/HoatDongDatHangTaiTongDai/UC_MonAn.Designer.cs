namespace HoatDongDatHangTaiTongDai
{
    partial class UC_MonAn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnThucDon = new System.Windows.Forms.Panel();
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnThucDon
            // 
            this.pnThucDon.AutoScroll = true;
            this.pnThucDon.Location = new System.Drawing.Point(0, 0);
            this.pnThucDon.Name = "pnThucDon";
            this.pnThucDon.Size = new System.Drawing.Size(689, 521);
            this.pnThucDon.TabIndex = 0;
            this.pnThucDon.Paint += new System.Windows.Forms.PaintEventHandler(this.pnThucDon_Paint);
            // 
            // pn_Menu
            // 
            this.pn_Menu.Location = new System.Drawing.Point(695, 0);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(130, 521);
            this.pn_Menu.TabIndex = 56;
            // 
            // UC_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_Menu);
            this.Controls.Add(this.pnThucDon);
            this.Name = "UC_MonAn";
            this.Size = new System.Drawing.Size(828, 521);
            this.Load += new System.EventHandler(this.UC_MonAn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThucDon;
        private System.Windows.Forms.Panel pn_Menu;
    }
}
