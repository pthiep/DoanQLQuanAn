using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChung.Control;
using QuanLyChung.Object;

namespace QuanLyChung.View
{
    public partial class frmNhanVien : Form
    {
        NhanVienCtrl nvctr = new NhanVienCtrl();
        NhanVienOBJ nvobj = new NhanVienOBJ();
        int flag = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable NhanViendt = new DataTable();
            NhanViendt = nvctr.getData();
            dgvDanhSachNhanVien.DataSource = NhanViendt;
            bingding();
        }



        void bingding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "maNhanVien");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "tenNV");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "ngaySinh");
            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "gioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "diaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "dienThoai");
            txtHeSoLuong.DataBindings.Clear();
            txtHeSoLuong.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "heSoLuong");
            txtThuocChiNhanh.DataBindings.Clear();
            txtThuocChiNhanh.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "thuocChiNhanh");           
        }

        void dis_enable(bool e)
        {
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            txtHeSoLuong.Enabled = e;
            txtThuocChiNhanh.Enabled = e;
            cbbGioiTinh.Enabled = e;
            dtpNgaySinh.Enabled = e;
            btLuu.Enabled = e;
            btHuy.Enabled = e;
            btThem.Enabled = !e;
            btSua.Enabled = !e;
            btXoa.Enabled = !e;
        }

        //Lay du lieu tu texbox -> cac form
        void ganDuLieu(NhanVienOBJ nvobj)
        {
            nvobj.Ma = txtMaNV.Text.Trim();
            nvobj.Ten = txtTenNV.Text.Trim();
            nvobj.Ngaysinh = dtpNgaySinh.Text.Trim();
            nvobj.Sodienthoai = txtSDT.Text.Trim();
            nvobj.Diachi = txtDiaChi.Text.Trim();
            nvobj.Hesoluong = float.Parse(txtHeSoLuong.Text.Trim());
            nvobj.Gioitinh = cbbGioiTinh.Text.Trim();
            nvobj.Thuocchinhanh = txtThuocChiNhanh.Text.Trim();
        }

        void loadcontrol()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");

            dtpNgaySinh.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_enable(true);
            loadcontrol();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btHuy_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(nvobj);
            if (flag == 0)
            {
                if(nvctr.addData(nvobj))
                {
                    MessageBox.Show("Thêm dữ liệu thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bạie", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                //Sua
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr  == DialogResult.Yes)
            {
                //Xoa
            }
            else
            {
                return;
            }
                
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enable(true);
        }
    }
}
