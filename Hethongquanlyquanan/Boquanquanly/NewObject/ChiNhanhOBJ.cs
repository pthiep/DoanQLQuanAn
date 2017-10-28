using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boquanquanly.NewObject
{
    class ChiNhanhOBJ
    {
        string MaChiNhanh, TenChiNhanh, SoDienThoai, DiaChi, NgayThanhLap, NhanVienQL;
        int SoLuongBan;
        public string NhanVienQL1
        {
            get { return NhanVienQL; }
            set { NhanVienQL = value; }
        }

        public string NgayThanhLap1
        {
            get { return NgayThanhLap; }
            set { NgayThanhLap = value; }
        }

        public string DiaChi1
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }

        public string SoDienThoai1
        {
            get { return SoDienThoai; }
            set { SoDienThoai = value; }
        }

        public string TenChiNhanh1
        {
            get { return TenChiNhanh; }
            set { TenChiNhanh = value; }
        }

        public string MaChiNhanh1
        {
            get { return MaChiNhanh; }
            set { MaChiNhanh = value; }
        }
       
        public int SoLuongBan1
        {
            get { return SoLuongBan; }
            set { SoLuongBan = value; }
        }

        ChiNhanhOBJ(){}

        ChiNhanhOBJ(ChiNhanhOBJ  cn) {
            this.MaChiNhanh = cn.MaChiNhanh;
            this.TenChiNhanh = cn.TenChiNhanh;
            this.DiaChi = cn.DiaChi;
            this.SoDienThoai = cn.SoDienThoai;
            this.SoLuongBan = cn.SoLuongBan;
            this.NgayThanhLap = cn.NgayThanhLap;
            this.NhanVienQL = cn.NhanVienQL;
        }
    }
}
