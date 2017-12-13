using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Bophanbanhangtaichinhanh
{
    public partial class Frm_ChiNhanh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_ChiNhanh()
        {
            InitializeComponent();
        }

        private void Frm_ChiNhanh_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HoaDon frm = new frm_HoaDon();
            frm.Show();
        }
    }
}