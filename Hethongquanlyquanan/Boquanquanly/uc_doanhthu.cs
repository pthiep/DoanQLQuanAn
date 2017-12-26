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

namespace Boquanquanly
{
    public partial class uc_doanhthu : UserControl
    {
        BUS_ChiNhanh busCN = new BUS_ChiNhanh();
        private static uc_doanhthu _instance;

        public static uc_doanhthu Instance
        {
            get { 
                    if(_instance == null) _instance = new uc_doanhthu();
                return _instance; }
            set { uc_doanhthu._instance = value; }
        }

        public uc_doanhthu()
        {
            InitializeComponent();
        }

        private void uc_doanhthu_Load(object sender, EventArgs e)
        {
            vebangbaocaodoanhthu();            
        }

        private void vebangbaocaodoanhthu()
        {
            pnBaocaodoanhthu.Controls.Clear();
            Panel pn_stt = new Panel();
            Panel pn_chinhanh = new Panel();
            Panel pn_sldonhang = new Panel();
            Panel pn_tienbanhang = new Panel();
            Panel pn_quanly = new Panel();


            Label lb_stt = new Label();
            Label lb_ChiNhanh = new Label();
            Label lb_sldh = new Label();
            Label lb_tienbanhang = new Label();
            Label lb_quanly = new Label();

            int cc = 35;
            int scl_stt = 5;
            int scl_chinhanh = 35;
            int scl_sldonhang = 10;
            int scl_tienbanhang = 30;
            int scl_quanly = 20;

            int ttw = pnBaocaodoanhthu.Width;
            int ttw_stt = (scl_stt * ttw) / 100;
             int ttw_chinhanh = (scl_chinhanh * ttw) / 100;
            int ttw_sldonhang = (scl_sldonhang * ttw) / 100;
            int ttw_quanly = scl_quanly * ttw / 100 - 10;
            int ttw_tienbanhang = (scl_tienbanhang * ttw) / 100;

            pn_stt.BorderStyle = BorderStyle.FixedSingle;
            pn_stt.Size = new Size(ttw_stt, cc);
            pn_stt.Location = new Point(10, 0);

            lb_stt.Width = pn_stt.Width;
            lb_stt.Height = pn_stt.Height;
            lb_stt.Text = "STT";
            lb_stt.TextAlign = ContentAlignment.MiddleCenter;
            lb_stt.Location = new Point(0, 0);
            pn_stt.Controls.Add(lb_stt);


            pn_chinhanh.BorderStyle = BorderStyle.FixedSingle;
            pn_chinhanh.Size = new Size(ttw_chinhanh, cc);
            pn_chinhanh.Location = new Point(pn_stt.Location.X + ttw_stt - 1, 0);

            lb_ChiNhanh.Width = pn_chinhanh.Width;
            lb_ChiNhanh.Height = pn_chinhanh.Height;
            lb_ChiNhanh.Text = "Chi nhánh";
            lb_ChiNhanh.TextAlign = ContentAlignment.MiddleCenter;
            lb_ChiNhanh.Location = new Point(0, 0);
            pn_chinhanh.Controls.Add(lb_ChiNhanh);


            pn_sldonhang.BorderStyle = BorderStyle.FixedSingle;
            pn_sldonhang.Size = new Size(ttw_sldonhang, cc);
            pn_sldonhang.Location = new Point(pn_chinhanh.Location.X + ttw_chinhanh - 1, 0);

            lb_sldh.Height = pn_sldonhang.Height;
            lb_sldh.Width = pn_sldonhang.Width;
            lb_sldh.TextAlign = ContentAlignment.MiddleCenter;
            lb_sldh.Text = "Số lượng đơn hàng";
            lb_sldh.Location = new Point(0, 0);
            pn_sldonhang.Controls.Add(lb_sldh);


            pn_tienbanhang.BorderStyle = BorderStyle.FixedSingle;
            pn_tienbanhang.Size = new Size(ttw_tienbanhang, cc);
            pn_tienbanhang.Location = new Point(pn_sldonhang.Location.X + ttw_sldonhang - 1, 0);

            lb_tienbanhang.Height = pn_tienbanhang.Height;
            lb_tienbanhang.Width = pn_tienbanhang.Width;
            lb_tienbanhang.Text = "Tiền bán hàng";
            lb_tienbanhang.TextAlign = ContentAlignment.MiddleCenter;
            lb_tienbanhang.Location = new Point(0, 0);
            pn_tienbanhang.Controls.Add(lb_tienbanhang);



            pn_quanly.BorderStyle = BorderStyle.FixedSingle;
            pn_quanly.Size = new Size(ttw_quanly, cc);
            pn_quanly.Location = new Point(pn_tienbanhang.Location.X + ttw_tienbanhang - 1, 0);

            lb_quanly.Height = pn_quanly.Height;
            lb_quanly.Width = pn_quanly.Width;
            lb_quanly.Text = "Quản lí chi nhánh";
            lb_quanly.TextAlign = ContentAlignment.MiddleCenter;
            lb_quanly.Location = new Point(0, 0);
            pn_quanly.Controls.Add(lb_quanly);

            pnBaocaodoanhthu.Controls.Add(pn_stt);
            pnBaocaodoanhthu.Controls.Add(pn_chinhanh);
            pnBaocaodoanhthu.Controls.Add(pn_quanly);
            pnBaocaodoanhthu.Controls.Add(pn_sldonhang);
            pnBaocaodoanhthu.Controls.Add(pn_tienbanhang);
        }

