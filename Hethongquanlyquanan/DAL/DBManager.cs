using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBManager : DBManagerBase
    {
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            
            Open();
            SqlCommand command = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            Close();

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            Open();

            SqlCommand command = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }

                data = command.ExecuteNonQuery();
            }
            else
            {
                SqlParameter retval = new SqlParameter("@ReturnValue", System.Data.SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(retval);
                command.ExecuteNonQuery();
                data = (int)command.Parameters["@ReturnValue"].Value;
            }
            Close();

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            Open();

            SqlCommand command = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            data = command.ExecuteScalar();

            connection.Close();

            return data;
        }

    }
}
