using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_MonAn
    {
        DBManager dalMA = new DBManager();

        public DataTable LoadDanhSachMonAn()
        {
            string query = "exec LoadMonAn";
            return dalMA.ExecuteQuery(query);  
        }

        public DataTable LoadDanhSachBan()
        {
            string query = "select * from Ban";
            return dalMA.ExecuteQuery(query);
        }

        public int SoBan()
        {
            return LoadDanhSachBan().Rows.Count;
        }

        public int Soluongmonan()
        {
            return LoadDanhSachMonAn().Rows.Count;
        }

        public bool Capnhatmonan(DTO_MonAn ma)
        {
            string query = "update MonAn set tenmonan = @tenma , giaban = @giaban where mamonan = @mama";
            Capnhatdanhmucmonan(ma.Mama, ma.Madanhmuc);
            return dalMA.ExecuteNonQuery(query, new object[] { ma.Tenma, ma.Giaban, ma.Mama }) > 0 ? true : false;
        }

        public bool Capnhatdanhmucmonan(string mama, string madm)
        {
            string query = "update Quanhe_Danhmuc_Monan set madanhmuc = @madm where mamonan = @mama";
            return dalMA.ExecuteNonQuery(query, new object[] { madm, mama }) > 0 ? true : false;
        }

        public bool Xoamonan(string ma)
        {
            string query = "update MonAn set trangthai = 0 where mamonan = @mama";
            return dalMA.ExecuteNonQuery(query, new object[] { ma }) > 0 ? true : false;
        }

        public string LayTenDanhMuc(string ma)
        {
            string query = "select * from DanhMucMonAn where madanhmuc = @madm";
            return dalMA.ExecuteQuery(query, new object[] { ma }).Rows[0].ItemArray[1].ToString();
        }

        public string LayMaDanhMuc(string ma)
        {
            string query = "select * from DanhMucMonAn where tendanhmuc = N'" + ma + "'";
            return dalMA.ExecuteQuery(query).Rows[0].ItemArray[0].ToString();
        }

        public string LayTenTuMaMonAn(string ma)
        {
            string query = "select tenmonan from MonAn where mamonan = N'" + ma + "'";
            return dalMA.ExecuteQuery(query).Rows[0].ItemArray[0].ToString();

        }

        public string LayGiaMonAnTheoMa(string ma)
        {
            string query = "select giaban from MonAn where mamonan = N'" + ma + "'";
            return dalMA.ExecuteQuery(query).Rows[0].ItemArray[0].ToString();
        }
    }
}
