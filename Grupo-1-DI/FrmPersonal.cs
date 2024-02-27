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
    /// Formulario para la gestión del personal.
    /// </summary>
    public partial class FrmPersonal : Form
    {
        /// <summary>
        /// Constructor de la clase FrmPersonal.
        /// </summary>
        public FrmPersonal()
        {
            InitializeComponent();
            cargarPersonal();
        }
        /// <summary>
        /// Carga los datos del personal desde la base de datos.
        /// </summary>
        private async void cargarPersonal()
        {
            var lst = await Administracion.ObtenerPersonal();

            if (lst != null)
            {
                modelarTabla(lst);
                lblPersonal.Text = "Registros: " + dgvPersonal.RowCount.ToString();
            }
        }

        // Modelar Tabla de dataGridView (Advertencia, Muy largo)
        /// <summary>
        /// Modela la tabla de personal en el DataGridView.
        /// </summary>
        /// <param name="lst">La lista de personal a mostrar.</param>

        private void modelarTabla(List<Personal> lst)
        {
            dgvPersonal.AutoGenerateColumns = false;

            // Crear columnas manualmente para el DataGridView

            DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn();
            columnaID.DataPropertyName = "id";
            columnaID.HeaderText = "ID";

            DataGridViewTextBoxColumn columnaDni = new DataGridViewTextBoxColumn();
            columnaDni.DataPropertyName = "dni";
            columnaDni.HeaderText = "DNI";

            DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn();
            columnaNombre.DataPropertyName = "nombre";
            columnaNombre.HeaderText = "Nombre";

            DataGridViewTextBoxColumn columnaApe1 = new DataGridViewTextBoxColumn();
            columnaApe1.DataPropertyName = "apellido1";
            columnaApe1.HeaderText = "Primer Apellido";

            DataGridViewTextBoxColumn columnaApe2 = new DataGridViewTextBoxColumn();
            columnaApe2.DataPropertyName = "apellido2";
            columnaApe2.HeaderText = "Segundo Apellido";

            DataGridViewTextBoxColumn columnaDir = new DataGridViewTextBoxColumn();
            columnaDir.DataPropertyName = "direccion";
            columnaDir.HeaderText = "Dirección";

            DataGridViewTextBoxColumn columnaLoc = new DataGridViewTextBoxColumn();
            columnaLoc.DataPropertyName = "localidad";
            columnaLoc.HeaderText = "Localidad";

            DataGridViewTextBoxColumn columnaCP = new DataGridViewTextBoxColumn();
            columnaCP.DataPropertyName = "cp";
            columnaCP.HeaderText = "Codigo Postal";

            DataGridViewTextBoxColumn columnaTlfn = new DataGridViewTextBoxColumn();
            columnaTlfn.DataPropertyName = "tlfn";
            columnaTlfn.HeaderText = "Telefono";

            DataGridViewTextBoxColumn columnaActivo = new DataGridViewTextBoxColumn();
            columnaActivo.HeaderText = "Activo";

            if (dgvPersonal.Columns.Count < 10)
            {
                dgvPersonal.Columns.Add(columnaID);
                dgvPersonal.Columns.Add(columnaDni);
                dgvPersonal.Columns.Add(columnaNombre);
                dgvPersonal.Columns.Add(columnaApe1);
                dgvPersonal.Columns.Add(columnaApe2);
                dgvPersonal.Columns.Add(columnaDir);
                dgvPersonal.Columns.Add(columnaLoc);
                dgvPersonal.Columns.Add(columnaCP);
                dgvPersonal.Columns.Add(columnaTlfn);
                dgvPersonal.Columns.Add(columnaActivo);
            }
            // Asignar los datos a cada fila
            foreach (var Activo in lst)
            {
                if (Activo.activo == 1)
                {
                    dgvPersonal.Rows.Add(Activo.id, Activo.dni, Activo.nombre, Activo.apellido1, Activo.apellido2, Activo.direccion, Activo.localidad, Activo.cp, Activo.tlf, "Si");
                }
                else
                {
                    // Manejar el caso donde no se puede encontrar el personal
                    dgvPersonal.Rows.Add(Activo.id, Activo.dni, Activo.nombre, Activo.apellido1, Activo.apellido2, Activo.direccion, Activo.localidad, Activo.cp, Activo.tlf, "No");
                }
            }
            lblPersonal.Text = "Personal: " + dgvPersonal.RowCount.ToString();
        }
        /// <summary>
        /// Maneja el evento del botón para dar de baja a una persona.
        /// </summary>
        private async void btnRegIncidencia_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.CurrentRow.Cells[9].Value.ToString().Equals("No"))
            {
                MessageBox.Show("Este usuario ya esta dado de baja", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere dar de baja a esta persona?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    long id = Convert.ToInt32(dgvPersonal.CurrentRow.Cells[0].Value);
                    Personal persona = await Administracion.ObtenerPersonalByID(id);
                    persona.activo = 0;

                    await Administracion.ActualizarPersonal(persona); 
                    await Task.Delay(500);
                    dgvPersonal.Rows.Clear();
                    cargarPersonal();

                }
            }
        }
        /// <summary>
        /// Maneja el evento del botón para volver al formulario anterior.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}