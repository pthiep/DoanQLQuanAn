using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonHang
    {
        private string maDonHang;
        private string maMonAn;
        private string tenMonAn;
        private string gia;

        public string MaDonHang
        {
            get
            {
                return maDonHang;
            }

            set
            {
                maDonHang = value;
            }
        }

        public string MaMonAn
        {
            get
            {
                return maMonAn;
            }

            set
            {
                maMonAn = value;
            }
        }

        public string Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public string TenMonAn
        {
            get
            {
                return tenMonAn;
            }

            set
            {
                tenMonAn = value;
            }
        }
    }
}
