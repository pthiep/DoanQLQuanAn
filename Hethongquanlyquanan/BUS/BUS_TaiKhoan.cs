using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class BUS_TaiKhoan
    {
        DBManager dalTK = new DBManager();

        public bool DangNhap(string tendn, string mk, ref string manv)
        {
            string sql = "exec Login '" + tendn + "' , '" + mk + "'";
            if (dalTK.ExecuteQuery(sql).Rows.Count > 0)
            {
                manv = dalTK.ExecuteQuery(sql).Rows[0].ItemArray[0].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool QuyenTruyCap(string manv,ref List<Tuple<string, int>> lstQuyen)
        {
            string sql = "exec QuyenTruyCap '" + manv + "'";
            if (dalTK.ExecuteQuery(sql).Rows.Count > 0)
            {
                lstQuyen = new List<Tuple<string, int>>();
                foreach(DataRow dr in dalTK.ExecuteQuery(sql).Rows)
                {
                    Tuple<string, int> tp = new Tuple<string, int>(dr.ItemArray[2].ToString(), int.Parse(dr.ItemArray[3].ToString()));
                    lstQuyen.Add(tp);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
