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


namespace Bophanbanhangtaichinhanh
{
    public partial class Frm_ChiNhanh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<DTO_ItemBill> lstDSMA;

        public Frm_ChiNhanh()
        {
            InitializeComponent();
        }

        private void Frm_ChiNhanh_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            PanelUser();
        }

        private void ThemMonAn(string mamonan)
        {
            MessageBox.Show(mamonan);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            PanelUser();
        }

        private void PanelUser()
        {

            if (btnVisible.Text == "Bàn")
            {
                if (!pnUC.Controls.Contains(UC_MonAn.Instance))
                {
                    pnUC.Controls.Add(UC_MonAn.Instance);
                    UC_MonAn.Instance.AddItems += Instance_AddItems;

                    UC_MonAn.Instance.Dock = DockStyle.Fill;
                    UC_MonAn.Instance.BringToFront();
                }
                else
                    UC_MonAn.Instance.BringToFront();

                btnVisible.Text = "Thực đơn";

            }
            else if (btnVisible.Text == "Thực đơn")
            {
                if (!pnUC.Controls.Contains(UC_Ban.Instance))
                {
                    pnUC.Controls.Add(UC_Ban.Instance);
                    UC_Ban.Instance.Dock = DockStyle.Fill;
                    UC_Ban.Instance.BringToFront();
                }
                else
                    UC_Ban.Instance.BringToFront();

                btnVisible.Text = "Bàn";

            }
        }

        private void Instance_AddItems(string ma)
        {
            Panel pH = (Panel)pnHD.Controls.Find("pnHeadHD", true).FirstOrDefault();

            if(pH != null)
            {
                // Thêm số lượng món ăn trong bill
                MessageBox.Show("Đã tạo bill");
                AddRowPanel(ma);

            }
            else
            {
                PaintHeadHD();
                PaintBodyHD(ma);
                
            }
        }



        private void PaintHeadHD()
        {
            Panel pnHeadHD = null;
            pnHeadHD = new Panel();

            pnHeadHD.BorderStyle = BorderStyle.FixedSingle;
            pnHeadHD.Location = new Point(0, 0);
            pnHeadHD.Name = "pnHeadHD";
            pnHeadHD.Size = new Size(419, 35);
            pnHD.Controls.Add(pnHeadHD);
        }

        private void PaintBodyHD(string ma)
        {
            Panel pH = (Panel)pnHD.Controls.Find("pnHeadHD", true).FirstOrDefault();
            Panel pnBodyHD = null;
            Label lb_Soluong = null;

            pnBodyHD = new Panel();
            pnBodyHD.BorderStyle = BorderStyle.FixedSingle;            
            pnBodyHD.Location = new Point(pH.Location.X, pH.Location.Y + pH.Height + 5);
            //pnBodyHD.Location = new Point(0, 0);
            pnBodyHD.Name = "pnBodyHD";
            pnBodyHD.Size = new Size(pH.Width, pnHD.Height - pH.Height - 5);
            
            pnHD.Controls.Add(pnBodyHD);
        }

        private void AddRowPanel(string ma)
        {
            Panel pH = (Panel)pnHD.Controls.Find("pnBodyHD", true).FirstOrDefault();
            pH.BorderStyle = BorderStyle.FixedSingle;
            if (pH != null)
            {
                Panel pnRowHD = null;
                Label lb_Soluong = null;
                pnRowHD = new Panel();
                lb_Soluong = new Label();

                pnRowHD.Location = new Point(0, 0);

                pnRowHD.Name = "pnRowHD_" + ma;

                pnRowHD.Size = new Size(100, 20);

                lb_Soluong = new Label();
                lb_Soluong.Location = new Point(0, 0);
                lb_Soluong.Text = "10";
                pnRowHD.Controls.Add(lb_Soluong);
                pH.Controls.Add(pnRowHD);


            }

        }
    }
}