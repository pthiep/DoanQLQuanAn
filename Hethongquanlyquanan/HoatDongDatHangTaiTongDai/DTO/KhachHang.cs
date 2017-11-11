using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoatDongDatHangTaiTongDai.DTO
{
    class KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string Sdt;
        private string diaChi;
        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public string TenKhachHang1
        {
            get
            {
                return tenKhachHang;
            }

            set
            {
                tenKhachHang = value;
            }
        }

        public string Sdt1
        {
            get
            {
                return Sdt;
            }

            set
            {
                Sdt = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }
    }
}
}
