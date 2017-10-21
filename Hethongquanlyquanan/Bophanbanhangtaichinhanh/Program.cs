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
            Application.Run(new frm_Hethong());

            // Tui chỉ brand trươớc nha ok
            // Ví dụ 2 dòng comment này là bà sưửa code save lạiái
        }
    }
}
