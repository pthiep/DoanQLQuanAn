using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiPhi
    {
        string tenCP;

        public string TenCP
        {
            get { return tenCP; }
            set { tenCP = value; }
        }
        float chiphi;

        public float Chiphi
        {
            get { return chiphi; }
            set { chiphi = value; }
        }

        //public string TenCP { get => tenCP; set => tenCP = value; }
        //public float ChiPhi { get => chiphi; set => chiphi = value; }
    }
}
