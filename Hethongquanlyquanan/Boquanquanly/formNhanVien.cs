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
        BindingList<dsNhanVien> lstDsNV = new BindingList<dsNhanVien>();
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
            dsNhanVien DsNV = new dsNhanVien();
            DsNV.MaNV = "NV1";
            DsNV.TenNV = "Lê Thị Hồng";
            DsNV.GioiTinh = "Nữ";
            DsNV.DiaChiNV = "Nguyễn Văn Cừ Q1, HCM";
            DsNV.SDT1 = "01226738123";
            DsNV.ThuocChiNhanh = "CN1";
            DsNV.NgaySinh = "07/08/1997";
            DsNV.HsLuong = "x2";

            lstDsNV.Add(DsNV);
            dtg_DanhsachNV.DataSource = lstDsNV;
        }
    }
}
