using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChung.Object
{
    class NhanVienOBJ
    {
        string ma, ten, gioitinh, diachi, sodienthoai, matkhau, thuocchinhanh;

        string ngaysinh;
        public string Thuocchinhanh
        {
            get { return thuocchinhanh; }
            set { thuocchinhanh = value; }
        }

        

        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        float hesoluong;

        public float Hesoluong
        {
            get { return hesoluong; }
            set { hesoluong = value; }
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string Sodienthoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        


        

        public NhanVienOBJ()
        { 
        }

        public NhanVienOBJ(string ma, string ten, string gioitinh, string diachi, string sodienthoai, string matkhau, string ngaysinh, float hesoluong)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
            this.matkhau = matkhau;
            this.hesoluong = hesoluong;
            this.ngaysinh = ngaysinh;
        }

    }
}
