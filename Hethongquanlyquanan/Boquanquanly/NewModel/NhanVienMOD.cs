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
    class NhanVienMOD
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData() {
            DataTable dt = new DataTable();

            cmd.CommandText = "Select * From HT_NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch(Exception ex){
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }

        public bool AddData(NhanVienOBJ nvOBJ) {
            cmd.CommandText = "Insert into HT_NhanVien value('" + nvOBJ.MaNV + "','" + nvOBJ.TenNV + "','" + nvOBJ.NgaySinh + "''" + nvOBJ.GioiTinh + "''" + nvOBJ.SoDienThoai + "''" + nvOBJ.DiaChi + "''" + nvOBJ.MatKhau + "''" + nvOBJ.HsLuong + "','"+nvOBJ.ThuocChiNhanh+")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
            }
            catch(Exception ex){
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            
            return false;
        }


        public bool UpdateData(NhanVienOBJ nvOBJ) {
            cmd.CommandText = "Update HT_NhanVien set tenNV = '"+nvOBJ.TenNV+"', set gioiTinh = '"+nvOBJ.GioiTinh+"', set ngaySinh = '"+nvOBJ.NgaySinh+"', set diaChi = '"+nvOBJ.DiaChi+"', set dienThoai = '"+nvOBJ.SoDienThoai+"', set hesoLuong = '"+nvOBJ.HsLuong+"', set matkhau = '"+nvOBJ.MatKhau+"', set thuocChiNhanh '"+nvOBJ.ThuocChiNhanh+"' Where maNhanVien = '"+nvOBJ.MaNV+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
            }
            catch(Exception ex){
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return false;
        }

        public bool DeleteData(string ma) {
            cmd.CommandText = "Deleta HT_NhanVien Where maNhanVien = '"+ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
           
            return false;
        }
    }
}
