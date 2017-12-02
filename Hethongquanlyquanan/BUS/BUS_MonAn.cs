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
        DBManager dalAcc = new DBManager();

        public DataTable LoadDanhSachMonAn()
        {
            string query = "Select * from tbl_User";
            DataTable result = dalAcc.ExecuteQuery(query);
            return result;            
        }
    }
}
