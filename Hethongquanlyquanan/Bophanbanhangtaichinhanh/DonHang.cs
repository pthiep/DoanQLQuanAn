using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bophanbanhangtaichinhanh
{
    public class DonHang
    {
        // lam dc k de xem new cai gi 
        // tạo đổi tươợng là ở bên thêm vào dâatagridview mới tạo
        // ơở đây mình thêm thuộc tính mấy cái biến cho nó thôi
        // đon hàng có gì nhỉ :v ???
        private string maDonHang; // Ctrl + r+e
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
