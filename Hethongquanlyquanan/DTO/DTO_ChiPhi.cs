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
        decimal chiphi;
        string macp;
        int loaicp;
        string macn;
        string ngayphatsinh;
        string manv;

        public string TenCP { get => tenCP; set => tenCP = value; }
        public decimal ChiPhi { get => chiphi; set => chiphi = value; }
        public string Macp { get => macp; set => macp = value; }
        public int Loaicp { get => loaicp; set => loaicp = value; }
        public string Macn { get => macn; set => macn = value; }
        public string Ngayphatsinh { get => ngayphatsinh; set => ngayphatsinh = value; }
        public string Manv { get => manv; set => manv = value; }
    }
}
