using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Menu
    {
        DBManager dalMenu = new DBManager();

        public DataTable LoadMenuChiNhanh(string macn)
        {
            string sql = "exec LoadDanhMucChiNhanh @macn";
            return dalMenu.ExecuteQuery(sql, new object[] { macn });
        }

        public int Sodanhmucchinhanh(string macn)
        {
            string sql = "exec SoLuongDanhMucChiNhanh @macn";
            return dalMenu.ExecuteQuery(sql, new object[] { macn }).Rows.Count;
        }

        public DataTable BanDanhMucChiNhanh(string macn)
        {
            string sql = "exec BangDanhMucChiNhanh @macn";
            return dalMenu.ExecuteQuery(sql, new object[] { macn });
        }
        public DataTable DanhSachMonAnTheoDanhMuc(string macn, string danhmuc)
        {
            string sql = "exec SoLuongMonAn @macn , N'" + danhmuc + "'";
            return dalMenu.ExecuteQuery(sql, new object[] { macn });
        }

        public int SoLuongMonAn(string macn, string danhmuc)
        {
            string sql = "exec SoLuongMonAn @macn , N'" + danhmuc +"'";
            return dalMenu.ExecuteQuery(sql, new object[] { macn }).Rows.Count;
        }

        public bool XoaMonAn(string macn, string mama)
        {
            string sql = "exec XoaMonAn @macn , @mama";
            return dalMenu.ExecuteNonQuery(sql, new object[] { macn, mama}) > 0 ? true : false;
        }

        public DataTable LoadDanhMuc()
        {
            string sql = "select * from DanhMucMonAn where trangthai = 1";
            return dalMenu.ExecuteQuery(sql);
        }

        public DataTable LoadMonAn(string dm)
        {
            string sql = "select mamonan from Quanhe_Danhmuc_Monan where trangthai = 1 and madanhmuc = (select madanhmuc from DanhMucMonAn where tendanhmuc = N'" + dm + "')";
            return dalMenu.ExecuteQuery(sql);
        }

        public string LayTenMonAnTuMa(string ma)
        {
            string sql = "select tenmonan from MonAn where trangthai = 1 and mamonan = '" + ma + "'";
            return dalMenu.ExecuteQuery(sql).Rows[0].ItemArray[0].ToString();
        }

        public string LayMaTuTenMonAn(string ten)
        {
            string sql = "select mamonan from MonAn where trangthai = 1 and tenmonan = N'" + ten + "'";
            return dalMenu.ExecuteQuery(sql).Rows[0].ItemArray[0].ToString();
        }

        public bool CheckMonAnTonTai(string macn, string mama)
        {
            string sql = "select * from Quanhe_Chinhanh_QHDM where maqhDM = (select maquanhe from Quanhe_Danhmuc_Monan where mamonan = '" + mama + "') and machinhanh = '" + macn + "'";
            return dalMenu.ExecuteQuery(sql).Rows.Count > 0 ? true : false;
        }

        public bool MonAnTonTaiTronMenu(string macn, string mama)
        {
            string sql = "select * from Quanhe_Chinhanh_QHDM where maqhDM = (select maquanhe from Quanhe_Danhmuc_Monan where mamonan = '" + mama + "') and trangthai = 1 and machinhanh = '" + macn + "'";
            return dalMenu.ExecuteQuery(sql).Rows.Count > 0 ? true : false;
        }

        public bool Capnhattrangthaiqhcndm(string macn, string mama)
        {
            string sql = "update Quanhe_Chinhanh_QHDM set trangthai = 1 where machinhanh = '" + macn + "' and maqhDM = (select maquanhe from Quanhe_Danhmuc_Monan where mamonan = '" + mama + "')";
            return dalMenu.ExecuteNonQuery(sql) > 0 ? true : false;
        }

        public bool Themmoiqhcndm(string macn, string mama)
        {
            string sql = "exec ThemMoiQuanHeChiNhanhDM @macn , @mama";
            return dalMenu.ExecuteNonQuery(sql, new object[] { macn, mama }) > 0 ? true : false;
        }
    }
}
