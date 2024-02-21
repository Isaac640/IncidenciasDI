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
        Personal personal;
        Perfiles perfil;
        Timer timer;

        private FrmProfesor()
        {
            InitializeComponent();
        }
        //Obtener perfil por login
        public FrmProfesor(Perfiles p) : this()
        {
            this.perfil = p;
            //Obtiene el personal por id de perfil
            ObtenerPersonalAsync(perfil.personal_id);

            // Tiempo y dia
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
            lblFecha.Text = DateTime.UtcNow.ToLongDateString();
        }

        // Obtener el personal por el id de perfil
        private async void ObtenerPersonalAsync(long personalId)
        {
            this.personal = await Administracion.ObtenerPersonalByPerfil(personalId);

            if (personal != null)
            {
                lblNombre.Text = this.personal.nombre;
                lblApellidos.Text = this.personal.apellido1 + " " + this.personal.apellido2;
                cargarInformesProfesor();
            }
        }

        // Cargar informes al DataGridView

        private async void cargarInformesProfesor()
        {
            var lst = await Administracion.ObtenerIncidenciasByProfesor(personal.id);

            if (lst != null)
            {
                modelarTabla(lst);
                lblRegistros.Text = "Registros: " + dgvIncidencias.RowCount.ToString();
            }
        }

        // Modelar Tabla de dataGridView (Advertencia, Muy largo)
        private void modelarTabla(List<Incidencias_Sin> lst)
        {
            dgvIncidencias.AutoGenerateColumns = false;

            // Crear columnas manualmente para el DataGridView

            DataGridViewTextBoxColumn columnaTipo = new DataGridViewTextBoxColumn();
            columnaTipo.DataPropertyName = "tipo";
            columnaTipo.HeaderText = "Tipo";

            DataGridViewTextBoxColumn columnaFecha = new DataGridViewTextBoxColumn();
            columnaFecha.DataPropertyName = "fecha_creacion";
            columnaFecha.HeaderText = "Fecha creacion";

            DataGridViewTextBoxColumn columnaDesc = new DataGridViewTextBoxColumn();
            columnaDesc.DataPropertyName = "descripcion";
            columnaDesc.HeaderText = "Descripcion";

            DataGridViewTextBoxColumn columnaEstado = new DataGridViewTextBoxColumn();
            columnaEstado.DataPropertyName = "estado";
            columnaEstado.HeaderText = "Estado";

            DataGridViewTextBoxColumn columnaAdjunto = new DataGridViewTextBoxColumn();
            columnaAdjunto.DataPropertyName = "adjunto_url";
            columnaAdjunto.HeaderText = "Adjunto";

            // Agregar las columnas al DataGridView

            if (dgvIncidencias.Columns.Count < 5)
            {
                dgvIncidencias.Columns.Add(columnaTipo);
                dgvIncidencias.Columns.Add(columnaFecha);
                dgvIncidencias.Columns.Add(columnaDesc);
                dgvIncidencias.Columns.Add(columnaEstado);
                dgvIncidencias.Columns.Add(columnaAdjunto);
            }

            // Asignar la lista de personas al origen de datos del DataGridView
            dgvIncidencias.DataSource = lst;
        }


        // ContextMenuStrips y botones
        private void btnNuevaIncidencia_Click(object sender, EventArgs e)
        {
            // Nuevo Formulario
            Incidencias inc = new Incidencias();
            FrmIncidencia formIncidencia = new FrmIncidencia(inc);
            if (formIncidencia.ShowDialog() == DialogResult.OK)
            {
                //Administracion.SubirIncidencia(inc);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*if (dgvIncidencias.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvIncidencias.CurrentRow.Cells[0].Value);
                Incidencias_Sin inc = Administracion.ObtenerIncidenciaByID(id).Result;
                FrmIncidencia frmInc = new FrmIncidencia(inc);
                if (frmInc.ShowDialog() == DialogResult.OK)
                {
                    Administracion.ModificarIncidencia(inc);
                }
                cargarInformesProfesor();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna fila para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvIncidencias.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere Eliminar esta incidencia?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvIncidencias.CurrentRow.Cells[0].Value);
                    Administracion.BorrarIncidencia(id);
                    cargarInformesProfesor();
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna fila para borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Filtrado de Incidencias
        // Se filtrarán por: Subtipo incidencia, Fecha Creación y Estado
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            
        }

        // Salir de la aplicacion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que quiere salir?", "Aviso", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Para mostrar la hora actual
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar la celda de la barra de estado con la fecha y hora actual
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            if (dgvIncidencias.SelectedCells.Count > 0)
            {
                
                int id = Convert.ToInt32(dgvIncidencias.CurrentRow.Cells[0].Value);
                FrmComentario formComent = new FrmComentario(id);
                if (formComent.DialogResult == DialogResult.OK)
                {
                    // Añadir comentario
                }
                
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna fila para ver los comentarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
