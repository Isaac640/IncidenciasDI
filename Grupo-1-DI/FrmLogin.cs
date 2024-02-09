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
        string userName;
        public FrmLogin()
        {
            InitializeComponent();
            userName = Environment.UserName;
            lblUser.Text = "Accediendo a las incidencias de " + userName;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            InicioSesion(userName);
        }

        private async Task InicioSesion(string userName)
        {
            Perfiles perfil = await Administracion.ObtenerPerfilByDominio(userName);

            // ACCESO PROFESOR
            if (perfil.perfil.Equals("profesor"))
            {
                FrmProfesor fProfesor = new FrmProfesor(perfil);
                fProfesor.Show();
                this.Close();
            }
            // ACCESO ADMINISTRADOR
            else if (perfil.perfil.Equals("administrador"))
            {
                FrmAdmin fAdmin = new FrmAdmin();
                fAdmin.Show();
            }
            else
            {
                MessageBox.Show("Este usuario de dominio no esta registrado en la base de datos por favor" +
                    " contacte con el administrador de dominio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

    }

}
