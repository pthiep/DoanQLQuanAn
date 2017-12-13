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
        DBManager cp = new DBManager();
       // DTO_ChiPhi cp = new DTO_ChiPhi();

        public DataTable LoadDanhSachMonAn()
        {
            string query = "Select * from tbl_ChiPhi";
            DataTable result = cp.ExecuteQuery(query);
            return result;
        }

        public void ThemCP(DTO_ChiPhi cp)
        {
            cp.ChiPhi = 

        }
    }
}
