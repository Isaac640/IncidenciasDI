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
    /// <summary>
    /// Formulario para el inicio de sesión de administradores o profesores.
    /// </summary>
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Nombre de usuario del sistema.
        /// </summary>
        string userName;

        /// <summary>
        /// Constructor de la clase FrmLogin.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            userName = Environment.UserName;
            lblUser.Text = "Accediendo a las incidencias de " + userName;
        }

        /// <summary>
        /// Método llamado cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            InicioSesion(userName);
        }

        /// <summary>
        /// Inicia sesión en el sistema.
        /// </summary>
        /// <param name="userName">El nombre de usuario del sistema.</param>
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
                FrmAdmin fAdmin = new FrmAdmin(perfil);
                fAdmin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Este usuario de dominio no está registrado en la base de datos. Por favor" +
                    " contacte con el administrador de dominio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
    }
}