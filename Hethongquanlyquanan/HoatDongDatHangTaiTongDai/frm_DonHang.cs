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
using DTO;

namespace HoatDongDatHangTaiTongDai
{
    public partial class frm_DonHang : Form
    {
        BUS_DonHang dhbus = new BUS_DonHang();
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
            dtg_DonHang.DataSource = dhbus.LoadDonHang();
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_themDH_Click(object sender, EventArgs e)
        {
            DTO_DonHang dh = new DTO_DonHang();
            dh.MaDonHang = txt_maDH.Text;
            dh.MaCN = txt_MaCN.Text;
            dh.MaKhachHang = txt_maKH.Text;
            dh.TongTien = float.Parse(txt_Tongtien.Text);
            dh.Sdt = txt_Sdt.Text;
            dh.DiaChi = txt_diaChi.Text;
            dh.TenNVLap = txtTenNV.Text;

            dhbus.ThemDH(dh);
            dtg_DonHang.DataSource = dhbus.LoadDonHang();
            MessageBox.Show("Ban da them thanh cong!");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DTO_DonHang dh = new DTO_DonHang();
            
            int index = dtg_DonHang.CurrentCell.RowIndex;
            dh.MaDonHang = dtg_DonHang.Rows[index].Cells[0].Value.ToString();
            dh.MaCN = dtg_DonHang.Rows[index].Cells[1].Value.ToString();
            dh.MaKhachHang = dtg_DonHang.Rows[index].Cells[2].Value.ToString();
            dh.TongTien= float.Parse(dtg_DonHang.Rows[index].Cells[3].Value.ToString());
            dh.Sdt= dtg_DonHang.Rows[index].Cells[4].Value.ToString();
            dh.DiaChi= dtg_DonHang.Rows[index].Cells[5].Value.ToString();
            dh.TenNVLap= dtg_DonHang.Rows[index].Cells[6].Value.ToString();
            dhbus.SuaDH(dh);
            dtg_DonHang.DataSource = dhbus.LoadDonHang();
            MessageBox.Show("Ban da sua thanh cong!");



        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            int index = dtg_DonHang.CurrentCell.RowIndex;
            string maDonHang = dtg_DonHang.Rows[index].Cells[0].Value.ToString();
           
            dhbus.XoaDH(maDonHang);
            dtg_DonHang.DataSource = dhbus.LoadDonHang();
            MessageBox.Show("Ban da xoa thanh cong!");

        }
    }
}
