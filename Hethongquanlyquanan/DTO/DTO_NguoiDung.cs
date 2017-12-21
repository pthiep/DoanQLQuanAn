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

        public int Maquyen
        {
            get { return maquyen; }
            set { maquyen = value; }
        }

        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        public int Mand
        {
            get { return mand; }
            set { mand = value; }
        }
        private string tendn;

        public string Tendn
        {
            get { return tendn; }
            set { tendn = value; }
        }

        //public int Mand { get => mand; set => mand = value; }
        //public int Manv { get => manv; set => manv = value; }
        //public int Maquyen { get => maquyen; set => maquyen = value; }
        //public string Tendn { get => tendn; set => tendn = value; }


    }
}
