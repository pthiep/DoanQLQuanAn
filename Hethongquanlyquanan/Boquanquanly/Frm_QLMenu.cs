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
        BUS_Menu busBan = new BUS_Menu();
        string macntemp = "CN1";
        public Frm_QLMenu()
        {
            InitializeComponent();
        }

        private void Frm_QLBan_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            VeBan(macntemp);
        }

        void VeBan(string macn)
        {
            pnBan.Controls.Clear();
            int slTang = busBan.Sotang(macn);
            for (int i = 1; i <= slTang; i++)
            {
                VeTang(macn, i);
                VeChiTietBan(macn, i);
            }

        }

        void VeTang(string macn, int tang)
        {
            Panel pnTang = null;
            SimpleButton btn_XoaTang = null;
            Label lb_Tang = null;
            SimpleButton btnThem = null;
            SimpleButton btnXoa = null;

            pnTang = new Panel();
            btn_XoaTang = new SimpleButton();
            lb_Tang = new Label();
            btnThem = new SimpleButton();
            btnXoa = new SimpleButton();

            if (tang == 1)
            {              
                pnTang.Location = new Point(0, 0);                              
            }
            else
            {
                Panel pn = (Panel)pnBan.Controls.Find("pnCTBan_" + macn + "_" + (tang - 1).ToString(), true).FirstOrDefault();
                pnTang.Location = new Point(0, pn.Location.Y + pn.Height + 2);
            }

            pnTang.Name = "pnTang_" + macn + "_" + tang;
            pnTang.BorderStyle = BorderStyle.FixedSingle;
            pnTang.Size = new Size(pnBan.Width - 50, 35);

            string imgXoaTang = "C:\\DBMA\\xoatang.png";
            btn_XoaTang.ImageOptions.Image = Image.FromFile(imgXoaTang);
            btn_XoaTang.ImageOptions.Location = ImageLocation.MiddleCenter;
            btn_XoaTang.Size = new Size(30, 30);
            btn_XoaTang.Location = new Point(5, pnTang.Height / 2 - 15);
            btn_XoaTang.Click += btn_XoaTang_Click;
            btn_XoaTang.Tag = tang.ToString();

            lb_Tang.Text = "Tầng " + tang;
            lb_Tang.TextAlign = ContentAlignment.MiddleCenter;
            lb_Tang.Location = new Point(pnTang.Width / 2 - lb_Tang.Width / 2, pnTang.Height / 2 - lb_Tang.Height / 2);

            string imgThem = "C:\\DBMA\\themban.png";
            string imgXoa = "C:\\DBMA\\xoaban.png";
            btnXoa.ImageOptions.Image = Image.FromFile(imgXoa);
            btnXoa.ImageOptions.Location = ImageLocation.MiddleCenter;
            btnXoa.Size = new Size(30, 30);
            btnXoa.Location = new Point(pnTang.Width - btnXoa.Width - 5, pnTang.Height / 2 - 15);
            btnThem.ImageOptions.Image = Image.FromFile(imgThem);
            btnThem.ImageOptions.Location = ImageLocation.MiddleCenter;
            btnThem.Size = new Size(30, 30);
            btnThem.Location = new Point(btnXoa.Location.X - btnThem.Width - 5, pnTang.Height / 2 - 15);
            btnThem.Tag = tang.ToString();
            btnXoa.Tag = tang.ToString();

            btnThem.Click += BtnThem_Click;
            btnXoa.Click += BtnXoa_Click;

            pnTang.Controls.Add(btn_XoaTang);
            pnTang.Controls.Add(lb_Tang);
            pnTang.Controls.Add(btnXoa);
            pnTang.Controls.Add(btnThem);
            pnBan.Controls.Add(pnTang);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int tang = int.Parse((sender as Control).Tag.ToString());
            busBan.XoaBan(lb_Macn.Text, tang);
            VeBan(lb_Macn.Text);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int tang = int.Parse((sender as Control).Tag.ToString());
            busBan.ThemBan(lb_Macn.Text, tang);
            VeBan(lb_Macn.Text);
        }

        void VeChiTietBan(string macn, int tang)
        {
            Panel pnCTBan = null;
            Panel pnBanNho = null;
            PictureBox pbBan = null;
            Label lb_Maban = null;

            Panel pn = (Panel)pnBan.Controls.Find("pnTang_" + macn + "_" + tang, true).FirstOrDefault();

            int soluongban = busBan.Sobantang(macn, tang);
            int sodong = soluongban % 4 == 0 ? soluongban / 4 : (soluongban / 4) + 1;

            pnCTBan = new Panel();
            pnCTBan.Name = "pnCTBan_" + macn + "_" + tang;
            pnCTBan.Size = new Size(pn.Width - 50, sodong * 120);
            pnCTBan.Location = new Point(0, pn.Location.Y + pn.Height);

            int dem = 1;
            for (int i = 0; i < sodong; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    pnBanNho = new Panel();
                    pbBan = new PictureBox();
                    lb_Maban = new Label();

                    pnBanNho.Size = new Size(96, 120);
                    pnBanNho.Location = new Point(96 * j, 120 * i);

                    string imgBan = "C:\\DBMA\\ctban.png";
                    pbBan.Image = Image.FromFile(imgBan);
                    pbBan.SizeMode = PictureBoxSizeMode.CenterImage;
                    pbBan.Location = new Point(0, 0);
                    pbBan.Size = new Size(96, 96);

                    lb_Maban.Text = "MB" + dem.ToString();
                    lb_Maban.Location = new Point(0, pbBan.Height);

                    pnBanNho.Controls.Add(pbBan);
                    pnBanNho.Controls.Add(lb_Maban);
                    pnCTBan.Controls.Add(pnBanNho);
                    if (dem == soluongban)
                        break; 
                    else
                        dem++;
                }
            }

            pnBan.Controls.Add(pnCTBan);
        }

        private void btn_Themtang_Click(object sender, EventArgs e)
        {
            busBan.ThemTang(lb_Macn.Text);
            VeBan(lb_Macn.Text);
        }

        private void btn_XoaTang_Click(object sender, EventArgs e)
        {
            int tang = int.Parse((sender as Control).Tag.ToString());
            busBan.XoaTang(lb_Macn.Text, tang);
            VeBan(lb_Macn.Text);
        }
    }
}