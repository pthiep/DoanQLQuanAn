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
            string sql = "insert into HoaDon(mahoadon,makhachhang,tongtien,ngaytao,manhanvien,machinhanh,loaihoadon,trangthai) values( @mahd , @makh , @ttien , @ngay , @manv , @macn , @loaihd , @tt )";
            return dalHD.ExecuteNonQuery(sql, new object[] { hd.Mahoadon, hd.Makhachhang,hd.Tongtien, hd.Ngay, hd.Manhanvien, hd.Machinhanh, hd.Loaihd , hd.Trangthai}) > 0 ? true : false;
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

        public DataTable LayCTHD(string ma)
        {
            string sql = "select * from ChiTietHoaDon where machitiethoadon = '" + ma + "'";
            return dalHD.ExecuteQuery(sql);
        }

        public string LayMaCTHD(string mahd)
        {
            string sql = "select macthoadon from Quanhe_Hoadon_CTHD where trangthai = 1 and mahoadon = '" + mahd + "'";
            return dalHD.ExecuteQuery(sql).Rows[0].ItemArray[0].ToString(); ;
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
        public bool LuuQHHDCTHD(string mahd, ref string macthd)
        {
            string ma = TaoMaCTHD();
            macthd = ma;
            string sql = "insert into Quanhe_Hoadon_CTHD(mahoadon , macthoadon , trangthai) values( @mahd , @macthd , @tt )";
            return dalHD.ExecuteNonQuery(sql, new object[] { mahd, ma , 1 }) > 0 ? true : false;            
        }

        public bool LuuCTHD(string macthd, DTO_ItemBill it)
        {
            string sql = "insert into Chitiethoadon(machitiethoadon , mamonan , soluong, thanhtien) values( @macthd , @ma , @sl , @tt )";
            return dalHD.ExecuteNonQuery(sql, new object[] { macthd, it.Ma, it.Soluong, it.Thanhtien }) > 0 ? true : false;
        }

        public bool CapnhattrangthaiHD(string mahd, int tt)
        {
            string sql = "update HoaDon set trangthai = " + tt + " where mahoadon = '" + mahd + "'";
            return dalHD.ExecuteNonQuery(sql) > 0 ? true : false;
        }
    }
}
