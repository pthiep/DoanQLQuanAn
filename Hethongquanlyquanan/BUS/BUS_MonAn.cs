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
<<<<<<< HEAD
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
=======
        DBManager dalMA= new DBManager();
        /*
        public DataTable LoadDanhSachMonAn()
        {
            string query = "Select * from tbl_User";
            DataTable result = dalAcc.ExecuteQuery(query);
            return result;            
        }*/

        public DataTable LoadDanhSachMonAn()
        {
            string query = "Select * from MonAn";
            DataTable result = dalMA.ExecuteQuery(query);
            return result;
        }

        public int SoMonAn()
        {
            string query = "select count(*) from MonAn";
            DataTable result = dalMA.ExecuteQuery(query);
            return int.Parse(result.Rows[0].ItemArray[0].ToString());

        }

        public DataTable LoadDanhSachBan()
        {
            string query = "Select * from Ban";
            DataTable result = dalMA.ExecuteQuery(query);
            return result;
>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85
        }


        public int SoBan()
        {
            string query = "select count(*) from Ban";
            DataTable result = dalMA.ExecuteQuery(query);
            return int.Parse(result.Rows[0].ItemArray[0].ToString());

        }


    }
}
