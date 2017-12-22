using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Ban
    {
        string maban;
        bool trangthai;
        List<DTO_ItemBill> lstItem;

        public List<DTO_ItemBill> LstItem { get => lstItem; set => lstItem = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public string Maban { get => maban; set => maban = value; }
    }
}
