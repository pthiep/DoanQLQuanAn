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
            string query = "select * from MonAn where trangthai = 1";
            return dalMA.ExecuteQuery(query);  
        }

        public int Soluongmonan()
        {
            return LoadDanhSachMonAn().Rows.Count;
        }

        public bool Capnhatmonan(DTO_MonAn ma)
        {
            string query = "update MonAn set tenmonan = @tenma , dongia = @dongia where mamonan = @mama";
            return dalMA.ExecuteNonQuery(query, new object[] { ma.Tenma, ma.Giaban, ma.Mama }) > 0 ? true : false;
        }

        public bool Xoamonan(string ma)
        {
            string query = "update MonAn set trangthai = 0 where mamonan = @mama";
            return dalMA.ExecuteNonQuery(query, new object[] { ma }) > 0 ? true : false;
        }
    }
}
