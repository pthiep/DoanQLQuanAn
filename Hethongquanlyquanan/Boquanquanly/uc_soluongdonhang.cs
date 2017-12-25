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
    public partial class uc_soluongdonhang : UserControl
    {
        private static uc_soluongdonhang _instance;

        public static uc_soluongdonhang Instance
        {
            get
            {
                if (_instance == null) _instance = new uc_soluongdonhang();
                return uc_soluongdonhang._instance; }
            set { uc_soluongdonhang._instance = value; }
        }

        public uc_soluongdonhang()
        {
            InitializeComponent();
        }

        private void uc_soluongdonhang_Load(object sender, EventArgs e)
        {

        }
    }
}
