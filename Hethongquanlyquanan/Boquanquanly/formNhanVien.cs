using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======

>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85

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

<<<<<<< HEAD
        private void formNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
=======

        int flag;

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
          //  dtNhanVien = nvctrl.getData();
>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85
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
<<<<<<< HEAD
        

=======
/*
        void GanDulieu(NhanVienOBJ nvobj) {
            nvobj.MaNV = txtMaNV.Text.Trim();
            nvobj.TenNV = txtTenNV.Text.Trim();
            nvobj.HsLuong = float.Parse(txtHeSoLuong.Text.Trim());
            nvobj.SoDienThoai = txtSDT.Text.Trim();
            nvobj.GioiTinh = cboGioiTinh.Text.Trim();
            nvobj.NgaySinh = dtpNgaySinh.Text.Trim();
            nvobj.ThuocChiNhanh = txtThuocChiNhanh.Text.Trim();
            nvobj.MatKhau = txtMatKhau.Text.Trim();
        }
        */
>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85
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
<<<<<<< HEAD
=======
           /* GanDulieu(nvobj);
            if (flag == 0)
            {
                //them moi
               if(nvctrl.AddData(nvobj)){
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { 
                //sua
                if (nvctrl.UpdateData(nvobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            formNhanVien_Load(sender, e);
            dis_en(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa " + txtMaNV.Text.Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
<<<<<<< HEAD
=======
                /*
                //xoa
                if (nvctrl.DeleteData(txtMaNV.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85
            }
            else {
                return;
            }*/
            }
        }


    }
}
