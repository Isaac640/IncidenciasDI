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
    /// <summary>
    /// Formulario para uso del administrador
    /// </summary>
    public partial class FrmAdmin : Form
    {
        Personal personal;
        Perfiles perfil;
        Timer timer;

        /// <summary>
        /// Constructor de la clase FrmAdmin.
        /// </summary>

        public FrmAdmin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor adicional de la clase FrmAdmin que recibe un perfil como parámetro.
        /// </summary>
        /// <param name="p">El perfil del usuario.</param>
        public FrmAdmin(Perfiles p) : this()
        {
            this.perfil = p;

            ObtenerPersonalAsync(perfil.personal_id);
            // Tiempo y dia
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
            lblFecha.Text = DateTime.UtcNow.ToLongDateString();
        }

        /// <summary>
        /// Obtiene los datos del personal de la base de datos de manera asíncrona.
        /// </summary>
        /// <param name="personalId">El ID del personal.</param>
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
                    cargarInformes();
                }

            }
        }

        /// <summary>
        /// Carga las incidencias desde la base de datos y las muestra en la interfaz gráfica.
        /// </summary>
        private async void cargarInformes()
        {
            var lst = await Administracion.ObtenerIncidencias();

            if (lst != null)
            {
                lblNombre.Text = this.personal.nombre;
                lblApellidos.Text = this.personal.apellido1 + " " + this.personal.apellido2;
                modelarTabla(lst);
                lblRegistros.Text = "Registros: " + dgvIncidencias.RowCount.ToString();
            }
        }
        /// <summary>
        /// Modela la tabla de incidencias con los datos proporcionados.
        /// </summary>
        /// <param name="lst">La lista de incidencias a mostrar.</param>
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

            if (dgvIncidencias.Columns.Count < 7)
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

        // Para mostrar la hora actual
        /// <summary>
        /// Maneja el evento de temporizador para actualizar la hora.
        /// </summary>
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
            FrmIncidencia formIncidencia = new FrmIncidencia(inc, this.perfil);
            if (formIncidencia.ShowDialog() == DialogResult.OK)
            {
                //Administracion.SubirIncidencia(inc);
            }
        }

        private void btbEditarIncidencia_Click(object sender, EventArgs e)
        {
            if (dgvIncidencias.SelectedCells.Count > 0)
            {
                // Ir al formulario para modificarlo
                // Administracion.BorrarIncidencia(inc);
                // Actualizar la tabla
                cargarInformes();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna fila para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnBorrarIncidencia_Click(object sender, EventArgs e)
        {
            if (dgvIncidencias.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere Eliminar esta incidencia?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvIncidencias.CurrentRow.Cells[0].Value);
                    await Administracion.BorrarIncidencia(id);
                    await Task.Delay(500);
                    cargarInformes();
                }
            }
        }

        // Filtrado de Incidencias
        // Se filtrarán por: Subtipo incidencia, Fecha Creación y Estado
        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            var listaInc = await Administracion.ObtenerIncidencias();
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

        //Salir

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que quiere salir?", "Aviso", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // seccion de comentarios
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

        // Resetear filtro
        private void btnReset_Click(object sender, EventArgs e)
        {
            cargarInformes();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FrmPersonal formPersonal = new FrmPersonal();
            formPersonal.ShowDialog();
        }
    }
}
