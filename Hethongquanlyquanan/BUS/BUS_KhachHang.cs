using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_KhachHang
    {
        DBManager dalKH = new DBManager();

        public DataTable DanhSachKhachHang()
        {
            string sql = "Select * from KhachHang where trangthai = 1";
            return dalKH.ExecuteQuery(sql);
        }

        public bool KiemTraMaKH(string ma)
        {
            string sql = "select * from KhachHang where trangthai = 1 and makh = @ma";
            return dalKH.ExecuteQuery(sql, new object[] { ma }).Rows.Count > 0 ? true : false;
        }

        public bool KiemTraSDT(string ma)
        {
            string sql = "select * from KhachHang where trangthai = 1 and sodienthoai = @ma";
            return dalKH.ExecuteQuery(sql, new object[] { ma }).Rows.Count > 0 ? true : false;
        }

        public DataTable LayThongTinKhachHang(string ma)
        {
            string sql = "select * from KhachHang where trangthai = 1 and makh = @ma";
            return dalKH.ExecuteQuery(sql, new object[] { ma });
        }

        public DataTable LayThongTinKhachHangSDT(string ma)
        {
            string sql = "select * from KhachHang where trangthai = 1 and sodienthoai = @ma";
            return dalKH.ExecuteQuery(sql, new object[] { ma });
        }

        public string GetMaKH()
        {
            string sql = "select makh from KhachHang";
            DataTable dt = dalKH.ExecuteQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return "KH1";
            }
            else
            {
                List<int> arr = new List<int>();
                foreach (DataRow dr in dt.Rows)
                {
                    arr.Add(int.Parse(dr.ItemArray[0].ToString().Substring(2)));
                }
                return "KH" + (arr.Max() + 1).ToString();
            }
        }

        public bool ThemKH(DTO_KhachHang kh)
        {
            string sql = "insert into KhachHang(makh, tenkh, sodienthoai , ngaytao, ngaysinh, gioitinh, diachi, trangthai) values( @makh , @hoten , @sdt , @nt , @ns , @gt , @dc , @tt )";
            return dalKH.ExecuteNonQuery(sql, new object[] { kh.Makh, kh.Tenkh, kh.Sdt, kh.Ngaytao, kh.Ngaysinh, kh.Gioitinh, kh.Diachi, 1 }) > 0 ? true : false;
        }
    }
}
