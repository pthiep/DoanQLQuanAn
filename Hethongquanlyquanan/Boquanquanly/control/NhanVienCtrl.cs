using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyChung.Model;
using QuanLyChung.Object;

namespace QuanLyChung.Control
{
    class NhanVienCtrl
    {
        NhanVienMOD nvMod = new NhanVienMOD();
        public DataTable getData()
        {
            return nvMod.GetData();
        }

        public bool addData(NhanVienOBJ nvobj)
        {
            return nvMod.addData(nvobj);
        }

        public bool updData(NhanVienOBJ nvobj)
        {
            return nvMod.UpDData(nvobj);
        }

        public bool delData(string ma)
        {
            return nvMod.delData(ma);
        }
    }
}
