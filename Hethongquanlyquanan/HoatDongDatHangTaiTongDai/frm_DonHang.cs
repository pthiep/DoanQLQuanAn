using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoatDongDatHangTaiTongDai
{
    public partial class frm_DonHang : Form
    {
        BindingList<Donhang> lstDh = new BindingList<Donhang>();
        public frm_DonHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gbo_DH_Enter(object sender, EventArgs e)
        {

        }

        private void dtg_DonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_DonHang_Load(object sender, EventArgs e)
        {
            Donhang Dh = new Donhang();
            Dh.NguoiNhan = "Bui Xuan Hieu";
            Dh.DiaChi = "212 Nguyễn Trãi Q5";
            Dh.Sdt1 = "0909786767";
            Dh.ChuyenPhat = "Chuyen Phat Nhanh";
            Dh.TenMonAn1 = "Mì xào bò";
            Dh.MaMA = "MA1";
            Dh.Tonghoadon1 = "50.000";


            lstDh.Add(Dh);
            dtg_DonHang.DataSource = lstDh;
        }
    }
}
