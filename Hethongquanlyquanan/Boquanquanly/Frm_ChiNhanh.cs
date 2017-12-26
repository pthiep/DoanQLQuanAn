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

namespace Boquanquanly
{
    public partial class Frm_ChiNhanh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_ChiNhanh busCN = new BUS_ChiNhanh();

        public bool flag = false;
        public Frm_ChiNhanh()
        {
            InitializeComponent();
        }

        private void Frm_ChiNhanh_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (flag)
            {
                LoadCbTinhthanh();
                TaoMaCN();
            }
        }

        void TaoMaCN()
        {
            tb_Macn.Text = busCN.TaoMaCN();
        }

        void LoadCbTinhthanh()
        {
            string stinhthanh = "An Giang/Bà Rịa -Vũng Tàu/Bắc Giang/Bắc Kạn/Bạc Liêu/Bắc Ninh/Bến Tre/Bình Định/Bình Dương/Bình Phước/Bình Thuận/Cà Mau/Cao Bằng/Đắk Lắk/Đắk Nông/Điện Biên/Đồng Nai/Đồng Tháp/Gia Lai/Hà Giang/Hà Nam/Hà Tĩnh/Hải Dương/Hậu Giang/Hòa Bình/Hưng Yên/Khánh Hòa/Kiên Giang/Kon Tum/Lai Châu/Lâm Đồng/Lạng Sơn/Lào Cai/Long An/Nam Định/Nghệ An/Ninh Bình/Ninh Thuận/Phú Thọ/Quảng Bình/Quảng Nam/Quảng Ngãi/Quảng Ninh/Quảng Trị/Sóc Trăng/Sơn La/Tây Ninh/Thái Bình/Thái Nguyên/Thanh Hóa/Thừa Thiên Huế/Tiền Giang/Trà Vinh/Tuyên Quang/Vĩnh Long/Vĩnh Phúc/Yên Bái/Phú Yên/Cần Thơ/Đà Nẵng/Hải Phòng/Hà Nội/Hồ Chí Minh";
            string[] tinhthanh = stinhthanh.Split('/');
            foreach (string tt in tinhthanh)
            {
                cb_tinhthanh.Properties.Items.Add(tt);
            }
            cb_tinhthanh.SelectedIndex = 0;            
        }

        public void GuiThongTin(DTO_ChiNhanh cn)
        {
            tb_Tencn.Text = cn.Tencn;
            tb_Macn.Text = cn.Macn;
            tb_Diachi.Text = cn.Diachi;
            tb_Sdt.Text = cn.Dienthoai;
            tb_Slban.Text = cn.Soluongban.ToString();
            LoadCbTinhthanh();
            for (int i = 0; i < cb_tinhthanh.Properties.Items.Count; i++)
            {
                cb_tinhthanh.SelectedIndex = i;
                if (cb_tinhthanh.Text == cn.Tinhthanh)
                    break;
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Frm_QLMenu frmMenu = new Frm_QLMenu(tb_Tencn.Text, tb_Macn.Text);
            frmMenu.ShowDialog();
        }

        private void bt_Trove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {

            DTO_ChiNhanh cn = new DTO_ChiNhanh();
            if (tb_Tencn.Text != "" && tb_Diachi.Text != "" && tb_Sdt.Text != "" && tb_Slban.Text != "")
            {
                cn.Tencn = tb_Tencn.Text;
                cn.Macn = tb_Macn.Text;
                cn.Diachi = tb_Diachi.Text;
                cn.Dienthoai = tb_Sdt.Text;
                cn.Tinhthanh = cb_tinhthanh.Text;
                cn.Manvql = "NV1";
                cn.Soluongban = int.Parse(tb_Slban.Text);


                if (!flag)
                {
                    if (busCN.Capnhatchinhanh(cn))
                    {
                        MessageBox.Show("Cập nhật chi nhánh thành công !!!", "Thông báo");
                    }
                }
                else
                {
                    if (busCN.ThemCN(cn))
                    {
                        MessageBox.Show("Thêm chi nhánh thành công !!!", "Thông báo");
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ !!!", "Thông báo");
            }
        }        
    }
}