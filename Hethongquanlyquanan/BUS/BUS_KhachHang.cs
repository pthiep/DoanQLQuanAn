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

        public DataTable LayThongTinKhachHang(string ma)
        {
            string sql = "select * from KhachHang where trangthai = 1 and makh = @ma";
            return dalKH.ExecuteQuery(sql, new object[] { ma });
        }
    }
}
