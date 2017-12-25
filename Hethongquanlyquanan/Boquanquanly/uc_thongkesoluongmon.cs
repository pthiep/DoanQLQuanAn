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
    public partial class uc_thongkesoluongmon : UserControl
    {
        private static uc_thongkesoluongmon _instance;

        public static uc_thongkesoluongmon Instance
        {
            get
            {
                if (_instance == null) _instance = new uc_thongkesoluongmon();
                return uc_thongkesoluongmon._instance; }
            set { uc_thongkesoluongmon._instance = value; }
        }
        public uc_thongkesoluongmon()
        {
            InitializeComponent();
        }

        private void uc_thongkesoluongmon_Load(object sender, EventArgs e)
        {

        }
    }
}
