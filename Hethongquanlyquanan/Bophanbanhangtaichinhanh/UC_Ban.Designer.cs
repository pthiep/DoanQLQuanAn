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
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnBan
            // 
            this.pnBan.Location = new System.Drawing.Point(0, 0);
            this.pnBan.Name = "pnBan";
            this.pnBan.Size = new System.Drawing.Size(660, 521);
            this.pnBan.TabIndex = 0;
            this.pnBan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBan_Paint);
            // 
            // pn_Menu
            // 
            this.pn_Menu.Location = new System.Drawing.Point(665, 0);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(130, 521);
            this.pn_Menu.TabIndex = 57;
            // 
            // UC_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_Menu);
            this.Controls.Add(this.pnBan);
            this.Name = "UC_Ban";
            this.Size = new System.Drawing.Size(795, 521);
            this.Load += new System.EventHandler(this.UC_Ban_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBan;
        private System.Windows.Forms.Panel pn_Menu;
    }
}
