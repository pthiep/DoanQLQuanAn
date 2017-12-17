using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BUS;

namespace Bophanbanhangtaichinhanh
{
    public partial class Frm_DangNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        
        public Frm_DangNhap()
        {
            InitializeComponent();
            
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void DangNhap(string user, string pass)
        {
            if(txt_TenDN.Text == "" || txt_MK.Text =="")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin!!");
            }
            else
            {
                //Login(user, pass);

            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Application.Exit();
        }
    }
}