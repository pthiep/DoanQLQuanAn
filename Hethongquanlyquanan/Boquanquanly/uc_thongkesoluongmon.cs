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

namespace Boquanquanly
{
    public partial class uc_thongkesoluongmon : UserControl
    {
        BUS_HoaDon busDH = new BUS_HoaDon();
        private static uc_thongkesoluongmon _instance;

        public static uc_thongkesoluongmon Instance
        {
            get
            {
                if (_instance == null) _instance = new uc_thongkesoluongmon();
                return uc_thongkesoluongmon._instance; }
            set { uc_thongkesoluongmon._instance = value; }
        }
        public uc_thongkesoluongmon()
        {
            InitializeComponent();
        }

        private void uc_thongkesoluongmon_Load(object sender, EventArgs e)
        {
            load_control();
            VeBangSoLuongMon();
            VeBangChiTietSLM();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            //XulyNgayThang();
            //DataTable dtcnma = busDH.ThongkeMonBanCuaChiNhanh(dtpBD.Value, dtpKT.Value);
            //DataTable dtma = busDH.ThongkeMonBan(dtpBD.Value, dtpKT.Value);
            //DataTable dttong = busDH.TongSldon(dtpBD.Value, dtpKT.Value);

            //if(dtma.Rows != null){
            //    lbSoLuongMon.Text = dttong.Rows[0].ItemArray[0].ToString();
            //}

            //if(dtma.Rows != null){
            //    VeBanSoLuongMon(dtcnma);
            //    vebangChiTietSLM(dtma);
            //}
        }

        void VeBangSoLuongMon()
        {
            pnSoLuongMon.Controls.Clear();
            Panel pnChiNhanh = new Panel();
            Panel pnSTT = new Panel();
            Panel pnSoLuongMonBan = new Panel();

            int cc = 35;
            int ttw = pnSoLuongMon.Width;
            int sw = 15 * ttw / 100;
            int cnw = 45 * ttw / 100;
            int slw = 40 * ttw / 100;

            pnChiNhanh.BorderStyle = BorderStyle.FixedSingle;
            pnChiNhanh.Size = new Size(cnw, cc);
            pnChiNhanh.Location = new Point(pnSTT.Location.X + sw - 1 , -1);

            Label lbChiNhanh = new Label();
            lbChiNhanh.Height = pnChiNhanh.Height;
            lbChiNhanh.Width = pnChiNhanh.Width;
            lbChiNhanh.Text = "Chi nhánh";
            lbChiNhanh.TextAlign = ContentAlignment.MiddleCenter;
            pnChiNhanh.Controls.Add(lbChiNhanh);

            pnSTT.BorderStyle = BorderStyle.FixedSingle;
            pnSTT.Size = new Size(sw, cc);
            pnSTT.Location = new Point(-1, -1);

            Label lbSTT = new Label();
            lbSTT.Height = pnSTT.Height;
            lbSTT.Width = pnSTT.Width;
            lbSTT.Text = "STT";
            lbSTT.TextAlign = ContentAlignment.MiddleCenter;
            pnSTT.Controls.Add(lbSTT);

            pnSoLuongMonBan.BorderStyle = BorderStyle.FixedSingle;
            pnSoLuongMonBan.Size = new Size(slw, cc);
            pnSoLuongMonBan.Location = new Point(pnChiNhanh.Location.X + cnw -1, -1);

            Label lbSoLuong = new Label();
            lbSoLuong.Height = pnSoLuongMonBan.Height;
            lbSoLuong.Width = pnSoLuongMonBan.Width;
            lbSoLuong.Text = "Số lượng";
            lbSoLuong.TextAlign = ContentAlignment.MiddleCenter;
            pnSoLuongMonBan.Controls.Add(lbSoLuong);

            pnSoLuongMon.Controls.Add(pnSTT);
            pnSoLuongMon.Controls.Add(pnChiNhanh);
            pnSoLuongMon.Controls.Add(pnSoLuongMonBan);
        }

