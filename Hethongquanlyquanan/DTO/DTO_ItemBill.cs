using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ItemBill
    {
        string ma;
        string ten;
        int soluong;
        decimal thanhtien;

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public decimal Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
