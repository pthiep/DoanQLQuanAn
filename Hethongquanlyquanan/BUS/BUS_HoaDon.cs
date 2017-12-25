using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_HoaDon
    {
        DBManager dalHD = new DBManager();


        public bool LuuHD(DTO_HoaDon hd)
        {
            string sql = "insert into HoaDon(mahoadon,makhachhang,ngaylap,manhanvien,machinhanh,loaihoadon,trangthai) values( @mahd , @makh , @ngay , @manv , @macn , @loaihd , @tt )";
            return dalHD.ExecuteNonQuery(sql, new object[] { hd.Mahoadon, hd.Makhachhang, hd.Ngay, hd.Manhanvien, hd.Machinhanh, hd.Loaihd , hd.Trangthai}) > 0 ? true : false;
        }

        public bool KiemTraHD(string ma)
        {
            string sql = "select count(*) from HoaDon where mahoadon = N'" + ma +"'";
            return int.Parse(dalHD.ExecuteQuery(sql).Rows[0].ItemArray[0].ToString()) > 0 ? true : false;
        }

        public int SoluongHDTheoKH(string ma)
        {
            string sql = "select count(*) from HoaDon where makhachhang = '" + ma + "'";
            return int.Parse(dalHD.ExecuteQuery(sql).Rows[0].ItemArray[0].ToString());
        }

        public DataTable DanhSachHD()
        {
            string sql = "select * from HoaDon";
            return dalHD.ExecuteQuery(sql);
        }

        public DataTable DanhSachHDTheoKH(string ma)
        {
            string sql = "select * from HoaDon where makhachhang = N'" + ma + "'";
            return dalHD.ExecuteQuery(sql);
        }

        public DataTable LayHD(string ma)
        {
            string sql = "select * from HoaDon where mahoadon = N'" + ma + "'";
            return ma == "" ? DanhSachHD() : dalHD.ExecuteQuery(sql);
        }

        public string TaoMaHD()
        {
            string sql = "select * from HoaDon";
            return "MHD" + (dalHD.ExecuteQuery(sql).Rows.Count + 1).ToString();
        }

        public string TaoMaCTHD()
        {
            string sql = "select * from Quanhe_Hoadon_CTHD";
            return "CTHD" + (dalHD.ExecuteQuery(sql).Rows.Count + 1).ToString();
        }
        public bool LuuCTHD(string mahd)
        {
            string sql = "insert into Quanhe_Hoadon_CTHD(mahoadon , macthoadon , trangthai) values( @mahd , @macthd , @tt )";
            return dalHD.ExecuteNonQuery(sql, new object[] { mahd, TaoMaCTHD() , 1 }) > 0 ? true : false;
        }
    }
}
