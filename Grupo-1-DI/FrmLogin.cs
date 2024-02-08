using Grupo_1_DI.Base_Datos;
using Grupo_1_DI.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grupo_1_DI
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Inicio de sesión de administrador o profesor
        /// </summary>
        Perfiles p = new Perfiles();
        string userName;
        public FrmLogin()
        {
            InitializeComponent();
            userName = Environment.UserName;
            lblUser.Text = "Accediendo a las incidencias de " + userName;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            InicioSesionAsync(userName, p);
        }

        private static async Task InicioSesionAsync(string userName, Perfiles p)
        {

            p = await Administracion.ObtenerPerfilByDominio(userName);

            // ACCESO PROFESOR
            if (p.perfil == Perfil.PROFESOR)
            {
                FrmProfesor fProfesor = new FrmProfesor(p);
                fProfesor.Show();
            }
            // ACCESO ADMINISTRADOR
            else if (p.perfil == Perfil.ADMINISTRADOR)
            {
                FrmAdmin fAdmin = new FrmAdmin();
                fAdmin.Show();
            }

        }


    }

}
