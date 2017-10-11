namespace Bophanbanhangtaichinhanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Quenmatkhau = new System.Windows.Forms.Button();
            this.txtB_Matkhau = new System.Windows.Forms.TextBox();
            this.txtB_Tendangnhap = new System.Windows.Forms.TextBox();
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.lb_Dangnhap = new System.Windows.Forms.Label();
            this.lb_BPQL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thuộc Hệ thống quản lý quán ăn ABC";
            // 
            // btn_Quenmatkhau
            // 
            this.btn_Quenmatkhau.Location = new System.Drawing.Point(60, 170);
            this.btn_Quenmatkhau.Name = "btn_Quenmatkhau";
            this.btn_Quenmatkhau.Size = new System.Drawing.Size(104, 23);
            this.btn_Quenmatkhau.TabIndex = 15;
            this.btn_Quenmatkhau.Text = "Quên mật khẩu";
            this.btn_Quenmatkhau.UseVisualStyleBackColor = true;
            // 
            // txtB_Matkhau
            // 
            this.txtB_Matkhau.Location = new System.Drawing.Point(123, 125);
            this.txtB_Matkhau.Name = "txtB_Matkhau";
            this.txtB_Matkhau.Size = new System.Drawing.Size(138, 20);
            this.txtB_Matkhau.TabIndex = 14;
            // 
            // txtB_Tendangnhap
            // 
            this.txtB_Tendangnhap.Location = new System.Drawing.Point(123, 86);
            this.txtB_Tendangnhap.Name = "txtB_Tendangnhap";
            this.txtB_Tendangnhap.Size = new System.Drawing.Size(138, 20);
            this.txtB_Tendangnhap.TabIndex = 13;
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.Location = new System.Drawing.Point(186, 170);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(75, 23);
            this.btn_Dangnhap.TabIndex = 12;
            this.btn_Dangnhap.Text = "Đăng nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = true;
            // 
            // lb_Matkhau
            // 
            this.lb_Matkhau.AutoSize = true;
            this.lb_Matkhau.Location = new System.Drawing.Point(24, 132);
            this.lb_Matkhau.Name = "lb_Matkhau";
            this.lb_Matkhau.Size = new System.Drawing.Size(52, 13);
            this.lb_Matkhau.TabIndex = 11;
            this.lb_Matkhau.Text = "Mật khẩu";
            // 
            // lb_Dangnhap
            // 
            this.lb_Dangnhap.AutoSize = true;
            this.lb_Dangnhap.Location = new System.Drawing.Point(24, 86);
            this.lb_Dangnhap.Name = "lb_Dangnhap";
            this.lb_Dangnhap.Size = new System.Drawing.Size(84, 13);
            this.lb_Dangnhap.TabIndex = 10;
            this.lb_Dangnhap.Text = "Tên đăng nhập:";
            // 
            // lb_BPQL
            // 
            this.lb_BPQL.AutoSize = true;
            this.lb_BPQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BPQL.Location = new System.Drawing.Point(55, 19);
            this.lb_BPQL.Name = "lb_BPQL";
            this.lb_BPQL.Size = new System.Drawing.Size(168, 25);
            this.lb_BPQL.TabIndex = 9;
            this.lb_BPQL.Text = "Bộ phận quản lý";
            // 
            // frm_Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Quenmatkhau);
            this.Controls.Add(this.txtB_Matkhau);
            this.Controls.Add(this.txtB_Tendangnhap);
            this.Controls.Add(this.btn_Dangnhap);
            this.Controls.Add(this.lb_Matkhau);
            this.Controls.Add(this.lb_Dangnhap);
            this.Controls.Add(this.lb_BPQL);
            this.Name = "frm_Dangnhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Quenmatkhau;
        private System.Windows.Forms.TextBox txtB_Matkhau;
        private System.Windows.Forms.TextBox txtB_Tendangnhap;
        private System.Windows.Forms.Button btn_Dangnhap;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.Label lb_Dangnhap;
        private System.Windows.Forms.Label lb_BPQL;
    }
}

