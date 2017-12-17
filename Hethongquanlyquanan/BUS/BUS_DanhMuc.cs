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
    public class BUS_DanhMuc
    {
        DBManager dalDM = new DBManager();

        public DataTable LoadDanhMuc()
        {
            string query = "select * from DanhMucMonAn where trangthai = 1";
            return dalDM.ExecuteQuery(query);
        }

        public int Soluongdanhmuc()
        {            
            return LoadDanhMuc().Rows.Count;
        }

        public bool Capnhatdanhmuc(DTO_DanhMuc dm)
        {
            string query = "update DanhMucMonAn set tendanhmuc = @tendm where madanhmuc = @madm";
            return dalDM.ExecuteNonQuery(query, new object[] { dm.Tendanhmuc, dm.Madanhmuc }) > 0 ? true : false;
        }

        public bool Xoadanhmuc(string ma)
        {
            string query = "update DanhMucMonAn set trangthai = 0 where madanhmuc = @madm";
            return dalDM.ExecuteNonQuery(query, new object[] { ma }) > 0 ? true : false;
        }

        public bool Themdanhmuc(DTO_DanhMuc dm)
        {
            string query = "insert into DanhMucMonAn (madanhmuc,tendanhmuc,trangthai) values ( @madm , @tendm , @tt )";
            return dalDM.ExecuteNonQuery(query, new object[] { dm.Madanhmuc, dm.Tendanhmuc, 1 }) > 0 ? true : false;
        }

        private int MaDMLonnhat()
        {
            DataTable dt = new DataTable();
            List<int> lstMa = new List<int>();
            string query = "select madanhmuc from DanhMucMonAn";
            dt = dalDM.ExecuteQuery(query);


            foreach (DataRow dr in dt.Rows)
            {
                lstMa.Add(int.Parse(dr.ItemArray[0].ToString().Substring(2)));
            }

            return lstMa.Max();
        }

        public string TaoMaDM()
        {
            return "DM"+ (MaDMLonnhat() + 1).ToString();
        }
    }
}
