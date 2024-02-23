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
    /// Formulario para CRear y mirar los comentarios de una incidencia en particular
    /// </summary>
    public partial class FrmComentario : Form
    {
        private Comentarios comentario;
        private int num_Inc;
        private Personal personal;
        private FrmComentario()
        {
            InitializeComponent();
        }
        public FrmComentario(int idInc, Personal per) : this()
        {
            cargarComentariosInforme(idInc);
            comentario = new Comentarios();
            this.num_Inc = idInc;
            this.personal = per;
        }

        private async void cargarComentariosInforme(int id)
        {
            var lst = await Administracion.ObtenerComentariosByIncidenciasId(id);

            if (lst != null)
            {
                modelarTabla(lst);
            }
        }

        private async void modelarTabla(List<Comentarios> lst)
        {
            dgvComentarios.AutoGenerateColumns = false;

            // Crear columnas manualmente para el DataGridView
            DataGridViewTextBoxColumn columnaPersona = new DataGridViewTextBoxColumn();
            columnaPersona.HeaderText = "Persona";

            DataGridViewTextBoxColumn columnaComentario = new DataGridViewTextBoxColumn();
            columnaComentario.DataPropertyName = "texto";
            columnaComentario.HeaderText = "Comentario";

            DataGridViewTextBoxColumn columnaFecha = new DataGridViewTextBoxColumn();
            columnaFecha.DataPropertyName = "fechahora";
            columnaFecha.HeaderText = "Fecha";

            DataGridViewTextBoxColumn columnaAdjunto = new DataGridViewTextBoxColumn();
            columnaAdjunto.DataPropertyName = "adjunto_url";
            columnaAdjunto.HeaderText = "Adjunto";

            // Agregar las columnas al DataGridView
            dgvComentarios.Columns.Clear();
            dgvComentarios.Columns.Add(columnaPersona);
            dgvComentarios.Columns.Add(columnaComentario);
            dgvComentarios.Columns.Add(columnaFecha);
            dgvComentarios.Columns.Add(columnaAdjunto);

            // Asignar los datos a cada fila
            foreach (var comentario in lst)
            {
                // Obtener los detalles del personal por su ID
                var personal = await Administracion.ObtenerPersonalByPerfil(comentario.personal);

                // Si se encontraron los detalles del personal, mostrar nombre y apellidos
                if (personal != null)
                {
                    dgvComentarios.Rows.Add($"{personal.nombre} {personal.apellido1} {personal.apellido2}", comentario.texto, comentario.fechahora, comentario.adjunto_url);
                }
                else
                {
                    // Si no se encontraron los detalles del personal, mostrar el ID
                    dgvComentarios.Rows.Add(comentario.personal, comentario.texto, comentario.fechahora, comentario.adjunto_url);
                }
            }
            lblComentarios.Text = "Comentarios: " + dgvComentarios.RowCount.ToString();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            //Administracion.SubirComentario(Comentario)
            this.DialogResult = DialogResult.OK;

            comentario.fechahora = DateTime.Now;
            comentario.personal = personal.id;
            comentario.texto = txtComentario.Text;
            comentario.incidencia_num = this.num_Inc;
            //comentario.adjunto_url = base64();

            Administracion.PublicarComentario(comentario);

            txtComentario.Text = string.Empty;
            btnAdjunto.Text = "Subir Archivo";
        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar archivo";
                openFileDialog.Filter = "Libros de Excel (*.xlsx)|*.xlsx|Documentos de Word (*.docx; *.doc)|*.docx;*.doc|Archivos PDF (*.pdf)|*.pdf|Imágenes JPG (*.jpg)|*.jpg";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivoSeleccionado = openFileDialog.FileName;
                    try
                    {
                        btnAdjunto.Text = openFileDialog.FileName;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al subir archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // CONVERSOR DE ARCHIVO
        private void base64()
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
