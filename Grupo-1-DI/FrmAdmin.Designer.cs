namespace Grupo_1_DI
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adjunto_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrarIncidencia = new System.Windows.Forms.Button();
            this.btbEditarIncidencia = new System.Windows.Forms.Button();
            this.btnRegIncidencia = new System.Windows.Forms.Button();
            this.btnComentar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnComentar);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnBorrarIncidencia);
            this.panel1.Controls.Add(this.btbEditarIncidencia);
            this.panel1.Controls.Add(this.btnRegIncidencia);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 465);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.lblRegistros);
            this.panel3.Controls.Add(this.btnFiltrar);
            this.panel3.Controls.Add(this.txtFiltro);
            this.panel3.Controls.Add(this.dgvIncidencias);
            this.panel3.Location = new System.Drawing.Point(211, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 353);
            this.panel3.TabIndex = 1;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.White;
            this.lblRegistros.Location = new System.Drawing.Point(32, 320);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(89, 19);
            this.lblRegistros.TabIndex = 29;
            this.lblRegistros.Text = "Registros:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtFiltro.Location = new System.Drawing.Point(36, 16);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(535, 24);
            this.txtFiltro.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFiltro, "Filtra por estado de incidencia y fecha de creación");
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.AllowUserToAddRows = false;
            this.dgvIncidencias.AllowUserToDeleteRows = false;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tipo,
            this.Fecha_Creacion,
            this.descripcion,
            this.estado,
            this.adjunto_url});
            this.dgvIncidencias.Location = new System.Drawing.Point(36, 46);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.ReadOnly = true;
            this.dgvIncidencias.Size = new System.Drawing.Size(626, 260);
            this.dgvIncidencias.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.lblFecha);
            this.panel4.Controls.Add(this.lblHora);
            this.panel4.Controls.Add(this.lblApellidos);
            this.panel4.Controls.Add(this.lblNombre);
            this.panel4.Controls.Add(this.pbUser);
            this.panel4.Location = new System.Drawing.Point(211, 349);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 115);
            this.panel4.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFecha.Location = new System.Drawing.Point(407, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(224, 20);
            this.lblFecha.TabIndex = 36;
            this.lblFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblHora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHora.Location = new System.Drawing.Point(432, 14);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(174, 46);
            this.lblHora.TabIndex = 35;
            this.lblHora.Text = "21:49:45";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(132, 41);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(97, 19);
            this.lblApellidos.TabIndex = 34;
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
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Isaac";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "num";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Fecha_Creacion
            // 
            this.Fecha_Creacion.DataPropertyName = "fecha_creacion";
            this.Fecha_Creacion.HeaderText = "Fecha Creacion";
            this.Fecha_Creacion.Name = "Fecha_Creacion";
            this.Fecha_Creacion.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // adjunto_url
            // 
            this.adjunto_url.DataPropertyName = "adjunto_url";
            this.adjunto_url.HeaderText = "Adjunto";
            this.adjunto_url.Name = "adjunto_url";
            this.adjunto_url.ReadOnly = true;
            // 
            // pbUser
            // 
            this.pbUser.Image = global::Grupo_1_DI.Properties.Resources.user_icon;
            this.pbUser.Location = new System.Drawing.Point(33, 6);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(93, 93);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 32;
            this.pbUser.TabStop = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFiltrar.Image = global::Grupo_1_DI.Properties.Resources.filter_icon;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(577, 9);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(85, 36);
            this.btnFiltrar.TabIndex = 28;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Image = global::Grupo_1_DI.Properties.Resources.admin_indicator;
            this.lblAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdmin.Location = new System.Drawing.Point(27, 84);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(172, 24);
            this.lblAdmin.TabIndex = 37;
            this.lblAdmin.Text = "     Administrador";
            this.toolTip1.SetToolTip(this.lblAdmin, "Usted es Administrador");
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Grupo_1_DI.Properties.Resources.IRIS_logo;
            this.pbLogo.Location = new System.Drawing.Point(81, 16);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(61, 55);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 31;
            this.pbLogo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalir.Image = global::Grupo_1_DI.Properties.Resources.shut_down2;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(45, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 60);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "  Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir de la aplicacion");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarIncidencia
            // 
            this.btnBorrarIncidencia.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarIncidencia.FlatAppearance.BorderSize = 0;
            this.btnBorrarIncidencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnBorrarIncidencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBorrarIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBorrarIncidencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrarIncidencia.Image = global::Grupo_1_DI.Properties.Resources.delete_Incindent;
            this.btnBorrarIncidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarIncidencia.Location = new System.Drawing.Point(13, 245);
            this.btnBorrarIncidencia.Name = "btnBorrarIncidencia";
            this.btnBorrarIncidencia.Size = new System.Drawing.Size(195, 61);
            this.btnBorrarIncidencia.TabIndex = 29;
            this.btnBorrarIncidencia.Text = "  Borrar Incidencia";
            this.btnBorrarIncidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnBorrarIncidencia, "Borra una incidencia existente");
            this.btnBorrarIncidencia.UseVisualStyleBackColor = false;
            this.btnBorrarIncidencia.Click += new System.EventHandler(this.btnBorrarIncidencia_Click);
            // 
            // btbEditarIncidencia
            // 
            this.btbEditarIncidencia.BackColor = System.Drawing.Color.Transparent;
            this.btbEditarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbEditarIncidencia.FlatAppearance.BorderSize = 0;
            this.btbEditarIncidencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btbEditarIncidencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btbEditarIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbEditarIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btbEditarIncidencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btbEditarIncidencia.Image = global::Grupo_1_DI.Properties.Resources.edit_Incindent;
            this.btbEditarIncidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbEditarIncidencia.Location = new System.Drawing.Point(13, 182);
            this.btbEditarIncidencia.Name = "btbEditarIncidencia";
            this.btbEditarIncidencia.Size = new System.Drawing.Size(195, 61);
            this.btbEditarIncidencia.TabIndex = 28;
            this.btbEditarIncidencia.Text = "  Editar Incidencia";
            this.btbEditarIncidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btbEditarIncidencia, "Modifica una incidencia existente");
            this.btbEditarIncidencia.UseVisualStyleBackColor = false;
            this.btbEditarIncidencia.Click += new System.EventHandler(this.btbEditarIncidencia_Click);
            // 
            // btnRegIncidencia
            // 
            this.btnRegIncidencia.BackColor = System.Drawing.Color.Transparent;
            this.btnRegIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegIncidencia.FlatAppearance.BorderSize = 0;
            this.btnRegIncidencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnRegIncidencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnRegIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegIncidencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegIncidencia.Image = global::Grupo_1_DI.Properties.Resources.add_Incindent;
            this.btnRegIncidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegIncidencia.Location = new System.Drawing.Point(13, 125);
            this.btnRegIncidencia.Name = "btnRegIncidencia";
            this.btnRegIncidencia.Size = new System.Drawing.Size(195, 61);
            this.btnRegIncidencia.TabIndex = 27;
            this.btnRegIncidencia.Text = "  Abrir Incidencia";
            this.btnRegIncidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnRegIncidencia, "Agrega una nueva incidencia");
            this.btnRegIncidencia.UseVisualStyleBackColor = false;
            this.btnRegIncidencia.Click += new System.EventHandler(this.btnRegIncidencia_Click);
            // 
            // btnComentar
            // 
            this.btnComentar.BackColor = System.Drawing.Color.Transparent;
            this.btnComentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComentar.FlatAppearance.BorderSize = 0;
            this.btnComentar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnComentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnComentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnComentar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnComentar.Image = global::Grupo_1_DI.Properties.Resources.comments_icon;
            this.btnComentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComentar.Location = new System.Drawing.Point(13, 312);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(195, 57);
            this.btnComentar.TabIndex = 38;
            this.btnComentar.Text = "  Comentar";
            this.btnComentar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnComentar, "Muestra los comentarios de una incidencia existente");
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // FrmAdmin
            // 
            this.ClientSize = new System.Drawing.Size(886, 460);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.Text = "Incidencias (Administrador)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNuevaIncidencia2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarIncidencia;
        private System.Windows.Forms.Button btbEditarIncidencia;
        private System.Windows.Forms.Button btnRegIncidencia;
        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn adjunto_url;
        private System.Windows.Forms.Button btnComentar;
    }
}