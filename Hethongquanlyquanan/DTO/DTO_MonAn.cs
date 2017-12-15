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
        decimal giaban;

        public string Mama { get => mama; set => mama = value; }
        public string Tenma { get => tenma; set => tenma = value; }
        public decimal Giaban { get => giaban; set => giaban = value; }
    }
}
