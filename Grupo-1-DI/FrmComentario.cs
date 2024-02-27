using Grupo_1_DI.Base_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
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
            dgvComentarios.Rows.Clear();
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
                var personal = await Administracion.ObtenerPersonalByID(comentario.personal);

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

        private async void btnSubir_ClickAsync(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime formattedTime = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            comentario.fechahora = formattedTime;
            comentario.personal = personal.id;
            comentario.texto = txtComentario.Text;
            comentario.incidenciaNum = this.num_Inc;


            if (await Administracion.PublicarComentario(comentario))
            {
                Task.Delay(500);
                txtComentario.Text = string.Empty;
                btnAdjunto.Text = "Subir Archivo";
                cargarComentariosInforme(num_Inc);
            }
            else
            {
                MessageBox.Show("No se ha podido enviar el comentario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {
            /*using (OpenFileDialog openFileDialog = new OpenFileDialog())
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
                        comentario.Extension = Path.GetExtension(archivoSeleccionado);
                        comentario.CuerpoBase64 = base64(openFileDialog);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al subir archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }

        /// <summary>
        /// Convierte el archivo seleccionado a Base64.
        /// </summary>
        /// <param name="openFileDialog">El diálogo para seleccionar el archivo.</param>
        /// <returns>El archivo convertido a Base64.</returns>
        /*private string base64(OpenFileDialog openFileDialog)
        {
            // Verificar si se seleccionó un archivo
            if (openFileDialog.FileName != "")
            {
                try
                {
                    // Obtener la extensión del archivo seleccionado
                    string extension = Path.GetExtension(openFileDialog.FileName);

                    // Leer el archivo y convertirlo a Base64
                    byte[] archivoBytes = File.ReadAllBytes(openFileDialog.FileName);
                    string cuerpoBase64 = Convert.ToBase64String(archivoBytes);

                    // Crear el contenido para enviar al servidor
                    var contenido = new StringContent($"extension={extension}&cuerpoBase64={cuerpoBase64}", Encoding.UTF8, "application/x-www-form-urlencoded");

                    return contenido.ReadAsStringAsync().Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al subir archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }*/

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
