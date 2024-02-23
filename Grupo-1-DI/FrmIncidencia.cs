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
        private FrmIncidencia()
        {
            InitializeComponent();
        }

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

        private void btnRegIncidencia_Click(object sender, EventArgs e)
        {
            //Rellenar el resto de campos de la incidencia

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private string base64(string ext, string ruta)
        {
            // Datos del archivo a enviar
            string extension = ext; // Extensión del archivo
            string direccionDirectorio = ruta; // Directorio donde se guardará el archivo

            // Leer el archivo y convertirlo a Base64
            string rutaArchivo = "ruta/del/archivo.pdf"; // Ruta del archivo a enviar
            byte[] archivoBytes = File.ReadAllBytes(rutaArchivo);
            string cuerpoBase64 = Convert.ToBase64String(archivoBytes);

            var contenido = new StringContent($"extension={extension}&cuerpoBase64={cuerpoBase64}&direccionDirectorio={ruta}", Encoding.UTF8, "application/x-www-form-urlencoded");

            return contenido.ReadAsStringAsync().Result;

        }
    }
}
