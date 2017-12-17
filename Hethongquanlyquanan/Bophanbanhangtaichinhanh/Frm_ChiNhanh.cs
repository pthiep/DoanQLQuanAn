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
using BUS;


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
            CenterToScreen();            
        }

        private void ThemMonAn(string mamonan)
        {
            MessageBox.Show(mamonan);

        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HoaDon frm = new frm_HoaDon();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (btnVisible.Text == "Bàn")
            {
                if (!pnUC.Controls.Contains(UC_MonAn.Instance))
                {
                    pnUC.Controls.Add(UC_MonAn.Instance);
                    UC_MonAn.Instance.Dock = DockStyle.Fill;
                    UC_MonAn.Instance.BringToFront();
                }
                else
                    UC_MonAn.Instance.BringToFront();

                btnVisible.Text = "Thực đơn";

            }
            else if (btnVisible.Text == "Thực đơn")
            {
                if (!pnUC.Controls.Contains(UC_Ban.Instance))
                {
                    pnUC.Controls.Add(UC_Ban.Instance);
                    UC_Ban.Instance.Dock = DockStyle.Fill;
                    UC_Ban.Instance.BringToFront();
                }
                else
                    UC_Ban.Instance.BringToFront();

                btnVisible.Text = "Bàn";
            }
        }
    }
}