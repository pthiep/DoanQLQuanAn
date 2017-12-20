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
using DevExpress.XtraEditors;

namespace Boquanquanly
{
    public partial class Frm_QLMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_Menu busMenu = new BUS_Menu();
        string tencn = "";
        string macn = "";
        public Frm_QLMenu()
        {
            InitializeComponent();
        }

        public Frm_QLMenu(string tencn, string macn)
        {
            InitializeComponent();
            this.tencn = tencn;
            this.macn = macn;
        }

        private void Frm_QLBan_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lb_Tencn.Text = tencn;
            lb_Macn.Text = macn;
            DataTable dt = busMenu.LoadMenuChiNhanh(macn);
            VeMon();
            LoadCbDanhmuc();
        }

        void LoadCbDanhmuc()
        {
            DataTable dt = busMenu.LoadDanhMuc();
            cb_DM.Properties.Items.Add("---Chọn danh mục---");
            foreach (DataRow dr in dt.Rows)
            {
                cb_DM.Properties.Items.Add(dr.ItemArray[1].ToString());
            }
            cb_DM.SelectedIndex = 0;
        }       

        void VeMon()
        {
            pnMenu.Controls.Clear();
            int slDM = busMenu.Sodanhmucchinhanh(macn);
            DataTable dtDMCN = busMenu.BanDanhMucChiNhanh(macn);
            DataTable dtMADM = null;

            if (slDM > 0)
            {
                Point pCu = new Point(0, 0);
                Point pMoi = new Point(0, 0);

                for (int i = 0; i < slDM; i++)
                {
                    dtMADM = busMenu.DanhSachMonAnTheoDanhMuc(macn, dtDMCN.Rows[i].ItemArray[1].ToString());
                    VeDanhMuc(dtDMCN.Rows[i].ItemArray[1].ToString(), pCu, ref pMoi);
                    pCu = pMoi;
                    VeChiTietBan(dtMADM, dtDMCN.Rows[i].ItemArray[1].ToString(), pCu, ref pMoi);
                    pCu = pMoi;
                }
            }
            else
            {
                VeKhongCoDanhMuc();
            }          
        }

        void VeKhongCoDanhMuc()
        {
            Label lb_Thongbao = new Label();
            lb_Thongbao.Text = "Không có danh mục nào";
            pnMenu.Controls.Add(lb_Thongbao);
        }

        void VeDanhMuc(string tenDM, Point pTenDM , ref Point pMoi)
        {
            Panel pnDanhmuc = null;
            Label lb_Tendanhmuc = null;

            pnDanhmuc = new Panel();
            lb_Tendanhmuc = new Label();

            pnDanhmuc.Name = "pnDanhmuc_" + macn + "_" + tenDM;
            pnDanhmuc.Size = new Size(pnMenu.Width, 25);
            pnDanhmuc.Location = new Point(pTenDM.X, pTenDM.Y);

            lb_Tendanhmuc.Text = "* " + tenDM;
            lb_Tendanhmuc.Font = new Font(lb_Tendanhmuc.Font.Name, 12, FontStyle.Bold);
            lb_Tendanhmuc.TextAlign = ContentAlignment.MiddleLeft;
            lb_Tendanhmuc.Size = new Size(200, 25);
            lb_Tendanhmuc.Location = new Point(0, pnDanhmuc.Height / 2 - lb_Tendanhmuc.Height / 2);

            pnDanhmuc.Controls.Add(lb_Tendanhmuc);
            pnMenu.Controls.Add(pnDanhmuc);
            pMoi = new Point(0, pTenDM.Y + pnDanhmuc.Height);
        }

        void VeChiTietBan(DataTable dt, string tendanhmuc, Point pCTMN, ref Point pMoi)
        {
            Panel pnCTMenu = null;
            Panel pnMonan = null;
            PictureBox pbMonan = null;
            Label lb_Tenmonan = null;
            Label lb_Giaban = null;
            SimpleButton btn_XoaMA = null;

            int soluongmonan = busMenu.SoLuongMonAn(macn, tendanhmuc);
            int sodong = soluongmonan % 4 == 0 ? soluongmonan / 4 : (soluongmonan / 4) + 1;

            pnCTMenu = new Panel();
            pnCTMenu.Location = new Point(pCTMN.X, pCTMN.Y);

            int dem = 1;
            for (int i = 0; i < sodong; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    pnMonan = new Panel();
                    pbMonan = new PictureBox();
                    lb_Tenmonan = new Label();
                    lb_Giaban = new Label();
                    btn_XoaMA = new SimpleButton();

                    pnMonan.BorderStyle = BorderStyle.FixedSingle;
                    pnMonan.Size = new Size(150, 165);
                    pnMonan.Location = (j == 0) ? new Point(pnMonan.Width * j, (pnMonan.Height * i) + 2) : new Point((pnMonan.Width * j) + 2, (pnMonan.Height * i) + 2);

                    string imgMonan = dt.Rows[dem - 1].ItemArray[6].ToString();
                    pbMonan.Image = Image.FromFile(imgMonan);
                    pbMonan.SizeMode = PictureBoxSizeMode.CenterImage;
                    pbMonan.Location = new Point(0, 0);
                    pbMonan.Size = new Size(150, 120);

                    lb_Tenmonan.Text = dt.Rows[dem - 1].ItemArray[4].ToString();
                    lb_Tenmonan.Location = new Point(40, pbMonan.Height);

                    lb_Giaban.Text = dt.Rows[dem - 1].ItemArray[5].ToString();
                    lb_Giaban.Location = new Point(40, lb_Tenmonan.Location.Y + lb_Tenmonan.Height);

                    btn_XoaMA.Text = "X";
                    btn_XoaMA.Size = new Size(30, 30);
                    btn_XoaMA.Location = new Point(2, pbMonan.Height + 4);
                    btn_XoaMA.Click += Btn_XoaMA_Click;
                    btn_XoaMA.Tag = dt.Rows[dem - 1].ItemArray[3].ToString();

                    pnMonan.Controls.Add(pbMonan);
                    pnMonan.Controls.Add(lb_Tenmonan);
                    pnMonan.Controls.Add(lb_Giaban);
                    pnMonan.Controls.Add(btn_XoaMA);

                    pnCTMenu.Controls.Add(pnMonan);
                    
                    if (dem == soluongmonan)
                        break;
                    else
                        dem++;
                }
            }

            pnCTMenu.Size = new Size(pnMenu.Width, sodong * 170);

            pnMenu.Controls.Add(pnCTMenu);
            pMoi = new Point(0, pnCTMenu.Location.Y + pnCTMenu.Height + 2);
        }

        private void Btn_XoaMA_Click(object sender, EventArgs e)
        {
            string mama = (sender as Control).Tag.ToString();
            if (busMenu.XoaMonAn(macn, mama))
            {
                MessageBox.Show("Xóa món ăn có mã " + mama + " thành công !!!", "Thông báo");
                VeMon();
            }
        }

        private void cb_DM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dm = cb_DM.Text;
            DataTable dt = busMenu.LoadMonAn(dm);
            LoadCbMonAn(dt);
        }

        void LoadCbMonAn(DataTable dt)
        {
            cbMA.Properties.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cbMA.Properties.Items.Add(busMenu.LayTenMonAnTuMa(dr.ItemArray[0].ToString()));
            }
            cbMA.SelectedIndex = 0;
        }

        private void btn_Themmonan_Click(object sender, EventArgs e)
        {
            string mama = busMenu.LayMaTuTenMonAn(cbMA.Text);
            bool flag = false;
            if (!busMenu.MonAnTonTaiTronMenu(macn, mama))
            {
                if (busMenu.CheckMonAnTonTai(macn, mama))
                {
                    flag = busMenu.Capnhattrangthaiqhcndm(macn, mama);
                }
                else
                {
                    flag = busMenu.Themmoiqhcndm(macn, mama);
                }

                if (flag)
                {
                    MessageBox.Show("Thêm món ăn " + cbMA.Text + " thành công !!!", "Thông báo");
                }
                VeMon();
            }
            else
            {
                MessageBox.Show("Món ăn đã tồn tại trong Menu !!!", "Thông báo");
            }
        }
    }
}