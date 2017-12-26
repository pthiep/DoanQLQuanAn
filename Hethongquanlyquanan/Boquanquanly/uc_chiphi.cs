using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boquanquanly
{
    public partial class uc_chiphi : UserControl
    {
        BUS.BUS_ChiNhanh busCN = new BUS.BUS_ChiNhanh();
        BUS.BUS_ChiPhi busCP = new BUS.BUS_ChiPhi();
        private static uc_chiphi _instance;

        public static uc_chiphi Instance
        {
            get {if(_instance == null) _instance = new uc_chiphi(); 
                return _instance; }
            set { uc_chiphi._instance = value; }
        }
        public uc_chiphi()
        {
            InitializeComponent();
        }

        private void uc_chiphi_Load(object sender, EventArgs e)
        {
            load_control();
            vebangchiphi();
        }

        void vebangchiphi() {
            pnChiPhi.Controls.Clear();
            Panel pnStt = new Panel();
            Panel pnChiNhanh = new Panel();
            Panel pnDien = new Panel();
            Panel pnNuoc = new Panel();
            Panel pnNet = new Panel();
            Panel pnLuongNV = new Panel();
            Panel pnKhac = new Panel();

            int cc = 35;
            int ttw = pnChiPhi.Width;
            int sttw = 5;
            int cnw = 35;
            int dw = 12;
            int Nw = 12;
            int Ntw = 12;
            int Lw = 12;
            int Kw = 12;

            int wstt = sttw * ttw / 100;
            int wcn = cnw * ttw / 100;
            int wd = dw * ttw / 100;
            int wn = Nw * ttw / 100;
            int wnt = Ntw * ttw / 100;
            int wL = Lw * ttw / 100;
            int wK = Kw * ttw / 100;

            pnStt.BorderStyle = BorderStyle.FixedSingle;
            pnStt.Size = new Size(wstt, cc);
            pnStt.Location = new Point(1, 0);

            Label lbStt = new Label();
            lbStt.Height = pnStt.Height;
            lbStt.Width = pnStt.Width;
            lbStt.Text = "STT";
            lbStt.TextAlign = ContentAlignment.MiddleCenter;
            pnStt.Controls.Add(lbStt);


            pnChiNhanh.BorderStyle = BorderStyle.FixedSingle;
            pnChiNhanh.Size = new Size(wcn, cc);
            pnChiNhanh.Location = new Point(pnStt.Location.X + wstt - 1, 0);

            Label lbCn = new Label();
            lbCn.Height = pnChiNhanh.Height;
            lbCn.Width = pnChiNhanh.Width;
            lbCn.Text = "Chi Nhanh";
            lbCn.TextAlign = ContentAlignment.MiddleCenter;
            pnChiNhanh.Controls.Add(lbCn);

            pnDien.BorderStyle = BorderStyle.FixedSingle;
            pnDien.Size = new Size(wd, cc);
            pnDien.Location = new Point(pnChiNhanh.Location.X + wcn - 1, 0);

            Label lbDien = new Label();
            lbDien.Height = pnDien.Height;
            lbDien.Width = pnDien.Width;
            lbDien.Text = "Tiền điện";
            lbDien.TextAlign = ContentAlignment.MiddleCenter;
            pnDien.Controls.Add(lbDien);

            pnNuoc.BorderStyle = BorderStyle.FixedSingle;
            pnNuoc.Size = new Size(wn, cc);
            pnNuoc.Location = new Point(pnDien.Location.X + wn - 1, 0);

            Label lbNuoc = new Label();
            lbNuoc.Height = pnNuoc.Height;
            lbNuoc.Width = pnNuoc.Width;
            lbNuoc.Text = "Tiền nuớc";
            lbNuoc.TextAlign = ContentAlignment.MiddleCenter;
            pnNuoc.Controls.Add(lbNuoc);

            pnNet.BorderStyle = BorderStyle.FixedSingle;
            pnNet.Size = new Size(wnt, cc);
            pnNet.Location = new Point(pnNuoc.Location.X + wn - 1, 0);

            Label lbNet = new Label();
            lbNet.Height = pnNet.Height;
            lbNet.Width = pnNet.Width;
            lbNet.Text = "Tiền net";
            lbNet.TextAlign = ContentAlignment.MiddleCenter;
            pnNet.Controls.Add(lbNet);


            pnLuongNV.BorderStyle = BorderStyle.FixedSingle;
            pnLuongNV.Size = new Size(wL, cc);
            pnLuongNV.Location = new Point(pnNet.Location.X + wnt - 1, 0);

            Label lbLuong = new Label();
            lbLuong.Height = pnLuongNV.Height;
            lbLuong.Width = pnLuongNV.Width;
            lbLuong.Text = "Tổng Tiền Lương";
            lbLuong.TextAlign = ContentAlignment.MiddleCenter;
            pnLuongNV.Controls.Add(lbLuong);


            pnKhac.BorderStyle = BorderStyle.FixedSingle;
            pnKhac.Size = new Size(wK, cc);
            pnKhac.Location = new Point(pnLuongNV.Location.X + wL - 1, 0);

            Label lbKhac = new Label();
            lbKhac.Height = pnKhac.Height;
            lbKhac.Width = pnKhac.Width;
            lbKhac.Text = "Khác";
            lbKhac.TextAlign = ContentAlignment.MiddleCenter;
            pnKhac.Controls.Add(lbKhac);

            pnChiPhi.Controls.Add(pnStt);
            pnChiPhi.Controls.Add(pnChiNhanh);
            pnChiPhi.Controls.Add(pnLuongNV);
            pnChiPhi.Controls.Add(pnDien);
            pnChiPhi.Controls.Add(pnNuoc);
            pnChiPhi.Controls.Add(pnNet);
            pnChiPhi.Controls.Add(pnKhac);
        }


        void vebangchiphi(DataTable data)
        {

            Panel pnStt = new Panel();
            Panel pnChiNhanh = new Panel();
            Panel pnDien = new Panel();
            Panel pnNuoc = new Panel();
            Panel pnNet = new Panel();
            Panel pnLuongNV = new Panel();
            Panel pnKhac = new Panel();
            Panel pnRow = new Panel();

            int cc = 35;
            int ttw = pnChiPhi.Width;
            int sttw = 5;
            int cnw = 35;
            int dw = 12;
            int Nw = 12;
            int Ntw = 12;
            int Lw = 12;
            int Kw = 12;

            int wstt = sttw * ttw / 100;
            int wcn = cnw * ttw / 100;
            int wd = dw * ttw / 100;
            int wn = Nw * ttw / 100;
            int wnt = Ntw * ttw / 100;
            int wL = Lw * ttw / 100;
            int wK = Kw * ttw / 100;
            int wr = ttw;

            int slcn = data.Rows.Count;

            for (int i = 0; i < slcn; i++) {
                pnStt = new Panel();
                pnChiNhanh = new Panel();
                pnDien = new Panel();
                pnNuoc = new Panel();
                pnNet = new Panel();
                pnLuongNV = new Panel();
                pnKhac = new Panel();
                pnRow = new Panel();

                pnRow.BorderStyle = BorderStyle.FixedSingle;
                pnRow.Size = new Size(ttw, cc);
                pnRow.Location = new Point(1 , (cc - 1) * (i + 1));

                    pnStt.BorderStyle = BorderStyle.FixedSingle;
                    pnStt.Size = new Size(wstt, cc);
                    pnStt.Location = new Point(-1, -1);

                    Label lbStt = new Label();
                    lbStt.Height = pnStt.Height;
                    lbStt.Width = pnStt.Width;
                    lbStt.Text = "" + i + 1;
                    lbStt.TextAlign = ContentAlignment.MiddleCenter;
                    pnStt.Controls.Add(lbStt);


                    pnChiNhanh.BorderStyle = BorderStyle.FixedSingle;
                    pnChiNhanh.Size = new Size(wcn, cc);
                    pnChiNhanh.Location = new Point(pnStt.Location.X + wstt - 1, -1);

                    Label lbCn = new Label();
                    lbCn.Height = pnChiNhanh.Height;
                    lbCn.Width = pnChiNhanh.Width;
                    lbCn.Text = data.Rows[i].ItemArray[0].ToString();
                    lbCn.TextAlign = ContentAlignment.MiddleCenter;
                    pnChiNhanh.Controls.Add(lbCn);

                    pnDien.BorderStyle = BorderStyle.FixedSingle;
                    pnDien.Size = new Size(wd, cc);
                    pnDien.Location = new Point(pnChiNhanh.Location.X + wcn - 1, -1);

                    Label lbDien = new Label();
                    lbDien.Height = pnDien.Height;
                    lbDien.Width = pnDien.Width;
                    lbDien.Text = data.Rows[i].ItemArray[1].ToString();
                    lbDien.TextAlign = ContentAlignment.MiddleCenter;
                    pnDien.Controls.Add(lbDien);

                    pnNuoc.BorderStyle = BorderStyle.FixedSingle;
                    pnNuoc.Size = new Size(wn, cc);
                    pnNuoc.Location = new Point(pnDien.Location.X + wn - 1, -1);

                    Label lbNuoc = new Label();
                    lbNuoc.Height = pnNuoc.Height;
                    lbNuoc.Width = pnNuoc.Width;
                    lbNuoc.Text = data.Rows[i].ItemArray[2].ToString();
                    lbNuoc.TextAlign = ContentAlignment.MiddleCenter;
                    pnNuoc.Controls.Add(lbNuoc);

                    pnNet.BorderStyle = BorderStyle.FixedSingle;
                    pnNet.Size = new Size(wnt, cc);
                    pnNet.Location = new Point(pnNuoc.Location.X + wn - 1, -1);

                    Label lbNet = new Label();
                    lbNet.Height = pnNet.Height;
                    lbNet.Width = pnNet.Width;
                    lbNet.Text = data.Rows[i].ItemArray[3].ToString();
                    lbNet.TextAlign = ContentAlignment.MiddleCenter;
                    pnNet.Controls.Add(lbNet);


                    pnLuongNV.BorderStyle = BorderStyle.FixedSingle;
                    pnLuongNV.Size = new Size(wL, cc);
                    pnLuongNV.Location = new Point(pnNet.Location.X + wnt - 1, -1);

                    Label lbLuong = new Label();
                    lbLuong.Height = pnLuongNV.Height;
                    lbLuong.Width = pnLuongNV.Width;
                    lbLuong.Text = data.Rows[i].ItemArray[4].ToString();
                    lbLuong.TextAlign = ContentAlignment.MiddleCenter;
                    pnLuongNV.Controls.Add(lbLuong);


                    pnKhac.BorderStyle = BorderStyle.FixedSingle;
                    pnKhac.Size = new Size(wK, cc);
                    pnKhac.Location = new Point(pnLuongNV.Location.X + wL - 1, -1);

                    Label lbKhac = new Label();
                    lbKhac.Height = pnKhac.Height;
                    lbKhac.Width = pnKhac.Width;
                    lbKhac.Text = data.Rows[i].ItemArray[5].ToString();
                    lbKhac.TextAlign = ContentAlignment.MiddleCenter;
                    pnKhac.Controls.Add(lbKhac);

                    pnRow.Controls.Add(pnStt);
                    pnRow.Controls.Add(pnChiNhanh);
                    pnRow.Controls.Add(pnDien);
                    pnRow.Controls.Add(pnNuoc);
                    pnRow.Controls.Add(pnNet);
                    pnRow.Controls.Add(pnLuongNV);
                    pnRow.Controls.Add(pnKhac);
                    pnChiPhi.Controls.Add(pnRow);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void load_control()
        {
            DateTime dt = DateTime.Today;

            for (int i = 0; i <= dt.Year - 1980; i ++)
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

        private void btXem_Click(object sender, EventArgs e)
        {
            DataTable dt = busCP.TinhChiPhi(dtpBD.Value, dtpKT.Value);
            DataTable dttong = busCP.TongChiPhi(dtpBD.Value, dtpKT.Value);
            XulyNgayThang();

            if(dt.Rows != null && dttong.Rows != null){
                lbChiPhi.Text = dttong.Rows[0].ItemArray[0].ToString();
                vebangchiphi(dt);
            }
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

    }
}
