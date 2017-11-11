using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoatDongDatHangTaiTongDai.DTO
{
    class QuanLy
    {
        private string maDonHang;

        public string GetMaDonHang()
        {
            return maDonHang;
        }

        public void SetMaDonHang(string value)
        {
            maDonHang = value;
        }
        private string tenKH;
        private string diaChiKH;
        private string SdtKhachHang;

        public string SdtKhachHang1 { get => SdtKhachHang; set => SdtKhachHang = value; }

        public string GetDiaChiKH()
        {
            return diaChiKH;
        }

        public void SetDiaChiKH(string value)
        {
            diaChiKH = value;
        }

        public string GetTenKH()
        {
            return tenKH;
        }

        public void SetTenKH(string value)
        {
            tenKH = value;
        }
    }
}
