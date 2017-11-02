using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boquanquanly.DTO
{
    public class Account
    {
        private int id;
        private string nameUser;

        public int Id { get => id; set => id = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }

        public Account(int id, string name)
        {
            this.Id = id;
            this.NameUser = name;
        }

        public Account(DataRow dr)
        {
            this.Id = (int)dr["id_user"];
            this.NameUser = dr["name_user"].ToString();
        }
    }
}
