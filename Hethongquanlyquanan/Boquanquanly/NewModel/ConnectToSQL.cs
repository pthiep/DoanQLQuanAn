using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Boquanquanly.NewModel
{
    class ConnectToSQL
    {
        #region Available
        private SqlConnection Conn;
        private SqlCommand _cmd;

        public SqlCommand Cmd
        {
            get { return _cmd; }
            set { _cmd = value; }
        }

        public SqlConnection Connection { get { return Conn; } }
        private string error;

        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        string StrCon;
        #endregion

        #region Contructor
        public ConnectToSQL() {
            StrCon = @"Data Source=DESKTOP-QN3IJ5G\SQLEXPRESS;Initial Catalog=QLQA;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
        }
        #endregion

        #region method
        public bool OpenConn() {
            try { 
                if(Conn.State == ConnectionState.Closed){
                    Conn.Open();
                }
            }
            catch(Exception ex){
                error = ex.Message;
                return false;
            }
            return true;
        }

        public bool CloseConn() {
            try { 
                if(Conn.State == ConnectionState.Open){
                    Conn.Close();
                }
            }
            catch(Exception ex){
                error = ex.Message;
                return false;
            }
            return true;
        }
        #endregion
    }
}
