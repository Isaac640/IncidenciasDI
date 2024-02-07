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
        Personal per = null;

        private FrmProfesor()
        {
            InitializeComponent();
        }
        public FrmProfesor(Perfiles p) : this()
        {
            per = Administracion.ObtenerPersonalByPerfil(per.id);
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            cargarInformesProfesor();
            tsslFecha.Text = "Fecha: " + DateTime.UtcNow.ToShortDateString();
        }

        private void cargarInformesProfesor()
        {
            var lst = Administracion.ObtenerIncidenciasByProfesor(per.id);
            dgvIncidencias.DataSource = lst;
            tsslRegistros.Text = "Numero de Registros: " + dgvIncidencias.RowCount.ToString();
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
    }
}
