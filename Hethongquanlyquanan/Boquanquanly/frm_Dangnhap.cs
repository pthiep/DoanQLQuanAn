using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;

namespace Boquanquanly
{
    public partial class frm_Dangnhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       
       BUS_Account busAcc = new BUS_Account();

        public frm_Dangnhap()
        {
            InitializeComponent();
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            dangNhap();
        }

        void dangNhap()
        {
            if (busAcc.Login(textB_Tendangnhap.Text, textB_Matkhau.Text))
            {
                Frm_Quanly frmQl = new Frm_Quanly();
               
                frmQl.Show();
                
                
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
            }
        }
    }
}
