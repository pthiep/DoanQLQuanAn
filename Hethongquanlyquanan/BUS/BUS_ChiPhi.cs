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
<<<<<<< HEAD
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
=======
        DBManager dalcp = new DBManager();

        public DataTable LoadDanhSachChiPhi()
        {
            string query = "Select * from ChiPhi";
            DataTable result = dalcp.ExecuteQuery(query);
            return result;
        }

        public bool Capnhatchiphi(DTO_ChiPhi cp)
        {
            string query = "update ChiPhi set tenchiphi = N'" + cp.TenCP + "' , chiphi = " + cp.ChiPhi + " where machinhanh = '" + cp.MaCP + "'";
            return dalcp.ExecuteNonQuery(query) > 0 ? true : false;
        }

        public bool ThemCP(DTO_ChiPhi cp)
        {
            string query = "insert into ChiPhi (machiphi, tenchinhanh, chiphi) values ( @macp , @tencp , @cp)";
            return dalcp.ExecuteNonQuery(query, new object[] { cp.MaCP, cp.TenCP, cp.ChiPhi }) > 0 ? true : false;
>>>>>>> 808c8447e350a6f3785fc3951d494528cb32c8e7
        }

        public bool Xoachiphi(string ma)
        {
            string query = "delete from ChiPhi set where machiphi = @macp";
            return dalcp.ExecuteNonQuery(query, new object[] { ma }) > 0 ? true : false;
        }


    }
}
