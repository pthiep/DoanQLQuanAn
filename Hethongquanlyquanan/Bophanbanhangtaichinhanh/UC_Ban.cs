using System;
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

namespace Bophanbanhangtaichinhanh
{
    public partial class UC_Ban : UserControl
    {
        BUS_MonAn BUSmonan = new BUS_MonAn();

        private static UC_Ban _instance;
        public static UC_Ban Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Ban();
                return _instance;
            }
        }

        public UC_Ban()
        {
            InitializeComponent();
        }

        private void UC_Ban_Load(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void LoadBan()
        {
            DataTable dt = new DataTable();
            dt = BUSmonan.LoadDanhSachBan();
            int slban = BUSmonan.SoBan();
            int cc = 4;
            int rc = 0;

            rc = slban % cc == 0 ? slban / cc : slban / cc + 1;

            Panel pn = null;
            PictureBox pt = null;
            Point p_pn;
            Point p_lbmaban;
            Point p_lbtang;
            Label lbmaban = null;
            Label lbtang = null;

            int dem = 0;

            for (int i = 0; i < rc; i++)
            {
                for (int j = 0; j < cc; j++)
                {
                    if (dem < slban)
                    {
                        pn = new Panel();
                        pt = new PictureBox();
                        p_pn = new Point();
                        p_lbmaban = new Point();
                        p_lbtang = new Point();
                        lbmaban = new Label();
                        lbtang = new Label();
                        pt.Image = Image.FromFile("C:\\DBMA\\ban.png");
                        pt.SizeMode = PictureBoxSizeMode.AutoSize;
                        pt.Tag = dt.Rows[dem].ItemArray[0].ToString(); //Sửa
                        pt.Click += Pt_Click;

                        p_lbmaban.X = 0;
                        p_lbmaban.Y = pt.Height + 10;
                        lbmaban.Text = "Mã bàn : " + dt.Rows[dem].ItemArray[0].ToString();
                        lbmaban.Location = p_lbmaban;
                        lbmaban.Tag = dt.Rows[dem].ItemArray[0].ToString();
                        lbmaban.Click += Pt_Click;

                        p_lbtang.X = 0;
                        p_lbtang.Y = p_lbmaban.Y + 20;
                        lbtang.Text = "Tầng : " + dt.Rows[dem].ItemArray[2].ToString();
                        lbtang.Location = p_lbtang;
                        lbtang.Tag = dt.Rows[dem].ItemArray[0].ToString();
                        lbtang.Click += Pt_Click;

                        pn.Width = pt.Width;
                        pn.Height = pt.Height + lbmaban.Height + lbtang.Height;
                        pn.BorderStyle = BorderStyle.FixedSingle;
                        p_pn.X = (pt.Width + 20) * j;
                        p_pn.Y = (pn.Height + 20) * i;
                        pn.Location = p_pn;
                        pn.Controls.Add(pt);
                        pn.Controls.Add(lbmaban);
                        pn.Controls.Add(lbtang);
                        pnBan.Controls.Add(pn);
                        dem++;
                    }
                    else
                        break;

                }
            }
        }

        private void Pt_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Control).Tag.ToString());
        }
    }
}
