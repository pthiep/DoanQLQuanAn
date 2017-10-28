using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boquanquanly.NewControl;

namespace Boquanquanly
{
    
    public partial class formNhanVien : Form

    {
       
        public formNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtg_DanhsachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        NhanVienCtrl nvctrl = new NhanVienCtrl();
        private void formNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvctrl.getData();
            dtg_DanhsachNV.DataSource = dtNhanVien;
            binding();
        }

        void binding() {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dtg_DanhsachNV.DataSource, "MaNhanVien");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dtg_DanhsachNV.DataSource, "TenNV");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtg_DanhsachNV.DataSource, "diaChi");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dtg_DanhsachNV.DataSource, "ngaySinh");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dtg_DanhsachNV.DataSource, "dienThoai");

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", dtg_DanhsachNV.DataSource, "gioiTinh");

            txtHeSoLuong.DataBindings.Clear();
            txtHeSoLuong.DataBindings.Add("Text", dtg_DanhsachNV.DataSource, "hesoLuong");

            txtThuocChiNhanh.DataBindings.Clear();
            txtThuocChiNhanh.DataBindings.Add("Text", dtg_DanhsachNV.DataSource, "thuocChiNhanh");
        }
    }
}
