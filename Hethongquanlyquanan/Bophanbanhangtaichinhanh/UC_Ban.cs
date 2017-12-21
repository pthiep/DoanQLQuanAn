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
        BUS_ChiNhanh busCN = new BUS_ChiNhanh();

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
            LoadBan(5);
            VePNMenu();
        }

        void VePNMenu()
        {
            Panel pn = new Panel();
            Label lb = new Label();

            pn.BorderStyle = BorderStyle.FixedSingle;
            pn.Size = new Size(pn_Menu.Width, 35);
            pn.Location = new Point(0, 0);
            lb.Text = "MENU";
            lb.TextAlign = ContentAlignment.MiddleCenter;

            lb.Font = new Font(lb.Font, FontStyle.Bold);
            lb.Size = pn.Size;
            lb.Location = new Point(0, 0);

            pn.Controls.Add(lb);
            pn_Menu.Controls.Add(pn);
        }

        private void LoadBan(int slban)
        {
            int cc = 4;
            int rc = 0;

            rc = slban % cc == 0 ? slban / cc : slban / cc + 1;

            Panel pn = null;
            Point p_pn;
            Point p_lbmaban;
            Label lbmaban = null;

            int dem = 0;

            for (int i = 0; i < rc; i++)
            {
                for (int j = 0; j < cc; j++)
                {
                    if (dem < slban)
                    {
                        pn = new Panel();
                        p_pn = new Point();
                        lbmaban = new Label();                    
                        lbmaban.Text = "Bàn " + (dem + 1).ToString();
                        lbmaban.TextAlign = ContentAlignment.MiddleCenter;
                        lbmaban.Font = new Font("Tahoma", 20f, FontStyle.Bold);
                        lbmaban.Size = new Size(150, 146);
                        lbmaban.Location = new Point(0, 0);
                        lbmaban.Click += Pt_Click;

                        pn.Width = 150;
                        pn.Height = 146;
                        pn.BorderStyle = BorderStyle.FixedSingle;
                        p_pn.X = 170 * j;
                        p_pn.Y = 166 * i;
                        pn.Location = p_pn;
                        pn.Controls.Add(lbmaban);
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

        private void pnBan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
