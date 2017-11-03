using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bophanbanhangtaichinhanh.DTO
{
    public class NhanVien
    {
        private int maNV;
        private string tenNV;
        private float luong;

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public float Luong { get => luong; set => luong = value; }
    }
}
