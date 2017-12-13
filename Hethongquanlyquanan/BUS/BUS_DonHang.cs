using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_DonHang
    {         
        DBManager dalDonHang = new DBManager();
        string sql;

        public void ThemDH(DTO_DonHang dh)
        {

            string query = "insert into HT_DonHang values('" + dh.MaDonHang + "', '" + dh.MaCN + "', '" + dh.MaKhachHang + "', " + dh.TongTien + ", " + dh.Sdt + ", '" + dh.DiaChi + "', '" + dh.TenNVLap + "')";
            dalDonHang.ExecuteNonQuery(query);

        }
        public void ThemDH1(DTO_DonHang dh)
        {

            string query = "insert into HT_DonHang values( @madh , @macn, @makh , @tongtien , @Sdt , @dc , @tennv )";

            dalDonHang.ExecuteNonQuery(query, new object[] { dh.MaDonHang, dh.MaCN, dh.MaKhachHang, dh.TongTien, dh.Sdt, dh.DiaChi, dh.TenNVLap});

        }
        public void SuaDH(DTO_DonHang dh)
        {

            string query = "update HT_DonHang set maChiNhanh= '"+dh.MaCN+"', maKhachHang='"+dh.MaKhachHang+"', tongtien="+dh.TongTien+", soDienThoai='"+dh.Sdt+"', diaChi='"+dh.DiaChi+"', nhanVienLapDon='"+dh.TenNVLap+"' where maDonHang = '"+ dh.MaDonHang + "'";
            dalDonHang.ExecuteNonQuery(query);

        }
   
        public void XoaDH(string dh)
        {
            string query = "delete from HT_DonHang where maDonHang='" + dh + "'";
            dalDonHang.ExecuteNonQuery(query);



        }





        public DataTable LoadDonHang()
        {
            string query = "Select * from HT_DonHang";
            DataTable result = dalDonHang.ExecuteQuery(query);
            return result;
        }

    }
}