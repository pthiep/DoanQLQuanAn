﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiPhi
    {
        string maCP;
        string tenCP;
        decimal chiphi;
        string macp;
        int loaicp;
        string macn;
        string ngayphatsinh;
        string manv;

        public string TenCP { get => tenCP; set => tenCP = value; }
<<<<<<< HEAD
        public decimal ChiPhi { get => chiphi; set => chiphi = value; }
        public string Macp { get => macp; set => macp = value; }
        public int Loaicp { get => loaicp; set => loaicp = value; }
        public string Macn { get => macn; set => macn = value; }
        public string Ngayphatsinh { get => ngayphatsinh; set => ngayphatsinh = value; }
        public string Manv { get => manv; set => manv = value; }
=======
        public float ChiPhi { get => chiphi; set => chiphi = value; }
        public string MaCP { get => maCP; set => maCP = value; }
>>>>>>> 808c8447e350a6f3785fc3951d494528cb32c8e7
    }
}
