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
    public partial class frm_Dangnhap : Form
    {
        public frm_Dangnhap()
        {
            InitializeComponent();
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            frm_Quanly frm_QL = new frm_Quanly();
            frm_QL.Show();
        }
    }
}
