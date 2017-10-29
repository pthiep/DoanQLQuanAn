using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Boquanquanly.NewObject;

namespace Boquanquanly.NewModel
{
    class ChiNhanhMOD
    {
        ConnectToSQL conn = new ConnectToSQL();
        SqlCommand cm = new SqlCommand();

        public DataTable GetData() {
            DataTable dt = new DataTable();

            cm.CommandText = "select * from HT_ChiNhanh";
            cm.CommandType = CommandType.Text;
            cm.Connection = conn.Connection;

            try {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cm);
                sda.Fill(dt);
                conn.CloseConn();
            }
            catch(Exception ex){
                string mes = ex.Message;
                cm.Dispose();
                conn.CloseConn();
            }

            return dt;
        }


        public bool AddData(ChiNhanhOBJ cnOBJ) {
            cm.CommandText = "insert into HT_ChiNhanh value('"+cnOBJ.MaChiNhanh1+"','"+cnOBJ.TenChiNhanh1+"','"+cnOBJ.SoDienThoai1+"','"+cnOBJ.DiaChi1+"','"+cnOBJ.SoLuongBan1+"','"+cnOBJ.NgayThanhLap1+"','"+cnOBJ.NhanVienQL1+"')";
            cm.CommandType = CommandType.Text;
            cm.Connection = conn.Connection;

            try {
                conn.OpenConn();
                cm.ExecuteNonQuery();
                conn.CloseConn();
            }
            catch(Exception ex){
                string mes = ex.Message;
                cm.Dispose();
                conn.CloseConn();
            }

            return false;
        }

        public bool UpdateData(ChiNhanhOBJ cnOBJ) {
            cm.CommandText = "Update HT_ChiNhanh set tenChiNhanh = '"+cnOBJ.TenChiNhanh1+"',set soDienThoai = '"+cnOBJ.SoDienThoai1+"', set diaChi = '"+cnOBJ.DiaChi1+"', set soLuongBan = '"+cnOBJ.SoLuongBan1+"', set ngayThanhLap = '"+cnOBJ.NgayThanhLap1+"', set nhanVienQuanLi = '"+cnOBJ.NhanVienQL1+"' Where maChiNhanh = '"+cnOBJ.MaChiNhanh1+"'";
            cm.CommandType = CommandType.Text;
            cm.Connection = conn.Connection;

            try {
                conn.OpenConn();
                cm.ExecuteNonQuery();
                conn.CloseConn();
            }
            catch(Exception ex){
                string mes = ex.Message;
                cm.Dispose();
                conn.CloseConn();
            }
            return false;
        }

        public bool DeleteData(string ma) {
            cm.CommandText = "Delete HT_ChiNhanh Where maChiNhanh = '"+ma+"'";
            cm.CommandType = CommandType.Text;
            cm.Connection = conn.Connection;

            try {
                conn.OpenConn();
                cm.ExecuteNonQuery();
                conn.CloseConn();
            }
            catch(Exception ex){
                string mes = ex.Message;
                cm.Dispose();
                conn.CloseConn();
            }

            return false;
        }
    }
}
