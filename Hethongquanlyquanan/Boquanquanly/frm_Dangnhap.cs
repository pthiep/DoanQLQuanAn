﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UICustom;

namespace Boquanquanly
{
    public partial class Frm_Dangnhap : Form
    {
        
        public Frm_Dangnhap()
        {
            InitializeComponent();
        }

        private void Btn_Dangnhap_Click(object sender, EventArgs e)
        {
            frm_Quanly frm_QL = new frm_Quanly();
            frm_QL.Show();
        }

        private void Btn_Quenmatkhau_Click(object sender, EventArgs e)
        {

        }
    }
}
