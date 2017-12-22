using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boquanquanly
{
    public partial class uc_thongkesoluongdonhangcuakhach : UserControl
    {
        private static uc_thongkesoluongdonhangcuakhach _instance;

        public static uc_thongkesoluongdonhangcuakhach Instance
        {
            get
            {
                if (_instance == null) _instance = new uc_thongkesoluongdonhangcuakhach();
                return uc_thongkesoluongdonhangcuakhach._instance; }
            set { uc_thongkesoluongdonhangcuakhach._instance = value; }
        }

        public uc_thongkesoluongdonhangcuakhach()
        {
            InitializeComponent();
        }

        private void us_thongkesoluongdonhang_Load(object sender, EventArgs e)
        {
        }
    }
}
