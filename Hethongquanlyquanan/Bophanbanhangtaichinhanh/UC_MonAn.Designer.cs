namespace Bophanbanhangtaichinhanh
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
            this.SuspendLayout();
            // 
            // pnThucDon
            // 
            this.pnThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThucDon.Location = new System.Drawing.Point(0, 0);
            this.pnThucDon.Name = "pnThucDon";
            this.pnThucDon.Size = new System.Drawing.Size(712, 521);
            this.pnThucDon.TabIndex = 0;
            this.pnThucDon.Paint += new System.Windows.Forms.PaintEventHandler(this.pnThucDon_Paint);
            // 
            // UC_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnThucDon);
            this.Name = "UC_MonAn";
            this.Size = new System.Drawing.Size(712, 521);
            this.Load += new System.EventHandler(this.UC_MonAn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThucDon;
    }
}
