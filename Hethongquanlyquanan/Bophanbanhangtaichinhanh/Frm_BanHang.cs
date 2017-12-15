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
    public partial class Frm_BanHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_BanHang()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}