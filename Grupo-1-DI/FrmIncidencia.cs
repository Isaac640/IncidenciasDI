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
using static System.Net.Mime.MediaTypeNames;

namespace Grupo_1_DI
{
    /// <summary>
    /// Formulario de creacion de incidencia
    /// </summary>
    public partial class FrmIncidencia : Form
    {
        Incidencias incidencias;

        /// <summary>
        /// Constructor privado de la clase FrmIncidencia.
        /// </summary>
        private FrmIncidencia()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor público de la clase FrmIncidencia que recibe una incidencia como parámetro.
        /// </summary>
        /// <param name="inc">La incidencia a editar.</param>
        public FrmIncidencia(Incidencias inc) : this()
        {
            this.incidencias = inc;
            this.DialogResult = DialogResult.Cancel;

            // SOLO SI SE MODIFICA
            cmbIncidencia.Text = this.incidencias.tipo.ToString();
            txtAula.Text = this.incidencias.equipo_id.aula_num.codigo.ToString();
            txtEtiqueta.Text = this.incidencias.equipo_id.etiqueta.ToString();
            txtPuesto.Text = this.incidencias.equipo_id.puesto.ToString();
            txtDesc.Text = this.incidencias.descripcion.ToString();
        }
        /// <summary>
        /// Maneja el evento del botón para registrar una incidencia.
        /// </summary>
        private void btnRegIncidencia_Click(object sender, EventArgs e)
        {
            //Rellenar el resto de campos de la incidencia

            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Maneja el evento del botón para cancelar la operación.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Maneja el evento de cambio de selección en el ComboBox de tipo de incidencia.
        /// </summary>
        private void cmbIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIncidencia.SelectedItem.ToString() == "Equipos")
            {
                txtEtiqueta.Enabled = true;
                txtAula.Enabled = true;
                txtPuesto.Enabled = true;
            }
            else
            {
                txtEtiqueta.Enabled = false;
                txtAula.Enabled = false;
                txtPuesto.Enabled = false;
            }
        }
        /// <summary>
        /// Maneja el evento del botón para adjuntar un archivo.
        /// </summary>
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
                        string extension = Path.GetExtension(openFileDialog.FileName);
                        string rutaArchivo = openFileDialog.FileName;
                        incidencias.adjunto_url = base64(extension, rutaArchivo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al subir archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Convierte el archivo seleccionado a Base64.
        /// </summary>
        /// <param name="ext">La extensión del archivo.</param>
        /// <param name="ruta">La ruta del archivo.</param>
        /// <returns>El archivo convertido a Base64.</returns>
        private string base64(string ext, string ruta)
        {
            string extension = ext; // Extensión del archivo
            string direccionDirectorio = ruta; // Directorio donde se guardará el archivo

            // Leer el archivo y convertirlo a Base64
            byte[] archivoBytes = File.ReadAllBytes(direccionDirectorio);
            string cuerpoBase64 = Convert.ToBase64String(archivoBytes);

            // Crear el contenido para enviar al servidor
            var contenido = new StringContent($"extension={extension}&cuerpoBase64={cuerpoBase64}&direccionDirectorio={direccionDirectorio}", Encoding.UTF8, "application/x-www-form-urlencoded");

            return contenido.ReadAsStringAsync().Result;
        }
    }
}
