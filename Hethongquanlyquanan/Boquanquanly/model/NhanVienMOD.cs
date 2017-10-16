using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyChung.Object;

namespace QuanLyChung.Model
{
    class NhanVienMOD
    {
        SqlCommand cmd = new SqlCommand();
        ConnectToSQL con = new ConnectToSQL();

        public DataTable GetData() 
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from HT_NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }

        public bool addData(NhanVienOBJ nv)
        {
            cmd.CommandText = "Insert into HT_NhanVien values ('" + nv.Ma + "','" + nv.Ten + "'," + nv.Diachi + "','" + nv.Sodienthoai + "','"+nv.Ngaysinh+"','" + nv.Matkhau +"," +nv.Hesoluong+"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try 
            {
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

        public bool UpDData(NhanVienOBJ nv)
        {
            cmd.CommandText = "Update HT_NhanVien set tenNV = '" +nv.Ten+"', set ngaySinh = '"+nv.Ngaysinh+"', set diaChi = '"+nv.Diachi+"', set gioiTinh = '"+nv.Gioitinh+"', set dienThoai = '"+nv.Sodienthoai+"', set hesoLuong = "+nv.Hesoluong+"'Where maNhanVien = '"+nv.Ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
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

        public bool delData(string ma)
        {
            cmd.CommandText = "delete HT_NhanVien where maNhanVien = '"+ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try 
            {
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
