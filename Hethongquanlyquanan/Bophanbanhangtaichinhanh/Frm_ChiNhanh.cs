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
        

        private void ThemMonAn(string mamonan)
        {
            MessageBox.Show(mamonan);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            PanelUser();
        }

        private void PanelUser()
        {
            if (btnVisible.Text == "Thực đơn")
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
                btnVisible.Text = "Bàn";
            }
            else if (btnVisible.Text == "Bàn")
            {
                if (!pnUC.Controls.Contains(UC_Ban.Instance))
                {
                    pnUC.Controls.Add(UC_Ban.Instance);
                    UC_Ban.Instance.Dock = DockStyle.Fill;
                    UC_Ban.Instance.BringToFront();
                }
                else
                    UC_Ban.Instance.BringToFront();

                btnVisible.Text = "Thực đơn";
            }
        }

        
        

        private void AddListDSMA(string ma)
        {
            DTO_ItemBill newbill = new DTO_ItemBill();
            string giaban = bus_monan.LayGiaMonAnTheoMa(ma);
            newbill.Ma = ma;
            newbill.Ten = bus_monan.LayTenTuMaMonAn(ma);

            bool flag = false;
            int vitri = 0;

            for(int i = 0; i < lstDSMA.Count; i++)
            {
                if(lstDSMA[i].Ma == ma)
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
            for(int i = 0; i < lstDSMA.Count;i++)
            {
                tongtien += lstDSMA[i].Thanhtien;
            }
            lbTongTien.Text = tongtien.ToString();
        }



        private void PaintHeadHD()
        {
            Panel pnHeadHD = new Panel();

            pnHeadHD.BorderStyle = BorderStyle.FixedSingle;
            pnHeadHD.Location = new Point(0, 0);
            pnHeadHD.Name = "pnHeadHD";
            pnHeadHD.Size = new Size(419, 35);
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
            pnBodyHD.BorderStyle = BorderStyle.FixedSingle;
            pnBodyHD.Location = new Point(pH.Location.X, pH.Location.Y + pH.Height + 5);
            pnBodyHD.Name = "pnBodyHD";
            pnBodyHD.Size = new Size(pH.Width, pnHD.Height - pH.Height - 5);
            
            pnHD.Controls.Add(pnBodyHD);
        }

        private void AddRowPanel(string ma)
        {
            Panel pH = (Panel)pnHD.Controls.Find("pnBodyHD", true).FirstOrDefault();
            Panel pnRow = (Panel)pnHD.Controls.Find("pnRowHD_"+ma, true).FirstOrDefault();
            
            if (pH != null)
            {
                if (pnRow == null)
                {
                    Panel pnRowHD = null;
                    Label lb_SoLuong = null;
                    Label lb_Ten = null;
                    Label lb_Gia = null;
                    Label lb_ThanhTien = null;

                    pnRowHD = new Panel();
                    lb_SoLuong = new Label();
                    lb_Ten = new Label();
                    lb_Gia = new Label();
                    lb_ThanhTien = new Label();

                    int index = 0;

                    for(int i = 0; i < lstDSMA.Count; i++)
                    {
                        if (lstDSMA[i].Ma == ma)
                        {
                            index = i;
                        }
                    }

                    pnRowHD.Location = new Point(0, index * 35);
                    pnRowHD.Name = "pnRowHD_" + ma;
                    pnRowHD.Size = new Size(pH.Width, 35);
                    pnRowHD.BorderStyle = BorderStyle.FixedSingle;

                    lb_SoLuong = new Label();
                    lb_SoLuong.Location = new Point(0, 0);
                    lb_SoLuong.Name = "lbSoLuong_" + ma;
                    lb_SoLuong.Text = "1";
                    pnRowHD.Controls.Add(lb_SoLuong);
                  
                    lb_Ten.Location = new Point(100, 0);
                    lb_Ten.Text = bus_monan.LayTenTuMaMonAn(ma);
                    pnRowHD.Controls.Add(lb_Ten);

                    lb_Gia.Location = new Point(100, lb_Ten.Height + lb_Ten.Location.Y);
                    lb_Gia.Text = bus_monan.LayGiaMonAnTheoMa(ma);
                    pnRowHD.Controls.Add(lb_Gia);

                    lb_ThanhTien.Location = new Point(pnRowHD.Width - lb_ThanhTien.Width, 0);
                    lb_ThanhTien.Name = "lbThanhTien_" + ma;
                    lb_ThanhTien.Text = (int.Parse(bus_monan.LayGiaMonAnTheoMa(ma)) * (int.Parse(lb_SoLuong.Text))).ToString();
                    pnRowHD.Controls.Add(lb_ThanhTien);

                    pH.Controls.Add(pnRowHD);

                    

                }
                else
                {
                    Label lb_SoLuong = (Label)pnHD.Controls.Find("lbSoLuong_" + ma, true).FirstOrDefault();
                    lb_SoLuong.Text = (int.Parse(lb_SoLuong.Text) + 1).ToString();

                    Label lb_ThanhTien = (Label)pnHD.Controls.Find("lbThanhTien_" + ma, true).FirstOrDefault();
                    lb_ThanhTien.Text = (int.Parse(lb_SoLuong.Text)* int.Parse(bus_monan.LayGiaMonAnTheoMa(ma))).ToString();
                }
            }
        }

        private void pnHD_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtKhachDua_EditValueChanged(object sender, EventArgs e)
        {
            if (lbTongTien.Text != "___" && txtKhachDua.Text != "")
            {
                lbTraLai.Text = (decimal.Parse(txtKhachDua.Text) - decimal.Parse(lbTongTien.Text)).ToString();
            }

            if(txtKhachDua.Text == "")
            {
                lbTraLai.Text = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!busHD.KiemTraHD(lbMHD.Text))
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                //hd.Loaihd = rdMangVe.Checked ? 1 : 0;
                hd.Machinhanh = barMaCN.Caption;
                hd.Mahoadon = lbMHD.Text;
                hd.Makhachhang = lbMKH.Text;
                hd.Manhanvien = lbMNV.Text;
                hd.Ngay = barTime.Caption;

                if (busHD.LuuHD(hd) && busHD.LuuCTHD(lbMHD.Text))
                {
                    MessageBox.Show("Hóa đơn đã được lưu!!", "Thông báo");
                }

            }

            pnHD.Controls.Clear();
            lbMHD.Text = "___";
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
    }
}