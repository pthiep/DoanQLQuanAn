using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonAn
    {
        string mama, tenma;

        public string Tenma
        {
            get { return tenma; }
            set { tenma = value; }
        }

        public string Mama
        {
            get { return mama; }
            set { mama = value; }
        }
        decimal giaban;

        public decimal Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }
        string hinhanh;

        public string Hinhanh
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }
        string madanhmuc;

        public string Madanhmuc
        {
            get { return madanhmuc; }
            set { madanhmuc = value; }
        }

        //public string Mama { get => mama; set => mama = value; }
        //public string Tenma { get => tenma; set => tenma = value; }
        //public decimal Giaban { get => giaban; set => giaban = value; }
        //public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        //public string Madanhmuc { get => madanhmuc; set => madanhmuc = value; }
    }
}
