using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using BUS;

namespace Boquanquanly
{
    public partial class Frm_Quanly : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_MonAn busMA;
        BUS_Clock busClock;
        public Frm_Quanly()
        {
            InitializeComponent();
            busMA = new BUS_MonAn();
            busClock = new BUS_Clock();
        }

        private void Frm_Quanly_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = busMA.LoadDanhSachMonAn();
            tileItem1.Elements[1].Text = "13.000 VNĐ";
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            lbl_Clock.Text = busClock.TimeServer();
        }

        private void SimpleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(busClock.TimeServer());
        }

        private void backstageViewControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
