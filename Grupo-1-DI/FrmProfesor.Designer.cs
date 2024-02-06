namespace Grupo_1_DI
{
    partial class FrmProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnNuevaIncidencia = new System.Windows.Forms.Button();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarIncidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarIncidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearIncidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Location = new System.Drawing.Point(12, 39);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.Size = new System.Drawing.Size(460, 178);
            this.dgvIncidencias.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRegistros,
            this.tsslFecha});
            this.statusStrip.Location = new System.Drawing.Point(0, 256);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(490, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslRegistros
            // 
            this.tsslRegistros.Name = "tsslRegistros";
            this.tsslRegistros.Size = new System.Drawing.Size(55, 17);
            this.tsslRegistros.Text = "Registros";
            // 
            // tsslFecha
            // 
            this.tsslFecha.Name = "tsslFecha";
            this.tsslFecha.Size = new System.Drawing.Size(38, 17);
            this.tsslFecha.Text = "Fecha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(292, 9);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(71, 23);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnNuevaIncidencia
            // 
            this.btnNuevaIncidencia.Location = new System.Drawing.Point(369, 9);
            this.btnNuevaIncidencia.Name = "btnNuevaIncidencia";
            this.btnNuevaIncidencia.Size = new System.Drawing.Size(103, 23);
            this.btnNuevaIncidencia.TabIndex = 4;
            this.btnNuevaIncidencia.Text = "Nueva Incidencia";
            this.btnNuevaIncidencia.UseVisualStyleBackColor = true;
            this.btnNuevaIncidencia.Click += new System.EventHandler(this.btnNuevaIncidencia_Click);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearIncidenciaToolStripMenuItem,
            this.modificarIncidenciaToolStripMenuItem,
            this.eliminarIncidenciaToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(183, 70);
            // 
            // modificarIncidenciaToolStripMenuItem
            // 
            this.modificarIncidenciaToolStripMenuItem.Image = global::Grupo_1_DI.Properties.Resources.Document_16x;
            this.modificarIncidenciaToolStripMenuItem.Name = "modificarIncidenciaToolStripMenuItem";
            this.modificarIncidenciaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modificarIncidenciaToolStripMenuItem.Text = "Modificar Incidencia";
            // 
            // eliminarIncidenciaToolStripMenuItem
            // 
            this.eliminarIncidenciaToolStripMenuItem.Image = global::Grupo_1_DI.Properties.Resources.Medium_228_16x;
            this.eliminarIncidenciaToolStripMenuItem.Name = "eliminarIncidenciaToolStripMenuItem";
            this.eliminarIncidenciaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarIncidenciaToolStripMenuItem.Text = "Eliminar Incidencia";
            // 
            // crearIncidenciaToolStripMenuItem
            // 
            this.crearIncidenciaToolStripMenuItem.Image = global::Grupo_1_DI.Properties.Resources.Add_8x_16x;
            this.crearIncidenciaToolStripMenuItem.Name = "crearIncidenciaToolStripMenuItem";
            this.crearIncidenciaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.crearIncidenciaToolStripMenuItem.Text = "Crear Incidencia";
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 278);
            this.Controls.Add(this.btnNuevaIncidencia);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dgvIncidencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProfesor";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslRegistros;
        private System.Windows.Forms.ToolStripStatusLabel tsslFecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnNuevaIncidencia;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem crearIncidenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarIncidenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarIncidenciaToolStripMenuItem;
    }
}