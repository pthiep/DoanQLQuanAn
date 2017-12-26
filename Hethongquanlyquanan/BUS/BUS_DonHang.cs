using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_DonHang
    {
        DBManager dalDM = new DBManager();

        public DataTable ThongkeMonBan(DateTime ngaybd, DateTime ngaykt)
        {
            string query = "exec ThongKeSoLuongMonBan '" + ngaybd + "','" + ngaykt + "'";
            return dalDM.ExecuteQuery(query);
        }

        public DataTable ThongkeMonBanCuaChiNhanh(DateTime ngaybd, DateTime ngaykt)
        {
            string query = "exec thongkehdtheochinhanh '" + ngaybd + "','" + ngaykt + "'";
            return dalDM.ExecuteQuery(query);
        }


        public DataTable TongSldon(DateTime ngaybd, DateTime ngaykt) {
            string query = "exec TongSoLuongDH '" + ngaybd + "','" + ngaykt + "'";
            return dalDM.ExecuteQuery(query);
        }

        public DataTable DonHangTheoNam()
        {
            string query = "exec SoLuongdonhangtheonam";
            return dalDM.ExecuteQuery(query);
        }
    }
}
