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
using DTO;

namespace Boquanquanly
{
    public partial class Frm_DanhMuc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_DanhMuc dmBUS = new BUS_DanhMuc();

        public Frm_DanhMuc()
        {
            InitializeComponent();
        }

        private void Frm_DanhMuc_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            tb_Madanhmuc.Text = dmBUS.TaoMaDM();
            VeHeadBangDanhSachDanhMuc();
            VeBodyBangDanhSachDanhMuc(dmBUS.LoadDanhMuc());
        }

        private void VeHeadBangDanhSachDanhMuc()
        {
            panel_DSDM.Controls.Clear();
            Panel pn_HChon = new Panel();
            Panel pn_HTendanhmuc = new Panel();
            Panel pn_HMadanhmuc = new Panel();
            Panel pn_HChucnang = new Panel();

            CheckBox cb_All = new CheckBox();
            Label lb_HTendanhmuc = new Label();
            Label lb_HMadanhmuc = new Label();
            Label lb_HChucnang = new Label();

            int scaleHChon = 5;
            int scaleHTendanhmuc = 50;
            int scaleHMadanhmuc = 30;
            int scaleHChucnang = 15;

            int cc = 35;
            int crpn = panel_DSDM.Width;
            int crpnHChon = (crpn * scaleHChon) / 100;
            int crpnHTemonan = (crpn * scaleHTendanhmuc) / 100;
            int crpnHMamonan = (crpn * scaleHMadanhmuc) / 100;
            int crpnHChucnang = (crpn * scaleHChucnang) / 100;

            pn_HChon.BorderStyle = BorderStyle.FixedSingle;
            pn_HChon.Size = new Size(crpnHChon, cc);
            pn_HChon.Location = new Point(0, 0);

            cb_All.Width = 14;
            cb_All.Height = 14;
            cb_All.Location = new Point((pn_HChon.Width / 2) - (cb_All.Width / 2), (pn_HChon.Height / 2) - (cb_All.Height / 2));
            pn_HChon.Controls.Add(cb_All);

            pn_HTendanhmuc.BorderStyle = BorderStyle.FixedSingle;
            pn_HTendanhmuc.Size = new Size(crpnHTemonan, cc);
            pn_HTendanhmuc.Location = new Point(pn_HChon.Location.X + pn_HChon.Width - 1, 0);

            lb_HTendanhmuc.Width = pn_HTendanhmuc.Width;
            lb_HTendanhmuc.Height = pn_HTendanhmuc.Height;
            lb_HTendanhmuc.Text = "Tên danh mục";
            lb_HTendanhmuc.TextAlign = ContentAlignment.MiddleCenter;
            lb_HTendanhmuc.Location = new Point(0, 0);
            pn_HTendanhmuc.Controls.Add(lb_HTendanhmuc);

            pn_HMadanhmuc.BorderStyle = BorderStyle.FixedSingle;
            pn_HMadanhmuc.Size = new Size(crpnHMamonan, cc);
            pn_HMadanhmuc.Location = new Point(pn_HTendanhmuc.Location.X + pn_HTendanhmuc.Width - 1, 0);

            lb_HMadanhmuc.Width = pn_HMadanhmuc.Width;
            lb_HMadanhmuc.Height = pn_HMadanhmuc.Height;
            lb_HMadanhmuc.Text = "Mã danh mục";
            lb_HMadanhmuc.TextAlign = ContentAlignment.MiddleCenter;
            lb_HMadanhmuc.Location = new Point(0, 0);
            pn_HMadanhmuc.Controls.Add(lb_HMadanhmuc);

            pn_HChucnang.BorderStyle = BorderStyle.FixedSingle;
            pn_HChucnang.Size = new Size(crpnHChucnang, cc);
            pn_HChucnang.Location = new Point(pn_HMadanhmuc.Location.X + pn_HMadanhmuc.Width - 1, 0);

            lb_HChucnang.Width = pn_HChucnang.Width;
            lb_HChucnang.Height = pn_HChucnang.Height;
            lb_HChucnang.Text = "";
            lb_HChucnang.TextAlign = ContentAlignment.MiddleCenter;
            lb_HChucnang.Location = new Point(0, 0);
            pn_HChucnang.Controls.Add(lb_HChucnang);

            panel_DSDM.Controls.Add(pn_HChon);
            panel_DSDM.Controls.Add(pn_HTendanhmuc);
            panel_DSDM.Controls.Add(pn_HMadanhmuc);
            panel_DSDM.Controls.Add(pn_HChucnang);
        }
        private void VeBodyBangDanhSachDanhMuc(DataTable dt)
        {
            Panel pn_Row = null;
            Panel pn_BChon = null;
            Panel pn_BTendanhmuc = null;
            Panel pn_BMadanhmuc = null;            
            Panel pn_BChucnang = null;

            CheckBox cb_Row = null;
            LinkLabel lb_BTendanhmuc = null;
            Label lb_BMadanhmuc = null;            
            Button btn_BSua = null;
            Button btn_BXoa = null;

            int scaleBChon = 5;
            int scaleBTendanhmuc = 50;
            int scaleBMadanhmuc = 30;
            int scaleBChucnang = 15;

            int cc = 35;
            int crpn = panel_DSDM.Width;
            int crpnBRow = crpn;
            int crpnBChon = (crpn * scaleBChon) / 100;
            int crpnBTemonan = (crpn * scaleBTendanhmuc) / 100;
            int crpnBMamonan = (crpn * scaleBMadanhmuc) / 100;
            int crpnBChucnang = (crpn * scaleBChucnang) / 100;

            int slma = dmBUS.Soluongdanhmuc();

            for (int i = 0; i < slma; i++)
            {
                pn_Row = new Panel();

                pn_BChon = new Panel();
                pn_BTendanhmuc = new Panel();
                pn_BMadanhmuc = new Panel();
                pn_BChucnang = new Panel();

                cb_Row = new CheckBox();
                lb_BTendanhmuc = new LinkLabel();
                lb_BMadanhmuc = new Label();
                btn_BSua = new Button();
                btn_BXoa = new Button();

                pn_Row.BorderStyle = BorderStyle.FixedSingle;
                pn_Row.Size = new Size(crpnBRow - 4, cc);
                pn_Row.Location = new Point(0, (cc - 1) * (i + 1));

                pn_BChon.Size = new Size(crpnBChon, cc);
                pn_BChon.Location = new Point(-1, -1);

                cb_Row.Width = 14;
                cb_Row.Height = 14;
                cb_Row.Location = new Point((pn_BChon.Width / 2) - (cb_Row.Width / 2), (pn_BChon.Height / 2) - (cb_Row.Height / 2));
                pn_BChon.Controls.Add(cb_Row);

                pn_BTendanhmuc.Size = new Size(crpnBTemonan, cc);
                pn_BTendanhmuc.Location = new Point(pn_BChon.Location.X + pn_BChon.Width - 1, -1);

                lb_BTendanhmuc.Width = pn_BTendanhmuc.Width;
                lb_BTendanhmuc.Height = pn_BTendanhmuc.Height;
                lb_BTendanhmuc.Text = dt.Rows[i].ItemArray[1].ToString();
                lb_BTendanhmuc.TextAlign = ContentAlignment.MiddleLeft;
                lb_BTendanhmuc.Location = new Point(0, 0);
                pn_BTendanhmuc.Controls.Add(lb_BTendanhmuc);
                lb_BTendanhmuc.Click += Lb_BTendanhmuc_Click;
                lb_BTendanhmuc.Tag = dt.Rows[i].ItemArray[0].ToString();

                pn_BMadanhmuc.Size = new Size(crpnBMamonan, cc);
                pn_BMadanhmuc.Location = new Point(pn_BTendanhmuc.Location.X + pn_BTendanhmuc.Width - 1, -1);

                lb_BMadanhmuc.Width = pn_BMadanhmuc.Width;
                lb_BMadanhmuc.Height = pn_BMadanhmuc.Height;
                lb_BMadanhmuc.Text = dt.Rows[i].ItemArray[0].ToString();
                lb_BMadanhmuc.TextAlign = ContentAlignment.MiddleCenter;
                lb_BMadanhmuc.Location = new Point(0, 0);
                pn_BMadanhmuc.Controls.Add(lb_BMadanhmuc);                

                pn_BChucnang.Size = new Size(crpnBChucnang, cc);
                pn_BChucnang.Location = new Point(pn_BMadanhmuc.Location.X + pn_BMadanhmuc.Width - 1, -1);

                string imgSua = "C:\\DBMA\\edit-row.png";
                string imgXoa = "C:\\DBMA\\del-row.png";
                btn_BSua.Image = Image.FromFile(imgSua);
                btn_BSua.Width = 25;
                btn_BSua.Height = 25;
                btn_BXoa.Image = Image.FromFile(imgXoa);
                btn_BXoa.Width = 25;
                btn_BXoa.Height = 25;
                btn_BSua.Location = new Point((pn_BChucnang.Width / 2) - btn_BSua.Width - 2, (pn_BChucnang.Height / 2 - 12));
                btn_BXoa.Location = new Point((pn_BChucnang.Width / 2) + 2, (pn_BChucnang.Height / 2 - 12));
                btn_BSua.Click += Btn_BSua_Click;
                btn_BXoa.Click += Btn_BXoa_Click;
                btn_BSua.Tag = dt.Rows[i].ItemArray[0].ToString();
                btn_BXoa.Tag = dt.Rows[i].ItemArray[0].ToString();
                pn_BChucnang.Controls.Add(btn_BSua);
                pn_BChucnang.Controls.Add(btn_BXoa);

                pn_Row.Controls.Add(pn_BChon);
                pn_Row.Controls.Add(pn_BTendanhmuc);
                pn_Row.Controls.Add(pn_BMadanhmuc);
                pn_Row.Controls.Add(pn_BChucnang);

                panel_DSDM.Controls.Add(pn_Row);
            }
        }

        private void VeBodyBangDanhSachDanhMucEdit(DataTable dt, string ma)
        {
            Panel pn_Row = null;
            Panel pn_BChon = null;
            Panel pn_BTendanhmuc = null;
            Panel pn_BMadanhmuc = null;
            Panel pn_BChucnang = null;

            CheckBox cb_Row = null;
            TextBox tb_BTendanhmuc = null;
            Label lb_BTendanhmuc = null;
            Label lb_BMadanhmuc = null;
            Button btn_BSua = null;
            Button btn_BXoa = null;
            Button btn_BLuu = null;
            Button btn_BHuy = null;

            int scaleBChon = 5;
            int scaleBTendanhmuc = 50;
            int scaleBMadanhmuc = 30;
            int scaleBChucnang = 15;

            int cc = 35;
            int crpn = panel_DSDM.Width;
            int crpnBRow = crpn;
            int crpnBChon = (crpn * scaleBChon) / 100;
            int crpnBTemonan = (crpn * scaleBTendanhmuc) / 100;
            int crpnBMamonan = (crpn * scaleBMadanhmuc) / 100;
            int crpnBChucnang = (crpn * scaleBChucnang) / 100;


            int slma = dmBUS.Soluongdanhmuc();

            for (int i = 0; i < slma; i++)
            {
                pn_Row = new Panel();

                pn_BChon = new Panel();
                pn_BTendanhmuc = new Panel();
                pn_BMadanhmuc = new Panel();
                pn_BChucnang = new Panel();

                cb_Row = new CheckBox();
                tb_BTendanhmuc = new TextBox();
                lb_BTendanhmuc = new Label();
                lb_BMadanhmuc = new Label();
                btn_BSua = new Button();
                btn_BXoa = new Button();
                btn_BLuu = new Button();
                btn_BHuy = new Button();

                pn_Row.BorderStyle = BorderStyle.FixedSingle;
                pn_Row.Size = new Size(crpnBRow - 4, cc);
                pn_Row.Location = new Point(0, (cc - 1) * (i + 1));
                pn_Row.Name = "pn_Row_" + dt.Rows[i].ItemArray[0].ToString();

                if (ma == dt.Rows[i].ItemArray[0].ToString())
                {
                    pn_BChon.Size = new Size(crpnBChon, cc);
                    pn_BChon.Location = new Point(-1, -1);

                    cb_Row.Width = 14;
                    cb_Row.Height = 14;
                    cb_Row.Location = new Point((pn_BChon.Width / 2) - (cb_Row.Width / 2), (pn_BChon.Height / 2) - (cb_Row.Height / 2));
                    pn_BChon.Controls.Add(cb_Row);

                    pn_BTendanhmuc.Name = "pn_BTendanhmuc_" + dt.Rows[i].ItemArray[0].ToString();
                    pn_BTendanhmuc.Size = new Size(crpnBTemonan, cc);
                    pn_BTendanhmuc.Location = new Point(pn_BChon.Location.X + pn_BChon.Width - 1, -1);

                    tb_BTendanhmuc.Width = pn_BTendanhmuc.Width - 5;
                    tb_BTendanhmuc.Height = pn_BTendanhmuc.Height - 5;
                    tb_BTendanhmuc.Text = dt.Rows[i].ItemArray[1].ToString();
                    tb_BTendanhmuc.Name = "tb_BTendanhmuc_" + dt.Rows[i].ItemArray[0].ToString();
                    tb_BTendanhmuc.Location = new Point((pn_BTendanhmuc.Width / 2) - (tb_BTendanhmuc.Width / 2), (pn_BTendanhmuc.Height / 2) - (tb_BTendanhmuc.Height / 2));
                    pn_BTendanhmuc.Controls.Add(tb_BTendanhmuc);

                    pn_BMadanhmuc.Size = new Size(crpnBMamonan, cc);
                    pn_BMadanhmuc.Location = new Point(pn_BTendanhmuc.Location.X + pn_BTendanhmuc.Width - 1, -1);

                    lb_BMadanhmuc.Width = pn_BMadanhmuc.Width;
                    lb_BMadanhmuc.Height = pn_BMadanhmuc.Height;
                    lb_BMadanhmuc.Name = "lb_BMadanhmuc_" + dt.Rows[i].ItemArray[0].ToString();
                    lb_BMadanhmuc.Text = dt.Rows[i].ItemArray[0].ToString();
                    lb_BMadanhmuc.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BMadanhmuc.Location = new Point(0, 0);
                    pn_BMadanhmuc.Controls.Add(lb_BMadanhmuc);

                    pn_BChucnang.Size = new Size(crpnBChucnang, cc);
                    pn_BChucnang.Location = new Point(pn_BMadanhmuc.Location.X + pn_BMadanhmuc.Width - 1, -1);

                    string imgLuu = "C:\\DBMA\\save-row.png";
                    string imgHuy = "C:\\DBMA\\can-row.png";
                    btn_BLuu.Image = Image.FromFile(imgLuu);
                    btn_BLuu.Width = 25;
                    btn_BLuu.Height = 25;
                    btn_BHuy.Image = Image.FromFile(imgHuy);
                    btn_BHuy.Width = 25;
                    btn_BHuy.Height = 25;
                    btn_BLuu.Location = new Point((pn_BChucnang.Width / 2) - btn_BLuu.Width - 2, (pn_BChucnang.Height / 2 - 12));
                    btn_BHuy.Location = new Point((pn_BChucnang.Width / 2) + 2, (pn_BChucnang.Height / 2 - 12));
                    btn_BLuu.Click += Btn_BLuu_Click;
                    btn_BHuy.Click += Btn_BHuy_Click;
                    btn_BLuu.Tag = dt.Rows[i].ItemArray[0].ToString();
                    pn_BChucnang.Controls.Add(btn_BLuu);
                    pn_BChucnang.Controls.Add(btn_BHuy);

                    pn_Row.Controls.Add(pn_BChon);
                    pn_Row.Controls.Add(pn_BTendanhmuc);
                    pn_Row.Controls.Add(pn_BMadanhmuc);
                    pn_Row.Controls.Add(pn_BChucnang);
                }
                else
                {
                    pn_BChon.Size = new Size(crpnBChon, cc);
                    pn_BChon.Location = new Point(-1, -1);

                    cb_Row.Width = 14;
                    cb_Row.Height = 14;
                    cb_Row.Location = new Point((pn_BChon.Width / 2) - (cb_Row.Width / 2), (pn_BChon.Height / 2) - (cb_Row.Height / 2));
                    pn_BChon.Controls.Add(cb_Row);

                    pn_BTendanhmuc.Size = new Size(crpnBTemonan, cc);
                    pn_BTendanhmuc.Location = new Point(pn_BChon.Location.X + pn_BChon.Width - 1, -1);

                    lb_BTendanhmuc.Width = pn_BTendanhmuc.Width;
                    lb_BTendanhmuc.Height = pn_BTendanhmuc.Height;
                    lb_BTendanhmuc.Text = dt.Rows[i].ItemArray[1].ToString();
                    lb_BTendanhmuc.TextAlign = ContentAlignment.MiddleLeft;
                    lb_BTendanhmuc.Location = new Point(0, 0);
                    pn_BTendanhmuc.Controls.Add(lb_BTendanhmuc);

                    pn_BMadanhmuc.Size = new Size(crpnBMamonan, cc);
                    pn_BMadanhmuc.Location = new Point(pn_BTendanhmuc.Location.X + pn_BTendanhmuc.Width - 1, -1);

                    lb_BMadanhmuc.Width = pn_BMadanhmuc.Width;
                    lb_BMadanhmuc.Height = pn_BMadanhmuc.Height;
                    lb_BMadanhmuc.Text = dt.Rows[i].ItemArray[0].ToString();
                    lb_BMadanhmuc.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BMadanhmuc.Location = new Point(0, 0);
                    pn_BMadanhmuc.Controls.Add(lb_BMadanhmuc);

                    pn_BChucnang.Size = new Size(crpnBChucnang, cc);
                    pn_BChucnang.Location = new Point(pn_BMadanhmuc.Location.X + pn_BMadanhmuc.Width - 1, -1);

                    string imgSua = "C:\\DBMA\\edit-row.png";
                    string imgXoa = "C:\\DBMA\\del-row.png";
                    btn_BSua.Image = Image.FromFile(imgSua);
                    btn_BSua.Width = 25;
                    btn_BSua.Height = 25;
                    btn_BXoa.Image = Image.FromFile(imgXoa);
                    btn_BXoa.Width = 25;
                    btn_BXoa.Height = 25;
                    btn_BSua.Location = new Point((pn_BChucnang.Width / 2) - btn_BSua.Width - 2, (pn_BChucnang.Height / 2 - 12));
                    btn_BXoa.Location = new Point((pn_BChucnang.Width / 2) + 2, (pn_BChucnang.Height / 2 - 12));
                    btn_BSua.Click += Btn_BSua_Click;
                    btn_BSua.Tag = dt.Rows[i].ItemArray[0].ToString();
                    pn_BChucnang.Controls.Add(btn_BSua);
                    pn_BChucnang.Controls.Add(btn_BXoa);
                    pn_BChucnang.Enabled = false;

                    pn_Row.Controls.Add(pn_BChon);
                    pn_Row.Controls.Add(pn_BTendanhmuc);
                    pn_Row.Controls.Add(pn_BMadanhmuc);
                    pn_Row.Controls.Add(pn_BChucnang);
                }
                panel_DSDM.Controls.Add(pn_Row);
            }
        }

        private void Btn_BHuy_Click(object sender, EventArgs e)
        {
            VeHeadBangDanhSachDanhMuc();
            VeBodyBangDanhSachDanhMuc(dmBUS.LoadDanhMuc());
            ActiveControl = panel_DSDM;
        }

        private void Btn_BSua_Click(object sender, EventArgs e)
        {
            VeHeadBangDanhSachDanhMuc();
            VeBodyBangDanhSachDanhMucEdit(dmBUS.LoadDanhMuc(), (sender as Control).Tag.ToString());
            ActiveControl = panel_DSDM;
        }

        private void Btn_BLuu_Click(object sender, EventArgs e)
        {
            DTO_DanhMuc dm = new DTO_DanhMuc();
            TextBox tbTendanhmuc = (TextBox)panel_DSDM.Controls.Find("tb_BTendanhmuc_" + (sender as Control).Tag.ToString(), true).FirstOrDefault();
            Label tbMadanhmuc = (Label)panel_DSDM.Controls.Find("lb_BMadanhmuc_" + (sender as Control).Tag.ToString(), true).FirstOrDefault();
            dm.Tendanhmuc = tbTendanhmuc.Text;
            dm.Madanhmuc = tbMadanhmuc.Text;
            if (dmBUS.Capnhatdanhmuc(dm))
            {
                MessageBox.Show("Cập nhật danh mục thành công !!!", "Thông báo");
                VeHeadBangDanhSachDanhMuc();
                VeBodyBangDanhSachDanhMuc(dmBUS.LoadDanhMuc());
                ActiveControl = panel_DSDM;
            }
        }

        private void Btn_BXoa_Click(object sender, EventArgs e)
        {
            string ma = (sender as Control).Tag.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa danh mục mã " + ma + " !!!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dmBUS.Xoadanhmuc(ma))
                {
                    MessageBox.Show("Xóa món ăn thành công !!!", "Thông báo");
                    VeHeadBangDanhSachDanhMuc();
                    VeBodyBangDanhSachDanhMuc(dmBUS.LoadDanhMuc());
                    ActiveControl = panel_DSDM;
                }
            }
        }

        private void Lb_BTendanhmuc_Click(object sender, EventArgs e)
        {
            VeHeadBangDanhSachDanhMuc();
            VeBodyBangDanhSachDanhMucEdit(dmBUS.LoadDanhMuc(), (sender as Control).Tag.ToString());
            ActiveControl = panel_DSDM;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO_DanhMuc dm = new DTO_DanhMuc();
            dm.Madanhmuc = tb_Madanhmuc.Text;
            dm.Tendanhmuc = tb_Tendanhmuc.Text; 
            dmBUS.Themdanhmuc(dm);
            MessageBox.Show("Đã thêm danh mục có mã " + dm.Madanhmuc + " !!!", "Thông báo");
            LamMoiFormDM();
        }        

        void LamMoiFormDM()
        {
            tb_Madanhmuc.Text = dmBUS.TaoMaDM();
            tb_Tendanhmuc.Text = "";
            VeHeadBangDanhSachDanhMuc();
            VeBodyBangDanhSachDanhMuc(dmBUS.LoadDanhMuc());
        }
    }
}