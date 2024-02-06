using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_1_DI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin login = new FrmLogin();
            login.FormClosed += FrmLogin_Closed;
            login.Show();
            Application.Run();
        }
        //Aquí si no encuentra forms abiertos, cierra las ventanas
        private static void FrmLogin_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FrmLogin_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
                return;
            }

            Application.OpenForms[0].FormClosed += FrmLogin_Closed;

        }
    }
}
