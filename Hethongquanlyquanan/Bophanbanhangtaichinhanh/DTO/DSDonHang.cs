using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bophanbanhangtaichinhanh.DTO;

namespace Bophanbanhangtaichinhanh
{
    public class DSDonHang
    {
        private KhachHang khachHang;
        private string nvLapDon;
        private string dsMonAn;
        private string tongGia;

        

        public string NvLapDon
        {
            get
            {
                return nvLapDon;
            }

            set
            {
                nvLapDon = value;
            }
        }

        public string DsMonAn
        {
            get
            {
                return dsMonAn;
            }

            set
            {
                dsMonAn = value;
            }
        }

        public string TongGia
        {
            get
            {
                return tongGia;
            }

            set
            {
                tongGia = value;
            }
        }
    }
}
