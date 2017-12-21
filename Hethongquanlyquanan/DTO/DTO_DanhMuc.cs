using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DanhMuc
    {
        string tendanhmuc, madanhmuc;

        public string Madanhmuc
        {
            get { return madanhmuc; }
            set { madanhmuc = value; }
        }

        public string Tendanhmuc
        {
            get { return tendanhmuc; }
            set { tendanhmuc = value; }
        }

        //public string Tendanhmuc { get => tendanhmuc; set => tendanhmuc = value; }
        //public string Madanhmuc { get => madanhmuc; set => madanhmuc = value; }
    }
}
