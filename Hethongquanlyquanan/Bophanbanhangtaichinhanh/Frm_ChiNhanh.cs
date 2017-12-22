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


namespace Bophanbanhangtaichinhanh
{
    public partial class Frm_ChiNhanh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<DTO_ItemBill> lstDSMA = new List<DTO_ItemBill>();

        BUS_MonAn bus_monan = new BUS_MonAn();
        BUS_HoaDon busHD = new BUS_HoaDon();
        BUS_Clock busClock = new BUS_Clock();
        BUS_DanhMuc busDM = new BUS_DanhMuc();

        bool lamangve = false;

        public Frm_ChiNhanh()
        {
            InitializeComponent();
        }

        private void Frm_ChiNhanh_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            PanelUser();
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
            txtKhachDua.Enabled = true;
            btnBaoBep.Enabled = true;
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

        private void txtKhachDua_EditValueChanged(object sender, EventArgs e)
        {
            pnHD.Focus();
            txtKhachDua.Focus();
            if (txtKhachDua.Text == " VND")
            {
                txtKhachDua.Text = "0 VND";
            }
            else
            {
                txtKhachDua.Text = ChuyenDecimalToVND(ChuyenVNDToDecimal(txtKhachDua.Text + " VND"));
                txtKhachDua.SelectionStart = txtKhachDua.Text.Length - 4;
                if (lbTongTien.Text != "___" && txtKhachDua.Text != "")
                {
                    lbTraLai.Text = ChuyenDecimalToVND(ChuyenVNDToDecimal(txtKhachDua.Text) - ChuyenVNDToDecimal(lbTongTien.Text));
                }

                if (txtKhachDua.Text == "")
                {
                    lbTraLai.Text = null;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!busHD.KiemTraHD(lbMHD.Text))
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.Loaihd = lamangve ? 1 : 0;
                hd.Machinhanh = barMaCN.Caption;
                hd.Mahoadon = lbMHD.Text;
                hd.Makhachhang = lbMKH.Text;
                hd.Manhanvien = lbMNV.Text;
                hd.Ngay = barTime.Caption;

                if (busHD.LuuHD(hd) && busHD.LuuCTHD(lbMHD.Text))
                {
                    MessageBox.Show("Hóa đơn đã được lưu và in !!", "Thông báo");
                }
            }

            pnHD.Controls.Clear();
            lbMHD.Text = "___";
            btnSave.Enabled = false;
            txtKhachDua.Enabled = false;
        }

        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            TaomoiHD();   
        }

        void TaomoiHD()
        {
            pnHD.Controls.Clear();
            PaintHeadHD();
            PaintBodyHD();
            if (lbMHD.Text != "___" && !busHD.KiemTraHD(lbMHD.Text))
            {
                lbMHD.Text = busHD.TaoMaHD();
                lstDSMA.Clear();
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            barTime.Caption = busClock.TimeServer();
        }

        private void btnMangve_Click(object sender, EventArgs e)
        {
            if (!lamangve)
            {
                btnMangve.BackColor = Color.FromArgb(255, 6, 6);
                lamangve = true;
            }
            else
            {
                btnMangve.BackColor = Color.FromArgb(240, 240, 240);
                lamangve = false;
            }
        }

        private void btnBaoBep_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            string MaHD = lbMHD.Text;
            MessageBox.Show("Đã báo hóa đơn " + MaHD + " xuống bếp !!!", "Thông báo");
            btnBaoBep.Enabled = false;
            
        }

        private void txtKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}