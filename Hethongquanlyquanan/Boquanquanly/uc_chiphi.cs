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
    public partial class uc_chiphi : UserControl
    {
        private static uc_chiphi _instance;

        public static uc_chiphi Instance
        {
            get {if(_instance == null) _instance = new uc_chiphi(); 
                return _instance; }
            set { uc_chiphi._instance = value; }
        }
        public uc_chiphi()
        {
            InitializeComponent();
        }

        private void uc_chiphi_Load(object sender, EventArgs e)
        {
            vebangchiphi();
        }

        void vebangchiphi() { 
        
        }
    }
}
