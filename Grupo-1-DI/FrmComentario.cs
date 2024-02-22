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
    public partial class FrmComentario : Form
    {
        Comentarios comentario;
        private FrmComentario()
        {
            InitializeComponent();
        }
        public FrmComentario(int idInc) : this()
        {
            cargarComentariosInforme(idInc);
            comentario = new Comentarios();
            this.DialogResult = DialogResult.Cancel;
        }

        private async void cargarComentariosInforme(int id)
        {
            var lst = await Administracion.ObtenerComentariosByIncidenciasId(id);

            if (lst != null)
            {
                modelarTabla(lst);
                lblComentarios.Text = "Comentarios: " + dgvComentarios.RowCount.ToString();
            }
        }

        private void modelarTabla(List<Comentarios> lst)
        {
            dgvComentarios.AutoGenerateColumns = false;

            // Crear columnas manualmente para el DataGridView

            DataGridViewTextBoxColumn columnaPersona = new DataGridViewTextBoxColumn();
            columnaPersona.DataPropertyName = "personal_id";
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

            if (dgvComentarios.Columns.Count < 4)
            {
                dgvComentarios.Columns.Add(columnaPersona);
                dgvComentarios.Columns.Add(columnaComentario);
                dgvComentarios.Columns.Add(columnaFecha);
                dgvComentarios.Columns.Add(columnaAdjunto);
            }

            // Asignar la lista de personas al origen de datos del DataGridView
            dgvComentarios.DataSource = lst;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            //Administracion.SubirComentario(Comentario)
            this.DialogResult = DialogResult.OK;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
