using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bophanbanhangtaichinhanh.DTO;

namespace Bophanbanhangtaichinhanh
{
    public class ChiNhanh
    {
        private int maCN;
        private string tenCN;
        private string diaChi;
        private List<Tuple<int, int>> tang;
        private DateTime ngayTL;
        private NhanVien nhanhVienQL;

        public List<Tuple<int, int>> Tang { get => tang; set => tang = value; }
        public int MaCN { get => maCN; set => maCN = value; }
        public string TenCN { get => tenCN; set => tenCN = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgayTL { get => ngayTL; set => ngayTL = value; }
        public NhanVien NhanhVien { get => nhanhVienQL; set => nhanhVienQL = value; }


        /*     ,[tenChiNhanh]
      ,[soDienThoai]
      ,[diaChi]
      ,[soLuongBanAn]
      ,[ngayThanhLap]
      ,[nhanVienQuanLi]*/
    }
}
