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
using DAL;

namespace Boquanquanly
{
    public partial class uc_thongkesoluongdonhangcuakhach : UserControl
    {
        BUS_KhachHang busKh = new BUS_KhachHang();

        private static uc_thongkesoluongdonhangcuakhach _instance;

        public static uc_thongkesoluongdonhangcuakhach Instance
        {
            get
            {
                if (_instance == null) _instance = new uc_thongkesoluongdonhangcuakhach();
                return uc_thongkesoluongdonhangcuakhach._instance; }
            set { uc_thongkesoluongdonhangcuakhach._instance = value; }
        }

        public uc_thongkesoluongdonhangcuakhach()
        {
            InitializeComponent();
        }

        private void us_thongkesoluongdonhang_Load(object sender, EventArgs e)
        {
            vebangkhachhang();
        }

        void vebangkhachhang()
        {
            pnKhachHang.Controls.Clear();
            Panel pnSTT = new Panel();
            Panel pnMakh = new Panel();
            Panel pnTenkh = new Panel();
            Panel pnSLDH = new Panel();
            Panel pnTongtien = new Panel();

            int cc = 35;

            int ttw = pnKhachHang.Width;
            int ttw_stt = (10 * ttw) / 100;
            int ttw_makh = (20 * ttw) / 100;
            int ttw_tenkh = (30 * ttw) / 100;
            int ttw_sl = 15 * ttw / 100;
            int ttw_tt = 25 * ttw / 100;

            pnSTT.BorderStyle = BorderStyle.FixedSingle;
            pnSTT.Size = new Size(ttw_stt, cc);
            pnSTT.Location = new Point(-1, 0);

            Label lbStt = new Label();
            lbStt.Height = pnSTT.Height;
            lbStt.Width = pnSTT.Width;
            lbStt.Text = "STT";
            lbStt.TextAlign = ContentAlignment.MiddleCenter;
            pnSTT.Controls.Add(lbStt);

            pnMakh.BorderStyle = BorderStyle.FixedSingle;
            pnMakh.Size = new Size(ttw_makh, cc);
            pnMakh.Location = new Point(pnSTT.Location.X + ttw_stt - 1, 0);

            Label lbMaKH = new Label();
            lbMaKH.Height = pnMakh.Height;
            lbMaKH.Width = pnMakh.Width;
            lbMaKH.Text = "Mã KH";
            lbMaKH.TextAlign = ContentAlignment.MiddleCenter;
            pnMakh.Controls.Add(lbMaKH);

            pnTenkh.BorderStyle = BorderStyle.FixedSingle;
            pnTenkh.Size = new Size(ttw_tenkh, cc);
            pnTenkh.Location = new Point(pnMakh.Location.X + ttw_makh - 1, 0);

            Label lbTenkh = new Label();
            lbTenkh.Height = pnTenkh.Height;
            lbTenkh.Width = pnTenkh.Width;
            lbTenkh.Text = "Tên Khách hàng";
            lbTenkh.TextAlign = ContentAlignment.MiddleCenter;
            pnTenkh.Controls.Add(lbTenkh);

            pnSLDH.BorderStyle = BorderStyle.FixedSingle;
            pnSLDH.Size = new Size(ttw_sl, cc);
            pnSLDH.Location = new Point(pnTenkh.Location.X + ttw_tenkh - 1, 0);

            Label lbSl = new Label();
            lbSl.Height = pnSLDH.Height;
            lbSl.Width = pnSLDH.Width;
            lbSl.Text = "Số lượng đh";
            lbSl.TextAlign = ContentAlignment.MiddleCenter;
            pnSLDH.Controls.Add(lbSl);

            pnTongtien.BorderStyle = BorderStyle.FixedSingle;
            pnTongtien.Size = new Size(ttw_tt, cc);
            pnTongtien.Location = new Point(pnSLDH.Location.X + ttw_sl - 1, 0);

            Label lbTt = new Label();
            lbTt.Height = pnTongtien.Height;
            lbTt.Width = pnTongtien.Width;
            lbTt.Text = "Tổng tiền";
            lbTt.TextAlign = ContentAlignment.MiddleCenter;
            pnTongtien.Controls.Add(lbTt);



            pnKhachHang.Controls.Add(pnSTT);
            pnKhachHang.Controls.Add(pnMakh);
            pnKhachHang.Controls.Add(pnTenkh);
            pnKhachHang.Controls.Add(pnSLDH);
            pnKhachHang.Controls.Add(pnTongtien);
        }


