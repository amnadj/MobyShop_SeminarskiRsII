using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobyShop.WinUI
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

            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {

                if (Global.Admin == true)
                {
                    Application.Run(new frmIndexAdmin());
                }
                else
                {
                    Application.Run(new frmIndexProdavac());
                }
            }
        }
    }
}