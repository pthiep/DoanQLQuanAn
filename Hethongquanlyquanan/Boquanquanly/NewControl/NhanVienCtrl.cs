using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Boquanquanly.NewModel;
using Boquanquanly.NewObject;


namespace Boquanquanly.NewControl
{
    class NhanVienCtrl
    {
        NhanVienMOD nvMOD = new NhanVienMOD();

        public DataTable getData(){
            return nvMOD.GetData();
        }

        public bool AddData(NhanVienOBJ nvobj) {

            return nvMOD.AddData(nvobj);
        }

        public bool UpdateData(NhanVienOBJ nvobj) {
            return nvMOD.UpdateData(nvobj);
        }


        public bool DeleteData(string ma)
        {
            return nvMOD.DeleteData(ma);
        }
    }
}
