﻿using System;
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

    }
}