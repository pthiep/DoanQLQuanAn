using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boquanquanly.DTO;
using System.Data.SqlClient;

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
            string query = "exec usp_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            
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

        public int getParamater()
        {
            string query = "DECLARE	@return_value int EXEC @return_value = [dbo].[usp_demo] SELECT @return_value";
            //string query = "DECLARE	@return_value int EXEC @return_value = [dbo].[usp_demo] SELECT EXEC @return_value = [dbo].[usp_demo]";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return (int)result.Rows[0].ItemArray[0];
        }
    }
}
