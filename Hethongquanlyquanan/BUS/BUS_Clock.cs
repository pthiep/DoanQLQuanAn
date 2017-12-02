using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Clock
    {
        string sql;
        DBManager dbClock = new DBManager();

        private string GetTimeServer()
        {
            sql = "SELECT GETDATE()";
            return dbClock.ExecuteQuery(sql).Rows[0].ItemArray[0].ToString();
        }

        public string TimeServer()
        {
            string time = "";
            time = GetTimeServer();
            //"11/27/2017 11:00:04 PM"
            string[] timeSplit = time.Split(' ');
            string[] timeDay = timeSplit[0].Split('/');
            string[] timeHour = timeSplit[1].Split(':');
            time = timeHour[0] + ":" + timeHour[1] + " " + timeSplit[2] + " - " + timeDay[1] + "/" + timeDay[0] + "/" + timeDay[2];
            return time;
        }
    }
}
