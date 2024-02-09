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
    public partial class FrmProfesor : Form
    {
        /// <summary>
        /// Formulario para el usuario Profesor
        /// </summary>
        Personal per;
        private Timer timer;

        private FrmProfesor()
        {
            InitializeComponent();
        }
        public FrmProfesor(Perfiles p) : this()
        {
            this.per = Administracion.ObtenerPersonalByPerfil(p.personal_id);

            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            //cargarInformesProfesor();
            lblFecha.Text = DateTime.UtcNow.ToLongDateString();
        }

        private void cargarInformesProfesor()
        {
            var lst = Administracion.ObtenerIncidenciasByProfesor(per.id);
            dgvIncidencias.DataSource = lst;
            lblRegistros.Text = "Numero de Registros: " + dgvIncidencias.RowCount.ToString();
        }



        private void btnNuevaIncidencia_Click(object sender, EventArgs e)
        {

        }

        // Filtrado de Incidencias
        // Se filtrarán por: Subtipo incidencia, Fecha Creación y Estado
        private void btnFiltro_Click(object sender, EventArgs e)
        {

        }


        // ContextMenuStrips

        private void tsmiModificar_Click(object sender, EventArgs e)
        {

        }

        private void tsmiEliminar_Click(object sender, EventArgs e)
        {

        }

        // Para mostrar la hora actual
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar la celda de la barra de estado con la fecha y hora actual
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
