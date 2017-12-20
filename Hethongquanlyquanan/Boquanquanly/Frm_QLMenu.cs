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
using DTO;
using BUS;
using DevExpress.XtraEditors;

namespace Boquanquanly
{
    public partial class Frm_QLMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_Menu busMenu = new BUS_Menu();
        string tencn = "";
        string macn = "";
        public Frm_QLMenu()
        {
            InitializeComponent();
        }

        public Frm_QLMenu(string tencn, string macn)
        {
            InitializeComponent();
            this.tencn = tencn;
            this.macn = macn;
        }

        private void Frm_QLBan_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lb_Tencn.Text = tencn;
            lb_Macn.Text = macn;
            DataTable dt = busMenu.LoadMenuChiNhanh(macn);
            VeMon();
            //VeDanhMuc("Cơm", new Point(0, 0));
        }

        void VeMon()
        {
            pnBan.Controls.Clear();
            int slDM = busMenu.Sodanhmucchinhanh(macn);
            DataTable dt = busMenu.BanDanhMucChiNhanh(macn);
            int cc = 30;
            for (int i = 0; i < slDM; i++)
            {
                VeDanhMuc(dt.Rows[i].ItemArray[1].ToString(), new Point(0, i * cc));
                VeChiTietBan(macn, i);
            }

        }

        void VeDanhMuc(string tenDM, Point pTenDM)
        {
            Panel pnDanhmuc = null;
            SimpleButton btn_XoaDanhmuc = null;
            Label lb_Tendanhmuc = null;
            SimpleButton btnThem = null;
            SimpleButton btnXoa = null;

            pnDanhmuc = new Panel();
            lb_Tendanhmuc = new Label();

            pnDanhmuc.Name = "pnDanhmuc_" + macn + "_" + tenDM;
            pnDanhmuc.BorderStyle = BorderStyle.FixedSingle;
            pnDanhmuc.Size = new Size(pnBan.Width, 25);
            pnDanhmuc.Location = new Point(pTenDM.X, pTenDM.Y);

            lb_Tendanhmuc.Text = "* " + tenDM;
            lb_Tendanhmuc.Font = new Font(lb_Tendanhmuc.Font.Name, 12, FontStyle.Bold);
            lb_Tendanhmuc.TextAlign = ContentAlignment.MiddleLeft;
            lb_Tendanhmuc.Size = new Size(200, 25);
            lb_Tendanhmuc.BorderStyle = BorderStyle.FixedSingle;
            lb_Tendanhmuc.Location = new Point(0, pnDanhmuc.Height / 2 - lb_Tendanhmuc.Height / 2);

            pnDanhmuc.Controls.Add(lb_Tendanhmuc);
            pnBan.Controls.Add(pnDanhmuc);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int tang = int.Parse((sender as Control).Tag.ToString());
            //busBan.XoaBan(lb_Macn.Text, tang);
            //VeBan(lb_Macn.Text);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int tang = int.Parse((sender as Control).Tag.ToString());
           // busBan.ThemBan(lb_Macn.Text, tang);
           // VeBan(lb_Macn.Text);
        }

        void VeChiTietBan(string macn, int tang)
        {
            Panel pnCTBan = null;
            Panel pnBanNho = null;
            PictureBox pbBan = null;
            Label lb_Maban = null;

            Panel pn = (Panel)pnBan.Controls.Find("pnTang_" + macn + "_" + tang, true).FirstOrDefault();

            //int soluongban = busBan.Sobantang(macn, tang);
           // int sodong = soluongban % 4 == 0 ? soluongban / 4 : (soluongban / 4) + 1;

            //pnCTBan = new Panel();
            //pnCTBan.Name = "pnCTBan_" + macn + "_" + tang;
            //pnCTBan.Size = new Size(pn.Width - 50, sodong * 120);
            //pnCTBan.Location = new Point(0, pn.Location.Y + pn.Height);

            //int dem = 1;
            //for (int i = 0; i < sodong; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        pnBanNho = new Panel();
            //        pbBan = new PictureBox();
            //        lb_Maban = new Label();

            //        pnBanNho.Size = new Size(96, 120);
            //        pnBanNho.Location = new Point(96 * j, 120 * i);

            //        string imgBan = "C:\\DBMA\\ctban.png";
            //        pbBan.Image = Image.FromFile(imgBan);
            //        pbBan.SizeMode = PictureBoxSizeMode.CenterImage;
            //        pbBan.Location = new Point(0, 0);
            //        pbBan.Size = new Size(96, 96);

            //        lb_Maban.Text = "MB" + dem.ToString();
            //        lb_Maban.Location = new Point(0, pbBan.Height);

            //        pnBanNho.Controls.Add(pbBan);
            //        pnBanNho.Controls.Add(lb_Maban);
            //        pnCTBan.Controls.Add(pnBanNho);
            //        //if (dem == soluongban)
            //        //    break; 
            //        //else
            //        //    dem++;
            //    }
            //}

            pnBan.Controls.Add(pnCTBan);
        }

        private void btn_Themtang_Click(object sender, EventArgs e)
        {
            //busBan.ThemTang(lb_Macn.Text);
            //VeBan(lb_Macn.Text);
        }

        private void btn_XoaTang_Click(object sender, EventArgs e)
        {
            int tang = int.Parse((sender as Control).Tag.ToString());
            //busBan.XoaTang(lb_Macn.Text, tang);
           // VeBan(lb_Macn.Text);
        }
    }
}