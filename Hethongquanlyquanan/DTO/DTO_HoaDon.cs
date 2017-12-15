using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_HoaDon
    {
        private int maHoaDon;
        private DateTime ngay;
        private string maKH;
       // private DonHang donHang;

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

        
    }
}
