using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string mahoadon;
        private string ngay;
        private string makhachhang, manhanvien, machinhanh;
        private int loaihd;
       
        public string Ngay { get => ngay; set => ngay = value; }
        public int Loaihd { get => loaihd; set => loaihd = value; }
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Machinhanh { get => machinhanh; set => machinhanh = value; }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }

        // private DonHang donHang;
    }
}
