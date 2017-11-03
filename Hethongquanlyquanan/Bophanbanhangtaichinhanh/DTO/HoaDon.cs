using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bophanbanhangtaichinhanh.DTO
{
    class HoaDon
    {
        private int maHoaDon;
        private DateTime ngay;
        private string maKH;
        private DonHang donHang;

        public int MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
            }
        }

        public DateTime Ngay
        {
            get
            {
                return ngay;
            }
            set
            {
                ngay = value;
            }
        }

        public string MaKH
        {
            get
            {
                return maKH;
            }
            set
            {
                maKH = value;
            }
        }

        public DonHang DonHang
        {
            get
            {
                return donHang;
            }
            set
            {
                donHang = value;
            }
        }
    }
}
