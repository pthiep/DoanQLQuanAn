namespace Boquanquanly.ViewFrm
{
    partial class UserControl1
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
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(239, 144);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(214, 115);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "metroTile2";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 16);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(618, 122);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Doanh thu hoặc Món hot";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(19, 144);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(214, 115);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Danh mục món ăn";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::Boquanquanly.Properties.Resources.icons8_restaurant_menu__1_;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseTileImage = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(650, 460);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
