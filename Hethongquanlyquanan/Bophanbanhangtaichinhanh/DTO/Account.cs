using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bophanbanhangtaichinhanh.DTO
{
    public class Account
    {
        private int id;
        private string nameUser;
        private string permission;
        


        public int Id { get => id; set => id = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public string Permission { get => permission; set => permission = value; }

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
