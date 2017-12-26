using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_KhachHang
    {
        DBManager dalDB = new DBManager();

        public DataTable bangthongkekhach()
        {
            string query = "exec bangthongkekhachhang";
            return dalDB.ExecuteQuery(query);
        }


        public DataTable hoatdongkhachhang(string ma, DateTime ngaykt)
        {
            string query = "exec thongtinhoatdongcuakhach '"+ma+"','"+ngaykt+"'";
            return dalDB.ExecuteQuery(query);
        }

        public DataTable tongtienkhachhang(DateTime ngaykt, string ma)
        {
            string query = "exec tongtienkhachhang '" + ngaykt + "','" + ma + "'";
            return dalDB.ExecuteQuery(query);
        }
    }
}
