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

namespace Grupo_1_DI
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Inicio de sesión de administrador o profesor
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Si alguno del los campos estan vacios, se mostrara un MensajeBox Alertando al usuario
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Uno de los campos esta vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // encriptacion de contraseña a MD5
            string contraEncr = EncriptadorMD5(txtContrasenia.Text);
            /*Si funciona, verifica que los campos esten rellenados y que el usuario exista
            *Usa la API, avanza al siguiente formulario y cierra la ventana de login.
            *El metodo que hay en Program.cs hace que si hay mas ventanas por aparecer, cierra la ventana y sigue a la siguiente
            *dependiendo del usuario, irá a una ventana a otra
            */


            //Dependiendo del usuario, se le redigirirá a su formulario
            //NO TERMINADO
            /*
            if (await Administracion.IniciarSesion(txtUsuario.Text, contraEncr) != 0)
            {
                if (Perfiles.Perfil.Profesor)
                {
                    FrmProfesor fProfesor = new FrmProfesor();
                    fProfesor.Show();
                    this.Close();
                }else if (Perfiles.Perfil.Administrador)
                {
                    FrmAdmin fAdmin = new FrmAdmin();
                    fAdmin.Show();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */


        }
        public static string EncriptadorMD5(string contraseña)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //calcular hash a partir de los bytes de texto
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(contraseña));

            //obtiene el resultado de hash despues de calcularlo
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //cambiarlo a 2 digitos hexadecimales por cada byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }

}