        void VeBanSoLuongMon(DataTable data) {
            Panel pnChiNhanh = new Panel();
            Panel pnSTT = new Panel();
            Panel pnSoLuongMonBan = new Panel();

            int cc = 35;
            int ttw = pnSoLuongMon.Width;
            int sw = 15 * ttw / 100;
            int cnw = 45 * ttw / 100;
            int slw = 40 * ttw / 100;
            int rw = ttw;

            int sl = data.Rows.Count;
            for (int i = 0; i < sl; i++)
            {
                Panel pnRow = new Panel();
                pnChiNhanh = new Panel();
                pnSTT = new Panel();
                pnSoLuongMonBan = new Panel();

                pnRow.BorderStyle = BorderStyle.FixedSingle;
                pnRow.Size = new Size(ttw, cc);
                pnRow.Location = new Point(-1, (cc - 1)*(i + 1));

                pnSTT.BorderStyle = BorderStyle.FixedSingle;
                pnSTT.Size = new Size(sw, cc);
                pnSTT.Location = new Point(-1, -1);

                Label lbSTT = new Label();
                lbSTT.Height = pnSTT.Height;
                lbSTT.Width = pnSTT.Width;
                lbSTT.Text = "" + i + 1;
                lbSTT.TextAlign = ContentAlignment.MiddleCenter;
                pnSTT.Controls.Add(lbSTT);


                pnChiNhanh.BorderStyle = BorderStyle.FixedSingle;
                pnChiNhanh.Size = new Size(cnw, cc);
                pnChiNhanh.Location = new Point(pnSTT.Location.X + sw - 1, -1);

                Label lbCN = new Label();
                lbCN.Height = pnChiNhanh.Height;
                lbCN.Width = pnChiNhanh.Width;
                lbCN.Text = data.Rows[i].ItemArray[0].ToString();
                lbCN.TextAlign = ContentAlignment.MiddleCenter;
                pnChiNhanh.Controls.Add(lbCN);


                pnSoLuongMonBan.BorderStyle = BorderStyle.FixedSingle;
                pnSoLuongMonBan.Size = new Size(slw, cc);
                pnSoLuongMonBan.Location = new Point(pnChiNhanh.Location.X + cnw - 1, -1);

                Label lbSL = new Label();
                lbSL.Height = pnSoLuongMonBan.Height;
                lbSL.Width = pnSoLuongMonBan.Width;
                lbSL.Text = data.Rows[i].ItemArray[2].ToString();
                lbSL.TextAlign = ContentAlignment.MiddleCenter;
                pnSoLuongMonBan.Controls.Add(lbSL);


                pnRow.Controls.Add(pnSTT);
                pnRow.Controls.Add(pnChiNhanh);
                pnRow.Controls.Add(pnSoLuongMonBan);
                pnSoLuongMon.Controls.Add(pnRow);
            }
        }

