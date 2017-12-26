using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_ChiPhi
    {
        DBManager dalcp = new DBManager();        

        public bool ThemCP(DTO_ChiPhi cp)
        {
            string sql = "insert into ChiPhiPhatSinh (machiphi, tenchiphi, chiphi, manhanvien, loaichiphi, machinhanh, ngayphatsinh) " +
                "values ('" + cp.Macp + "', N'" + cp.TenCP + "', " + cp.ChiPhi + ", '" + cp.Manv + "' , " + cp.Loaicp + ", '" + cp.Macn + "', '" + cp.Ngayphatsinh + "')";
            return dalcp.ExecuteNonQuery(sql) > 0 ? true : false;
        }

        public string TaoMaCP(string macn)
        {
            string sql = "select * from ChiPhiPhatSinh";
            int ma = dalcp.ExecuteQuery(sql).Rows.Count;
            string sma = "CPPS" + (ma + 1);
            return sma;
        }

        public DataTable TinhChiPhi(DateTime NgayBD, DateTime NgayKT)
        {
            string query = "exec TinhChiPhi '"+NgayBD+"','"+NgayKT+"'";
            DataTable result = cp.ExecuteQuery(query);
            return result;
        }

        public DataTable TongChiPhi(DateTime NgayBD, DateTime NgayKT)
        {
            string query = "exec TongChiPhi '" + NgayBD + "','" + NgayKT + "'";
            DataTable result = cp.ExecuteQuery(query);
            return result;
        }
    }
}
