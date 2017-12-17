namespace Bophanbanhangtaichinhanh
{
    partial class UC_Ban
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
            this.pnBan = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnBan
            // 
            this.pnBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBan.Location = new System.Drawing.Point(0, 0);
            this.pnBan.Name = "pnBan";
            this.pnBan.Size = new System.Drawing.Size(712, 521);
            this.pnBan.TabIndex = 0;
            // 
            // UC_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBan);
            this.Name = "UC_Ban";
            this.Size = new System.Drawing.Size(712, 521);
            this.Load += new System.EventHandler(this.UC_Ban_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBan;
    }
}
