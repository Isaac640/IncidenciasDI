using Grupo_1_DI.Base_Datos;
using Grupo_1_DI.Enumerados;
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
        Perfiles perfil;
        private FrmIncidencia()
        {
            InitializeComponent();
        }

        public FrmIncidencia(Incidencias inc, Perfiles per) : this()
        {
            this.perfil = per;
            this.incidencias = inc;
            this.DialogResult = DialogResult.Cancel;

            // SOLO SI SE MODIFICA
            if (this.incidencias.equipo_id != null)
            {
                cmbTipoIncidencia.Text = this.incidencias.tipo.ToString();
                txtAula.Text = this.incidencias.equipo_id.aula_num.codigo.ToString();
                txtEtiqueta.Text = this.incidencias.equipo_id.etiqueta.ToString();
                txtPuesto.Text = this.incidencias.equipo_id.puesto.ToString();
                txtDesc.Text = this.incidencias.descripcion.ToString();
            }
        }

        private void btnRegIncidencia_Click(object sender, EventArgs e)
        {
            if (this.incidencias.equipo_id != null)
            {
                this.incidencias.tipo = (Tipo)Enum.Parse(typeof(Tipo), cmbTipoIncidencia.SelectedItem.ToString().ToUpper());
                this.incidencias.descripcion = txtDesc.Text;
                this.incidencias.estado = "ABIERTA";
                DateTime now = DateTime.Now;

                this.incidencias.fecha_creacion = DateTime.Now;
                this.incidencias.tiempo = 0;
                //Actualizar campos
                //await Administracion.ModificarIncidencia_Sin(inc);
            }
            else
            {
                //Crear un objeto de tipo Incidencias_Sin con los datos de la incidencia
                Incidencias_Sin inc = new Incidencias_Sin();
                inc.tipo = (Tipo)Enum.Parse(typeof(Tipo), cmbTipoIncidencia.SelectedItem.ToString().ToUpper());
                inc.descripcion = txtDesc.Text;
                inc.estado = "ABIERTA";

                inc.fecha_creacion = DateTime.Now;
                inc.equipo_id = 1;
                inc.creador_id = this.perfil.personal_id;
                inc.tiempo = 0;
                //Enviar el objeto a la base de datos
                //await Administracion.EnviarIncidencia_Sin(inc);
            }




            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cmbIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // me cago en mis muertos con este codigo de mierda que no funciona
            if (cmbIncidencia.Text == "Equipos")
            {
                cmbTipoIncidencia.Enabled = true;
                cmbSubSubtipo.Enabled = true;
                txtEtiqueta.Enabled = true;
                txtAula.Enabled = true;
                txtPuesto.Enabled = true;
                cmbTipoIncidencia.Items.Clear();
                List<Incidencias_Subtipos> listaSub = await Administracion.ObtenerTipos();
                
                foreach (var comentario in listaSub)
                {

                    if (comentario.tipo == Tipo.EQUIPOS)
                    {
                        cmbTipoIncidencia.Items.Add(comentario.subtipoNombre);
                        cmbSubSubtipo.Items.Add(comentario.subSubtipo);
                    }

                }
                
            }
            else if (cmbTipoIncidencia.Text == "Cuentas")
            {
                cmbTipoIncidencia.Items.Clear();
                cmbTipoIncidencia.Enabled = true;
                txtEtiqueta.Enabled = false;
                txtAula.Enabled = false;
                txtPuesto.Enabled = false;
                List<Incidencias_Subtipos> listaSub = await Administracion.ObtenerTipos();

                foreach (var comentario in listaSub)
                {

                    if (comentario.tipo == Tipo.CUENTAS)
                    {
                        cmbTipoIncidencia.Items.Add(comentario.subtipoNombre);
                        cmbSubSubtipo.Items.Add(comentario.subSubtipo);
                    }

                }

            }
            else if (cmbTipoIncidencia.Text == "WiFi")
            {
                cmbTipoIncidencia.Items.Clear();
                cmbTipoIncidencia.Enabled = true;
                txtEtiqueta.Enabled = false;
                txtAula.Enabled = false;
                txtPuesto.Enabled = false;
                List<Incidencias_Subtipos> listaSub = await Administracion.ObtenerTipos();

                foreach (var comentario in listaSub)
                {

                    if (comentario.tipo == Tipo.WIFI)
                    {
                        cmbTipoIncidencia.Items.Add(comentario.subtipoNombre);
                        cmbSubSubtipo.Items.Add(comentario.subSubtipo);
                    }

                }
            }
            else if (cmbTipoIncidencia.Text == "Internet")
            {
                cmbTipoIncidencia.Items.Clear();
                cmbTipoIncidencia.Enabled = true;
                txtEtiqueta.Enabled = false;
                txtAula.Enabled = false;
                txtPuesto.Enabled = false;
                List<Incidencias_Subtipos> listaSub = await Administracion.ObtenerTipos();

                foreach (var comentario in listaSub)
                {

                    if (comentario.tipo == Tipo.INTERNET)
                    {
                        cmbTipoIncidencia.Items.Add(comentario.subtipoNombre);
                        cmbSubSubtipo.Items.Add(comentario.subSubtipo);
                    }

                }
            }
            else if (cmbTipoIncidencia.Text == "Software")
            {
                cmbTipoIncidencia.Items.Clear();
                cmbTipoIncidencia.Enabled = true;
                txtEtiqueta.Enabled = false;
                txtAula.Enabled = false;
                txtPuesto.Enabled = false;
                List<Incidencias_Subtipos> listaSub = await Administracion.ObtenerTipos();

                foreach (var comentario in listaSub)
                {

                    if (comentario.tipo == Tipo.SOFTWARE)
                    {
                        cmbTipoIncidencia.Items.Add(comentario.subtipoNombre);
                        cmbSubSubtipo.Items.Add(comentario.subSubtipo);
                    }

                }
            }
            else
            {
                cmbTipoIncidencia.Items.Clear();
                cmbTipoIncidencia.Enabled = false;
                txtEtiqueta.Enabled = false;
                txtAula.Enabled = false;
                txtPuesto.Enabled = false;
            }
        }
        private void btnAdjunto_Click(object sender, EventArgs e)
        {

        }

    }
}
