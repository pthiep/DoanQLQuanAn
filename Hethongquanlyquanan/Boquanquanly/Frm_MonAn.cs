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
using DTO;
using BUS;

namespace Boquanquanly
{
    public partial class Frm_MonAn : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_MonAn busMA = new BUS_MonAn();
        BUS_DanhMuc busDM = new BUS_DanhMuc();

        public delegate void LoadEvent();
        public event LoadEvent LoadMAEvent;

        public bool ThemMoi = false;

        public Frm_MonAn()
        {
            InitializeComponent();
        }

        private void Frm_MonAn_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (ThemMoi)
            {
                LoadDanhMuc();
            }
        }

        private void LoadDanhMuc()
        {
            cb_DM.Properties.Items.Add("--- Chọn danh mục ---");
            
            foreach (DataRow dr in busDM.LoadDanhMuc().Rows)
            {
                cb_DM.Properties.Items.Add(dr.ItemArray[1].ToString());
            }
            cb_DM.SelectedIndex = 0;
        }

        public void LoadMA(DTO_MonAn ma)
        {
            LoadDanhMuc();
            tb_Tenmonan.Text = ma.Tenma;
            tb_Mamonan.Text = ma.Mama;
            tb_Giaban.Text = ma.Giaban.ToString();
            pb_Hinhanh.Image = Image.FromFile(ma.Hinhanh);
            btn_Uphinh.Text = ma.Hinhanh;

            int n = cb_DM.Properties.Items.Count;
            for (int i = 0; i < n; i++)
            {
                cb_DM.SelectedIndex = i;
                if (cb_DM.Text == busMA.LayTenDanhMuc(ma.Madanhmuc))
                {
                    break;
                }
            }
        }

        private void btn_Trove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (tb_Tenmonan.Text != "" && tb_Giaban.Text != "")
            {
                Capnhat();
                if (LoadMAEvent != null)
                {
                    LoadMAEvent();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin !!!", "Thông báo");
            }
        }

        private void btn_Luuvatt_Click(object sender, EventArgs e)
        {
            Capnhat();
            CleanText();
        }

        private void CleanText()
        {
            tb_Tenmonan.Text = "";
            tb_Mamonan.Text = "Hệ thống sẽ tự tạo mã";
            tb_Giaban.Text = "";
            pb_Hinhanh.Image = null;
            btn_Uphinh.Text = "";
        }

        void Capnhat()
        {

            DTO_MonAn ma = new DTO_MonAn();
            ma.Tenma = tb_Tenmonan.Text;
            ma.Mama = tb_Mamonan.Text;
            ma.Giaban = decimal.Parse(tb_Giaban.Text);
            ma.Madanhmuc = busMA.LayMaDanhMuc(cb_DM.Text);
            if (busMA.Capnhatmonan(ma))
            {
                MessageBox.Show("Cập nhật món ăn thành công !!!", "Thông báo");
            }


        }

        private void bt_QLDM_Click(object sender, EventArgs e)
        {
            Frm_DanhMuc frmDM = new Frm_DanhMuc();
            frmDM.ShowDialog();
        }
    }
}