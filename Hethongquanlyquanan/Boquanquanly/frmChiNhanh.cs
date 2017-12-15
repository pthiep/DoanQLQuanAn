using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
<<<<<<< HEAD
=======

>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85

namespace Boquanquanly
{
    public partial class frmChiNhanh : Form
    {
<<<<<<< HEAD
=======
      //  ChiNhanhCtrl cnctrl = new ChiNhanhCtrl();
>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85

        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
<<<<<<< HEAD
=======
           // dt = cnctrl.GetData();
>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85
            dgv_ChiNhanh.DataSource = dt;
            binding();
        }

        void binding() {
            txtMaCN.DataBindings.Clear();
            txtMaCN.DataBindings.Add("Text", dgv_ChiNhanh.DataSource, "MaChiNhanh");
            txtTenCN.DataBindings.Clear();
            txtTenCN.DataBindings.Add("Text", dgv_ChiNhanh.DataSource, "TenChiNhanh");
            txtMaCN.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgv_ChiNhanh.DataSource, "DiaChi");
            txtDiaChi.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgv_ChiNhanh.DataSource, "SoDienThoai");
            dtpNTL.DataBindings.Clear();
            dtpNTL.DataBindings.Add("Text", dgv_ChiNhanh.DataSource, "NgayThanhLap");
            txtNVQL.DataBindings.Clear();
            txtNVQL.DataBindings.Add("Text", dgv_ChiNhanh.DataSource, "NhanVienQuanLi");
            txtSLBA.DataBindings.Clear();
            txtSLBA.DataBindings.Add("Text", dgv_ChiNhanh.DataSource, "SoLuongBanAn");
        }
    }
}
