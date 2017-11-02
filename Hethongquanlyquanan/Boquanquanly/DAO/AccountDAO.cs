using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boquanquanly.DTO;

namespace Boquanquanly.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public static Account currentUser;

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM tbl_User WHERE user_name = N'" + userName + "' AND pass = N'" + passWord + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            
            if (result.Rows.Count > 0)
            {
                currentUser = new Account(result.Rows[0]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
