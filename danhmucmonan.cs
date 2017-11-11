using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gioithieuvadathang.DTO
{
    class danhmucmonan
    {
         private danhmucmonan Monan;
        private string maChiNhanh;
        private string maMonAn;
        private string donGia;



        public string maChiNhanh
        {
            get;

            set;
            {

            }
        }

        public string maMonAn
        {
            get;
            
            set;
            {
                maMonAn = value;
            }
        }

        public string donGia
        {
            get;
          
             set;
            {
                donGia = value;
            }
        }
    }
}
