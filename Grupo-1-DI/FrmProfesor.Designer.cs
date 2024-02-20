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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnBorrarIncidencia = new System.Windows.Forms.Button();
            this.btnEditarIncidencia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevaIncidencia2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Location = new System.Drawing.Point(36, 46);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.Size = new System.Drawing.Size(626, 260);
            this.dgvIncidencias.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(432, 14);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(174, 46);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "21:49:45";
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelDatos.Controls.Add(this.btnFiltro);
            this.panelDatos.Controls.Add(this.lblRegistros);
            this.panelDatos.Controls.Add(this.txtFiltro);
            this.panelDatos.Controls.Add(this.dgvIncidencias);
            this.panelDatos.Location = new System.Drawing.Point(211, -4);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(679, 353);
            this.panelDatos.TabIndex = 9;
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFiltro.Image = global::Grupo_1_DI.Properties.Resources.filter_icon;
            this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltro.Location = new System.Drawing.Point(574, 9);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(88, 36);
            this.btnFiltro.TabIndex = 23;
            this.btnFiltro.Text = " Filtrar";
            this.btnFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltro.UseVisualStyleBackColor = false;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.White;
            this.lblRegistros.Location = new System.Drawing.Point(32, 320);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(89, 19);
            this.lblRegistros.TabIndex = 8;
            this.lblRegistros.Text = "Registros:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(36, 16);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(532, 24);
            this.txtFiltro.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.pbLogo);
            this.panelMenu.Controls.Add(this.btnBorrarIncidencia);
            this.panelMenu.Controls.Add(this.btnEditarIncidencia);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnNuevaIncidencia2);
            this.panelMenu.Location = new System.Drawing.Point(-3, -4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 465);
            this.panelMenu.TabIndex = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Grupo_1_DI.Properties.Resources.IRIS_logo;
            this.pbLogo.Location = new System.Drawing.Point(81, 16);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(61, 55);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 22;
            this.pbLogo.TabStop = false;
            // 
            // btnBorrarIncidencia
            // 
            this.btnBorrarIncidencia.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarIncidencia.FlatAppearance.BorderSize = 0;
            this.btnBorrarIncidencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnBorrarIncidencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBorrarIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarIncidencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrarIncidencia.Image = global::Grupo_1_DI.Properties.Resources.delete_Incindent;
            this.btnBorrarIncidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarIncidencia.Location = new System.Drawing.Point(8, 249);
            this.btnBorrarIncidencia.Name = "btnBorrarIncidencia";
            this.btnBorrarIncidencia.Size = new System.Drawing.Size(205, 57);
            this.btnBorrarIncidencia.TabIndex = 17;
            this.btnBorrarIncidencia.Text = "  Borrar Incidencia";
            this.btnBorrarIncidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarIncidencia.UseVisualStyleBackColor = false;
            this.btnBorrarIncidencia.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditarIncidencia
            // 
            this.btnEditarIncidencia.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarIncidencia.FlatAppearance.BorderSize = 0;
            this.btnEditarIncidencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEditarIncidencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEditarIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarIncidencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarIncidencia.Image = global::Grupo_1_DI.Properties.Resources.edit_Incindent;
            this.btnEditarIncidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarIncidencia.Location = new System.Drawing.Point(8, 181);
            this.btnEditarIncidencia.Name = "btnEditarIncidencia";
            this.btnEditarIncidencia.Size = new System.Drawing.Size(205, 62);
            this.btnEditarIncidencia.TabIndex = 16;
            this.btnEditarIncidencia.Text = "  Editar Incidencia";
            this.btnEditarIncidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarIncidencia.UseVisualStyleBackColor = false;
            this.btnEditarIncidencia.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalir.Image = global::Grupo_1_DI.Properties.Resources.shut_down2;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(49, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 60);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "  Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevaIncidencia2
            // 
            this.btnNuevaIncidencia2.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaIncidencia2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaIncidencia2.FlatAppearance.BorderSize = 0;
            this.btnNuevaIncidencia2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnNuevaIncidencia2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNuevaIncidencia2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaIncidencia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaIncidencia2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevaIncidencia2.Image = global::Grupo_1_DI.Properties.Resources.add_Incindent;
            this.btnNuevaIncidencia2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaIncidencia2.Location = new System.Drawing.Point(8, 121);
            this.btnNuevaIncidencia2.Name = "btnNuevaIncidencia2";
            this.btnNuevaIncidencia2.Size = new System.Drawing.Size(205, 61);
            this.btnNuevaIncidencia2.TabIndex = 14;
            this.btnNuevaIncidencia2.Text = "  Nueva Incidencia";
            this.btnNuevaIncidencia2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaIncidencia2.UseVisualStyleBackColor = false;
            this.btnNuevaIncidencia2.Click += new System.EventHandler(this.btnNuevaIncidencia_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.lblApellidos);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.pbUser);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Location = new System.Drawing.Point(211, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 115);
            this.panel2.TabIndex = 11;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(132, 41);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(97, 19);
            this.lblApellidos.TabIndex = 11;
            this.lblApellidos.Text = "Cabria Diez";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(132, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 19);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Isaac";
            // 
            // pbUser
            // 
            this.pbUser.Image = global::Grupo_1_DI.Properties.Resources.user_icon;
            this.pbUser.Location = new System.Drawing.Point(33, 6);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(93, 93);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 9;
            this.pbUser.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(407, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(224, 20);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 460);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnNuevaIncidencia2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarIncidencia;
        private System.Windows.Forms.Button btnEditarIncidencia;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnFiltro;
    }
}