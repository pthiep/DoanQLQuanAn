using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonAn
    {
        private string maMonAn;

        public string MaMonAn
        {
            get { return maMonAn; }
            set { maMonAn = value; }
        }
        string tenMonAn;

        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }
        float donGia;

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

    }
}
