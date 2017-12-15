using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
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

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text",dtg_DanhsachNV.DataSource, "matKhau");
        }

        void dis_en(bool e) {
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            txtSDT.Enabled = e;
            txtDiaChi.Enabled = e;
            txtHeSoLuong.Enabled = e;
            txtThuocChiNhanh.Enabled = e;
            txtMatKhau.Enabled = e;
            cboGioiTinh.Enabled = e;
            dtpNgaySinh.Enabled = e;
            btLuu.Enabled = e;
            btHuy.Enabled = e;
            btThem.Enabled = !e;
            btSua.Enabled = !e;
            btXoa.Enabled = !e;
        }
        

        void load_ctrl() {
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            dtpNgaySinh.Text = DateTime.Now.ToShortDateString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            dis_en(true);
            load_ctrl();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            dis_en(true);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            formNhanVien_Load(sender, e);
            dis_en(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa "+txtMaNV.Text.Trim()+"?","Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
            }
            else {
                return;
            }
        }


    }
}
