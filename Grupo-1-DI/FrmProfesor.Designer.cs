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
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnNuevaIncidencia = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsmiCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.ContextMenuStrip = this.cmsMenu;
            this.dgvIncidencias.Location = new System.Drawing.Point(42, 90);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.Size = new System.Drawing.Size(626, 229);
            this.dgvIncidencias.TabIndex = 0;
            // 
            // cmsMenu
            // 
            this.cmsMenu.BackColor = System.Drawing.SystemColors.Control;
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrear,
            this.tsmiModificar,
            this.tsmiEliminar});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(183, 70);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.Location = new System.Drawing.Point(480, 38);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(67, 24);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnNuevaIncidencia
            // 
            this.btnNuevaIncidencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaIncidencia.Location = new System.Drawing.Point(553, 38);
            this.btnNuevaIncidencia.Name = "btnNuevaIncidencia";
            this.btnNuevaIncidencia.Size = new System.Drawing.Size(115, 24);
            this.btnNuevaIncidencia.TabIndex = 4;
            this.btnNuevaIncidencia.Text = "Nueva Incidencia";
            this.btnNuevaIncidencia.UseVisualStyleBackColor = true;
            this.btnNuevaIncidencia.Click += new System.EventHandler(this.btnNuevaIncidencia_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(334, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(224, 20);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(357, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(174, 46);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "21:49:45";
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelDatos.Controls.Add(this.lblRegistros);
            this.panelDatos.Controls.Add(this.txtUsuario);
            this.panelDatos.Controls.Add(this.dgvIncidencias);
            this.panelDatos.Controls.Add(this.btnFiltro);
            this.panelDatos.Controls.Add(this.btnNuevaIncidencia);
            this.panelDatos.Location = new System.Drawing.Point(206, -4);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(684, 380);
            this.panelDatos.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 465);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo_1_DI.Properties.Resources.menuIcon;
            this.pictureBox1.Location = new System.Drawing.Point(145, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tsmiCrear
            // 
            this.tsmiCrear.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiCrear.Image = global::Grupo_1_DI.Properties.Resources.Add_8x_16x;
            this.tsmiCrear.Name = "tsmiCrear";
            this.tsmiCrear.Size = new System.Drawing.Size(182, 22);
            this.tsmiCrear.Text = "Crear Incidencia";
            this.tsmiCrear.Click += new System.EventHandler(this.btnNuevaIncidencia_Click);
            // 
            // tsmiModificar
            // 
            this.tsmiModificar.Image = global::Grupo_1_DI.Properties.Resources.Document_16x;
            this.tsmiModificar.Name = "tsmiModificar";
            this.tsmiModificar.Size = new System.Drawing.Size(182, 22);
            this.tsmiModificar.Text = "Modificar Incidencia";
            this.tsmiModificar.Click += new System.EventHandler(this.tsmiModificar_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.Image = global::Grupo_1_DI.Properties.Resources.Medium_228_16x;
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(182, 22);
            this.tsmiEliminar.Text = "Eliminar Incidencia";
            this.tsmiEliminar.Click += new System.EventHandler(this.tsmiEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Location = new System.Drawing.Point(206, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 95);
            this.panel2.TabIndex = 11;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(42, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(420, 24);
            this.txtUsuario.TabIndex = 7;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.White;
            this.lblRegistros.Location = new System.Drawing.Point(42, 337);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(89, 19);
            this.lblRegistros.TabIndex = 8;
            this.lblRegistros.Text = "Registros:";
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProfesor";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnNuevaIncidencia;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrear;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblRegistros;
    }
}