        void VeBangChiTietSLM()
        {
            pnCTSLM.Controls.Clear();
            Panel pnSTT = new Panel();
            Panel pnMaMon = new Panel();
            Panel pnChiNhanh = new Panel();
            Panel pnSoLuong = new Panel();
            Panel pnTenMon = new Panel();

            int cc = 35;
            int ttw = pnCTSLM.Width;
            int sw = 5 * ttw / 100;
            int cnw = 20 * ttw / 100;
            int mmw = 20 * ttw / 100;
            int tw = 40 * ttw / 100;
            int slw = 15 * ttw / 100;

            pnSTT.BorderStyle = BorderStyle.FixedSingle;
            pnSTT.Size = new Size(sw, cc);
            pnSTT.Location = new Point( -1, -1);

            Label lbSTT = new Label();
            lbSTT.Height = pnSTT.Height;
            lbSTT.Width = pnSTT.Width;
            lbSTT.Text = "STT";
            lbSTT.TextAlign = ContentAlignment.MiddleCenter;
            pnSTT.Controls.Add(lbSTT);


            pnChiNhanh.BorderStyle = BorderStyle.FixedSingle;
            pnChiNhanh.Size = new Size(cnw, cc);
            pnChiNhanh.Location = new Point(pnSTT.Location.X + sw - 1, -1);

            Label lbChiNhanh = new Label();
            lbChiNhanh.Height = pnChiNhanh.Height;
            lbChiNhanh.Width = pnChiNhanh.Width;
            lbChiNhanh.Text = "Chi nhánh";
            lbChiNhanh.TextAlign = ContentAlignment.MiddleCenter;
            pnChiNhanh.Controls.Add(lbChiNhanh);

            pnMaMon.BorderStyle = BorderStyle.FixedSingle;
            pnMaMon.Size = new Size(mmw, cc);
            pnMaMon.Location = new Point(pnChiNhanh.Location.X + cnw - 1, -1);

            Label lbMaMon = new Label();
            lbMaMon.Height = pnMaMon.Height;
            lbMaMon.Width = pnMaMon.Width;
            lbMaMon.Text = "Mã món";
            lbMaMon.TextAlign = ContentAlignment.MiddleCenter;
            pnMaMon.Controls.Add(lbMaMon);


            pnTenMon.BorderStyle = BorderStyle.FixedSingle;
            pnTenMon.Size = new Size(tw, cc);
            pnTenMon.Location = new Point(pnMaMon.Location.X + mmw - 1, -1);

            Label lbTenMon = new Label();
            lbTenMon.Height = pnTenMon.Height;
            lbTenMon.Width = pnTenMon.Width;
            lbTenMon.Text = "Tên món";
            lbTenMon.TextAlign = ContentAlignment.MiddleCenter;
            pnTenMon.Controls.Add(lbTenMon);


            pnSoLuong.BorderStyle = BorderStyle.FixedSingle;
            pnSoLuong.Size = new Size(slw + 7, cc);
            pnSoLuong.Location = new Point(pnTenMon.Location.X + tw - 1, -1);

            Label lbSoLuong = new Label();
            lbSoLuong.Height = pnSoLuong.Height;
            lbSoLuong.Width = pnSoLuong.Width;
            lbSoLuong.Text = "Số lượng";
            lbSoLuong.TextAlign = ContentAlignment.MiddleCenter;
            pnSoLuong.Controls.Add(lbSoLuong);

            

            pnCTSLM.Controls.Add(pnSTT);
            pnCTSLM.Controls.Add(pnChiNhanh);
            pnCTSLM.Controls.Add(pnMaMon);
            pnCTSLM.Controls.Add(pnTenMon);
            pnCTSLM.Controls.Add(pnSoLuong);
        }

