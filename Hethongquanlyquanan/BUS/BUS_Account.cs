using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Account
    {
        DBManager dalAcc = new DBManager();

        public bool Login(string userName, string passWord)
        {
            string query = "exec usp_Login @userName , @passWord";
            DataTable result = dalAcc.ExecuteQuery(query, new object[] { userName, passWord });

            if (result.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
