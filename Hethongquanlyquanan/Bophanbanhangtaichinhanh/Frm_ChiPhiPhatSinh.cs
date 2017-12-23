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

namespace Bophanbanhangtaichinhanh
{
    public partial class Frm_ChiPhiPhatSinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_ChiPhi busCP = new BUS_ChiPhi();
        public bool flag = false;
        public Frm_ChiPhiPhatSinh()
        {
            InitializeComponent();
        }

        private void Frm_ChiPhiPhatSinh_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DTO_ChiPhi cp = new DTO_ChiPhi();
            if (txtTenCP.Text != "" || txtCP.Text != "")
            {
                cp.TenCP = txtTenCP.Text;
                cp.ChiPhi = float.Parse(txtCP.Text);
                if (!flag)
                {
                    if (busCP.Capnhatchiphi(cp))
                    {
                        MessageBox.Show("cập nhật chi phsi thành công!!!", "Thông báo");

                    }
                }
                else
                {
                    if (busCP.ThemCP(cp))
                    {
                        MessageBox.Show("thêm chi phí thành công!!!", "Thông báo");
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("chưa cập nhật thông itn đầy đủ", "Thông báo");
            }                
        }
    }
}

