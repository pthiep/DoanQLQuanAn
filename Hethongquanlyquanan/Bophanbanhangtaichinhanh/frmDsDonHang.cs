using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bophanbanhangtaichinhanh
{

    public partial class frmDonHang : Form
    {
        BindingList<DSDonHang> lstDSDonHang = new BindingList<DSDonHang>();
        public frmDonHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            DSDonHang dsdh = new DSDonHang();
            dsdh.MaKhachHang = "KH01";
            dsdh.KhachHang1 = "Le Van Hiep";
            dsdh.Sdt1 = "0909123456";
            dsdh.NvLapDon = "Nguyen Thi A";
            dsdh.DsMonAn = "Mì xào bò";
            dsdh.DiaChi = "TPCCM, Q1";
            dsdh.TongGia = "50.000";

            lstDSDonHang.Add(dsdh);
            dtg_DSDonHang.DataSource = lstDSDonHang;
        }
    }
}
