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

            if (btnVisible.Text == "Bàn")
            {
                if (!pnUC.Controls.Contains(UC_MonAn.Instance))
                {
                    pnUC.Controls.Add(UC_MonAn.Instance);
                    UC_MonAn.Instance.AddItems += Instance_AddItems;

                    UC_MonAn.Instance.Dock = DockStyle.Fill;
                    UC_MonAn.Instance.BringToFront();
                }
                else
                    UC_MonAn.Instance.BringToFront();

                btnVisible.Text = "Thực đơn";

            }
            else if (btnVisible.Text == "Thực đơn")
            {
                if (!pnUC.Controls.Contains(UC_Ban.Instance))
                {
                    pnUC.Controls.Add(UC_Ban.Instance);
                    UC_Ban.Instance.Dock = DockStyle.Fill;
                    UC_Ban.Instance.BringToFront();
                }
                else
                    UC_Ban.Instance.BringToFront();

                btnVisible.Text = "Bàn";

            }
        }

        private void Instance_AddItems(string ma)
        {
            Panel pH = (Panel)pnHD.Controls.Find("pnHeadHD", true).FirstOrDefault();

            if(pH != null)
            {
                // Thêm số lượng món ăn trong bill
                MessageBox.Show("Đã tạo bill");
                AddRowPanel(ma);

            }
            else
            {
                PaintHeadHD();
                PaintBodyHD(ma);
                
            }
        }



        private void PaintHeadHD()
        {
            Panel pnHeadHD = null;
            pnHeadHD = new Panel();

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

        }

        private void PaintBodyHD(string ma)
        {
            Panel pH = (Panel)pnHD.Controls.Find("pnHeadHD", true).FirstOrDefault();
            Panel pnBodyHD = null;
            Label lb_Soluong = null;

            pnBodyHD = new Panel();
            pnBodyHD.BorderStyle = BorderStyle.FixedSingle;            
            pnBodyHD.Location = new Point(pH.Location.X, pH.Location.Y + pH.Height + 5);
            //pnBodyHD.Location = new Point(0, 0);
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
                    
                    pnRowHD.Location = new Point(0, 0);
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

                    DTO_ItemBill newbill = new DTO_ItemBill();
                    newbill.Ma = ma;
                    newbill.Ten = lb_Ten.Text;
                    newbill.Soluong = int.Parse(lb_SoLuong.Text);
                    newbill.Thanhtien = decimal.Parse(lb_ThanhTien.Text);
                    if(lstDSMA.Contains(newbill))
                    {
                        int i = lstDSMA.IndexOf(newbill);
                        lstDSMA[i].Soluong = int.Parse(lb_SoLuong.Text); 
                        lstDSMA[i].Thanhtien = decimal.Parse(lb_ThanhTien.Text);

                    }
                    else
                    {
                        lstDSMA.Add(newbill);
                    }
                    
                
                }
                else
                {
                    MessageBox.Show("abc");
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

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(DTO_ItemBill BILL in lstDSMA)
            {
                MessageBox.Show(BILL.Ma + BILL.Soluong + BILL.Thanhtien);
            }
        }
    }
}