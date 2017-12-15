using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bophanbanhangtaichinhanh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Frm_BanHang());
=======
            //Application.Run(new frm_Dangnhap());
            Application.Run(new Frm_ChiNhanh());
>>>>>>> bc5c5506f4eb27b8dfb3d18464b4f5b1e619ff85
        }
    }
}