        void vebangkhachhang(DataTable data)
        {
            Panel pnRow = new Panel();
            Panel pnSTT = new Panel();
            Panel pnMakh = new Panel();
            Panel pnTenkh = new Panel();
            Panel pnSLDH = new Panel();
            Panel pnTongtien = new Panel();


            int cc = 35;

            int ttw = pnKhachHang.Width;
            int ttw_stt = (10 * ttw) / 100;
            int ttw_makh = (20 * ttw) / 100;
            int ttw_tenkh = (30 * ttw) / 100;
            int ttw_sl = 15 * ttw / 100;
            int ttw_tt = 25 * ttw / 100;

            int sl = data.Rows.Count;

            for (int i = 0; i < sl; i++ ) {
                pnRow = new Panel();
                pnRow.BorderStyle = BorderStyle.FixedSingle;
                pnRow.Size = new Size(ttw, cc);
                pnRow.Location = new Point(-1 , (cc - 1)*(i + 1));

                pnSTT = new Panel();
                pnSTT.BorderStyle = BorderStyle.FixedSingle;
                pnSTT.Size = new Size(ttw_stt, cc);
                pnSTT.Location = new Point(-1, -1);

                Label lbStt = new Label();
                lbStt.Height = pnSTT.Height;
                lbStt.Width = pnSTT.Width;
                lbStt.Text = ""+ i + 1;
                lbStt.TextAlign = ContentAlignment.MiddleCenter;
                pnSTT.Controls.Add(lbStt);


                pnMakh = new Panel();
                pnMakh.BorderStyle = BorderStyle.FixedSingle;
                pnMakh.Size = new Size(ttw_makh, cc);
                pnMakh.Location = new Point(pnSTT.Location.X + ttw_stt - 1, -1);

                Label lbmakh = new Label();
                lbmakh.Height = pnMakh.Height;
                lbmakh.Width = pnMakh.Width;
                lbmakh.Text = data.Rows[i].ItemArray[0].ToString();
                lbmakh.TextAlign = ContentAlignment.MiddleCenter;
                pnMakh.Controls.Add(lbmakh);

                pnTenkh = new Panel();
                pnTenkh.BorderStyle = BorderStyle.FixedSingle;
                pnTenkh.Size = new Size(ttw_tenkh, cc);
                pnTenkh.Location = new Point(pnMakh.Location.X + ttw_makh - 1 ,-1);

                Label lbtenkh = new Label();
                lbtenkh.Height = pnTenkh.Height;
                lbtenkh.Width = pnTenkh.Width;
                lbtenkh.Text = data.Rows[i].ItemArray[1].ToString(); ;
                lbtenkh.TextAlign = ContentAlignment.MiddleCenter;
                pnTenkh.Controls.Add(lbtenkh);

                pnSLDH = new Panel();
                pnSLDH.BorderStyle = BorderStyle.FixedSingle;
                pnSLDH.Size = new Size(ttw_sl, cc);
                pnSLDH.Location = new Point(pnTenkh.Location.X + ttw_tenkh - 1, -1);

                Label lbsldh = new Label();
                lbsldh.Height = pnSLDH.Height;
                lbsldh.Width = pnSLDH.Width;
                lbsldh.Text = data.Rows[i].ItemArray[2].ToString(); ;
                lbsldh.TextAlign = ContentAlignment.MiddleCenter;
                pnSLDH.Controls.Add(lbsldh);

                pnTongtien = new Panel();
                pnTongtien.BorderStyle = BorderStyle.FixedSingle;
                pnTongtien.Size = new Size(ttw_tt, cc);
                pnTongtien.Location = new Point(pnSLDH.Location.X + ttw_sl - 1, 0);

                Label lbTt = new Label();
                lbTt.Height = pnTongtien.Height;
                lbTt.Width = pnTongtien.Width;
                lbTt.Text = data.Rows[i].ItemArray[3].ToString(); ;
                lbTt.TextAlign = ContentAlignment.MiddleCenter;
                pnTongtien.Controls.Add(lbTt);


                pnRow.Controls.Add(pnSTT);
                pnRow.Controls.Add(pnMakh);
                pnRow.Controls.Add(pnTenkh);
                pnRow.Controls.Add(pnSLDH);
                pnRow.Controls.Add(pnTongtien);
                pnKhachHang.Controls.Add(pnRow);
            }

        }

        private void btXem_Click(object sender, EventArgs e)
        {
            //DataTable dtkh = busKh.hoatdongkhachhang(txtMaKh.Text, dtpThoiGian.Value);

            //if (dtkh.Rows != null)
            //{
            //    lbTongdh.Text = dtkh.Rows[0].ItemArray[2].ToString();
            //    lbTongtien.Text = dtkh.Rows[0].ItemArray[3].ToString();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable dtkh = busKh.bangthongkekhach();

            //if (dtkh.Rows != null)
            //{
            //    vebangkhachhang(dtkh);
            //}
        }
    }
}