        void vebangChiTietSLM(DataTable data)
        {
            Panel pnRow = new Panel();
            Panel pnSTT = new Panel();
            Panel pnMaMon = new Panel();
            Panel pnChiNhanh = new Panel();
            Panel pnSoLuong = new Panel();
            Panel pnTenMon = new Panel();

            int cc = 35;
            int ttw = pnCTSLM.Width;
            int sw = 5 * ttw / 100;
            int cnw = 20 * ttw / 100;
            int mmw = 20 * ttw / 100;
            int tw = 40 * ttw / 100;
            int slw = 15 * ttw / 100;

            int sl = data.Rows.Count;
            if (data.Rows.Count != null)
            {
                for (int i = 0; i < sl; i++)
                {
                    pnRow = new Panel();
                    pnSTT = new Panel();
                    pnChiNhanh = new Panel();
                    pnMaMon = new Panel();
                    pnTenMon = new Panel();
                    pnSoLuong = new Panel();

                    pnRow.BorderStyle = BorderStyle.FixedSingle;
                    pnRow.Size = new Size(ttw, cc);
                    pnRow.Location = new Point(-1, (cc - 1) * (i + 1));

                    pnSTT.BorderStyle = BorderStyle.FixedSingle;
                    pnSTT.Size = new Size(sw, cc);
                    pnSTT.Location = new Point(-1, -1);

                    Label lbSTT = new Label();
                    lbSTT.Height = pnSTT.Height;
                    lbSTT.Width = pnSTT.Width;
                    lbSTT.Text = "" + i + 1;
                    lbSTT.TextAlign = ContentAlignment.MiddleCenter;
                    pnSTT.Controls.Add(lbSTT);


                    pnChiNhanh.BorderStyle = BorderStyle.FixedSingle;
                    pnChiNhanh.Size = new Size(cnw, cc);
                    pnChiNhanh.Location = new Point(pnSTT.Location.X + sw - 1, -1);

                    Label lbCN = new Label();
                    lbCN.Height = pnChiNhanh.Height;
                    lbCN.Width = pnChiNhanh.Width;
                    lbCN.Text = data.Rows[i].ItemArray[0].ToString();
                    lbCN.TextAlign = ContentAlignment.MiddleCenter;
                    pnChiNhanh.Controls.Add(lbCN);

                    pnMaMon.BorderStyle = BorderStyle.FixedSingle;
                    pnMaMon.Size = new Size(mmw, cc);
                    pnMaMon.Location = new Point(pnChiNhanh.Location.X + cnw - 1, -1);

                    Label lbMM = new Label();
                    lbMM.Height = pnMaMon.Height;
                    lbMM.Width = pnMaMon.Width;
                    lbMM.Text = data.Rows[i].ItemArray[1].ToString();
                    lbMM.TextAlign = ContentAlignment.MiddleCenter;
                    pnMaMon.Controls.Add(lbMM);


                    pnTenMon.BorderStyle = BorderStyle.FixedSingle;
                    pnTenMon.Size = new Size(tw, cc);
                    pnTenMon.Location = new Point(pnMaMon.Location.X + mmw - 1, -1);

                    Label lbTM = new Label();
                    lbTM.Height = pnTenMon.Height;
                    lbTM.Width = pnTenMon.Width;
                    lbTM.Text = data.Rows[i].ItemArray[2].ToString();
                    lbTM.TextAlign = ContentAlignment.MiddleCenter;
                    pnTenMon.Controls.Add(lbTM);

                    pnSoLuong.BorderStyle = BorderStyle.FixedSingle;
                    pnSoLuong.Size = new Size(slw + 7, cc);
                    pnSoLuong.Location = new Point(pnTenMon.Location.X + tw - 1, -1);

                    Label lbSL = new Label();
                    lbSL.Height = pnSoLuong.Height;
                    lbSL.Width = pnSoLuong.Width;
                    lbSL.Text = data.Rows[i].ItemArray[3].ToString();
                    lbSL.TextAlign = ContentAlignment.MiddleCenter;
                    pnSoLuong.Controls.Add(lbSL);

                    pnRow.Controls.Add(pnSTT);
                    pnRow.Controls.Add(pnChiNhanh);
                    pnRow.Controls.Add(pnMaMon);
                    pnRow.Controls.Add(pnTenMon);
                    pnRow.Controls.Add(pnSoLuong);
                    pnCTSLM.Controls.Add(pnRow);
                }
            }
        }


        //------------------------------------------------------------------------
        //-----------------------------------------------------------------------------


        private void load_control()
        {
            DateTime dt = DateTime.Today;

            for (int i = 0; i <= dt.Year - 1980; i++)
            {
                cbbNam.Items.Add(i + 1980);
            }

            //combox: Add quý
            cbbQuy.Items.Add(1);
            cbbQuy.Items.Add(2);
            cbbQuy.Items.Add(3);
            cbbQuy.Items.Add(4);

            //combox: tháng thứ i của quý j
            cbbThang.Items.Add(1);
            cbbThang.Items.Add(2);
            cbbThang.Items.Add(3);

            cbbTuan.Items.Add(1);
            cbbTuan.Items.Add(2);
            cbbTuan.Items.Add(3);
            cbbTuan.Items.Add(4);

            cbbNgay.Items.Add(1);
            cbbNgay.Items.Add(2);
            cbbNgay.Items.Add(3);
            cbbNgay.Items.Add(4);
            cbbNgay.Items.Add(5);
            cbbNgay.Items.Add(6);
            cbbNgay.Items.Add(7);


        }




