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
    }
}
