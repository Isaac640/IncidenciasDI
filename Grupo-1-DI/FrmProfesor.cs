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
            this.personal = await Administracion.ObtenerPersonalByID(personalId);

            if (personal != null)
            {
                if (personal.activo == 0)
                {
                    MessageBox.Show("Este usuario no esta dado de alta, por favor contacte con el administrador del dominio", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
                else
                {
                    lblNombre.Text = this.personal.nombre;
                    lblApellidos.Text = this.personal.apellido1 + " " + this.personal.apellido2;
                    lblCorreo.Text = this.perfil.educantabria;
                    cargarInformesProfesor();
                }

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

        private async void modelarTabla(List<Incidencias> lst)
        {
            dgvIncidencias.Rows.Clear();
            dgvIncidencias.AutoGenerateColumns = false;

            // Crear columnas manualmente para el DataGridView

            DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn();
            columnaID.DataPropertyName = "id";
            columnaID.HeaderText = "ID";

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
            columnaAdjunto.DataPropertyName = "adjunto_url"; // Corregido aquí
            columnaAdjunto.HeaderText = "Adjunto";

            DataGridViewTextBoxColumn columnaResponsable = new DataGridViewTextBoxColumn();
            columnaResponsable.HeaderText = "Responsable";
            // Agregar las columnas al DataGridView

            if (dgvIncidencias.Columns.Count < 5)
            {
                dgvIncidencias.Columns.Add(columnaID);
                dgvIncidencias.Columns.Add(columnaTipo);
                dgvIncidencias.Columns.Add(columnaFecha);
                dgvIncidencias.Columns.Add(columnaDesc);
                dgvIncidencias.Columns.Add(columnaEstado);
                dgvIncidencias.Columns.Add(columnaAdjunto);
                dgvIncidencias.Columns.Add(columnaResponsable);
            }
            // Asignar los datos a cada fila
            foreach (var responsable in lst)
            {
                if (responsable.responsable_id != null) // Verificar si responsable_id no es null
                {
                    // Obtener los detalles del personal por su ID
                    var personal = await Administracion.ObtenerPersonalByID(responsable.responsable_id.id);

                    if (personal != null)
                    {
                        dgvIncidencias.Rows.Add(responsable.num, responsable.tipo, responsable.fecha_creacion, responsable.descripcion, responsable.estado, responsable.adjunto_url, $"{personal.nombre} {personal.apellido1} {personal.apellido2}");
                    }
                    else
                    {
                        // Manejar el caso donde no se puede encontrar el personal
                        dgvIncidencias.Rows.Add(responsable.num, responsable.tipo, responsable.fecha_creacion, responsable.descripcion, responsable.estado, responsable.adjunto_url, "Personal no encontrado");
                    }
                }
                else
                {
                    // Manejar el caso donde responsable_id es null
                    dgvIncidencias.Rows.Add(responsable.num, responsable.tipo, responsable.fecha_creacion, responsable.descripcion, responsable.estado, responsable.adjunto_url, "Sin Responsable");
                }
            }
            lblRegistros.Text = "Registros: " + dgvIncidencias.RowCount.ToString();
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

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvIncidencias.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere Eliminar esta incidencia?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvIncidencias.CurrentRow.Cells[0].Value);
                    await Administracion.BorrarIncidencia(id);
                    await Task.Delay(500);
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
        private async void btnFiltro_Click(object sender, EventArgs e)
        {
            var listaInc = await Administracion.ObtenerIncidenciasByProfesor(personal.id);
            List<Incidencias> listaAux = new List<Incidencias>();
            foreach (Incidencias inc in listaInc)
            {
                if (cmbEstadoFiltro.Text.Equals(inc.estado) || dtpFechaFiltro.Value.Equals(inc.fecha_creacion) ||
                    (cmbEstadoFiltro.Text.Equals(inc.estado) && dtpFechaFiltro.Value.Equals(inc.fecha_creacion)))
                {
                    listaAux.Add(inc);
                }
            }

            modelarTabla(listaAux);

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
                FrmComentario formComent = new FrmComentario(id, personal);
                formComent.Show();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna fila para ver los comentarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Resetear el filtro
        private void btnReset_Click(object sender, EventArgs e)
        {
            cargarInformesProfesor();
        }
    }
}
