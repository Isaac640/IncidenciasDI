using Grupo_1_DI.Base_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_1_DI
{
    public partial class FrmAdmin : Form
    {
        Personal personal;
        Perfiles perfil;
        private Timer timer;
        public FrmAdmin()
        {
            InitializeComponent();
        }

        public FrmAdmin(Perfiles p)
        {
            this.perfil = p;
            
            cargarInformes();
            // Tiempo y dia
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
            lblFecha.Text = DateTime.UtcNow.ToLongDateString();
        }

        private async void cargarInformes()
        {
            var lst = await Administracion.ObtenerIncidencias();

            if (lst != null)
            {
                lblNombre.Text = personal.nombre;
                lblApellidos.Text = this.personal.apellido1 + " " + this.personal.apellido2;
                lblRegistros.Text = "Registros: " + dgvIncidencias.RowCount.ToString();
            }
        }


        // Para mostrar la hora actual
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar la celda de la barra de estado con la fecha y hora actual
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Botones principales
        private void btnRegIncidencia_Click(object sender, EventArgs e)
        {
            // Nuevo Formulario
            Incidencias inc = new Incidencias();
            FrmIncidencia formIncidencia = new FrmIncidencia(inc);
            if (formIncidencia.ShowDialog() == DialogResult.OK)
            {
                //Administracion.SubirIncidencia(inc);
            }
        }

        private void btbEditarIncidencia_Click(object sender, EventArgs e)
        {
            // Comprobacion de que este seleccionado
            // Ir al formulario para modificarlo
        }

        private void btnBorrarIncidencia_Click(object sender, EventArgs e)
        {
            // Comprobacion de que este seleccionado
            // Preguntar si quiere borrar la incidencia
        }

        // Filtrado de Incidencias
        // Se filtrarán por: Subtipo incidencia, Fecha Creación y Estado
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        //Salir

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que quiere salir?", "Aviso", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
