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


namespace Bophanbanhangtaichinhanh
{
    public partial class Frm_ChiNhanh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_MonAn BUSmonan = new BUS_MonAn();
        public Frm_ChiNhanh()
        {
            InitializeComponent();
        }

        private void Frm_ChiNhanh_Load(object sender, EventArgs e)
        {
            btnVisible.Tag = "1";
            LoadThucDon();
           
        }

        private void LoadThucDon()
        {
            DataTable dt = new DataTable();
            dt = BUSmonan.LoadDanhSachMonAn();
            int slma = BUSmonan.SoMonAn();
            int cc = 4;
            int rc = 0;
            /*if (slma % cc == 0)
                rc = slma / cc;
            else
                rc = slma / cc + 1;*/

            rc = slma % cc == 0 ? slma / cc : slma / cc + 1;

            Panel pn = null;
            PictureBox pt = null ;
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

        private void LoadBan()
        {
            DataTable dt = new DataTable();
            dt = BUSmonan.LoadDanhSachBan();
            int slban = BUSmonan.SoBan();
            int cc = 4;
            int rc = 0;
            /*if (slma % cc == 0)
                rc = slma / cc;
            else
                rc = slma / cc + 1;*/

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
                        pt.Image = Image.FromFile("C:\\image\\ban.png");
                        pt.SizeMode = PictureBoxSizeMode.AutoSize;
                        pt.Tag = dt.Rows[dem].ItemArray[0].ToString();
                        pt.Click += Pt_Click;

                        p_lbmaban.X = 0;
                        p_lbtang.Y = pt.Height + 10;
                        lbmaban.Text = dt.Rows[dem].ItemArray[1].ToString();
                        lbmaban.Location = p_lbmaban;
                        lbmaban.Tag = dt.Rows[dem].ItemArray[0].ToString();
                        lbmaban.Click += Pt_Click;


                        p_lbtang.X = 0;
                        p_lbtang.Y = p_lbtang.Y + 20;
                        lbtang.Text = dt.Rows[dem].ItemArray[3].ToString();
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
            MessageBox.Show((sender as Control).Tag.ToString());
        }



        private void ThemMonAn(string mamonan)
        {
            MessageBox.Show(mamonan);

        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HoaDon frm = new frm_HoaDon();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (btnVisible.Tag.ToString() == "1")
            {
                pnThucDon.Visible = false;
                panel1.Visible = true;
                btnVisible.Text = "Thực đơn";
                btnVisible.Tag = "0";
            }
            else
            {
                pnThucDon.Visible = true;
                panel1.Visible = false;
                btnVisible.Text = "Bàn";
                btnVisible.Tag = "1";

            }
        }
    }
}