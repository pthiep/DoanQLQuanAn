using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boquanquanly.NewObject
{
    class NhanVienOBJ
    {
        string maNV, tenNV, gioiTinh, ngaySinh, diaChi, soDienThoai, matKhau, thuocChiNhanh;
        float hsLuong;

        public string ThuocChiNhanh
        {
            get { return thuocChiNhanh; }
            set { thuocChiNhanh = value; }
        }
        
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }


        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public float HsLuong
        {
            get { return hsLuong; }
            set { hsLuong = value; }
        }

        public NhanVienOBJ() { }

        public NhanVienOBJ(NhanVienOBJ nv) {
            this.maNV = nv.maNV;
            this.tenNV = nv.tenNV;
            this.ngaySinh = nv.ngaySinh;
            this.soDienThoai = nv.soDienThoai;
            this.matKhau = nv.matKhau;
            this.gioiTinh = nv.gioiTinh;
            this.hsLuong = nv.hsLuong;
            this.diaChi = nv.diaChi;
            this.thuocChiNhanh = nv.thuocChiNhanh;
        }

        public NhanVienOBJ(string ma, string ten, string gioitinh, string diachi, string sdt, string matkhau, float heso, string ngaysinh, string thuocChiNhanh) {
            this.maNV = ma;
            this.tenNV = ten;
            this.gioiTinh = gioitinh;
            this.diaChi = diachi;
            this.soDienThoai = sdt;
            this.ngaySinh = ngaysinh;
            this.hsLuong = heso;
            this.matKhau = matkhau;
            this.thuocChiNhanh = thuocChiNhanh;
        }
    }
}
