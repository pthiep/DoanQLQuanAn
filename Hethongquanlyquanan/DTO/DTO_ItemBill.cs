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

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        decimal thanhtien;

        public decimal Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        //public string Ma { get => ma; set => ma = value; }
        //public string Ten { get => ten; set => ten = value; }
        //public int Soluong { get => soluong; set => soluong = value; }
        //public decimal Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
