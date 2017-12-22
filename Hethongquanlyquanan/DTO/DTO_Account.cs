﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nameUser;

        public string NameUser
        {
            get { return nameUser; }
            set { nameUser = value; }
        }

        //public int Id { get => id; set => id = value; }
        //public string NameUser { get => nameUser; set => nameUser = value; }

        public DTO_Account(int id, string name)
        {
            this.Id = id;
            this.NameUser = name;
        }

        public DTO_Account(DataRow dr)
        {
            this.Id = (int)dr["id_user"];
            this.NameUser = dr["name_user"].ToString();
        }
    }
}
