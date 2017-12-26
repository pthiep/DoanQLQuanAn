using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Boquanquanly
{
    public partial class uc_soluongdonhang : UserControl
    {
        BUS_DonHang busDH = new BUS_DonHang();
        private static uc_soluongdonhang _instance;

        public static uc_soluongdonhang Instance
        {
            get
            {
                if (_instance == null) _instance = new uc_soluongdonhang();
                return uc_soluongdonhang._instance; }
            set { uc_soluongdonhang._instance = value; }
        }

        public uc_soluongdonhang()
        {
            InitializeComponent();
            load_control();
        }

        void uc_soluongdonhang_shown(object sender, EventArgs e)
        {
            
        }

        void load_control()
        {
            DateTime dt = DateTime.Today;

            for (int i = 0; i <= dt.Year - 1980; i++)
            {
                cbbNam.Items.Add(i + 1980);
            }

            for (int i = 1; i <= 12; i++) {
                cbbThang.Items.Add(i);
            }

            cbbthongke.Items.Add("Quý");
            cbbthongke.Items.Add("Năm");
            cbbthongke.Items.Add("Tháng");
            cbbthongke.Items.Add("Tuần");
        }

        void load_data()
        {
            DataTable data = new DataTable();
            if(cbbthongke.SelectedItem == "Năm"){
                data = busDH.DonHangTheoNam();
            }

        }

        private void dgvSoLieu_MouseClick(object sender, MouseEventArgs e)
        {
            int max = Convert.ToInt32(dgvSoLieu.CurrentRow.Cells[0].Value);
            for (int i = 1; i < 12; i++)
            {
                if (max < Convert.ToInt32(dgvSoLieu.CurrentRow.Cells[i].Value))
                {
                    max = Convert.ToInt32(dgvSoLieu.CurrentRow.Cells[i].Value);
                }
            }

            if (chart1.ChartAreas[0].AxisY.Maximum < max) chart1.ChartAreas[0].AxisY.Maximum = max;
            chart1.Series.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbthongke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbthongke.SelectedItem == "Quý" || cbbthongke.SelectedItem == "Tháng")
            {
                cbbNam.Enabled = true;
            }

            if (cbbthongke.SelectedItem == "Tuần")
            {
                cbbNam.Enabled = true;
                cbbThang.Enabled = true;
            }

        }
    }
}
