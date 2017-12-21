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
using DTO;
using System.Drawing.Drawing2D;
using DevExpress.XtraEditors;

namespace Boquanquanly
{
    public partial class Frm_Quanly : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        BUS_MonAn busMA;
        BUS_Clock busClock;
        BUS_ChiNhanh busCN;

        public Frm_Quanly()
        {
            InitializeComponent();
            busMA = new BUS_MonAn();
            busClock = new BUS_Clock();
            busCN = new BUS_ChiNhanh();
        }

        private void Frm_Quanly_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            DataTable dtma = busMA.LoadDanhSachMonAn();
            DataTable dtcn = busCN.LoadDanhSachChiNhanh();
            VeHeadBangDanhSachMonAn();
            VeBodyBangDanhSachMonAn(dtma);

            VeHeadBangDanhSachChiNhanh();
            VeBodyBangDanhSachChiNhanh(dtcn);
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            barStaTime.Caption = busClock.TimeServer();
        }

        private void VeHeadBangDanhSachMonAn()
        {
            panel_DSMA.Controls.Clear();
            Panel pn_HChon = new Panel();
            Panel pn_HTenmonan = new Panel();
            Panel pn_HMamonan = new Panel();
            Panel pn_HSoluong = new Panel();
            Panel pn_HGiaban = new Panel();
            Panel pn_HDachmuc = new Panel();
            Panel pn_HKho = new Panel();
            Panel pn_HHinh = new Panel();
            Panel pn_HChucnang = new Panel();

            CheckBox cb_All = new CheckBox();
            Label lb_HTenmonan = new Label();
            Label lb_HMamonan = new Label();
            Label lb_HSoluong = new Label();
            Label lb_HGiaban = new Label();
            Label lb_HDanhmuc = new Label();
            Label lb_HKho = new Label();
            Label lb_HHinh = new Label();
            Label lb_HChucnang = new Label();

            int scaleHChon = 5;
            int scaleHTenmonan = 30;
            int scaleHMamonan = 10;
            int scaleHSoluong = 5;
            int scaleHGiaban = 10;
            int scaleHDanhmuc = 15;
            int scaleHKho = 5;
            int scaleHHinh = 5;
            int scaleHChucnang = 15;

            int cc = 35;
            int crpn = panel_DSMA.Width;
            int crpnHChon = (crpn * scaleHChon) / 100;
            int crpnHTemonan = (crpn * scaleHTenmonan) / 100;
            int crpnHMamonan = (crpn * scaleHMamonan) / 100;
            int crpnHSoluong = (crpn * scaleHSoluong) / 100;
            int crpnHGiaban = (crpn * scaleHGiaban) / 100;
            int crpnHDanhmuc = (crpn * scaleHDanhmuc) / 100;
            int crpnHKho = (crpn * scaleHKho) / 100;
            int crpnHHinh = (crpn * scaleHHinh) / 100;
            int crpnHChucnang = (crpn * scaleHChucnang) / 100;

            pn_HChon.BorderStyle = BorderStyle.FixedSingle;
            pn_HChon.Size = new Size(crpnHChon, cc);
            pn_HChon.Location = new Point(0, 0);

            cb_All.Width = 14;
            cb_All.Height = 14;
            cb_All.Location = new Point((pn_HChon.Width / 2) - (cb_All.Width / 2), (pn_HChon.Height / 2) - (cb_All.Height / 2));
            pn_HChon.Controls.Add(cb_All);

            pn_HTenmonan.BorderStyle = BorderStyle.FixedSingle;
            pn_HTenmonan.Size = new Size(crpnHTemonan, cc);
            pn_HTenmonan.Location = new Point(pn_HChon.Location.X + pn_HChon.Width - 1, 0);

            lb_HTenmonan.Width = pn_HTenmonan.Width;
            lb_HTenmonan.Height = pn_HTenmonan.Height;
            lb_HTenmonan.Text = "Tên món ăn";
            lb_HTenmonan.TextAlign = ContentAlignment.MiddleCenter;
            lb_HTenmonan.Location = new Point(0, 0);
            pn_HTenmonan.Controls.Add(lb_HTenmonan);

            pn_HMamonan.BorderStyle = BorderStyle.FixedSingle;
            pn_HMamonan.Size = new Size(crpnHMamonan, cc);
            pn_HMamonan.Location = new Point(pn_HTenmonan.Location.X + pn_HTenmonan.Width - 1, 0);

            lb_HMamonan.Width = pn_HMamonan.Width;
            lb_HMamonan.Height = pn_HMamonan.Height;
            lb_HMamonan.Text = "Mã món ăn";
            lb_HMamonan.TextAlign = ContentAlignment.MiddleCenter;
            lb_HMamonan.Location = new Point(0, 0);
            pn_HMamonan.Controls.Add(lb_HMamonan);

            pn_HSoluong.BorderStyle = BorderStyle.FixedSingle;
            pn_HSoluong.Size = new Size(crpnHSoluong, cc);
            pn_HSoluong.Location = new Point(pn_HMamonan.Location.X + pn_HMamonan.Width - 1, 0);

            lb_HSoluong.Width = pn_HSoluong.Width;
            lb_HSoluong.Height = pn_HSoluong.Height;
            lb_HSoluong.Text = "SL";
            lb_HSoluong.TextAlign = ContentAlignment.MiddleCenter;
            lb_HSoluong.Location = new Point(0, 0);
            pn_HSoluong.Controls.Add(lb_HSoluong);

            pn_HGiaban.BorderStyle = BorderStyle.FixedSingle;
            pn_HGiaban.Size = new Size(crpnHGiaban, cc);
            pn_HGiaban.Location = new Point(pn_HSoluong.Location.X + pn_HSoluong.Width - 1, 0);

            lb_HGiaban.Width = pn_HGiaban.Width;
            lb_HGiaban.Height = pn_HGiaban.Height;
            lb_HGiaban.Text = "Giá bán";
            lb_HGiaban.TextAlign = ContentAlignment.MiddleCenter;
            lb_HGiaban.Location = new Point(0, 0);
            pn_HGiaban.Controls.Add(lb_HGiaban);

            pn_HDachmuc.BorderStyle = BorderStyle.FixedSingle;
            pn_HDachmuc.Size = new Size(crpnHDanhmuc, cc);
            pn_HDachmuc.Location = new Point(pn_HGiaban.Location.X + pn_HGiaban.Width - 1, 0);

            lb_HDanhmuc.Width = pn_HDachmuc.Width;
            lb_HDanhmuc.Height = pn_HDachmuc.Height;
            lb_HDanhmuc.Text = "Danh mục";
            lb_HDanhmuc.TextAlign = ContentAlignment.MiddleCenter;
            lb_HDanhmuc.Location = new Point(0, 0);
            pn_HDachmuc.Controls.Add(lb_HDanhmuc);

            pn_HKho.BorderStyle = BorderStyle.FixedSingle;
            pn_HKho.Size = new Size(crpnHKho, cc);
            pn_HKho.Location = new Point(pn_HDachmuc.Location.X + pn_HDachmuc.Width - 1, 0);

            lb_HKho.Width = pn_HKho.Width;
            lb_HKho.Height = pn_HKho.Height;
            lb_HKho.Text = "Kho";
            lb_HKho.TextAlign = ContentAlignment.MiddleCenter;
            lb_HKho.Location = new Point(0, 0);
            pn_HKho.Controls.Add(lb_HKho);

            pn_HHinh.BorderStyle = BorderStyle.FixedSingle;
            pn_HHinh.Size = new Size(crpnHHinh, cc);
            pn_HHinh.Location = new Point(pn_HKho.Location.X + pn_HKho.Width - 1, 0);

            lb_HHinh.Width = pn_HHinh.Width;
            lb_HHinh.Height = pn_HHinh.Height;
            lb_HHinh.Text = "Hình";
            lb_HHinh.TextAlign = ContentAlignment.MiddleCenter;
            lb_HHinh.Location = new Point(0, 0);
            pn_HHinh.Controls.Add(lb_HHinh);

            pn_HChucnang.BorderStyle = BorderStyle.FixedSingle;
            pn_HChucnang.Size = new Size(crpnHChucnang, cc);
            pn_HChucnang.Location = new Point(pn_HHinh.Location.X + pn_HHinh.Width - 1, 0);

            lb_HChucnang.Width = pn_HChucnang.Width;
            lb_HChucnang.Height = pn_HChucnang.Height;
            lb_HChucnang.Text = "";
            lb_HChucnang.TextAlign = ContentAlignment.MiddleCenter;
            lb_HChucnang.Location = new Point(0, 0);
            pn_HChucnang.Controls.Add(lb_HChucnang);

            panel_DSMA.Controls.Add(pn_HChon);
            panel_DSMA.Controls.Add(pn_HTenmonan);
            panel_DSMA.Controls.Add(pn_HMamonan);
            panel_DSMA.Controls.Add(pn_HSoluong);
            panel_DSMA.Controls.Add(pn_HGiaban);
            panel_DSMA.Controls.Add(pn_HDachmuc);
            panel_DSMA.Controls.Add(pn_HKho);
            panel_DSMA.Controls.Add(pn_HHinh);
            panel_DSMA.Controls.Add(pn_HChucnang);
        }

        private void VeBodyBangDanhSachMonAn(DataTable dt)
        {            
            Panel pn_Row = null;
            Panel pn_BChon = null;
            Panel pn_BTenmonan = null;
            Panel pn_BMamonan = null;
            Panel pn_BSoluong = null;
            Panel pn_BGiaban = null;
            Panel pn_BDachmuc = null;
            Panel pn_BKho = null;
            Panel pn_BHinh = null;
            Panel pn_BChucnang = null;

            CheckBox cb_Row = null;
            LinkLabel lb_BTenmonan = null;
            Label lb_BMamonan = null;
            Label lb_BSoluong = null;
            Label lb_BGiaban = null;
            Label lb_BDanhmuc = null;
            Label lb_BKho = null;
            PictureBox pb_BHinh = null;
            Button btn_BSua = null;
            Button btn_BXoa = null;

            int scaleBChon = 5;
            int scaleBTenmonan = 30;
            int scaleBMamonan = 10;
            int scaleBSoluong = 5;
            int scaleBGiaban = 10;
            int scaleBDanhmuc = 15;
            int scaleBKho = 5;
            int scaleBHinh = 5;
            int scaleBChucnang = 15;

            int cc = 35;
            int crpn = panel_DSMA.Width;
            int crpnBRow = crpn;
            int crpnBChon = (crpn * scaleBChon) / 100;
            int crpnBTemonan = (crpn * scaleBTenmonan) / 100;
            int crpnBMamonan = (crpn * scaleBMamonan) / 100;
            int crpnBSoluong = (crpn * scaleBSoluong) / 100;
            int crpnBGiaban = (crpn * scaleBGiaban) / 100;
            int crpnBDanhmuc = (crpn * scaleBDanhmuc) / 100;
            int crpnBKho = (crpn * scaleBKho) / 100;
            int crpnBHinh = (crpn * scaleBHinh) / 100;
            int crpnBChucnang = (crpn * scaleBChucnang) / 100;

            int slma = busMA.Soluongmonan();

            for (int i = 0; i < slma; i++)
            {
                pn_Row = new Panel();

                pn_BChon = new Panel();
                pn_BTenmonan = new Panel();
                pn_BMamonan = new Panel();
                pn_BSoluong = new Panel();
                pn_BGiaban = new Panel();
                pn_BDachmuc = new Panel();
                pn_BKho = new Panel();
                pn_BHinh = new Panel();
                pn_BChucnang = new Panel();

                cb_Row = new CheckBox();
                lb_BTenmonan = new LinkLabel();
                lb_BMamonan = new Label();
                lb_BSoluong = new Label();
                lb_BGiaban = new Label();
                lb_BDanhmuc = new Label();
                lb_BKho = new Label();
                pb_BHinh = new PictureBox();
                btn_BSua = new Button();
                btn_BXoa = new Button();

                pn_Row.BorderStyle = BorderStyle.FixedSingle;
                pn_Row.Size = new Size(crpnBRow - 8, cc);
                pn_Row.Location = new Point(0, (cc - 1) * (i + 1));

                pn_BChon.Size = new Size(crpnBChon, cc);
                pn_BChon.Location = new Point(-1, -1);

                cb_Row.Width = 14;
                cb_Row.Height = 14;
                cb_Row.Location = new Point((pn_BChon.Width / 2) - (cb_Row.Width / 2), (pn_BChon.Height / 2) - (cb_Row.Height / 2));
                pn_BChon.Controls.Add(cb_Row);

                pn_BTenmonan.Size = new Size(crpnBTemonan, cc);
                pn_BTenmonan.Location = new Point(pn_BChon.Location.X + pn_BChon.Width - 1, -1);

                lb_BTenmonan.Width = pn_BTenmonan.Width;
                lb_BTenmonan.Height = pn_BTenmonan.Height;
                lb_BTenmonan.Text = dt.Rows[i].ItemArray[1].ToString();
                lb_BTenmonan.TextAlign = ContentAlignment.MiddleLeft;
                lb_BTenmonan.Location = new Point(0, 0);
                pn_BTenmonan.Controls.Add(lb_BTenmonan);
                lb_BTenmonan.Click += Lb_BTenmonan_Click;                

                pn_BMamonan.Size = new Size(crpnBMamonan, cc);
                pn_BMamonan.Location = new Point(pn_BTenmonan.Location.X + pn_BTenmonan.Width - 1, -1);

                lb_BMamonan.Width = pn_BMamonan.Width;
                lb_BMamonan.Height = pn_BMamonan.Height;
                lb_BMamonan.Text = dt.Rows[i].ItemArray[0].ToString();
                lb_BMamonan.TextAlign = ContentAlignment.MiddleCenter;
                lb_BMamonan.Location = new Point(0, 0);
                pn_BMamonan.Controls.Add(lb_BMamonan);

                pn_BSoluong.Size = new Size(crpnBSoluong, cc);
                pn_BSoluong.Location = new Point(pn_BMamonan.Location.X + pn_BMamonan.Width - 1, 0);

                lb_BSoluong.Width = pn_BSoluong.Width;
                lb_BSoluong.Height = pn_BSoluong.Height;
                lb_BSoluong.Text = "SL";
                lb_BSoluong.TextAlign = ContentAlignment.MiddleCenter;
                lb_BSoluong.Location = new Point(0, 0);
                pn_BSoluong.Controls.Add(lb_BSoluong);

                pn_BGiaban.Size = new Size(crpnBGiaban, cc);
                pn_BGiaban.Location = new Point(pn_BSoluong.Location.X + pn_BSoluong.Width - 1, -1);

                lb_BGiaban.Width = pn_BGiaban.Width;
                lb_BGiaban.Height = pn_BGiaban.Height;
                lb_BGiaban.Text = dt.Rows[i].ItemArray[3].ToString();
                lb_BGiaban.TextAlign = ContentAlignment.MiddleCenter;
                lb_BGiaban.Location = new Point(0, 0);
                pn_BGiaban.Controls.Add(lb_BGiaban);

                pn_BDachmuc.Size = new Size(crpnBDanhmuc, cc);
                pn_BDachmuc.Location = new Point(pn_BGiaban.Location.X + pn_BGiaban.Width - 1, 0);

                lb_BDanhmuc.Width = pn_BDachmuc.Width;
                lb_BDanhmuc.Height = pn_BDachmuc.Height;
                lb_BDanhmuc.Text = busMA.LayTenDanhMuc(dt.Rows[i].ItemArray[4].ToString());
                lb_BDanhmuc.TextAlign = ContentAlignment.MiddleCenter;
                lb_BDanhmuc.Location = new Point(0, 0);
                pn_BDachmuc.Controls.Add(lb_BDanhmuc);

                pn_BKho.Size = new Size(crpnBKho, cc);
                pn_BKho.Location = new Point(pn_BDachmuc.Location.X + pn_BDachmuc.Width - 1, 0);

                lb_BKho.Width = pn_BKho.Width;
                lb_BKho.Height = pn_BKho.Height;
                lb_BKho.Text = "Kho";
                lb_BKho.TextAlign = ContentAlignment.MiddleCenter;
                lb_BKho.Location = new Point(0, 0);
                pn_BKho.Controls.Add(lb_BKho);

                pn_BHinh.Size = new Size(crpnBHinh, cc);
                pn_BHinh.Location = new Point(pn_BKho.Location.X + pn_BKho.Width - 1, -1);

                string linkimg = dt.Rows[i].ItemArray[2].ToString();
                Image img = Resize(Image.FromFile(linkimg), 0.25f);
                pb_BHinh.Image = img;
                pb_BHinh.Location = new Point((pn_BHinh.Width / 2) - (img.Width / 2), (pn_BHinh.Height / 2) - (img.Height / 2));
                pn_BHinh.Controls.Add(pb_BHinh);

                pn_BChucnang.Size = new Size(crpnBChucnang, cc);
                pn_BChucnang.Location = new Point(pn_BHinh.Location.X + pn_BHinh.Width - 1, -1);

                string imgSua = "C:\\DBMA\\edit-row.png";
                string imgXoa = "C:\\DBMA\\del-row.png";
                btn_BSua.Image = Image.FromFile(imgSua);
                btn_BSua.Width = 25;
                btn_BSua.Height = 25;
                btn_BXoa.Image = Image.FromFile(imgXoa);
                btn_BXoa.Width = 25;
                btn_BXoa.Height = 25;
                btn_BSua.Location = new Point((pn_BChucnang.Width / 2) - btn_BSua.Width - 2, (pn_BChucnang.Height / 2 - 12));
                btn_BXoa.Location = new Point((pn_BChucnang.Width / 2) + 2 , (pn_BChucnang.Height / 2 - 12));
                btn_BSua.Click += Btn_BSua_Click;
                btn_BXoa.Click += Btn_BXoa_Click;
                btn_BSua.Tag = dt.Rows[i].ItemArray[0].ToString();
                btn_BXoa.Tag = dt.Rows[i].ItemArray[0].ToString();
                pn_BChucnang.Controls.Add(btn_BSua);
                pn_BChucnang.Controls.Add(btn_BXoa);

                DTO_MonAn ma = new DTO_MonAn();
                ma.Tenma = lb_BTenmonan.Text;
                ma.Mama = lb_BMamonan.Text;
                ma.Giaban = decimal.Parse(lb_BGiaban.Text);
                ma.Hinhanh = dt.Rows[i].ItemArray[2].ToString();
                ma.Madanhmuc = dt.Rows[i].ItemArray[4].ToString();
                lb_BTenmonan.Tag = ma;


                pn_Row.Controls.Add(pn_BChon);
                pn_Row.Controls.Add(pn_BTenmonan);
                pn_Row.Controls.Add(pn_BMamonan);
                //pn_Row.Controls.Add(pn_BSoluong);
                pn_Row.Controls.Add(pn_BGiaban);
                pn_Row.Controls.Add(pn_BDachmuc);
                //pn_Row.Controls.Add(pn_BKho);
                pn_Row.Controls.Add(pn_BHinh);
                pn_Row.Controls.Add(pn_BChucnang);

                panel_DSMA.Controls.Add(pn_Row);
            }
        }

        private void VeBodyBangDanhSachMonAnEdit(DataTable dt, string ma)
        {
            Panel pn_Row = null;
            Panel pn_BChon = null;
            Panel pn_BTenmonan = null;
            Panel pn_BMamonan = null;
            Panel pn_BSoluong = null;
            Panel pn_BGiaban = null;
            Panel pn_BDachmuc = null;
            Panel pn_BKho = null;
            Panel pn_BHinh = null;
            Panel pn_BChucnang = null;

            CheckBox cb_Row = null;
            TextBox tb_BTenmonan = null;
            TextBox tb_BGiaban = null;
            Label lb_BTenmonan = null;
            Label lb_BMamonan = null;
            Label lb_BSoluong = null;
            Label lb_BGiaban = null;
            Label lb_BDanhmuc = null;
            Label lb_BKho = null;
            PictureBox pb_BHinh = null;
            Button btn_BSua = null;
            Button btn_BXoa = null;
            Button btn_BLuu = null;
            Button btn_BHuy = null;

            int scaleBChon = 5;
            int scaleBTenmonan = 30;
            int scaleBMamonan = 10;
            int scaleBSoluong = 5;
            int scaleBGiaban = 10;
            int scaleBDanhmuc = 15;
            int scaleBKho = 5;
            int scaleBHinh = 5;
            int scaleBChucnang = 15;

            int cc = 35;
            int crpn = panel_DSMA.Width;
            int crpnBRow = crpn;
            int crpnBChon = (crpn * scaleBChon) / 100;
            int crpnBTemonan = (crpn * scaleBTenmonan) / 100;
            int crpnBMamonan = (crpn * scaleBMamonan) / 100;
            int crpnBSoluong = (crpn * scaleBSoluong) / 100;
            int crpnBGiaban = (crpn * scaleBGiaban) / 100;
            int crpnBDanhmuc = (crpn * scaleBDanhmuc) / 100;
            int crpnBKho = (crpn * scaleBKho) / 100;
            int crpnBHinh = (crpn * scaleBHinh) / 100;
            int crpnBChucnang = (crpn * scaleBChucnang) / 100;

            int slma = busMA.Soluongmonan();

            for (int i = 0; i < slma; i++)
            {
                pn_Row = new Panel();

                pn_BChon = new Panel();
                pn_BTenmonan = new Panel();
                pn_BMamonan = new Panel();
                pn_BSoluong = new Panel();
                pn_BGiaban = new Panel();
                pn_BDachmuc = new Panel();
                pn_BKho = new Panel();
                pn_BHinh = new Panel();
                pn_BChucnang = new Panel();

                cb_Row = new CheckBox();
                tb_BTenmonan = new TextBox();
                tb_BGiaban = new TextBox();
                lb_BTenmonan = new Label();
                lb_BMamonan = new Label();
                lb_BSoluong = new Label();
                lb_BGiaban = new Label();
                lb_BDanhmuc = new Label();
                lb_BKho = new Label();
                pb_BHinh = new PictureBox();
                btn_BSua = new Button();
                btn_BXoa = new Button();
                btn_BLuu = new Button();
                btn_BHuy = new Button();

                pn_Row.BorderStyle = BorderStyle.FixedSingle;
                pn_Row.Size = new Size(crpnBRow - 8, cc);
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

                    pn_BTenmonan.Name = "pn_BTenmonan_" + dt.Rows[i].ItemArray[0].ToString();
                    pn_BTenmonan.Size = new Size(crpnBTemonan, cc);
                    pn_BTenmonan.Location = new Point(pn_BChon.Location.X + pn_BChon.Width - 1, -1);

                    tb_BTenmonan.Width = pn_BTenmonan.Width - 5;
                    tb_BTenmonan.Height = pn_BTenmonan.Height - 5;
                    tb_BTenmonan.Text = dt.Rows[i].ItemArray[1].ToString();
                    tb_BTenmonan.Name = "tb_BTenmonan_" + dt.Rows[i].ItemArray[0].ToString();
                    tb_BTenmonan.Location = new Point((pn_BTenmonan.Width / 2) - (tb_BTenmonan.Width / 2), (pn_BTenmonan.Height / 2) - (tb_BTenmonan.Height / 2));
                    pn_BTenmonan.Controls.Add(tb_BTenmonan);

                    pn_BMamonan.Size = new Size(crpnBMamonan, cc);
                    pn_BMamonan.Location = new Point(pn_BTenmonan.Location.X + pn_BTenmonan.Width - 1, -1);

                    lb_BMamonan.Width = pn_BMamonan.Width;
                    lb_BMamonan.Height = pn_BMamonan.Height;
                    lb_BMamonan.Text = dt.Rows[i].ItemArray[0].ToString();
                    lb_BMamonan.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BMamonan.Location = new Point(0, 0);
                    pn_BMamonan.Controls.Add(lb_BMamonan);

                    pn_BSoluong.Size = new Size(crpnBSoluong, cc);
                    pn_BSoluong.Location = new Point(pn_BMamonan.Location.X + pn_BMamonan.Width - 1, 0);

                    lb_BSoluong.Width = pn_BSoluong.Width;
                    lb_BSoluong.Height = pn_BSoluong.Height;
                    lb_BSoluong.Text = "SL";
                    lb_BSoluong.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BSoluong.Location = new Point(0, 0);
                    pn_BSoluong.Controls.Add(lb_BSoluong);

                    pn_BGiaban.Size = new Size(crpnBGiaban, cc);
                    pn_BGiaban.Location = new Point(pn_BSoluong.Location.X + pn_BSoluong.Width - 1, -1);

                    tb_BGiaban.Width = pn_BGiaban.Width - 5;
                    tb_BGiaban.Height = pn_BGiaban.Height - 5;
                    tb_BGiaban.Text = dt.Rows[i].ItemArray[3].ToString();
                    tb_BGiaban.Name = "tb_BGiaban_" + dt.Rows[i].ItemArray[0].ToString();
                    tb_BGiaban.Location = new Point((pn_BGiaban.Width / 2) - (tb_BGiaban.Width / 2), (pn_BGiaban.Height / 2) - (tb_BGiaban.Height / 2));
                    pn_BGiaban.Controls.Add(tb_BGiaban);

                    pn_BDachmuc.Size = new Size(crpnBDanhmuc, cc);
                    pn_BDachmuc.Location = new Point(pn_BGiaban.Location.X + pn_BGiaban.Width - 1, 0);

                    lb_BDanhmuc.Width = pn_BDachmuc.Width;
                    lb_BDanhmuc.Height = pn_BDachmuc.Height;
                    lb_BDanhmuc.Text = busMA.LayTenDanhMuc(dt.Rows[i].ItemArray[4].ToString());
                    lb_BDanhmuc.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BDanhmuc.Location = new Point(0, 0);
                    pn_BDachmuc.Controls.Add(lb_BDanhmuc);

                    pn_BKho.Size = new Size(crpnBKho, cc);
                    pn_BKho.Location = new Point(pn_BDachmuc.Location.X + pn_BDachmuc.Width - 1, 0);

                    lb_BKho.Width = pn_BKho.Width;
                    lb_BKho.Height = pn_BKho.Height;
                    lb_BKho.Text = "Kho";
                    lb_BKho.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BKho.Location = new Point(0, 0);
                    pn_BKho.Controls.Add(lb_BKho);

                    pn_BHinh.Size = new Size(crpnBHinh, cc);
                    pn_BHinh.Location = new Point(pn_BKho.Location.X + pn_BKho.Width - 1, -1);

                    string linkimg = dt.Rows[i].ItemArray[2].ToString();
                    Image img = Resize(Image.FromFile(linkimg), 0.25f);
                    pb_BHinh.Image = img;
                    pb_BHinh.Location = new Point((pn_BHinh.Width / 2) - (img.Width / 2), (pn_BHinh.Height / 2) - (img.Height / 2));
                    pn_BHinh.Controls.Add(pb_BHinh);

                    pn_BChucnang.Size = new Size(crpnBChucnang, cc);
                    pn_BChucnang.Location = new Point(pn_BHinh.Location.X + pn_BHinh.Width - 1, -1);

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
                    pn_Row.Controls.Add(pn_BTenmonan);
                    pn_Row.Controls.Add(pn_BMamonan);
                    //pn_Row.Controls.Add(pn_BSoluong);
                    pn_Row.Controls.Add(pn_BGiaban);
                    pn_Row.Controls.Add(pn_BDachmuc);
                    //pn_Row.Controls.Add(pn_BKho);
                    pn_Row.Controls.Add(pn_BHinh);
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

                    pn_BTenmonan.Size = new Size(crpnBTemonan, cc);
                    pn_BTenmonan.Location = new Point(pn_BChon.Location.X + pn_BChon.Width - 1, -1);

                    lb_BTenmonan.Width = pn_BTenmonan.Width;
                    lb_BTenmonan.Height = pn_BTenmonan.Height;
                    lb_BTenmonan.Text = dt.Rows[i].ItemArray[1].ToString();
                    lb_BTenmonan.TextAlign = ContentAlignment.MiddleLeft;
                    lb_BTenmonan.Location = new Point(0, 0);
                    pn_BTenmonan.Controls.Add(lb_BTenmonan);

                    pn_BMamonan.Size = new Size(crpnBMamonan, cc);
                    pn_BMamonan.Location = new Point(pn_BTenmonan.Location.X + pn_BTenmonan.Width - 1, -1);

                    lb_BMamonan.Width = pn_BMamonan.Width;
                    lb_BMamonan.Height = pn_BMamonan.Height;
                    lb_BMamonan.Text = dt.Rows[i].ItemArray[0].ToString();
                    lb_BMamonan.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BMamonan.Location = new Point(0, 0);
                    pn_BMamonan.Controls.Add(lb_BMamonan);

                    pn_BSoluong.Size = new Size(crpnBSoluong, cc);
                    pn_BSoluong.Location = new Point(pn_BMamonan.Location.X + pn_BMamonan.Width - 1, 0);

                    lb_BSoluong.Width = pn_BSoluong.Width;
                    lb_BSoluong.Height = pn_BSoluong.Height;
                    lb_BSoluong.Text = "SL";
                    lb_BSoluong.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BSoluong.Location = new Point(0, 0);
                    pn_BSoluong.Controls.Add(lb_BSoluong);

                    pn_BGiaban.Size = new Size(crpnBGiaban, cc);
                    pn_BGiaban.Location = new Point(pn_BSoluong.Location.X + pn_BSoluong.Width - 1, -1);

                    lb_BGiaban.Width = pn_BGiaban.Width;
                    lb_BGiaban.Height = pn_BGiaban.Height;
                    lb_BGiaban.Text = dt.Rows[i].ItemArray[3].ToString();
                    lb_BGiaban.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BGiaban.Location = new Point(0, 0);
                    pn_BGiaban.Controls.Add(lb_BGiaban);

                    pn_BDachmuc.Size = new Size(crpnBDanhmuc, cc);
                    pn_BDachmuc.Location = new Point(pn_BGiaban.Location.X + pn_BGiaban.Width - 1, 0);

                    lb_BDanhmuc.Width = pn_BDachmuc.Width;
                    lb_BDanhmuc.Height = pn_BDachmuc.Height;
                    lb_BDanhmuc.Text = busMA.LayTenDanhMuc(dt.Rows[i].ItemArray[4].ToString());
                    lb_BDanhmuc.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BDanhmuc.Location = new Point(0, 0);
                    pn_BDachmuc.Controls.Add(lb_BDanhmuc);

                    pn_BKho.Size = new Size(crpnBKho, cc);
                    pn_BKho.Location = new Point(pn_BDachmuc.Location.X + pn_BDachmuc.Width - 1, 0);

                    lb_BKho.Width = pn_BKho.Width;
                    lb_BKho.Height = pn_BKho.Height;
                    lb_BKho.Text = "Kho";
                    lb_BKho.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BKho.Location = new Point(0, 0);
                    pn_BKho.Controls.Add(lb_BKho);

                    pn_BHinh.Size = new Size(crpnBHinh, cc);
                    pn_BHinh.Location = new Point(pn_BKho.Location.X + pn_BKho.Width - 1, -1);

                    string linkimg = dt.Rows[i].ItemArray[2].ToString();
                    Image img = Resize(Image.FromFile(linkimg), 0.25f);
                    pb_BHinh.Image = img;
                    pb_BHinh.Location = new Point((pn_BHinh.Width / 2) - (img.Width / 2), (pn_BHinh.Height / 2) - (img.Height / 2));
                    pn_BHinh.Controls.Add(pb_BHinh);

                    pn_BChucnang.Size = new Size(crpnBChucnang, cc);
                    pn_BChucnang.Location = new Point(pn_BHinh.Location.X + pn_BHinh.Width - 1, -1);

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
                    pn_Row.Controls.Add(pn_BTenmonan);
                    pn_Row.Controls.Add(pn_BMamonan);
                    //pn_Row.Controls.Add(pn_BSoluong);
                    pn_Row.Controls.Add(pn_BGiaban);
                    pn_Row.Controls.Add(pn_BDachmuc);
                    //pn_Row.Controls.Add(pn_BKho);
                    pn_Row.Controls.Add(pn_BHinh);
                    pn_Row.Controls.Add(pn_BChucnang);
                }
                panel_DSMA.Controls.Add(pn_Row);
            }
        }

        private void VeHeadBangDanhSachChiNhanh()
        {
            pnCN.Controls.Clear();
            Panel pn_HChon = new Panel();
            Panel pn_HTenchinhanh = new Panel();
            Panel pn_HMachinhanh = new Panel();
            Panel pn_HDiachi = new Panel();
            Panel pn_HDienthoai = new Panel();
            Panel pn_HTinhthanh = new Panel();
            Panel pn_HBan = new Panel();
            Panel pn_HMenu = new Panel();
            Panel pn_HChucnang = new Panel();

            CheckBox cb_All = new CheckBox();
            Label lb_HTenchinhanh = new Label();
            Label lb_HMachinhanh = new Label();
            Label lb_HDiachi = new Label();
            Label lb_HDienthoai = new Label();
            Label lb_HTinhthanh = new Label();
            Label lb_HBan = new Label();
            Label lb_HMenu = new Label();
            Label lb_HChucnang = new Label();

            int scaleHChon = 5;
            int scaleHTenchinhanh = 30;
            int scaleHMachinhanh = 10;
            int scaleHDiachi = 5;
            int scaleHDienthoai = 10;
            int scaleHTinhthanh = 15;
            int scaleHBan = 5;
            int scaleHMenu = 5;
            int scaleHChucnang = 15;

            int cc = 35;
            int crpn = panel_DSMA.Width;
            int crpnHChon = (crpn * scaleHChon) / 100;
            int crpnHTenchinhanh = (crpn * scaleHTenchinhanh) / 100;
            int crpnHMachinhanh = (crpn * scaleHMachinhanh) / 100;
            int crpnHDiachi = (crpn * scaleHDiachi) / 100;
            int crpnHDienthoai = (crpn * scaleHDienthoai) / 100;
            int crpnHTinhthanh = (crpn * scaleHTinhthanh) / 100;
            int crpnHBan = (crpn * scaleHBan) / 100;
            int crpnHMenu = (crpn * scaleHMenu) / 100;
            int crpnHChucnang = (crpn * scaleHChucnang) / 100;

            pn_HChon.BorderStyle = BorderStyle.FixedSingle;
            pn_HChon.Size = new Size(crpnHChon, cc);
            pn_HChon.Location = new Point(0, 0);

            cb_All.Width = 14;
            cb_All.Height = 14;
            cb_All.Location = new Point((pn_HChon.Width / 2) - (cb_All.Width / 2), (pn_HChon.Height / 2) - (cb_All.Height / 2));
            pn_HChon.Controls.Add(cb_All);

            pn_HTenchinhanh.BorderStyle = BorderStyle.FixedSingle;
            pn_HTenchinhanh.Size = new Size(crpnHTenchinhanh, cc);
            pn_HTenchinhanh.Location = new Point(pn_HChon.Location.X + pn_HChon.Width - 1, 0);

            lb_HTenchinhanh.Width = pn_HTenchinhanh.Width;
            lb_HTenchinhanh.Height = pn_HTenchinhanh.Height;
            lb_HTenchinhanh.Text = "Tên chi nhánh";
            lb_HTenchinhanh.TextAlign = ContentAlignment.MiddleCenter;
            lb_HTenchinhanh.Location = new Point(0, 0);
            pn_HTenchinhanh.Controls.Add(lb_HTenchinhanh);

            pn_HMachinhanh.BorderStyle = BorderStyle.FixedSingle;
            pn_HMachinhanh.Size = new Size(crpnHMachinhanh, cc);
            pn_HMachinhanh.Location = new Point(pn_HTenchinhanh.Location.X + pn_HTenchinhanh.Width - 1, 0);

            lb_HMachinhanh.Width = pn_HMachinhanh.Width;
            lb_HMachinhanh.Height = pn_HMachinhanh.Height;
            lb_HMachinhanh.Text = "Mã chi nhánh";
            lb_HMachinhanh.TextAlign = ContentAlignment.MiddleCenter;
            lb_HMachinhanh.Location = new Point(0, 0);
            pn_HMachinhanh.Controls.Add(lb_HMachinhanh);

            pn_HDiachi.BorderStyle = BorderStyle.FixedSingle;
            pn_HDiachi.Size = new Size(crpnHDiachi, cc);
            pn_HDiachi.Location = new Point(pn_HMachinhanh.Location.X + pn_HMachinhanh.Width - 1, 0);

            lb_HDiachi.Width = pn_HDiachi.Width;
            lb_HDiachi.Height = pn_HDiachi.Height;
            lb_HDiachi.Text = "Địa chỉ";
            lb_HDiachi.TextAlign = ContentAlignment.MiddleCenter;
            lb_HDiachi.Location = new Point(0, 0);
            pn_HDiachi.Controls.Add(lb_HDiachi);

            pn_HDienthoai.BorderStyle = BorderStyle.FixedSingle;
            pn_HDienthoai.Size = new Size(crpnHDienthoai, cc);
            pn_HDienthoai.Location = new Point(pn_HDiachi.Location.X + pn_HDiachi.Width - 1, 0);

            lb_HDienthoai.Width = pn_HDienthoai.Width;
            lb_HDienthoai.Height = pn_HDienthoai.Height;
            lb_HDienthoai.Text = "Điện thoại";
            lb_HDienthoai.TextAlign = ContentAlignment.MiddleCenter;
            lb_HDienthoai.Location = new Point(0, 0);
            pn_HDienthoai.Controls.Add(lb_HDienthoai);

            pn_HTinhthanh.BorderStyle = BorderStyle.FixedSingle;
            pn_HTinhthanh.Size = new Size(crpnHTinhthanh, cc);
            pn_HTinhthanh.Location = new Point(pn_HDienthoai.Location.X + pn_HDienthoai.Width - 1, 0);

            lb_HTinhthanh.Width = pn_HTinhthanh.Width;
            lb_HTinhthanh.Height = pn_HTinhthanh.Height;
            lb_HTinhthanh.Text = "Tỉnh thành";
            lb_HTinhthanh.TextAlign = ContentAlignment.MiddleCenter;
            lb_HTinhthanh.Location = new Point(0, 0);
            pn_HTinhthanh.Controls.Add(lb_HTinhthanh);

            pn_HBan.BorderStyle = BorderStyle.FixedSingle;
            pn_HBan.Size = new Size(crpnHBan, cc);
            pn_HBan.Location = new Point(pn_HTinhthanh.Location.X + pn_HTinhthanh.Width - 1, 0);

            lb_HBan.Width = pn_HBan.Width;
            lb_HBan.Height = pn_HBan.Height;
            lb_HBan.Text = "Số lượng bàn";
            lb_HBan.TextAlign = ContentAlignment.MiddleCenter;
            lb_HBan.Location = new Point(0, 0);
            pn_HBan.Controls.Add(lb_HBan);

            pn_HMenu.BorderStyle = BorderStyle.FixedSingle;
            pn_HMenu.Size = new Size(crpnHMenu, cc);
            pn_HMenu.Location = new Point(pn_HBan.Location.X + pn_HBan.Width - 1, 0);

            lb_HMenu.Width = pn_HMenu.Width;
            lb_HMenu.Height = pn_HMenu.Height;
            lb_HMenu.Text = "Menu";
            lb_HMenu.TextAlign = ContentAlignment.MiddleCenter;
            lb_HMenu.Location = new Point(0, 0);
            pn_HMenu.Controls.Add(lb_HMenu);

            pn_HChucnang.BorderStyle = BorderStyle.FixedSingle;
            pn_HChucnang.Size = new Size(crpnHChucnang, cc);
            pn_HChucnang.Location = new Point(pn_HMenu.Location.X + pn_HMenu.Width - 1, 0);

            lb_HChucnang.Width = pn_HChucnang.Width;
            lb_HChucnang.Height = pn_HChucnang.Height;
            lb_HChucnang.Text = "";
            lb_HChucnang.TextAlign = ContentAlignment.MiddleCenter;
            lb_HChucnang.Location = new Point(0, 0);
            pn_HChucnang.Controls.Add(lb_HChucnang);

            pnCN.Controls.Add(pn_HChon);
            pnCN.Controls.Add(pn_HTenchinhanh);
            pnCN.Controls.Add(pn_HMachinhanh);
            pnCN.Controls.Add(pn_HDiachi);
            pnCN.Controls.Add(pn_HDienthoai);
            pnCN.Controls.Add(pn_HTinhthanh);
            pnCN.Controls.Add(pn_HBan);
            pnCN.Controls.Add(pn_HMenu);
            pnCN.Controls.Add(pn_HChucnang);
        }

        private void VeBodyBangDanhSachChiNhanh(DataTable dt)
        {
            Panel pn_Row = null;
            Panel pn_BChon = null;
            Panel pn_BTenchinhanh = null;
            Panel pn_BMachinhanh = null;
            Panel pn_BDiachi = null;
            Panel pn_BDienthoai = null;
            Panel pn_BTinhthanh = null;
            Panel pn_BBan = null;
            Panel pn_BMenu = null;
            Panel pn_BChucnang = null;

            CheckBox cb_Row = null;
            LinkLabel lb_BTenchinhanh = null;
            Label lb_BMachinhanh = null;
            Label lb_BDiachi = null;
            Label lb_BDienthoai = null;
            Label lb_BTinhthanh = null;
            Label lb_BBan = null;
            SimpleButton btn_BMenu = null;
            SimpleButton btn_BSua = null;
            SimpleButton btn_BXoa = null;

            int scaleBChon = 5;
            int scaleBTenchinhanh = 30;
            int scaleBMachinhanh = 10;
            int scaleBDiachi = 5;
            int scaleBDienthoai = 10;
            int scaleBDanhmuc = 15;
            int scaleBBan = 5;
            int scaleBMenu = 5;
            int scaleBChucnang = 15;

            int cc = 35;
            int crpn = panel_DSMA.Width;
            int crpnBRow = crpn;
            int crpnBChon = (crpn * scaleBChon) / 100;
            int crpnBTenchinhanh = (crpn * scaleBTenchinhanh) / 100;
            int crpnBMachinhanh = (crpn * scaleBMachinhanh) / 100;
            int crpnBDiachi = (crpn * scaleBDiachi) / 100;
            int crpnBDienthoai = (crpn * scaleBDienthoai) / 100;
            int crpnBDanhmuc = (crpn * scaleBDanhmuc) / 100;
            int crpnBBan = (crpn * scaleBBan) / 100;
            int crpnBMenu = (crpn * scaleBMenu) / 100;
            int crpnBChucnang = (crpn * scaleBChucnang) / 100;

            int slma = busCN.Soluongchinhanh();

            for (int i = 0; i < slma; i++)
            {
                pn_Row = new Panel();

                pn_BChon = new Panel();
                pn_BTenchinhanh = new Panel();
                pn_BMachinhanh = new Panel();
                pn_BDiachi = new Panel();
                pn_BDienthoai = new Panel();
                pn_BTinhthanh = new Panel();
                pn_BBan = new Panel();
                pn_BMenu = new Panel();
                pn_BChucnang = new Panel();

                cb_Row = new CheckBox();
                lb_BTenchinhanh = new LinkLabel();
                lb_BMachinhanh = new Label();
                lb_BDiachi = new Label();
                lb_BDienthoai = new Label();
                lb_BTinhthanh = new Label();
                lb_BBan = new Label();
                btn_BMenu = new SimpleButton();
                btn_BSua = new SimpleButton();
                btn_BXoa = new SimpleButton();

                pn_Row.BorderStyle = BorderStyle.FixedSingle;
                pn_Row.Size = new Size(crpnBRow - 8, cc);
                pn_Row.Location = new Point(0, (cc - 1) * (i + 1));

                pn_BChon.Size = new Size(crpnBChon, cc);
                pn_BChon.Location = new Point(-1, -1);

                cb_Row.Width = 14;
                cb_Row.Height = 14;
                cb_Row.Location = new Point((pn_BChon.Width / 2) - (cb_Row.Width / 2), (pn_BChon.Height / 2) - (cb_Row.Height / 2));
                pn_BChon.Controls.Add(cb_Row);

                pn_BTenchinhanh.Size = new Size(crpnBTenchinhanh, cc);
                pn_BTenchinhanh.Location = new Point(pn_BChon.Location.X + pn_BChon.Width - 1, -1);

                lb_BTenchinhanh.Width = pn_BTenchinhanh.Width;
                lb_BTenchinhanh.Height = pn_BTenchinhanh.Height;
                lb_BTenchinhanh.Text = dt.Rows[i].ItemArray[1].ToString();
                lb_BTenchinhanh.Name = "lb_BTenchinhanh_" + dt.Rows[i].ItemArray[0].ToString();
                lb_BTenchinhanh.TextAlign = ContentAlignment.MiddleLeft;
                lb_BTenchinhanh.Location = new Point(0, 0);
                pn_BTenchinhanh.Controls.Add(lb_BTenchinhanh);
                //lb_BTenchinhanh.Click += Lb_BTenchinhanh_Click;

                pn_BMachinhanh.Size = new Size(crpnBMachinhanh, cc);
                pn_BMachinhanh.Location = new Point(pn_BTenchinhanh.Location.X + pn_BTenchinhanh.Width - 1, -1);

                lb_BMachinhanh.Width = pn_BMachinhanh.Width;
                lb_BMachinhanh.Height = pn_BMachinhanh.Height;
                lb_BMachinhanh.Text = dt.Rows[i].ItemArray[0].ToString();
                lb_BMachinhanh.Name = "lb_BMachinhanh_" + dt.Rows[i].ItemArray[0].ToString();
                lb_BMachinhanh.TextAlign = ContentAlignment.MiddleCenter;
                lb_BMachinhanh.Location = new Point(0, 0);
                pn_BMachinhanh.Controls.Add(lb_BMachinhanh);

                pn_BDiachi.Size = new Size(crpnBDiachi, cc);
                pn_BDiachi.Location = new Point(pn_BMachinhanh.Location.X + pn_BMachinhanh.Width - 1, 0);

                lb_BDiachi.Width = pn_BDiachi.Width;
                lb_BDiachi.Height = pn_BDiachi.Height;
                lb_BDiachi.Text = dt.Rows[i].ItemArray[3].ToString();
                lb_BDiachi.TextAlign = ContentAlignment.MiddleCenter;
                lb_BDiachi.Location = new Point(0, 0);
                pn_BDiachi.Controls.Add(lb_BDiachi);

                pn_BDienthoai.Size = new Size(crpnBDienthoai, cc);
                pn_BDienthoai.Location = new Point(pn_BDiachi.Location.X + pn_BDiachi.Width - 1, -1);

                lb_BDienthoai.Width = pn_BDienthoai.Width;
                lb_BDienthoai.Height = pn_BDienthoai.Height;
                lb_BDienthoai.Text = dt.Rows[i].ItemArray[2].ToString();
                lb_BDienthoai.TextAlign = ContentAlignment.MiddleCenter;
                lb_BDienthoai.Location = new Point(0, 0);
                pn_BDienthoai.Controls.Add(lb_BDienthoai);

                pn_BTinhthanh.Size = new Size(crpnBDanhmuc, cc);
                pn_BTinhthanh.Location = new Point(pn_BDienthoai.Location.X + pn_BDienthoai.Width - 1, 0);

                lb_BTinhthanh.Width = pn_BTinhthanh.Width;
                lb_BTinhthanh.Height = pn_BTinhthanh.Height;
                lb_BTinhthanh.Text = dt.Rows[i].ItemArray[4].ToString();
                lb_BTinhthanh.TextAlign = ContentAlignment.MiddleCenter;
                lb_BTinhthanh.Location = new Point(0, 0);
                pn_BTinhthanh.Controls.Add(lb_BTinhthanh);

                pn_BBan.Size = new Size(crpnBBan, cc);
                pn_BBan.Location = new Point(pn_BTinhthanh.Location.X + pn_BTinhthanh.Width - 1, 0);

                lb_BBan.Width = pn_BBan.Width;
                lb_BBan.Height = pn_BBan.Height;
                lb_BBan.Text = dt.Rows[i].ItemArray[5].ToString();
                lb_BBan.TextAlign = ContentAlignment.MiddleCenter;
                lb_BBan.Location = new Point(0, 0);
                pn_BBan.Controls.Add(lb_BBan);


                pn_BMenu.Size = new Size(crpnBMenu, cc);
                pn_BBan.Location = new Point(pn_BTinhthanh.Location.X + pn_BTinhthanh.Width - 1, 0);

                string imgMenu = "C:\\DBMA\\qlmenu.png";
                btn_BMenu.ImageOptions.Image = Image.FromFile(imgMenu);
                btn_BMenu.ImageOptions.Location = ImageLocation.MiddleCenter;
                btn_BMenu.Size = new Size(btn_BMenu.ImageOptions.Image.Width, btn_BMenu.ImageOptions.Image.Height);
                btn_BMenu.Location = new Point(pn_BBan.Width / 2 - btn_BMenu.Size.Width / 2, pn_BBan.Height / 2 - btn_BMenu.Size.Height / 2);
                pn_BMenu.Location = new Point(pn_BBan.Location.X + pn_BBan.Width - 1, -1);
                pn_BMenu.Controls.Add(btn_BMenu);
                btn_BMenu.Click += Btn_BMenu_Click;
                btn_BMenu.Tag = dt.Rows[i].ItemArray[0].ToString();


                pn_BChucnang.Size = new Size(crpnBChucnang, cc);
                pn_BChucnang.Location = new Point(pn_BMenu.Location.X + pn_BMenu.Width - 1, -1);

                string imgSua = "C:\\DBMA\\edit-row.png";
                string imgXoa = "C:\\DBMA\\del-row.png";
                btn_BSua.ImageOptions.Image = Image.FromFile(imgSua);
                btn_BXoa.ImageOptions.Image = Image.FromFile(imgXoa);
                btn_BSua.ImageOptions.Location = ImageLocation.MiddleCenter;
                btn_BXoa.ImageOptions.Location = ImageLocation.MiddleCenter;
                btn_BSua.Size = new Size(btn_BSua.ImageOptions.Image.Width, btn_BSua.ImageOptions.Image.Height);
                btn_BXoa.Size = new Size(btn_BXoa.ImageOptions.Image.Width, btn_BXoa.ImageOptions.Image.Height);
                btn_BSua.Location = new Point((pn_BChucnang.Width / 2) - btn_BSua.Width - 2, (pn_BChucnang.Height / 2 - 12));
                btn_BXoa.Location = new Point((pn_BChucnang.Width / 2) + 2, (pn_BChucnang.Height / 2 - 12));
                btn_BSua.Click += Btn_BSuaCN_Click;
                btn_BXoa.Click += Btn_BXoaCN_Click;
                btn_BSua.Tag = dt.Rows[i].ItemArray[0].ToString();
                btn_BXoa.Tag = dt.Rows[i].ItemArray[0].ToString();
                pn_BChucnang.Controls.Add(btn_BSua);
                pn_BChucnang.Controls.Add(btn_BXoa);


                pn_Row.Controls.Add(pn_BChon);
                pn_Row.Controls.Add(pn_BTenchinhanh);
                pn_Row.Controls.Add(pn_BMachinhanh);
                pn_Row.Controls.Add(pn_BDiachi);
                pn_Row.Controls.Add(pn_BDienthoai);
                pn_Row.Controls.Add(pn_BTinhthanh);
                pn_Row.Controls.Add(pn_BBan);
                pn_Row.Controls.Add(pn_BMenu);
                pn_Row.Controls.Add(pn_BChucnang);

                pnCN.Controls.Add(pn_Row);
            }
        }

        private void Btn_BMenu_Click(object sender, EventArgs e)
        {
            Label lbTencn = (Label)pnCN.Controls.Find("lb_BTenchinhanh_" + (sender as Control).Tag.ToString(), true).FirstOrDefault();
            Label lbMacn = (Label)pnCN.Controls.Find("lb_BMachinhanh_" + (sender as Control).Tag.ToString(), true).FirstOrDefault();
            Frm_QLMenu frmMenu = new Frm_QLMenu(lbTencn.Text, lbMacn.Text);
            frmMenu.ShowDialog();
        }

        private void VeBodyBangDanhSachChiNhanhEdit(DataTable dt, string ma)
        {
            Panel pn_Row = null;
            Panel pn_BChon = null;
            Panel pn_BTenchinhanh = null;
            Panel pn_BMachinhanh = null;
            Panel pn_BDiachi = null;
            Panel pn_BDienthoai = null;
            Panel pn_BTinhthanh = null;
            Panel pn_BBan = null;
            Panel pn_BMenu = null;
            Panel pn_BChucnang = null;

            CheckBox cb_Row = null;
            LinkLabel lb_BTenchinhanh = null;
            TextBox tb_BTenchinhanh = null;
            Label lb_BMachinhanh = null;
            Label lb_BDiachi = null;
            TextBox tb_BDiachi = null;
            Label lb_BDienthoai = null;
            TextBox tb_BSodienthoai = null;
            Label lb_BTinhthanh = null;
            Label lb_BBan = null;
            TextBox tb_BBan = null;
            SimpleButton btn_BMenu = null;
            SimpleButton btn_BSua = null;
            SimpleButton btn_BXoa = null;
            SimpleButton btn_BLuu = null;
            SimpleButton btn_BHuy = null;

            int scaleBChon = 5;
            int scaleBTenchinhanh = 30;
            int scaleBMachinhanh = 10;
            int scaleBDiachi = 5;
            int scaleBDienthoai = 10;
            int scaleBDanhmuc = 15;
            int scaleBBan = 5;
            int scaleBMenu = 5;
            int scaleBChucnang = 15;

            int cc = 35;
            int crpn = panel_DSMA.Width;
            int crpnBRow = crpn;
            int crpnBChon = (crpn * scaleBChon) / 100;
            int crpnBTenchinhanh = (crpn * scaleBTenchinhanh) / 100;
            int crpnBMachinhanh = (crpn * scaleBMachinhanh) / 100;
            int crpnBDiachi = (crpn * scaleBDiachi) / 100;
            int crpnBDienthoai = (crpn * scaleBDienthoai) / 100;
            int crpnBDanhmuc = (crpn * scaleBDanhmuc) / 100;
            int crpnBBan = (crpn * scaleBBan) / 100;
            int crpnBMenu = (crpn * scaleBMenu) / 100;
            int crpnBChucnang = (crpn * scaleBChucnang) / 100;

            int slma = busCN.Soluongchinhanh();

            for (int i = 0; i < slma; i++)
            {
                pn_Row = new Panel();

                pn_BChon = new Panel();
                pn_BTenchinhanh = new Panel();
                pn_BMachinhanh = new Panel();
                pn_BDiachi = new Panel();
                pn_BDienthoai = new Panel();
                pn_BTinhthanh = new Panel();
                pn_BBan = new Panel();
                pn_BMenu = new Panel();
                pn_BChucnang = new Panel();

                cb_Row = new CheckBox();
                lb_BTenchinhanh = new LinkLabel();
                tb_BTenchinhanh = new TextBox();
                lb_BMachinhanh = new Label();
                lb_BDiachi = new Label();
                tb_BDiachi = new TextBox();
                lb_BDienthoai = new Label();
                tb_BSodienthoai = new TextBox();
                lb_BTinhthanh = new Label();
                lb_BBan = new Label();
                tb_BBan = new TextBox();
                btn_BMenu = new SimpleButton();
                btn_BSua = new SimpleButton();
                btn_BXoa = new SimpleButton();
                btn_BLuu = new SimpleButton();
                btn_BHuy = new SimpleButton();

                if (ma == dt.Rows[i].ItemArray[0].ToString())
                {
                    pn_Row.BorderStyle = BorderStyle.FixedSingle;
                    pn_Row.Size = new Size(crpnBRow - 8, cc);
                    pn_Row.Location = new Point(0, (cc - 1) * (i + 1));

                    pn_BChon.Size = new Size(crpnBChon, cc);
                    pn_BChon.Location = new Point(-1, -1);

                    cb_Row.Width = 14;
                    cb_Row.Height = 14;
                    cb_Row.Location = new Point((pn_BChon.Width / 2) - (cb_Row.Width / 2), (pn_BChon.Height / 2) - (cb_Row.Height / 2));
                    pn_BChon.Controls.Add(cb_Row);

                    pn_BTenchinhanh.Size = new Size(crpnBTenchinhanh, cc);
                    pn_BTenchinhanh.Location = new Point(pn_BChon.Location.X + pn_BChon.Width - 1, -1);

                    tb_BTenchinhanh.Width = pn_BTenchinhanh.Width - 5;
                    tb_BTenchinhanh.Height = pn_BTenchinhanh.Height - 5;
                    tb_BTenchinhanh.Text = dt.Rows[i].ItemArray[1].ToString();
                    tb_BTenchinhanh.Name = "tb_BTenchinhanh_" + dt.Rows[i].ItemArray[0].ToString();
                    tb_BTenchinhanh.Location = new Point(pn_BTenchinhanh.Width / 2 - tb_BTenchinhanh.Width / 2, pn_BTenchinhanh.Height / 2 - tb_BTenchinhanh.Height / 2);
                    pn_BTenchinhanh.Controls.Add(tb_BTenchinhanh);

                    pn_BMachinhanh.Size = new Size(crpnBMachinhanh, cc);
                    pn_BMachinhanh.Location = new Point(pn_BTenchinhanh.Location.X + pn_BTenchinhanh.Width - 1, -1);

                    lb_BMachinhanh.Width = pn_BMachinhanh.Width;
                    lb_BMachinhanh.Height = pn_BMachinhanh.Height;
                    lb_BMachinhanh.Text = dt.Rows[i].ItemArray[0].ToString();
                    lb_BMachinhanh.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BMachinhanh.Location = new Point(0, 0);
                    pn_BMachinhanh.Controls.Add(lb_BMachinhanh);

                    pn_BDiachi.Size = new Size(crpnBDiachi, cc);
                    pn_BDiachi.Location = new Point(pn_BMachinhanh.Location.X + pn_BMachinhanh.Width - 1, 0);


                    tb_BDiachi.Width = pn_BDiachi.Width - 5;
                    tb_BDiachi.Height = pn_BDiachi.Height - 5;
                    tb_BDiachi.Text = dt.Rows[i].ItemArray[3].ToString();
                    tb_BDiachi.Name = "tb_BDiachi_" + dt.Rows[i].ItemArray[0].ToString();
                    tb_BDiachi.Location = new Point(pn_BDiachi.Width / 2 - tb_BDiachi.Width / 2, pn_BDiachi.Height / 2 - tb_BDiachi.Height / 2);
                    pn_BDiachi.Controls.Add(tb_BDiachi);

                    pn_BDienthoai.Size = new Size(crpnBDienthoai, cc);
                    pn_BDienthoai.Location = new Point(pn_BDiachi.Location.X + pn_BDiachi.Width - 1, -1);

                    tb_BSodienthoai.Width = pn_BDienthoai.Width - 5;
                    tb_BSodienthoai.Height = pn_BDienthoai.Height - 5;
                    tb_BSodienthoai.Text = dt.Rows[i].ItemArray[2].ToString();
                    tb_BSodienthoai.Name = "tb_BSodienthoai_" + dt.Rows[i].ItemArray[0].ToString();
                    tb_BSodienthoai.Location = new Point(pn_BDienthoai.Width / 2 - tb_BSodienthoai.Width / 2, pn_BDienthoai.Height / 2 - tb_BSodienthoai.Height / 2);
                    pn_BDienthoai.Controls.Add(tb_BSodienthoai);

                    pn_BTinhthanh.Size = new Size(crpnBDanhmuc, cc);
                    pn_BTinhthanh.Location = new Point(pn_BDienthoai.Location.X + pn_BDienthoai.Width - 1, 0);

                    lb_BTinhthanh.Width = pn_BTinhthanh.Width;
                    lb_BTinhthanh.Height = pn_BTinhthanh.Height;
                    lb_BTinhthanh.Text = dt.Rows[i].ItemArray[4].ToString();
                    lb_BTinhthanh.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BTinhthanh.Location = new Point(0, 0);
                    pn_BTinhthanh.Controls.Add(lb_BTinhthanh);

                    pn_BBan.Size = new Size(crpnBBan, cc);
                    pn_BBan.Location = new Point(pn_BTinhthanh.Location.X + pn_BTinhthanh.Width - 1, 0);

                    tb_BBan.Width = pn_BBan.Width - 5;
                    tb_BBan.Height = pn_BBan.Height - 5;
                    tb_BBan.Text = dt.Rows[i].ItemArray[5].ToString();
                    tb_BBan.Name = "tb_BBan_" + dt.Rows[i].ItemArray[0].ToString();
                    tb_BBan.Location = new Point(pn_BBan.Width / 2 - tb_BBan.Width / 2, pn_BBan.Height / 2 - tb_BBan.Height / 2);
                    pn_BBan.Controls.Add(tb_BBan);

                    pn_BMenu.Size = new Size(crpnBMenu, cc);
                    pn_BBan.Location = new Point(pn_BTinhthanh.Location.X + pn_BTinhthanh.Width - 1, 0);

                    string imgMenu = "C:\\DBMA\\qlmenu.png";
                    btn_BMenu.ImageOptions.Image = Image.FromFile(imgMenu);
                    btn_BMenu.ImageOptions.Location = ImageLocation.MiddleCenter;
                    btn_BMenu.Size = new Size(btn_BMenu.ImageOptions.Image.Width, btn_BMenu.ImageOptions.Image.Height);
                    btn_BMenu.Location = new Point(pn_BBan.Width / 2 - btn_BMenu.Size.Width / 2, pn_BBan.Height / 2 - btn_BMenu.Size.Height / 2);
                    pn_BMenu.Location = new Point(pn_BBan.Location.X + pn_BBan.Width - 1, -1);
                    pn_BMenu.Controls.Add(btn_BMenu);


                    pn_BChucnang.Size = new Size(crpnBChucnang, cc);
                    pn_BChucnang.Location = new Point(pn_BMenu.Location.X + pn_BMenu.Width - 1, -1);


                    string imgLuu = "C:\\DBMA\\save-row.png";
                    string imgHuy = "C:\\DBMA\\can-row.png";
                    btn_BLuu.ImageOptions.Image = Image.FromFile(imgLuu);
                    btn_BHuy.ImageOptions.Image = Image.FromFile(imgHuy);
                    btn_BLuu.ImageOptions.Location = ImageLocation.MiddleCenter;
                    btn_BHuy.ImageOptions.Location = ImageLocation.MiddleCenter;
                    btn_BLuu.Size = new Size(btn_BLuu.ImageOptions.Image.Width, btn_BLuu.ImageOptions.Image.Height);
                    btn_BHuy.Size = new Size(btn_BHuy.ImageOptions.Image.Width, btn_BHuy.ImageOptions.Image.Height);
                    btn_BLuu.Location = new Point((pn_BChucnang.Width / 2) - btn_BLuu.Width - 2, (pn_BChucnang.Height / 2 - 12));
                    btn_BHuy.Location = new Point((pn_BChucnang.Width / 2) + 2, (pn_BChucnang.Height / 2 - 12));
                    btn_BLuu.Click += Btn_BLuuCN_Click;
                    btn_BHuy.Click += Btn_BHuyCN_Click;
                    btn_BLuu.Tag = dt.Rows[i].ItemArray[0].ToString();
                    pn_BChucnang.Controls.Add(btn_BLuu);
                    pn_BChucnang.Controls.Add(btn_BHuy);
                }
                else
                {
                    pn_Row.BorderStyle = BorderStyle.FixedSingle;
                    pn_Row.Size = new Size(crpnBRow - 8, cc);
                    pn_Row.Location = new Point(0, (cc - 1) * (i + 1));

                    pn_BChon.Size = new Size(crpnBChon, cc);
                    pn_BChon.Location = new Point(-1, -1);

                    cb_Row.Width = 14;
                    cb_Row.Height = 14;
                    cb_Row.Location = new Point((pn_BChon.Width / 2) - (cb_Row.Width / 2), (pn_BChon.Height / 2) - (cb_Row.Height / 2));
                    pn_BChon.Controls.Add(cb_Row);

                    pn_BTenchinhanh.Size = new Size(crpnBTenchinhanh, cc);
                    pn_BTenchinhanh.Location = new Point(pn_BChon.Location.X + pn_BChon.Width - 1, -1);

                    lb_BTenchinhanh.Width = pn_BTenchinhanh.Width;
                    lb_BTenchinhanh.Height = pn_BTenchinhanh.Height;
                    lb_BTenchinhanh.Text = dt.Rows[i].ItemArray[1].ToString();
                    lb_BTenchinhanh.TextAlign = ContentAlignment.MiddleLeft;
                    lb_BTenchinhanh.Location = new Point(0, 0);
                    pn_BTenchinhanh.Controls.Add(lb_BTenchinhanh);
                    //lb_BTenchinhanh.Click += Lb_BTenchinhanh_Click;

                    pn_BMachinhanh.Size = new Size(crpnBMachinhanh, cc);
                    pn_BMachinhanh.Location = new Point(pn_BTenchinhanh.Location.X + pn_BTenchinhanh.Width - 1, -1);

                    lb_BMachinhanh.Width = pn_BMachinhanh.Width;
                    lb_BMachinhanh.Height = pn_BMachinhanh.Height;
                    lb_BMachinhanh.Text = dt.Rows[i].ItemArray[0].ToString();
                    lb_BMachinhanh.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BMachinhanh.Location = new Point(0, 0);
                    pn_BMachinhanh.Controls.Add(lb_BMachinhanh);

                    pn_BDiachi.Size = new Size(crpnBDiachi, cc);
                    pn_BDiachi.Location = new Point(pn_BMachinhanh.Location.X + pn_BMachinhanh.Width - 1, 0);

                    lb_BDiachi.Width = pn_BDiachi.Width;
                    lb_BDiachi.Height = pn_BDiachi.Height;
                    lb_BDiachi.Text = dt.Rows[i].ItemArray[3].ToString();
                    lb_BDiachi.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BDiachi.Location = new Point(0, 0);
                    pn_BDiachi.Controls.Add(lb_BDiachi);

                    pn_BDienthoai.Size = new Size(crpnBDienthoai, cc);
                    pn_BDienthoai.Location = new Point(pn_BDiachi.Location.X + pn_BDiachi.Width - 1, -1);

                    lb_BDienthoai.Width = pn_BDienthoai.Width;
                    lb_BDienthoai.Height = pn_BDienthoai.Height;
                    lb_BDienthoai.Text = dt.Rows[i].ItemArray[2].ToString();
                    lb_BDienthoai.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BDienthoai.Location = new Point(0, 0);
                    pn_BDienthoai.Controls.Add(lb_BDienthoai);

                    pn_BTinhthanh.Size = new Size(crpnBDanhmuc, cc);
                    pn_BTinhthanh.Location = new Point(pn_BDienthoai.Location.X + pn_BDienthoai.Width - 1, 0);

                    lb_BTinhthanh.Width = pn_BTinhthanh.Width;
                    lb_BTinhthanh.Height = pn_BTinhthanh.Height;
                    lb_BTinhthanh.Text = dt.Rows[i].ItemArray[4].ToString();
                    lb_BTinhthanh.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BTinhthanh.Location = new Point(0, 0);
                    pn_BTinhthanh.Controls.Add(lb_BTinhthanh);

                    pn_BBan.Size = new Size(crpnBBan, cc);
                    pn_BBan.Location = new Point(pn_BTinhthanh.Location.X + pn_BTinhthanh.Width - 1, 0);

                    lb_BBan.Width = pn_BBan.Width;
                    lb_BBan.Height = pn_BBan.Height;
                    lb_BBan.Text = dt.Rows[i].ItemArray[5].ToString();
                    lb_BBan.TextAlign = ContentAlignment.MiddleCenter;
                    lb_BBan.Location = new Point(0, 0);
                    pn_BBan.Controls.Add(lb_BBan);

                    pn_BMenu.Size = new Size(crpnBMenu, cc);
                    pn_BBan.Location = new Point(pn_BTinhthanh.Location.X + pn_BTinhthanh.Width - 1, 0);

                    string imgMenu = "C:\\DBMA\\qlmenu.png";
                    btn_BMenu.ImageOptions.Image = Image.FromFile(imgMenu);
                    btn_BMenu.ImageOptions.Location = ImageLocation.MiddleCenter;
                    btn_BMenu.Size = new Size(btn_BMenu.ImageOptions.Image.Width, btn_BMenu.ImageOptions.Image.Height);
                    btn_BMenu.Location = new Point(pn_BBan.Width / 2 - btn_BMenu.Size.Width / 2, pn_BBan.Height / 2 - btn_BMenu.Size.Height / 2);
                    pn_BMenu.Location = new Point(pn_BBan.Location.X + pn_BBan.Width - 1, -1);
                    pn_BMenu.Controls.Add(btn_BMenu);
                    pn_BMenu.Enabled = false;


                    pn_BChucnang.Size = new Size(crpnBChucnang, cc);
                    pn_BChucnang.Location = new Point(pn_BMenu.Location.X + pn_BMenu.Width - 1, -1);

                    string imgSua = "C:\\DBMA\\edit-row.png";
                    string imgXoa = "C:\\DBMA\\del-row.png";
                    btn_BSua.ImageOptions.Image = Image.FromFile(imgSua);
                    btn_BXoa.ImageOptions.Image = Image.FromFile(imgXoa);
                    btn_BSua.ImageOptions.Location = ImageLocation.MiddleCenter;
                    btn_BXoa.ImageOptions.Location = ImageLocation.MiddleCenter;
                    btn_BSua.Size = new Size(btn_BSua.ImageOptions.Image.Width, btn_BSua.ImageOptions.Image.Height);
                    btn_BXoa.Size = new Size(btn_BXoa.ImageOptions.Image.Width, btn_BXoa.ImageOptions.Image.Height);
                    btn_BSua.Location = new Point((pn_BChucnang.Width / 2) - btn_BSua.Width - 2, (pn_BChucnang.Height / 2 - 12));
                    btn_BXoa.Location = new Point((pn_BChucnang.Width / 2) + 2, (pn_BChucnang.Height / 2 - 12));
                    btn_BSua.Click += Btn_BSuaCN_Click;
                    btn_BXoa.Click += Btn_BXoaCN_Click;
                    btn_BSua.Tag = dt.Rows[i].ItemArray[0].ToString();
                    btn_BXoa.Tag = dt.Rows[i].ItemArray[0].ToString();
                    pn_BChucnang.Controls.Add(btn_BSua);
                    pn_BChucnang.Controls.Add(btn_BXoa);
                    pn_BChucnang.Enabled = false;
                }
                pn_Row.Controls.Add(pn_BChon);
                pn_Row.Controls.Add(pn_BTenchinhanh);
                pn_Row.Controls.Add(pn_BMachinhanh);
                pn_Row.Controls.Add(pn_BDiachi);
                pn_Row.Controls.Add(pn_BDienthoai);
                pn_Row.Controls.Add(pn_BTinhthanh);
                pn_Row.Controls.Add(pn_BBan);
                pn_Row.Controls.Add(pn_BMenu);
                pn_Row.Controls.Add(pn_BChucnang);

                pnCN.Controls.Add(pn_Row);
            }
        }


        private void Lb_BTenmonan_Click(object sender, EventArgs e)
        {
            DTO_MonAn ma = new DTO_MonAn();
            ma = (sender as Control).Tag as DTO_MonAn;

            Frm_MonAn frmMA = new Frm_MonAn();
            frmMA.LoadMA(ma);
            frmMA.LoadMAEvent += frmMA_LoadEvent;
            frmMA.ShowDialog();
        }
        private void Btn_BSua_Click(object sender, EventArgs e)
        {
            VeHeadBangDanhSachMonAn();
            VeBodyBangDanhSachMonAnEdit(busMA.LoadDanhSachMonAn(), (sender as Control).Tag.ToString());
            ActiveControl = panel_DSMA;
        }
        private void Btn_BXoa_Click(object sender, EventArgs e)
        {
            string ma = (sender as Control).Tag.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa món ăn mã " + ma + " !!!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (busMA.Xoamonan(ma))
                {
                    MessageBox.Show("Xóa món ăn thành công !!!", "Thông báo");
                    VeHeadBangDanhSachMonAn();
                    VeBodyBangDanhSachMonAn(busMA.LoadDanhSachMonAn());
                    ActiveControl = panel_DSMA;
                }
            }            
        }

        private void Btn_BHuy_Click(object sender, EventArgs e)
        {
            VeHeadBangDanhSachMonAn();
            VeBodyBangDanhSachMonAn(busMA.LoadDanhSachMonAn());
            ActiveControl = panel_DSMA;
        }

        private void Btn_BSuaCN_Click(object sender, EventArgs e)
        {
            VeHeadBangDanhSachChiNhanh();
            VeBodyBangDanhSachChiNhanhEdit(busCN.LoadDanhSachChiNhanh(), (sender as Control).Tag.ToString());
            ActiveControl = pnCN;
        }

        private void Btn_BXoaCN_Click(object sender, EventArgs e)
        {
            string ma = (sender as Control).Tag.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa chi nhánh mã " + ma + " !!!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (busCN.Xoachinhanh(ma))
                {
                    MessageBox.Show("Xóa chi nhánh thành công !!!", "Thông báo");
                    VeHeadBangDanhSachChiNhanh();
                    VeBodyBangDanhSachChiNhanh(busCN.LoadDanhSachChiNhanh());
                    ActiveControl = pnCN;
                }
            }
        }

        private void Btn_BHuyCN_Click(object sender, EventArgs e)
        {
            VeHeadBangDanhSachChiNhanh();
            VeBodyBangDanhSachChiNhanh(busCN.LoadDanhSachChiNhanh());
            ActiveControl = pnCN;
        }

        private void Btn_BLuuCN_Click(object sender, EventArgs e)
        {
            DTO_ChiNhanh cn = new DTO_ChiNhanh();
            TextBox tbTenchinhanh = (TextBox)pnCN.Controls.Find("tb_BTenchinhanh_" + (sender as Control).Tag.ToString(), true).FirstOrDefault();
            TextBox tbDiachi = (TextBox)pnCN.Controls.Find("tb_BDiachi_" + (sender as Control).Tag.ToString(), true).FirstOrDefault();
            TextBox tbDienthoai = (TextBox)pnCN.Controls.Find("tb_BSodienthoai_" + (sender as Control).Tag.ToString(), true).FirstOrDefault();
            cn.Macn = (sender as Control).Tag.ToString();
            cn.Tencn = tbTenchinhanh.Text;
            cn.Diachi = tbDiachi.Text;
            cn.Dienthoai = tbDienthoai.Text;
            if (busCN.Capnhatchinhanhnhanh(cn))
            {
                MessageBox.Show("Cập nhật chi nhánh thành công !!!", "Thông báo");
                VeHeadBangDanhSachChiNhanh();
                VeBodyBangDanhSachChiNhanh(busCN.LoadDanhSachChiNhanh());
                ActiveControl = pnCN;
            }
        }

        private void Btn_BLuu_Click(object sender, EventArgs e)
        {
            DTO_MonAn ma = new DTO_MonAn();
            TextBox tbTenmonan = (TextBox)panel_DSMA.Controls.Find("tb_BTenmonan_" + (sender as Control).Tag.ToString(), true).FirstOrDefault();
            TextBox tbGiaban = (TextBox)panel_DSMA.Controls.Find("tb_BGiaban_" + (sender as Control).Tag.ToString(), true).FirstOrDefault();
            ma.Mama = (sender as Control).Tag.ToString();
            ma.Tenma = tbTenmonan.Text;
            ma.Giaban = decimal.Parse(tbGiaban.Text);
            if (busMA.Capnhatmonan(ma))
            {
                MessageBox.Show("Cập nhật món ăn thành công !!!", "Thông báo");
                VeHeadBangDanhSachMonAn();
                VeBodyBangDanhSachMonAn(busMA.LoadDanhSachMonAn());
                ActiveControl = panel_DSMA;
            }
        }

        public Image Resize(Image img, float percentage)
        {
            int originalW = img.Width;
            int originalH = img.Height;
            int resizedW = (int)(originalW * percentage);
            int resizedH = (int)(originalH * percentage);
            Bitmap bmp = new Bitmap(resizedW, resizedH);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(img, 0, 0, resizedW, resizedH);
            graphic.Dispose();
            return (Image)bmp;
        }

        private void btn_Themmonan_Click(object sender, EventArgs e)
        {
            Frm_MonAn frmMA = new Frm_MonAn();
            frmMA.LoadMAEvent += frmMA_LoadEvent;
            frmMA.ThemMoi = true;
            frmMA.ShowDialog();
        }
        void frmMA_LoadEvent()
        {
            VeHeadBangDanhSachMonAn();
            VeBodyBangDanhSachMonAn(busMA.LoadDanhSachMonAn());
        }

        private void backstageViewClientControl3_Load(object sender, EventArgs e)
        {

        }

        private void backstageViewTabItem2_SelectedChanged(object sender, BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem4_SelectedChanged(object sender, BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem3_SelectedChanged(object sender, BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem1_SelectedChanged(object sender, BackstageViewItemEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pBaoCao_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void rbDoanhThu_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!pBaoCao.Controls.Contains(uc_doanhthu.Instance))
            {
                pBaoCao.Controls.Add(uc_doanhthu.Instance);
                //uc_doanhthu.Instance.Dock = DockStyle.Fill;
                uc_doanhthu.Instance.BringToFront();
            }
            else { uc_doanhthu.Instance.BringToFront(); }
        }

        private void rbChiPhi_CheckedChanged(object sender, EventArgs e)
        {
            if (!pBaoCao.Controls.Contains(uc_chiphi.Instance))
            {
                pBaoCao.Controls.Add(uc_chiphi.Instance);
                uc_chiphi.Instance.Dock = DockStyle.Fill;
                uc_chiphi.Instance.BringToFront();
            }
            else { uc_chiphi.Instance.BringToFront(); }
        }

        private void rbSoLuongMonBan_CheckedChanged(object sender, EventArgs e)
        {
            if (!pBaoCao.Controls.Contains(uc_thongkesoluongmon.Instance))
            {
                pBaoCao.Controls.Add(uc_thongkesoluongmon.Instance);
                uc_thongkesoluongmon.Instance.Dock = DockStyle.Fill;
                uc_thongkesoluongmon.Instance.BringToFront();
            }
            else { uc_thongkesoluongmon.Instance.BringToFront(); }
        }

        private void rbSoLuongHD_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!pBaoCao.Controls.Contains(uc_soluongdonhang.Instance))
            {
                pBaoCao.Controls.Add(uc_soluongdonhang.Instance);
                uc_soluongdonhang.Instance.Dock = DockStyle.Fill;
                uc_soluongdonhang.Instance.BringToFront();
            }
            else { uc_soluongdonhang.Instance.BringToFront(); }
        }

        private void rbHDKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (!pBaoCao.Controls.Contains(uc_thongkesoluongdonhangcuakhach.Instance))
            {
                pBaoCao.Controls.Add(uc_thongkesoluongdonhangcuakhach.Instance);
                uc_thongkesoluongdonhangcuakhach.Instance.Dock = DockStyle.Fill;
                uc_thongkesoluongdonhangcuakhach.Instance.BringToFront();
            }
            else { uc_thongkesoluongdonhangcuakhach.Instance.BringToFront(); }
        }
    }
}
