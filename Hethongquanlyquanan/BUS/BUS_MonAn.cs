using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_MonAn
    {
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
        }


        public int SoBan()
        {
            string query = "select count(*) from Ban";
            DataTable result = dalMA.ExecuteQuery(query);
            return int.Parse(result.Rows[0].ItemArray[0].ToString());

        }


    }
}
