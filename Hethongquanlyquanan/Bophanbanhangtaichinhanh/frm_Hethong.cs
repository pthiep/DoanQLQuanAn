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
    public partial class frm_Hethong : Form
    {
        //BindingList<DonHang> lstDH = new BindingList<DonHang>();
        public frm_Hethong()
        {
            InitializeComponent();
        }

        private void frm_Hethong_Load(object sender, EventArgs e)
        {
            
           // DonHang dh = new DonHang(); 
            //dh.MaDonHang = "DH1";
            //dh.MaMonAn = "MA1";
            //dh.TenMonAn = "Mì xào bò";
            //dh.Gia = "50.000VND";
      
            //lstDH.Add(dh);
            //dtg_DonHang.DataSource = lstDH;
        }

        private void dtg_DonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
