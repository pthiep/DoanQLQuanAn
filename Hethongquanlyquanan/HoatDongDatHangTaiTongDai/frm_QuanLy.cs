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

namespace HoatDongDatHangTaiTongDai
{
    public partial class Frm_Quanly : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_MonAn bus_monan = new BUS_MonAn();
        BUS_HoaDon busHD = new BUS_HoaDon();
        BUS_Clock busClock = new BUS_Clock();
        BUS_DanhMuc busDM = new BUS_DanhMuc();

        List<DTO_ItemBill> lstDSMA = new List<DTO_ItemBill>();

        public Frm_Quanly()
        {
            InitializeComponent();
        }

        private void Frm_Quanly_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            PanelUser();
        }

        void Test()
        {
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();

            foreach(DataRow dt in busKH.DanhSachKhachHang().Rows)
            {
                combData.Add(dt.ItemArray[0].ToString());
            }

            tb_TimkiemKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_TimkiemKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_TimkiemKH.AutoCompleteCustomSource = combData;
        }

        private void PanelUser()
        {
            if (!pnUC.Controls.Contains(UC_MonAn.Instance))
            {
                pnUC.Controls.Add(UC_MonAn.Instance);
                UC_MonAn.Instance.AddItems += Instance_AddItems;
                UC_MonAn.Instance.macn = barMaCN.Caption;
                UC_MonAn.Instance.Dock = DockStyle.Fill;
                UC_MonAn.Instance.BringToFront();
            }
            else
                UC_MonAn.Instance.BringToFront();
        }

        private void Instance_AddItems(string ma)
        {
            Panel pH = (Panel)pnHD.Controls.Find("pnHeadHD", true).FirstOrDefault();
            decimal tongtien = 0;
            if (pH != null)
            {
                AddListDSMA(ma);
                AddRowPanel(ma);
            }
            else
            {
                PaintHeadHD();
                PaintBodyHD();
                lbMHD.Text = busHD.TaoMaHD();
                lstDSMA.Clear();
                AddListDSMA(ma);
                AddRowPanel(ma);
            }
            for (int i = 0; i < lstDSMA.Count; i++)
            {
                tongtien += lstDSMA[i].Thanhtien;
            }
            lbTongTien.Text = ChuyenDecimalToVND(tongtien);
        }

        private void AddListDSMA(string ma)
        {
            DTO_ItemBill newbill = new DTO_ItemBill();
            string giaban = bus_monan.LayGiaMonAnTheoMa(ma);
            newbill.Ma = ma;
            newbill.Ten = bus_monan.LayTenTuMaMonAn(ma);


            bool flag = false;
            int vitri = 0;

            for (int i = 0; i < lstDSMA.Count; i++)
            {
                if (lstDSMA[i].Ma == ma)
                {
                    flag = true;
                    vitri = i;
                    break;
                }
            }

            if (flag)
            {
                lstDSMA[vitri].Soluong++;
                lstDSMA[vitri].Thanhtien = decimal.Parse(giaban) * lstDSMA[vitri].Soluong;
            }
            else
            {
                newbill.Soluong = 1;
                newbill.Thanhtien = decimal.Parse(giaban) * newbill.Soluong;
                lstDSMA.Add(newbill);
            }
        }


        private void PaintHeadHD()
        {
            Panel pnHeadHD = new Panel();

            pnHeadHD.BorderStyle = BorderStyle.FixedSingle;
            pnHeadHD.Location = new Point(0, 0);
            pnHeadHD.Name = "pnHeadHD";
            pnHeadHD.Size = new Size(pnHD.Width, 35);
            pnHeadHD.BackColor = Color.FromArgb(177, 177, 177);
            pnHD.Controls.Add(pnHeadHD);

            Label lbTenNV = new Label();
            lbTenNV.Text = "Nguyễn Văn A";
            lbTenNV.Location = new Point(0, 0);


            Label lbDate = new Label();
            lbDate.Text = "Giờ đến:  10:00:00";
            lbDate.Location = new Point(pnHeadHD.Width - lbDate.Width, 0);

            pnHeadHD.Controls.Add(lbTenNV);
            pnHeadHD.Controls.Add(lbDate);
            lbMHD.Text = busHD.TaoMaHD();
            lstDSMA.Clear();
        }

        private void PaintBodyHD()
        {
            Panel pH = (Panel)pnHD.Controls.Find("pnHeadHD", true).FirstOrDefault();
            Panel pnBodyHD = null;

            pnBodyHD = new Panel();
            pnBodyHD.Location = new Point(pH.Location.X, pH.Location.Y + pH.Height);
            pnBodyHD.Name = "pnBodyHD";
            pnBodyHD.Size = new Size(pH.Width, pnHD.Height - pH.Height - 5);
            pnHD.Controls.Add(pnBodyHD);
        }

        private void AddRowPanel(string ma)
        {
            Panel pH = (Panel)pnHD.Controls.Find("pnBodyHD", true).FirstOrDefault();
            Panel pnRow = (Panel)pnHD.Controls.Find("pnRowHD_" + ma, true).FirstOrDefault();

            if (pH != null)
            {
                if (pnRow == null)
                {
                    Panel pnRowHD = null;
                    Label lb_SoLuong = null;
                    Label lb_Ten = null;
                    Label lb_Gia = null;
                    Label lb_ThanhTien = null;
                    Button btn_ThemSL = null;
                    Button btn_XoaSL = null;
                    Button btn_Xoa = null;

                    pnRowHD = new Panel();
                    lb_SoLuong = new Label();
                    lb_Ten = new Label();
                    lb_Gia = new Label();
                    lb_ThanhTien = new Label();
                    btn_ThemSL = new Button();
                    btn_XoaSL = new Button();
                    btn_Xoa = new Button();

                    int index = 0;


                    for (int i = 0; i < lstDSMA.Count; i++)
                    {
                        if (lstDSMA[i].Ma == ma)
                        {
                            index = i;
                        }
                    }

                    pnRowHD.Location = new Point(0, index * 45);


                    pnRowHD.Name = "pnRowHD_" + ma;
                    pnRowHD.Size = new Size(pH.Width, 45);
                    pnRowHD.BackColor = Color.FromArgb(252, 234, 164);

                    lb_SoLuong = new Label();
                    lb_SoLuong.Location = new Point(0, 0);
                    lb_SoLuong.Size = new Size(45, 45);
                    lb_SoLuong.TextAlign = ContentAlignment.MiddleCenter;
                    lb_SoLuong.Name = "lbSoLuong_" + ma;
                    lb_SoLuong.Text = "1";
                    lb_SoLuong.Font = new Font("tahoma", 15f, FontStyle.Bold);
                    pnRowHD.Controls.Add(lb_SoLuong);

                    lb_Ten.Location = new Point(100, 5);
                    lb_Ten.Text = bus_monan.LayTenTuMaMonAn(ma);
                    lb_Ten.Font = new Font("tahoma", 11f, FontStyle.Bold);
                    pnRowHD.Controls.Add(lb_Ten);

                    lb_Gia.Location = new Point(100, 30);
                    lb_Gia.Text = "Giá : " + bus_monan.LayGiaMonAnTheoMa(ma);
                    pnRowHD.Controls.Add(lb_Gia);

                    lb_ThanhTien.Location = new Point(pnRowHD.Width - lb_ThanhTien.Width - 50, 45 / 2 - 15 / 2);
                    lb_ThanhTien.Name = "lbThanhTien_" + ma;
                    lb_ThanhTien.Size = new Size(115, 16);
                    lb_ThanhTien.Text = ChuyenDecimalToVND(decimal.Parse(bus_monan.LayGiaMonAnTheoMa(ma)) * decimal.Parse(lb_SoLuong.Text));
                    lb_ThanhTien.Font = new Font("tahoma", 11f, FontStyle.Bold);
                    lb_ThanhTien.TextAlign = ContentAlignment.MiddleRight;
                    pnRowHD.Controls.Add(lb_ThanhTien);

                    btn_Xoa.Image = Image.FromFile("C:\\DBMA\\xoama.png");
                    btn_Xoa.Size = new Size(23, 23);
                    btn_Xoa.Location = new Point(pnRowHD.Width - 30, pnRowHD.Height / 2 - 10);
                    pnRowHD.Controls.Add(btn_Xoa);

                    btn_ThemSL.Image = Image.FromFile("C:\\DBMA\\themsl.png");
                    btn_ThemSL.Size = new Size(23, 23);
                    btn_ThemSL.Location = new Point(47, 45 / 2 - 23 / 2);
                    pnRowHD.Controls.Add(btn_ThemSL);

                    btn_XoaSL.Image = Image.FromFile("C:\\DBMA\\xoasl.png");
                    btn_XoaSL.Size = new Size(23, 23);
                    btn_XoaSL.Location = new Point(70, 45 / 2 - 23 / 2);
                    pnRowHD.Controls.Add(btn_XoaSL);

                    pH.Controls.Add(pnRowHD);
                }
                else
                {
                    Label lb_SoLuong = (Label)pnHD.Controls.Find("lbSoLuong_" + ma, true).FirstOrDefault();
                    lb_SoLuong.Text = (int.Parse(lb_SoLuong.Text) + 1).ToString();

                    Label lb_ThanhTien = (Label)pnHD.Controls.Find("lbThanhTien_" + ma, true).FirstOrDefault();
                    lb_ThanhTien.Text = ChuyenDecimalToVND((int.Parse(lb_SoLuong.Text) * int.Parse(bus_monan.LayGiaMonAnTheoMa(ma))));
                }
            }
        }

        string ChuyenDecimalToVND(decimal tien)
        {
            string kq = "";
            string temp = tien.ToString();

            if (temp.Length > 3)
            {
                int sll = temp.Length % 3 == 0 ? temp.Length / 3 : temp.Length / 3 + 1;
                for (int i = 0; i < sll; i++)
                {
                    if (temp.Length > 3)
                    {
                        kq = temp.Substring(temp.Length - 3, 3) + kq;
                        temp = temp.Substring(0, temp.Length - 3);

                        kq = "," + kq;

                    }
                    else
                    {
                        kq = temp + kq;
                    }

                }
            }
            else
            {
                kq = temp;
            }

            kq += " VND";

            return kq;
        }

        decimal ChuyenVNDToDecimal(string tien)
        {
            decimal kq = 0;
            string[] tempsplit = tien.Split(' ');
            string temp = tempsplit[0];
            string temp3 = "";

            string[] temp1 = temp.Split(',');

            for (int i = 0; i < temp1.Count(); i++)
            {
                temp3 += temp1[i];
            }
            kq = decimal.Parse(temp3);

            return kq;
        }

        private void tb_TimkiemKH_TextChanged(object sender, EventArgs e)
        {
            string ma = tb_TimkiemKH.Text;

            if (busKH.KiemTraMaKH(ma))
            {
                DataTable dt = busKH.LayThongTinKhachHang(ma);                
                lb_MaKH.Text = dt.Rows[0].ItemArray[0].ToString();
                lb_TenKH.Text = dt.Rows[0].ItemArray[1].ToString();
                lb_SDT.Text = dt.Rows[0].ItemArray[2].ToString();
            }
            else
            {
                lb_MaKH.Text = "___";
                lb_TenKH.Text = "___";
                lb_SDT.Text = "___";
            }
        }

        private void tb_TimkiemKH_Enter(object sender, EventArgs e)
        {
            if (tb_TimkiemKH.Text == "Nhập tên, sđt hoặc mã khách hàng để tìm !!!")
            {
                tb_TimkiemKH.Text = "";
                tb_TimkiemKH.ForeColor = SystemColors.WindowText;
            }
        }

        private void tb_TimkiemKH_Leave(object sender, EventArgs e)
        {
            if (tb_TimkiemKH.Text.Length == 0)
            {
                tb_TimkiemKH.Text = "Nhập tên, sđt hoặc mã khách hàng để tìm !!!";
                tb_TimkiemKH.ForeColor = SystemColors.GrayText;
            }
        }
    }
}