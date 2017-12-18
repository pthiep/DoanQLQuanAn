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
    public partial class UC_MonAn : UserControl
    {
        public delegate void AddItem(string abc);
        public event AddItem AddItems;

        BUS_MonAn BUSmonan = new BUS_MonAn();

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
            LoadThucDon();
        }

        private void LoadThucDon()
        {
            DataTable dt = new DataTable();
            dt = BUSmonan.LoadDanhSachMonAn();
            int slma = BUSmonan.Soluongmonan();
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

                        p_lbma.X = 0;
                        p_lbma.Y = pt.Height + 10;
                        lbmonan.Text = dt.Rows[dem].ItemArray[1].ToString();
                        lbmonan.Location = p_lbma;
                        lbmonan.Tag = dt.Rows[dem].ItemArray[0].ToString();
                        lbmonan.Click += Pt_Click;


                        p_lbgia.X = 0;
                        p_lbgia.Y = p_lbma.Y + 20;
                        lbgia.Text = dt.Rows[dem].ItemArray[3].ToString();
                        lbgia.Location = p_lbgia;
                        lbgia.Tag = dt.Rows[dem].ItemArray[0].ToString();
                        lbgia.Click += Pt_Click;

                        pn.Width = pt.Width;
                        pn.Height = pt.Height + lbmonan.Height + lbgia.Height;
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

        private void Pt_Click(object sender, EventArgs e)
        {
            
            if (AddItems != null)
            {
                AddItems((sender as Control).Tag.ToString());
            }

        }

        private void pnThucDon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