        void XulyNgayThang()
        {
            if (dtpKT.Enabled == false && dtpBD.Enabled == false)
            {
                if (cbbNam.SelectedItem != null && cbbThang.SelectedItem == null && cbbTuan.SelectedItem == null && cbbQuy.SelectedItem == null && cbbNgay.SelectedItem == null)
                {
                    string tBD = "1/1/" + cbbNam.SelectedItem.ToString();
                    dtpBD.Value = DateTime.Parse(tBD);

                    string tKT = "12/31/" + cbbNam.SelectedItem.ToString();
                    dtpKT.Value = DateTime.Parse(tKT);
                }

                if (cbbNam.SelectedItem != null && cbbThang.SelectedItem == null && cbbTuan.SelectedItem == null && cbbQuy.SelectedItem != null && cbbNgay.SelectedItem == null)
                {
                    int thangBD = int.Parse(cbbQuy.SelectedItem.ToString()) * 3 - 2;
                    int thangKT = int.Parse(cbbQuy.SelectedItem.ToString()) * 3;

                    string tBD = thangBD + "/1/" + cbbNam.SelectedItem.ToString();
                    dtpBD.Value = DateTime.Parse(tBD);

                    if (cbbQuy.SelectedItem.ToString() == "1")
                    {
                        string tKT = thangKT + "/31/" + cbbNam.SelectedItem.ToString();
                        dtpKT.Value = DateTime.Parse(tKT);
                    }

                    if (cbbQuy.SelectedItem.ToString() == "2")
                    {
                        string tKT = thangKT + "/30/" + cbbNam.SelectedItem.ToString();
                        dtpKT.Value = DateTime.Parse(tKT);
                    }

                    if (cbbQuy.SelectedItem.ToString() == "3")
                    {
                        string tKT = thangKT + "/30/" + cbbNam.SelectedItem.ToString();
                        dtpKT.Value = DateTime.Parse(tKT);
                    }

                    if (cbbQuy.SelectedItem.ToString() == "4")
                    {
                        string tKT = thangKT + "/31/" + cbbNam.SelectedItem.ToString();
                        dtpKT.Value = DateTime.Parse(tKT);
                    }
                }

                if (cbbNam.SelectedItem != null && cbbThang.SelectedItem != null && cbbTuan.SelectedItem == null && cbbQuy.SelectedItem != null && cbbNgay.SelectedItem == null)
                {
                    string nBD;
                    string nKT;
                    if (LaNamNhuan(int.Parse(cbbNam.SelectedItem.ToString())))
                    {
                        if (cbbQuy.SelectedItem.ToString() == "1")
                        {
                            if (cbbThang.SelectedItem.ToString() == "1" || cbbThang.SelectedItem.ToString() == "3")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/31/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                            if (cbbThang.SelectedItem.ToString() == "2")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/29/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                        }

                        if (cbbQuy.SelectedItem.ToString() == "2")
                        {
                            if (cbbThang.SelectedItem.ToString() == "1" || cbbThang.SelectedItem.ToString() == "3")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/30/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                            if (cbbThang.SelectedItem.ToString() == "2")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/31/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                        }

                        if (cbbQuy.SelectedItem.ToString() == "3")
                        {
                            if (cbbThang.SelectedItem.ToString() == "2" || cbbThang.SelectedItem.ToString() == "3")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/31/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                            if (cbbThang.SelectedItem.ToString() == "1")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/30/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                        }

                        if (cbbQuy.SelectedItem.ToString() == "4")
                        {
                            if (cbbThang.SelectedItem.ToString() == "1" || cbbThang.SelectedItem.ToString() == "3")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/31/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                            if (cbbThang.SelectedItem.ToString() == "2")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/30/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                        }
                    }
                    else
                    {
                        if (cbbQuy.SelectedItem.ToString() == "1")
                        {
                            if (cbbThang.SelectedItem.ToString() == "1" || cbbThang.SelectedItem.ToString() == "3")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/31/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                            if (cbbThang.SelectedItem.ToString() == "2")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/28/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                        }

                        if (cbbQuy.SelectedItem.ToString() == "2")
                        {
                            if (cbbThang.SelectedItem.ToString() == "1" || cbbThang.SelectedItem.ToString() == "3")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/30/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                            if (cbbThang.SelectedItem.ToString() == "2")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/31/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                        }

                        if (cbbQuy.SelectedItem.ToString() == "3")
                        {
                            if (cbbThang.SelectedItem.ToString() == "2" || cbbThang.SelectedItem.ToString() == "3")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/31/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                            if (cbbThang.SelectedItem.ToString() == "1")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/30/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                        }

                        if (cbbQuy.SelectedItem.ToString() == "4")
                        {
                            if (cbbThang.SelectedItem.ToString() == "1" || cbbThang.SelectedItem.ToString() == "3")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/31/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                            if (cbbThang.SelectedItem.ToString() == "2")
                            {
                                nBD = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/1/" + cbbNam.SelectedItem.ToString();
                                nKT = int.Parse(cbbThang.SelectedItem.ToString()) * int.Parse(cbbQuy.SelectedItem.ToString()) + "/30/" + cbbNam.SelectedItem.ToString();
                                dtpBD.Value = DateTime.Parse(nBD);
                                dtpKT.Value = DateTime.Parse(nKT);
                            }
                        }
                    }
                }
                //-------------------------
                if (cbbNam.SelectedItem != null && cbbThang.SelectedItem != null && cbbTuan.SelectedItem != null && cbbQuy.SelectedItem != null && cbbNgay.SelectedItem == null)
                {
                    int nBD, nKT;
                    if (LaNamNhuan(int.Parse(cbbNam.SelectedItem.ToString())))
                    {
                        //QUy 1
                        if (cbbQuy.SelectedItem.ToString() == "1")
                        {
                            if (cbbThang.SelectedItem.ToString() == "2")
                            {
                                if (cbbTuan.SelectedItem.ToString() == "4")
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = 29;
                                }
                                else
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = int.Parse(cbbTuan.SelectedItem.ToString()) * 7;
                                }
                            }
                            else
                            {
                                if (cbbTuan.SelectedItem.ToString() == "4")
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = 31;
                                }
                                else
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = int.Parse(cbbTuan.SelectedItem.ToString()) * 7;
                                }
                            }
                        }
                        //quy2
                        if (cbbQuy.SelectedItem.ToString() == "2")
                        {
                            if (cbbThang.SelectedItem.ToString() == "2")
                            {
                                if (cbbTuan.SelectedItem.ToString() == "4")
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = 31;
                                }
                                else
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = int.Parse(cbbTuan.SelectedItem.ToString()) * 7;
                                }
                            }
                            else
                            {
                                if (cbbTuan.SelectedItem.ToString() == "4")
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = 30;
                                }
                                else
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = int.Parse(cbbTuan.SelectedItem.ToString()) * 7;
                                }
                            }
                        }
                        //quy3
                        if (cbbQuy.SelectedItem.ToString() == "3")
                        {
                            if (cbbThang.SelectedItem.ToString() == "3")
                            {
                                if (cbbTuan.SelectedItem.ToString() == "4")
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = 30;
                                }
                                else
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = int.Parse(cbbTuan.SelectedItem.ToString()) * 7;
                                }
                            }
                            else
                            {
                                if (cbbTuan.SelectedItem.ToString() == "4")
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = 31;
                                }
                                else
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = int.Parse(cbbTuan.SelectedItem.ToString()) * 7;
                                }
                            }
                        }
                        //quy4
                        if (cbbQuy.SelectedItem.ToString() == "4")
                        {
                            if (cbbThang.SelectedItem.ToString() == "2")
                            {
                                if (cbbTuan.SelectedItem.ToString() == "4")
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = 30;
                                }
                                else
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = int.Parse(cbbTuan.SelectedItem.ToString()) * 7;
                                }
                            }
                            else
                            {
                                if (cbbTuan.SelectedItem.ToString() == "4")
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = 31;
                                }
                                else
                                {
                                    nBD = (int.Parse(cbbTuan.SelectedItem.ToString()) - 1) * 7;
                                    nKT = int.Parse(cbbTuan.SelectedItem.ToString()) * 7;
                                }
                            }
                        }
                    }
                }
            }
        }

        bool LaNamNhuan(int Nam)
        {
            return Nam % 4 == 0 && Nam % 100 != 0 ? true : false;
        }

        private void cbbChonLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonLich.SelectedItem == "Theo lịch năm")
            {
                dtpBD.Enabled = true;
                dtpKT.Enabled = true;
                cbbNam.Enabled = false;
                cbbNgay.Enabled = false;
                cbbQuy.Enabled = false;
                cbbThang.Enabled = false;
                cbbTuan.Enabled = false;


            }
            else if (cbbChonLich.SelectedItem == "Theo lịch làm việc")
            {
                cbbNam.Enabled = true;
                cbbNgay.Enabled = true;
                cbbQuy.Enabled = true;
                cbbThang.Enabled = true;
                cbbTuan.Enabled = true;
                dtpBD.Enabled = false;
                dtpKT.Enabled = false;

            }
        }

        private void pnSoLuongMon_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
