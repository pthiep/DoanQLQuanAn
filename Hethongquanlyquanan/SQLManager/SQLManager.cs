using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLManager
{
    public class SqlManager
    {
        SqlConnection conn;

        bool isSuccess = false;

        public bool Connect(string sqlStr)
        {
            conn = new SqlConnection(sqlStr);
            try
            {
                conn.Open();
                isSuccess = true;
                return true;
            }
            catch (SqlException)
            {
                isSuccess = false;
                return false;
            }
        }

        public bool Disconnect()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public DataTable Command(string cmd)
        {
            DataTable dt = new DataTable();
            if (isSuccess)
            {
                SqlDataAdapter sqlAdap = new SqlDataAdapter(cmd, conn);
                sqlAdap.Fill(dt);
                return dt;
            }
            else
            {
                return null;
            }
        }
    }
}
