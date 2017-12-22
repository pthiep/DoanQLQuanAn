using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiNhanh
    {
        string macn;

        public string Macn
        {
            get { return macn; }
            set { macn = value; }
        }


       


string tencn;

public string Tencn
{
    get { return tencn; }
    set { tencn = value; }
}
string diachi;

public string Diachi
{
    get { return diachi; }
    set { diachi = value; }
}
string dienthoai;

public string Dienthoai
{
    get { return dienthoai; }
    set { dienthoai = value; }
}
        string tinhthanh;


        public string Tinhthanh
        {
            get { return tinhthanh; }
            set { tinhthanh = value; }
        }


        int soluongban;
        string manvql;
        public string Tinhthanh { get => tinhthanh; set => tinhthanh = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Tencn { get => tencn; set => tencn = value; }
        public string Macn { get => macn; set => macn = value; }
        public int Soluongban { get => soluongban; set => soluongban = value; }
        public string Manvql { get => manvql; set => manvql = value; }
    }
}
