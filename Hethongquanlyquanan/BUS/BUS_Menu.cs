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

        public DataTable LoadDanhSachBan(string macn, int tang)
        {
            string sql = "select * from Ban where machinhanh = @macn and tang = @tang";
            return dalBan.ExecuteQuery(sql, new object[] { macn , tang});
        }

        public int Sotang(string macn)
        {
            string sql = "select count(tang) from Ban where machinhanh = @macn group by tang";
            return dalBan.ExecuteQuery(sql, new object[] { macn}).Rows.Count;
        }

        public int Sobantang(string macn, int tang)
        {
            string sql = "select * from Ban where machinhanh = @macn and tang = @tang";
            return dalBan.ExecuteQuery(sql, new object[] { macn, tang }).Rows.Count;
        }

        public DataTable ThemBan(string macn, int tang)
        {
            string mabanmoi = "MB" + (Sobantang(macn, tang) + 1).ToString();
            string sql = "insert into Ban (maban, machinhanh, tang) values ( @mb , @macn , @tang )";
            return dalBan.ExecuteQuery(sql, new object[] { mabanmoi, macn, tang });
        }

        public DataTable XoaBan(string macn, int tang)
        {
            string maban = "MB" + Sobantang(macn, tang);
            string sql = "delete from Ban where maban = @maban and machinhanh = @macn and tang = @tang";
            return dalBan.ExecuteQuery(sql, new object[] { maban, macn, tang });
        }

        public DataTable ThemTang(string macn)
        {
            string mabanmoi = "MB" + (Sobantang(macn, Sotang(macn)) + 1).ToString();
            int tangmoi = Sotang(macn) + 1;
            string sql = "insert into Ban (maban, machinhanh, tang) values ( @mb , @macn , @tang )";
            return dalBan.ExecuteQuery(sql, new object[] { mabanmoi, macn, tangmoi });
        }

        public DataTable XoaTang(string macn, int tang)
        {
            string sql = "delete from Ban where machinhanh = @macn and tang = @tang";
            return dalBan.ExecuteQuery(sql, new object[] { macn, tang });
        }
    }
}
