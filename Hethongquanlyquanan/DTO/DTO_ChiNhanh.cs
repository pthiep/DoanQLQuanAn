﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiNhanh
    {
        string macn;
        string tencn;
        string diachi;
        string dienthoai;
        string tinhthanh;

        public string Tinhthanh { get => tinhthanh; set => tinhthanh = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Tencn { get => tencn; set => tencn = value; }
        public string Macn { get => macn; set => macn = value; }
    }
}
