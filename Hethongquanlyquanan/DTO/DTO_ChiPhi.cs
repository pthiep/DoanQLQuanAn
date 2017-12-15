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
        float chiphi;

        public string TenCP { get => tenCP; set => tenCP = value; }
        public float ChiPhi { get => chiphi; set => chiphi = value; }
    }
}
