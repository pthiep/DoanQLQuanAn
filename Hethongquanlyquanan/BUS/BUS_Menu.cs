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
        DBManager dalBan = new DBManager();

        public DataTable LoadMenuChiNhanh(string macn)
        {
            string sql = "exec LoadDanhMucChiNhanh @macn";
            return dalBan.ExecuteQuery(sql, new object[] { macn });
        }

        public int Sodanhmucchinhanh(string macn)
        {
            string sql = "exec SoLuongDanhMucChiNhanh @macn";
            return dalBan.ExecuteQuery(sql, new object[] { macn }).Rows.Count;
        }

        public DataTable BanDanhMucChiNhanh(string macn)
        {
            string sql = "exec BanDanhMucChiNhanh @macn";
            return dalBan.ExecuteQuery(sql, new object[] { macn });
        }
    }
}
