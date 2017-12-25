using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_SLTruycap
    {
        DBManager dalTC = new DBManager();

        public int SoluongTruycap()
        {
            string sql = "select soluongtruycap from Thongtinphanmem";
            return int.Parse(dalTC.ExecuteQuery(sql).Rows[0].ItemArray[0].ToString());
        }
        public bool TangSLTC()
        {
            int sltc = SoluongTruycap() + 1;
            string sql = "update Thongtinphanmem set soluongtruycap = @sltc";
            return dalTC.ExecuteNonQuery(sql , new object[] { sltc }) > 0 ? true : false;
        }
    }
}
