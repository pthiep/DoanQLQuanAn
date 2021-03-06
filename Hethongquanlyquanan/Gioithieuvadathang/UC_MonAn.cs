﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Gioithieuvadathang
{
    public partial class UC_MonAn : UserControl
    {
        public delegate void AddItem(string ma, bool tt);
        public event AddItem AddItems;

        public string macn = "";

        BUS_MonAn BUSmonan = new BUS_MonAn();
        BUS_DanhMuc busDM = new BUS_DanhMuc();

        private static UC_MonAn _instance;
        public static UC_MonAn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_MonAn();
                return _instance;
            }
        }
        public UC_MonAn()
        {
            InitializeComponent();
        }

        private void UC_MonAn_Load(object sender, EventArgs e)
        {
            LoadThucDon(BUSmonan.LoadDanhSachMonAnCN(macn));
            VePNMenu();
            VeClickPNMenu();
        }

        public void VeAgain()
        {
            pnThucDon.Controls.Clear();
            pn_Menu.Controls.Clear();
            LoadThucDon(BUSmonan.LoadDanhSachMonAnCN(macn));
            VePNMenu();
            VeClickPNMenu();
        }

        public void Timkiemmonan(string ten)
        {
            pnThucDon.Controls.Clear();
            if (ten != "")
            {
                if (BUSmonan.Timkiemmonan(ten, macn).Rows.Count > 0)
                {
                    LoadThucDon(BUSmonan.Timkiemmonan(ten, macn));
                }
                else
                {
                    Label lb = new Label();
                    lb.Text = "Không tìm thấy món ăn !!!";
                    pnThucDon.Controls.Add(lb);
                }
            }
            else
            {
                VeAgain();
            }
        }

        public void LoadThucDon(DataTable dt)
        {
            pnThucDon.Controls.Clear();
            int slma = dt.Rows.Count;
            int cc = 4;
            int rc = 0;

            rc = slma % cc == 0 ? slma / cc : slma / cc + 1;

            Panel pn = null;
            PictureBox pt = null;
            Point p_pn;
            Point p_lbma;
            Point p_lbgia;
            Label lbmonan = null;
            Label lbgia = null;

            int dem = 0;

            for (int i = 0; i < rc; i++)
            {
                for (int j = 0; j < cc; j++)
                {
                    if (dem < slma)
                    {
                        pn = new Panel();
                        pt = new PictureBox();
                        p_pn = new Point();
                        p_lbma = new Point();
                        p_lbgia = new Point();
                        lbmonan = new Label();
                        lbgia = new Label();
                        pt.Image = Image.FromFile(dt.Rows[dem].ItemArray[2].ToString());
                        pt.SizeMode = PictureBoxSizeMode.AutoSize;
                        pt.Tag = dt.Rows[dem].ItemArray[0].ToString();
                        pt.Click += Pt_Click;

                        pn.Width = pt.Width;

                        p_lbma.X = 2;
                        p_lbma.Y = pt.Height + 10;
                        lbmonan.Text = dt.Rows[dem].ItemArray[1].ToString();
                        lbmonan.Location = p_lbma;
                        lbmonan.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                        lbmonan.Size = new Size(pn.Width, 20);
                        lbmonan.Tag = dt.Rows[dem].ItemArray[0].ToString();
                        lbmonan.Click += Pt_Click;


                        p_lbgia.X = 2;
                        p_lbgia.Y = p_lbma.Y + 20;
                        lbgia.Text = "Giá : " + ChuyenDecimalToVND(ChuyenVNDToDecimal(dt.Rows[dem].ItemArray[3].ToString()));
                        lbgia.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                        lbgia.Location = p_lbgia;
                        lbgia.Size = new Size(pn.Width, 20);
                        lbgia.Tag = dt.Rows[dem].ItemArray[0].ToString();
                        lbgia.Click += Pt_Click;

                        
                        pn.Height = pt.Height + lbmonan.Height + lbgia.Height + 10;
                        pn.BorderStyle = BorderStyle.FixedSingle;
                        p_pn.X = (pt.Width + 20) * j;
                        p_pn.Y = (pn.Height + 20) * i;
                        pn.Location = p_pn;
                        pn.Controls.Add(pt);
                        pn.Controls.Add(lbmonan);
                        pn.Controls.Add(lbgia);
                        pnThucDon.Controls.Add(pn);


                        dem++;
                    }
                    else
                        break;

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

        void VePNMenu()
        {
            DataTable dt = new DataTable();
            dt = busDM.LoadDanhMuc();

            Panel pn = null;
            Label lb = null;
            for (int i = 0; i <= busDM.Soluongdanhmuc() + 1; i++)
            {
                pn = new Panel();
                lb = new Label();

                pn.BorderStyle = BorderStyle.FixedSingle;
                pn.Size = new Size(pn_Menu.Width, 35);                

                if (i == 0)
                {
                    lb.Text = "MENU";
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    pn.Name = "pnMenu_DM0";
                    pn.Tag = 1;
                    lb.Tag = "DM0";

                    pn.Location = new Point(0, 34 * i);
                }
                else if (i == busDM.Soluongdanhmuc() + 1)
                {
                    lb.Text = "Món bán chạy";
                    lb.TextAlign = ContentAlignment.MiddleLeft;
                    pn.Name = "pnMenu_DMBanchay";
                    pn.Tag = 0;
                    lb.Tag = "DMBanchay";

                    pn.Location = new Point(0, 34);
                }
                else
                {
                    lb.Text = dt.Rows[i - 1].ItemArray[1].ToString();
                    lb.TextAlign = ContentAlignment.MiddleLeft;
                    lb.Tag = dt.Rows[i - 1].ItemArray[0].ToString();
                    pn.Name = "pnMenu_" + dt.Rows[i - 1].ItemArray[0].ToString();
                    pn.Tag = 0;
                    lb.Tag = dt.Rows[i - 1].ItemArray[0].ToString();

                    pn.Location = new Point(0, 34 + 34 * i);
                }

                lb.Font = new Font(lb.Font, FontStyle.Bold);
                lb.Size = pn.Size;
                lb.Location = new Point(0, 0);
                lb.Click += Lb_Click;

                pn.Controls.Add(lb);
                pn_Menu.Controls.Add(pn);
            }
        }
        void VeClickPNMenu()
        {
            Panel pn = null;
            for (int i = 0; i < busDM.Soluongdanhmuc() + 2; i++)
            {
                if (i == busDM.Soluongdanhmuc() + 1)
                {
                    pn = (Panel)pn_Menu.Controls.Find("pnMenu_DMBanchay", true).FirstOrDefault();
                }
                else
                {
                    pn = (Panel)pn_Menu.Controls.Find("pnMenu_DM" + i, true).FirstOrDefault();
                }
                int kt = int.Parse(pn.Tag.ToString());
                if (kt == 1)
                {
                    pn.BackColor = Color.FromArgb(1, 115, 199);
                }
                else
                {
                    pn.BackColor = Color.FromArgb(240, 240, 240);
                }
            }
        }

        private void Lb_Click(object sender, EventArgs e)
        {
            Panel pn = null;

            int ma = 0;
            if ((sender as Control).Tag.ToString() == "DMBanchay")
            {
                ma = busDM.Soluongdanhmuc() + 1;
            }
            else
            {
                ma = int.Parse((sender as Control).Tag.ToString().Substring(2));
            }

            for (int i = 0; i < busDM.Soluongdanhmuc() + 2; i++)
            {
                if (i == busDM.Soluongdanhmuc() + 1)
                {
                    pn = (Panel)pn_Menu.Controls.Find("pnMenu_DMBanchay", true).FirstOrDefault();
                }
                else
                {
                    pn = (Panel)pn_Menu.Controls.Find("pnMenu_DM" + i, true).FirstOrDefault();
                }
                if (i == ma)
                {
                    pn.Tag = "1";
                }
                else
                {
                    pn.Tag = "0";
                }
            }

            VeClickPNMenu();
            
            if ((sender as Control).Tag.ToString() == "DM0")
            {
                LoadThucDon(BUSmonan.LoadDanhSachMonAnCN(macn));
            }
            else if ((sender as Control).Tag.ToString() == "DMBanchay")
            {
                LoadThucDon(BUSmonan.LoadDanhSachBanChay(macn));
            }
            else
            {
                LoadThucDon(BUSmonan.LoadDanhSachMonAn(macn, (sender as Control).Tag.ToString()));
            }
        }

        private void Pt_Click(object sender, EventArgs e)
        {
            
            if (AddItems != null)
            {
                AddItems((sender as Control).Tag.ToString(), true);
            }

        }

        private void pnThucDon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
