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
    public partial class Frm_ChiPhiPhatSinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_ChiPhi busCP = new BUS_ChiPhi();

        public string macn = "";
        public string ngay = "";
        public string manv = "";

        public Frm_ChiPhiPhatSinh()
        {
            InitializeComponent();
        }

        private void Frm_ChiPhiPhatSinh_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lb_MaCN.Text = macn;
            lb_Ngay.Text = ngay;
            lb_MaNV.Text = manv;
            TaoMaCP();
            LoadCB();
        }

        void LoadCB()
        {
            cb_Loai.Items.Add("Ngày");
            cb_Loai.Items.Add("Tháng");
            cb_Loai.SelectedIndex = 0;
        }

        void TaoMaCP()
        {
            lb_MaCP.Text = busCP.TaoMaCP(macn);
        }
        private void btnThemNgay_Click(object sender, EventArgs e)
        {
            if (tb_TenCP.Text != "" && tb_Chiphi.Text != "")
            {
                DTO_ChiPhi dtocp = new DTO_ChiPhi();
                dtocp.Macp = lb_MaCP.Text;
                dtocp.Macn = lb_MaCN.Text;
                dtocp.TenCP = tb_TenCP.Text;
                dtocp.ChiPhi = ChuyenVNDToDecimal(tb_Chiphi.Text);
                dtocp.Manv = lb_MaNV.Text;
                dtocp.Ngayphatsinh = lb_Ngay.Text;
                dtocp.Loaicp = cb_Loai.SelectedIndex == 0 ? 0 : 1;

                if (busCP.ThemCP(dtocp))
                {
                    MessageBox.Show("Thêm chi phí phát sinh thành công !!!", "Thông báo");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin !!!", "Thông báo");
            }
        }

        private void tb_Chiphi_TextChanged(object sender, EventArgs e)
        {
            groupBox1.Focus();
            tb_Chiphi.Focus();
            if (tb_Chiphi.Text == " VND")
            {
                tb_Chiphi.Text = "0 VND";
            }
            else
            {
                tb_Chiphi.Text = ChuyenDecimalToVND(ChuyenVNDToDecimal(tb_Chiphi.Text + " VND"));
                tb_Chiphi.SelectionStart = tb_Chiphi.Text.Length - 4;                
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

        private void tb_Chiphi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}