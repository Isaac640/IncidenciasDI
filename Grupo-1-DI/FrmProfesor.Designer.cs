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
            this.lblHora = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.cmbEstadoFiltro = new System.Windows.Forms.ComboBox();
            this.dtpFechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnComentar = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnBorrarIncidencia = new System.Windows.Forms.Button();
            this.btnEditarIncidencia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevaIncidencia2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
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
            this.panelDatos.Controls.Add(this.btnReset);
            this.panelDatos.Controls.Add(this.lblRegistros);
            this.panelDatos.Controls.Add(this.dtpFechaFiltro);
            this.panelDatos.Controls.Add(this.dgvIncidencias);
            this.panelDatos.Controls.Add(this.cmbEstadoFiltro);
            this.panelDatos.Controls.Add(this.btnFiltro);
            this.panelDatos.Location = new System.Drawing.Point(211, -4);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(679, 353);
            this.panelDatos.TabIndex = 9;
            // 
            // cmbEstadoFiltro
            // 
            this.cmbEstadoFiltro.FormattingEnabled = true;
            this.cmbEstadoFiltro.Items.AddRange(new object[] {
            "abierta",
            "asignada",
            "en proceso",
            "enviado a infortec",
            "resuelta",
            "cerrada"});
            this.cmbEstadoFiltro.Location = new System.Drawing.Point(350, 15);
            this.cmbEstadoFiltro.Name = "cmbEstadoFiltro";
            this.cmbEstadoFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoFiltro.TabIndex = 26;
            this.cmbEstadoFiltro.Text = "abierta";
            // 
            // dtpFechaFiltro
            // 
            this.dtpFechaFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFiltro.Location = new System.Drawing.Point(219, 15);
            this.dtpFechaFiltro.Name = "dtpFechaFiltro";
            this.dtpFechaFiltro.Size = new System.Drawing.Size(106, 21);
            this.dtpFechaFiltro.TabIndex = 25;
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
            this.estado});
            this.dgvIncidencias.Location = new System.Drawing.Point(36, 46);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.ReadOnly = true;
            this.dgvIncidencias.Size = new System.Drawing.Size(626, 288);
            this.dgvIncidencias.TabIndex = 24;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.White;
            this.lblRegistros.Location = new System.Drawing.Point(37, 17);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(89, 19);
            this.lblRegistros.TabIndex = 8;
            this.lblRegistros.Text = "Registros:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.btnComentar);
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
            this.lblApellidos.Size = new System.Drawing.Size(163, 19);
            this.lblApellidos.TabIndex = 11;
            this.lblApellidos.Text = "apellido 1, apellido 2";
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
            // btnComentar
            // 
            this.btnComentar.BackColor = System.Drawing.Color.Transparent;
            this.btnComentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComentar.FlatAppearance.BorderSize = 0;
            this.btnComentar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnComentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnComentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComentar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnComentar.Image = global::Grupo_1_DI.Properties.Resources.comments_icon;
            this.btnComentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComentar.Location = new System.Drawing.Point(15, 290);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(199, 57);
            this.btnComentar.TabIndex = 23;
            this.btnComentar.Text = "  Comentar";
            this.btnComentar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnComentar, "Muestra los comentarios de una incidencia existente");
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
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
            this.btnBorrarIncidencia.Location = new System.Drawing.Point(15, 227);
            this.btnBorrarIncidencia.Name = "btnBorrarIncidencia";
            this.btnBorrarIncidencia.Size = new System.Drawing.Size(198, 57);
            this.btnBorrarIncidencia.TabIndex = 17;
            this.btnBorrarIncidencia.Text = "  Borrar Incidencia";
            this.btnBorrarIncidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnBorrarIncidencia, "Borra una incidencia existente");
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
            this.btnEditarIncidencia.Location = new System.Drawing.Point(15, 159);
            this.btnEditarIncidencia.Name = "btnEditarIncidencia";
            this.btnEditarIncidencia.Size = new System.Drawing.Size(198, 62);
            this.btnEditarIncidencia.TabIndex = 16;
            this.btnEditarIncidencia.Text = "  Editar Incidencia";
            this.btnEditarIncidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEditarIncidencia, "Modifica una incidencia existente");
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
            this.btnSalir.Location = new System.Drawing.Point(45, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 60);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "  Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir de la aplicacion");
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
            this.btnNuevaIncidencia2.Location = new System.Drawing.Point(15, 99);
            this.btnNuevaIncidencia2.Name = "btnNuevaIncidencia2";
            this.btnNuevaIncidencia2.Size = new System.Drawing.Size(198, 61);
            this.btnNuevaIncidencia2.TabIndex = 14;
            this.btnNuevaIncidencia2.Text = "  Nueva Incidencia";
            this.btnNuevaIncidencia2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNuevaIncidencia2, "Agrega una nueva incidencia");
            this.btnNuevaIncidencia2.UseVisualStyleBackColor = false;
            this.btnNuevaIncidencia2.Click += new System.EventHandler(this.btnNuevaIncidencia_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Image = global::Grupo_1_DI.Properties.Resources.reset_Icon;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(575, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 36);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = " Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnReset, "Carga todas las incidencias de nuevo");
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnFiltro.Location = new System.Drawing.Point(477, 6);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(88, 36);
            this.btnFiltro.TabIndex = 23;
            this.btnFiltro.Text = " Filtrar";
            this.btnFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnFiltro, "Filtra por la fecha y estado indicados");
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
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
            // ID
            // 
            this.ID.DataPropertyName = "num";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
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
            this.Fecha_Creacion.Width = 95;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 220;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
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
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbEstadoFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaFiltro;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}