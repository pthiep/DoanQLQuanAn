using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boquanquanly.NewObject;
using Boquanquanly.NewModel;
using System.Data;
using System.Data.SqlClient;

namespace Boquanquanly.NewControl
{
    class ChiNhanhCtrl
    {
        ChiNhanhMOD cnMOD = new ChiNhanhMOD();

        public DataTable GetData() {
            return cnMOD.GetData();
        }

        public bool AddData(ChiNhanhOBJ cnOBJ) {
            return cnMOD.AddData(cnOBJ);
        }

        public bool UpdateData(ChiNhanhOBJ cnOBJ) {
            return cnMOD.UpdateData(cnOBJ);
        }

        public bool DeleteData(string ma) {
            return cnMOD.DeleteData(ma);
        }
    }
}
