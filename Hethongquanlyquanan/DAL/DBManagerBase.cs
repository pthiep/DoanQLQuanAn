using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBManagerBase
    {
<<<<<<< HEAD
        private string connectionSTR = "Data Source=DESKTOP-65CP3TA\\SQLEXPRESS;Initial Catalog=QLQA;Integrated Security=True";
=======
        private string connectionSTR = "Data Source=DESKTOP-O5BCKAU;Initial Catalog=QLQA;Integrated Security=True";
>>>>>>> 05f6d9e2fd9063a9db2c0be202051a26e8570b99
        protected SqlConnection connection;

        protected void Open()
        {
            connection = new SqlConnection(connectionSTR);
            connection.Open();
        }

        protected void Close()
        {
            connection.Close();
        }

    }
}
