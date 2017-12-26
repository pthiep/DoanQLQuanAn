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
using DTO;
using BUS;

namespace Bophanbanhangtaichinhanh
{
    public partial class Frm_DangNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();
        string manv = "";
        string machinhanh = "";
        bool dangnhap = false;
        List<Tuple<string, int>> lstQuyenTC;

        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            Dangnhap();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        public void ThongTinDangNhap(ref bool dn,ref string ma , ref string macn)
        {
            dn = dangnhap;
            ma = manv;
            macn = machinhanh;
        }

        void Dangnhap()
        {
            if (tb_TenDN.Text != "" && tb_MK.Text != "")
            {
                if (busTK.DangNhap(tb_TenDN.Text, tb_MK.Text, ref manv))
                {
                    machinhanh = busTK.LayMaCN(manv);
                    if (busTK.QuyenTruyCap(manv, ref lstQuyenTC))
                    {
                        foreach (Tuple<string, int> q in lstQuyenTC)
                        {
                            if (q.Item1 == "Q1" && q.Item2 == 1)
                            {
                                dangnhap = true;
                                this.Close();
                            }
                            
                            if (q.Item1 == "Q3" && q.Item2 == 1)
                            {
                                dangnhap = true;
                                this.Close();
                            }

                        }
                        if (dangnhap == false)
                        {
                            MessageBox.Show("Bạn không có quyền truy cập !!!", "Thông báo");
                        }
                    }                                     
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Nhập tên đăng nhập và mật khẩu !!!", "Thông báo");
            }
        }
    }
}