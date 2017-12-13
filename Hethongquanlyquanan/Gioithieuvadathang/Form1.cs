using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace Gioithieuvadathang
{
    public partial class Form1 : Form
    {
        BUS_MonAn maBUS = new BUS_MonAn();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monan.DataSource = maBUS.LoadDanhSachMonAn();
        }

        private void monan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_MonAn dtoMA = new DTO_MonAn();
            dtoMA.MaMonAn = txtMamonan.Text;
            dtoMA.TenMonAn = txtTenmonan.Text;
            dtoMA.DonGia = float.Parse(txtDongia.Text);

            maBUS.ThemMonAn(dtoMA);
            monan.DataSource = maBUS.LoadDanhSachMonAn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = monan.CurrentRow.Index;
            string Ma = monan.Rows[index].Cells[0].Value.ToString();
            maBUS.XoaMonAn(Ma);
            monan.DataSource = maBUS.LoadDanhSachMonAn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = monan.CurrentRow.Index;
            string Ma = monan.Rows[index].Cells[1].Value.ToString();
            DTO_MonAn ma = new DTO_MonAn();
            ma.MaMonAn = monan.Rows[index].Cells[0].Value.ToString();
            ma.TenMonAn = monan.Rows[index].Cells[1].Value.ToString();
            ma.DonGia = float.Parse(monan.Rows[index].Cells[2].Value.ToString());

            maBUS.SuaMonAn(ma);
            monan.DataSource = maBUS.LoadDanhSachMonAn();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            string ma = FindMA.Text;
            if (maBUS.SearchMonAn(ma))
            {
                monan.DataSource = maBUS.LoadDanhSachMonAnTheoMa(ma);
            }
            else 
            {
                MessageBox.Show("ko tìm thấy món ăn!");
            }
        }
    }
}