        void vebangbaocaodoanhthu(DataTable data)
        {
            DataTable dtcn = busCN.LoadDanhSachChiNhanh();
            int slcn = data.Rows.Count;

            Panel pn_row = new Panel();
            Panel pn_stt = new Panel();
            Panel pn_chinhanh = new Panel();
            Panel pn_sldonhang = new Panel();
            Panel pn_tienbanhang = new Panel();
            Panel pn_quanly = new Panel();


            Label lb_stt = new Label();
            Label lb_ChiNhanh = new Label();
            Label lb_sldh = new Label();
            Label lb_tienbanhang = new Label();
            Label lb_quanly = new Label();

            int cc = 35;

            int scl_stt = 5;
            int scl_chinhanh = 35;
            int scl_sldonhang = 10;
            int scl_tienbanhang = 30;
            int scl_quanly = 20;

            int ttw = pnBaocaodoanhthu.Width;
            int ttw_stt = (scl_stt * ttw) / 100;
            int ttw_chinhanh = (scl_chinhanh * ttw) / 100;
            int ttw_sldonhang = (scl_sldonhang * ttw) / 100;
            int ttw_quanly = scl_quanly * ttw / 100 - 10;
            int ttw_tienbanhang = (scl_tienbanhang * ttw) / 100;


                for (int i = 0; i < slcn; i++)
                {
                    pn_row = new Panel();
                    pn_stt = new Panel();
                    pn_chinhanh = new Panel();
                    pn_sldonhang = new Panel();
                    pn_tienbanhang = new Panel();
                    pn_quanly = new Panel();


                    lb_stt = new Label();
                    lb_ChiNhanh = new Label();
                    lb_sldh = new Label();
                    lb_tienbanhang = new Label();
                    lb_quanly = new Label();

                    pn_row.BorderStyle = BorderStyle.FixedSingle;
                    pn_row.Size = new Size(ttw - 14, cc);
                    pn_row.Location = new Point(10, (cc - 1) * (i + 1));

                    pn_stt.BorderStyle = BorderStyle.FixedSingle;
                    pn_stt.Size = new Size(ttw_stt, cc);
                    pn_stt.Location = new Point(-1, -1);

                    lb_stt.Height = pn_stt.Height;
                    lb_stt.Width = pn_stt.Width;
                    lb_stt.Text = "" + (i + 1);
                    lb_stt.TextAlign = ContentAlignment.MiddleCenter;
                    pn_stt.Controls.Add(lb_stt);

                    pn_chinhanh.BorderStyle = BorderStyle.FixedSingle;
                    pn_chinhanh.Size = new Size(ttw_chinhanh, cc);
                    pn_chinhanh.Location = new Point(pn_stt.Location.X + ttw_stt - 1, -1);

                    lb_ChiNhanh.Height = pn_chinhanh.Height;
                    lb_ChiNhanh.Width = pn_chinhanh.Width;
                    lb_ChiNhanh.Text = data.Rows[i].ItemArray[0].ToString();
                    lb_ChiNhanh.TextAlign = ContentAlignment.MiddleLeft;
                    pn_chinhanh.Controls.Add(lb_ChiNhanh);


                    pn_sldonhang.BorderStyle = BorderStyle.FixedSingle;
                    pn_sldonhang.Size = new Size(ttw_sldonhang, cc);
                    pn_sldonhang.Location = new Point(pn_chinhanh.Location.X + ttw_chinhanh - 1, -1);

                    lb_sldh.Height = pn_sldonhang.Height;
                    lb_sldh.Width = pn_sldonhang.Width;
                    lb_sldh.Text = data.Rows[i].ItemArray[1].ToString();
                    lb_sldh.TextAlign = ContentAlignment.MiddleCenter;
                    pn_sldonhang.Controls.Add(lb_sldh);


                    pn_tienbanhang.BorderStyle = BorderStyle.FixedSingle;
                    pn_tienbanhang.Size = new Size(ttw_tienbanhang, cc);
                    pn_tienbanhang.Location = new Point(pn_sldonhang.Location.X + ttw_sldonhang - 1, -1);

                    lb_tienbanhang.Height = pn_tienbanhang.Height;
                    lb_tienbanhang.Width = pn_tienbanhang.Width;
                    lb_tienbanhang.Text = data.Rows[i].ItemArray[2].ToString();
                    lb_tienbanhang.TextAlign = ContentAlignment.MiddleRight;
                    pn_tienbanhang.Controls.Add(lb_tienbanhang);

                    pn_quanly.BorderStyle = BorderStyle.FixedSingle;
                    pn_quanly.Size = new Size(ttw_quanly, cc);
                    pn_quanly.Location = new Point(pn_tienbanhang.Location.X + ttw_tienbanhang - 1, -1);


                    lb_quanly.Height = pn_quanly.Height;
                    lb_quanly.Width = pn_quanly.Width;
                    lb_quanly.Text = data.Rows[i].ItemArray[3].ToString();
                    lb_quanly.TextAlign = ContentAlignment.MiddleCenter;
                    pn_quanly.Controls.Add(lb_quanly);

                    pn_row.Controls.Add(pn_stt);
                    pn_row.Controls.Add(pn_chinhanh);
                    pn_row.Controls.Add(pn_sldonhang);
                    pn_row.Controls.Add(pn_tienbanhang);
                    pn_row.Controls.Add(pn_quanly);

                    pnBaocaodoanhthu.Controls.Add(pn_row);

                }
        }

        private void pnBaocaodoanhthu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Xem_Click(object sender, EventArgs e)
        {             

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }   
    }
}
