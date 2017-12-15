using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string sdt;
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

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
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
