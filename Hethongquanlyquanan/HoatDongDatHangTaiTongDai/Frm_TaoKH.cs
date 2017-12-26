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

namespace HoatDongDatHangTaiTongDai
{
    public partial class Frm_TaoKH : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        public string ngaytao = "";

        public Frm_TaoKH()
        {
            InitializeComponent();
        }

        private void Frm_TaoKH_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lb_MaKH.Text = busKH.GetMaKH();
            LoadCBGT();
        }

        void LoadCBGT()
        {
            cb_GioiTinh.Properties.Items.Add("Nam");
            cb_GioiTinh.Properties.Items.Add("Nữ");
            cb_GioiTinh.SelectedIndex = 0;
        }

        private void sBtnAdd_Click(object sender, EventArgs e)
        {
            if (tbTenKH.Text != "" && tbSDT.Text != "" && tbDiaChi.Text != "" && dateNS.EditValue.ToString() != "")
            {
                DTO_KhachHang khDTO = new DTO_KhachHang();
                khDTO.Makh = lb_MaKH.Text;
                khDTO.Tenkh = tbTenKH.Text;
                khDTO.Sdt = tbSDT.Text;
                khDTO.Ngaysinh = dateNS.EditValue.ToString();
                khDTO.Ngaytao = ngaytao;
                khDTO.Gioitinh = cb_GioiTinh.SelectedItem.ToString();
                khDTO.Diachi = tbDiaChi.Text;
                busKH.ThemKH(khDTO);

                MessageBox.Show("Tạo khách hàng thành công !!!", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin khách hàng !!!", "Thông báo");
            }
            
        }        
    }
}