using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace BUS
{
    public class BUS_MonAn
    {
        DBManager dalMA = new DBManager();
        DTO_MonAn dtoMA;

        public DataTable LoadDanhSachMonAn()
        {
            string query = "Select * from HT_MonAn";
            DataTable result = dalMA.ExecuteQuery(query);
            return result;
        }

        public DataTable LoadDanhSachMonAnTheoMa(string ma)
        {
            string query = "Select * from HT_MonAn where maMonAn = '" + ma + "'";
            DataTable result = dalMA.ExecuteQuery(query);
            return result;
        }

        public void ThemMonAn(DTO_MonAn dtoMA)
        {
            string query = "insert into HT_MonAn(maMonAn, tenMonAn, donGia) values ('" + dtoMA.MaMonAn + "',N'" + dtoMA.TenMonAn + "', '" + dtoMA.DonGia + "')";
            dalMA.ExecuteNonQuery(query);
        }
        public void XoaMonAn(string MaMonAn)
        {
            string query = "delete from HT_MonAn where maMonAn = '" + MaMonAn + "'";
            dalMA.ExecuteNonQuery(query);
        }
        public void SuaMonAn(DTO_MonAn dtoMA)
        {
            string query = "update HT_MonAn set tenMonAn=N'" + dtoMA.TenMonAn + "', donGia= " + dtoMA.DonGia + " where maMonAn = '" + dtoMA.MaMonAn + "'";
            dalMA.ExecuteNonQuery(query);
        }
        public bool SearchMonAn(string MaMonAn)
        {
            string query = "Select * from HT_MonAn where maMonAn = '" + MaMonAn + "'";
            if (dalMA.ExecuteQuery(query).Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
