using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_NguoiDung
    {
        private int mand, manv, maquyen;
        private string tendn;

        public int Mand { get => mand; set => mand = value; }
        public int Manv { get => manv; set => manv = value; }
        public int Maquyen { get => maquyen; set => maquyen = value; }
        public string Tendn { get => tendn; set => tendn = value; }


    }
}
