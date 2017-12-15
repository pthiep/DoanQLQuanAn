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
        private string connectionSTR = "Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=QLQA;Integrated Security=True";
=======
         //private string connectionSTR = "Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=Accout;Integrated Security=True";
        string connectionSTR = @"Data Source=DESKTOP-HF3Q9MR\SQLEXPRESS;Initial Catalog=QLQA;Integrated Security=True";
>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85
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
