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
    public partial class Frm_CTHD : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_MonAn bus_monan = new BUS_MonAn();
        BUS_HoaDon busHD = new BUS_HoaDon();

        public string mahd = "";
        public string tongtien = "";
        public string trangthai = "";
        public bool edit = false;

        public Frm_CTHD()
        {
            InitializeComponent();
        }

        private void VeCTHD(DataTable dt)
        {

            Panel pnRowHD = null;
            Label lb_SoLuong = null;
            Label lb_Ten = null;
            Label lb_Gia = null;
            Label lb_ThanhTien = null;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pnRowHD = new Panel();
                lb_SoLuong = new Label();
                lb_Ten = new Label();
                lb_Gia = new Label();
                lb_ThanhTien = new Label();

                string ma = dt.Rows[i].ItemArray[1].ToString();
                pnRowHD.Location = new Point(0, i * 45);
                pnRowHD.Name = "pnRowHD_" + ma;
                pnRowHD.Size = new Size(pnCTHD.Width, 45);

                lb_SoLuong = new Label();
                lb_SoLuong.Location = new Point(0, 0);
                lb_SoLuong.Size = new Size(45, 45);
                lb_SoLuong.TextAlign = ContentAlignment.MiddleCenter;
                lb_SoLuong.Name = "lbSoLuong_" + ma;
                lb_SoLuong.Text = dt.Rows[i].ItemArray[2].ToString();
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

                pnCTHD.Controls.Add(pnRowHD);
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

        private void Frm_CTHD_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lb_MaHD.Text = mahd;
            lb_Tongtien.Text = tongtien;            
            VeCTHD(busHD.LayCTHD(busHD.LayMaCTHD(lb_MaHD.Text)));
            if (int.Parse(trangthai) == 2)
            {
                edit = true;
            }
            if (edit)
            {
                btn_Duyet.Enabled = true;
                btn_Huy.Enabled = true;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (busHD.CapnhattrangthaiHD(lb_MaHD.Text, 3))
            {
                MessageBox.Show("Đã hủy thành công đơn hàng !!!", "Thông báo");
                this.Close();
            }
        }

        private void btn_Duyet_Click(object sender, EventArgs e)
        {
            if (busHD.CapnhattrangthaiHD(lb_MaHD.Text, 1))
            {
                MessageBox.Show("Đã duyệt thành công đơn hàng !!!", "Thông báo");
                this.Close();
            }            
        }        
    }
}