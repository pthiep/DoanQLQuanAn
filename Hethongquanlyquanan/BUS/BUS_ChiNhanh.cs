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
    public class BUS_ChiNhanh
    {
        DBManager dalCN = new DBManager();

        public DataTable LoadDanhSachChiNhanh()
        {
            string query = "exec LoadChiNhanh";
            return dalCN.ExecuteQuery(query);
        }

        public int Soluongchinhanh()
        {
            return LoadDanhSachChiNhanh().Rows.Count;
        }

        public bool Capnhatchinhanhnhanh(DTO_ChiNhanh cn)
        {
            string query = "update ChiNhanh set tenchinhanh = N'" + cn.Tencn + "' , sodienthoai = " + cn.Dienthoai + " , diachi = N'" + cn.Diachi + "' where machinhanh = " + cn.Macn;
            return dalCN.ExecuteNonQuery(query) > 0 ? true : false;
        }

        public bool Xoachinhanh(string ma)
        {
            string query = "update ChiNhanh set trangthai = 0 where machinhanh = @macn";
            return dalCN.ExecuteNonQuery(query, new object[] { ma }) > 0 ? true : false;
        }

        public DataTable TinhTongDoanhThuChiNhanh(DateTime Ngaybatdau, DateTime Ngayketthuc)
        {
            string query = "exec TinhTongTienChiNhanh '"+Ngaybatdau+"', '"+Ngayketthuc+"'";
            return dalCN.ExecuteQuery(query);
        }

        public DataTable TinhSLDHcuaCN(string macn)
        {
            string query = " ";
            return dalCN.ExecuteQuery(query);
        }
    }
}
