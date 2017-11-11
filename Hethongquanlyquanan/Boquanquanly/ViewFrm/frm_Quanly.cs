using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boquanquanly.ViewFrm;
using MetroFramework.Forms;

namespace Boquanquanly
{
    public partial class frm_Quanly : MetroForm
    {

        public frm_Quanly()
        {
            InitializeComponent();
            
        }

        private void frm_Quanly_Load(object sender, EventArgs e)
        {
            
            if (!metroPanel1.Controls.Contains(UserControl1.Instance))
            {
                metroPanel1.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox19_Enter(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
