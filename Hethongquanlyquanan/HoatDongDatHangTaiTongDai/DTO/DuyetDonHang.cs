using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoatDongDatHangTaiTongDai.DTO
{
    class DuyetDonHang
    {
        private string maDH;
        private string tenKH;
        private string maMonAn;
        public string tenMonAn;
        private string tongTien;

        public string GetMaDH()
        {
            return maDH;
        }

        public void SetMaDH(string value)
        {
            maDH = value;
        }

        public string GetTenKH()
        {
            return tenKH;
        }

        public void SetTenKH(string value)
        {
            tenKH = value;
        }

        public string GetMaMonAn()
        {
            return maMonAn;
        }

        public void SetMaMonAn(string value)
        {
            maMonAn = value;
        }

        public string GetTongTien()
        {
            return tongTien;
        }

        public void SetTongTien(string value)
        {
            tongTien = value;
        }
    }
}
