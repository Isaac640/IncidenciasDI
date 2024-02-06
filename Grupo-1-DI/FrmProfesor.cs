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
        Administracion datos = new Administracion();
        //static private string CadenaConexion = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Neumaticos;Integrated Security=True";

        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            cargarInformesProfesor();
            tsslFecha.Text = "Fecha: " + DateTime.UtcNow.ToString();
        }

        private void cargarInformesProfesor()
        {
            var lst = datos.ObtenerIncidenciasProfesor();
            dgvIncidencias.DataSource = lst;
            tsslRegistros.Text = "Numero de Registros: " + dgvIncidencias.RowCount.ToString();
        }

        private void btnNuevaIncidencia_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
