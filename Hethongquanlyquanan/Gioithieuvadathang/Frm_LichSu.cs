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

namespace Gioithieuvadathang
{
    public partial class Frm_LichSu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string makh = "";
        BUS_HoaDon busHD = new BUS_HoaDon();
        BUS_ChiNhanh busCN = new BUS_ChiNhanh();

        public Frm_LichSu()
        {
            InitializeComponent();
        }

        private void Frm_LichSu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lbMaKH.Text = makh;
            VeHeadBangLS();
            VeBodyBangLS(busHD.DanhSachHDTheoKH(makh));
        }

        private void VeHeadBangLS()
        {
            pnLS.Controls.Clear();
            Panel pn_HMaHD = new Panel();
            Panel pn_HTongtien = new Panel();
            Panel pn_HNgaytao = new Panel();
            Panel pn_HManhanvien = new Panel();
            Panel pn_HTenchinhanh = new Panel();
            Panel pn_HTrangthai = new Panel();
            
            Label lb_HMaHD = new Label();
            Label lb_HTongtien = new Label();
            Label lb_HNgaytao = new Label();
            Label lb_HManhanvien = new Label();
            Label lb_HTenchinhanh = new Label();
            Label lb_HTrangthai = new Label();
            
            int scaleHMaHD = 10;
            int scaleHTongtien = 15;
            int scaleHNgaytao = 15;
            int scaleHManhanvien = 10;
            int scaleHTenchinhanh = 35;
            int scaleHTrangthai = 15;

            int cc = 35;
            int crpn = 824;
            int crpnHMaHD = (crpn * scaleHMaHD) / 100;
            int crpnHTongtien = (crpn * scaleHTongtien) / 100;
            int crpnHNgaytao = (crpn * scaleHNgaytao) / 100;
            int crpnHManhanvien = (crpn * scaleHManhanvien) / 100;
            int crpnHTenchinhanh = (crpn * scaleHTenchinhanh) / 100;
            int crpnHTrangthai = (crpn * scaleHTrangthai) / 100;

            pn_HMaHD.BorderStyle = BorderStyle.FixedSingle;
            pn_HMaHD.Size = new Size(crpnHMaHD, cc);
            pn_HMaHD.Location = new Point(0, 0);

            lb_HMaHD.Width = pn_HMaHD.Width;
            lb_HMaHD.Height = pn_HMaHD.Height;
            lb_HMaHD.Text = "Mã hóa đơn";
            lb_HMaHD.TextAlign = ContentAlignment.MiddleCenter;
            lb_HMaHD.Location = new Point(0, 0);
            pn_HMaHD.Controls.Add(lb_HMaHD);

            pn_HTongtien.BorderStyle = BorderStyle.FixedSingle;
            pn_HTongtien.Size = new Size(crpnHTongtien, cc);
            pn_HTongtien.Location = new Point(pn_HMaHD.Location.X + pn_HMaHD.Width - 1, 0);

            lb_HTongtien.Width = pn_HTongtien.Width;
            lb_HTongtien.Height = pn_HTongtien.Height;
            lb_HTongtien.Text = "Tổng tiền";
            lb_HTongtien.TextAlign = ContentAlignment.MiddleCenter;
            lb_HTongtien.Location = new Point(0, 0);
            pn_HTongtien.Controls.Add(lb_HTongtien);

            pn_HNgaytao.BorderStyle = BorderStyle.FixedSingle;
            pn_HNgaytao.Size = new Size(crpnHNgaytao, cc);
            pn_HNgaytao.Location = new Point(pn_HTongtien.Location.X + pn_HTongtien.Width - 1, 0);

            lb_HNgaytao.Width = pn_HNgaytao.Width;
            lb_HNgaytao.Height = pn_HNgaytao.Height;
            lb_HNgaytao.Text = "Ngày tạo";
            lb_HNgaytao.TextAlign = ContentAlignment.MiddleCenter;
            lb_HNgaytao.Location = new Point(0, 0);
            pn_HNgaytao.Controls.Add(lb_HNgaytao);

            pn_HManhanvien.BorderStyle = BorderStyle.FixedSingle;
            pn_HManhanvien.Size = new Size(crpnHManhanvien, cc);
            pn_HManhanvien.Location = new Point(pn_HNgaytao.Location.X + pn_HNgaytao.Width - 1, 0);

            lb_HManhanvien.Width = pn_HManhanvien.Width;
            lb_HManhanvien.Height = pn_HManhanvien.Height;
            lb_HManhanvien.Text = "Mã nhân viên";
            lb_HManhanvien.TextAlign = ContentAlignment.MiddleCenter;
            lb_HManhanvien.Location = new Point(0, 0);
            pn_HManhanvien.Controls.Add(lb_HManhanvien);

            pn_HTenchinhanh.BorderStyle = BorderStyle.FixedSingle;
            pn_HTenchinhanh.Size = new Size(crpnHTenchinhanh, cc);
            pn_HTenchinhanh.Location = new Point(pn_HManhanvien.Location.X + pn_HManhanvien.Width - 1, 0);

            lb_HTenchinhanh.Width = pn_HTenchinhanh.Width;
            lb_HTenchinhanh.Height = pn_HTenchinhanh.Height;
            lb_HTenchinhanh.Text = "Tên chi nhánh";
            lb_HTenchinhanh.TextAlign = ContentAlignment.MiddleCenter;
            lb_HTenchinhanh.Location = new Point(0, 0);
            pn_HTenchinhanh.Controls.Add(lb_HTenchinhanh);

            pn_HTrangthai.BorderStyle = BorderStyle.FixedSingle;
            pn_HTrangthai.Size = new Size(crpnHTrangthai, cc);
            pn_HTrangthai.Location = new Point(pn_HTenchinhanh.Location.X + pn_HTenchinhanh.Width - 1, 0);

            lb_HTrangthai.Width = pn_HTrangthai.Width;
            lb_HTrangthai.Height = pn_HTrangthai.Height;
            lb_HTrangthai.Text = "Trạng thái";
            lb_HTrangthai.TextAlign = ContentAlignment.MiddleCenter;
            lb_HTrangthai.Location = new Point(0, 0);
            pn_HTrangthai.Controls.Add(lb_HTrangthai);
            
            pnLS.Controls.Add(pn_HMaHD);
            pnLS.Controls.Add(pn_HTongtien);
            pnLS.Controls.Add(pn_HNgaytao);
            pnLS.Controls.Add(pn_HManhanvien);
            pnLS.Controls.Add(pn_HTenchinhanh);
            pnLS.Controls.Add(pn_HTrangthai);
        }

        private void VeBodyBangLS(DataTable dt)
        {
            Panel pn_Row = null;
            Panel pn_BMaHD = null;
            Panel pn_BTongtien = null;
            Panel pn_BNgaytao = null;
            Panel pn_BManhanvien = null;
            Panel pn_BTenchinhanh = null;
            Panel pn_BTrangthai = null;

            Label lb_BMaHD = null;
            Label lb_BTongtien = null;
            Label lb_BNgaytao = null;
            Label lb_BManhanvien = null;
            Label lb_BTenchinhanh = null;
            Label lb_BTrangthai = null;

            int scaleBMaHD = 10;
            int scaleBTongtien = 15;
            int scaleBNgaytao = 15;
            int scaleBManhanvien = 10;
            int scaleBTenchinhanh = 35;
            int scaleBTrangthai = 15;

            int cc = 35;
            int crpn = 824;
            int crpnBMaHD = (crpn * scaleBMaHD) / 100;
            int crpnBTongtien = (crpn * scaleBTongtien) / 100;
            int crpnBNgaytao = (crpn * scaleBNgaytao) / 100;
            int crpnBManhanvien = (crpn * scaleBManhanvien) / 100;
            int crpnBTenchinhanh = (crpn * scaleBTenchinhanh) / 100;
            int crpnBTrangthai = (crpn * scaleBTrangthai) / 100;

            int slls = busHD.SoluongHDTheoKH(makh);

            for (int i = 0; i < slls; i++)
            {
                pn_Row = new Panel();
                pn_BMaHD = new Panel();
                pn_BTongtien = new Panel();
                pn_BNgaytao = new Panel();
                pn_BManhanvien = new Panel();
                pn_BTenchinhanh = new Panel();
                pn_BTrangthai = new Panel();

                lb_BMaHD = new Label();
                lb_BTongtien = new Label();
                lb_BNgaytao = new Label();
                lb_BManhanvien = new Label();
                lb_BTenchinhanh = new Label();
                lb_BTrangthai = new Label();

                pn_Row.BorderStyle = BorderStyle.FixedSingle;
                pn_Row.Size = new Size(crpn - 8, cc);
                pn_Row.Location = new Point(0, 34 + (34 * i));
                
                pn_BMaHD.Size = new Size(crpnBMaHD - 1, cc);
                pn_BMaHD.Location = new Point(-1, -1);

                lb_BMaHD.Width = pn_BMaHD.Width;
                lb_BMaHD.Height = pn_BMaHD.Height;
                lb_BMaHD.Text = dt.Rows[i].ItemArray[0].ToString();
                lb_BMaHD.TextAlign = ContentAlignment.MiddleCenter;
                lb_BMaHD.Location = new Point(0, 0);
                pn_BMaHD.Controls.Add(lb_BMaHD);
                
                pn_BTongtien.Size = new Size(crpnBTongtien, cc);
                pn_BTongtien.Location = new Point(pn_BMaHD.Location.X + pn_BMaHD.Width, -1);

                lb_BTongtien.Width = pn_BTongtien.Width;
                lb_BTongtien.Height = pn_BTongtien.Height;
                lb_BTongtien.Text = ChuyenDecimalToVND(ChuyenVNDToDecimal(dt.Rows[i].ItemArray[2].ToString()));
                lb_BTongtien.TextAlign = ContentAlignment.MiddleCenter;
                lb_BTongtien.Location = new Point(0, 0);
                pn_BTongtien.Controls.Add(lb_BTongtien);
                
                pn_BNgaytao.Size = new Size(crpnBNgaytao, cc);
                pn_BNgaytao.Location = new Point(pn_BTongtien.Location.X + pn_BTongtien.Width - 1, -1);
            
                lb_BNgaytao.Width = pn_BNgaytao.Width;
                lb_BNgaytao.Height = pn_BNgaytao.Height;
                lb_BNgaytao.Text = dt.Rows[i].ItemArray[3].ToString();
                lb_BNgaytao.TextAlign = ContentAlignment.MiddleCenter;
                lb_BNgaytao.Location = new Point(0, 0);
                pn_BNgaytao.Controls.Add(lb_BNgaytao);
                
                pn_BManhanvien.Size = new Size(crpnBManhanvien, cc);
                pn_BManhanvien.Location = new Point(pn_BNgaytao.Location.X + pn_BNgaytao.Width - 1, -1);
            
                lb_BManhanvien.Width = pn_BManhanvien.Width;
                lb_BManhanvien.Height = pn_BManhanvien.Height;
                lb_BManhanvien.Text = dt.Rows[i].ItemArray[4].ToString();
                lb_BManhanvien.TextAlign = ContentAlignment.MiddleCenter;
                lb_BManhanvien.Location = new Point(0, 0);
                pn_BManhanvien.Controls.Add(lb_BManhanvien);
                
                pn_BTenchinhanh.Size = new Size(crpnBTenchinhanh, cc);
                pn_BTenchinhanh.Location = new Point(pn_BManhanvien.Location.X + pn_BManhanvien.Width - 1, -1);

                lb_BTenchinhanh.Width = pn_BTenchinhanh.Width;
                lb_BTenchinhanh.Height = pn_BTenchinhanh.Height;
                lb_BTenchinhanh.Text = busCN.LayTenCNTuMa(dt.Rows[i].ItemArray[5].ToString());
                lb_BTenchinhanh.TextAlign = ContentAlignment.MiddleCenter;
                lb_BTenchinhanh.Location = new Point(0, 0);
                pn_BTenchinhanh.Controls.Add(lb_BTenchinhanh);
                
                pn_BTrangthai.Size = new Size(crpnBTrangthai, cc);
                pn_BTrangthai.Location = new Point(pn_BTenchinhanh.Location.X + pn_BTenchinhanh.Width - 1, -1);

                lb_BTrangthai.Width = pn_BTrangthai.Width;
                lb_BTrangthai.Height = pn_BTrangthai.Height;
                lb_BTrangthai.Text = int.Parse(dt.Rows[i].ItemArray[7].ToString()) == 0 ? "Đã xử lý" : "Đang xử lý";
                lb_BTrangthai.TextAlign = ContentAlignment.MiddleCenter;
                lb_BTrangthai.Location = new Point(0, 0);
                pn_BTrangthai.Controls.Add(lb_BTrangthai);

                pn_Row.Controls.Add(pn_BMaHD);
                pn_Row.Controls.Add(pn_BTongtien);
                pn_Row.Controls.Add(pn_BNgaytao);
                pn_Row.Controls.Add(pn_BManhanvien);
                pn_Row.Controls.Add(pn_BTenchinhanh);
                pn_Row.Controls.Add(pn_BTrangthai);
                pnLS.Controls.Add(pn_Row);
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
    }
}