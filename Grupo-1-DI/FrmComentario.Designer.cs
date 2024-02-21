namespace Grupo_1_DI
{
    partial class FrmComentario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComentario));
            this.dgvComentarios = new System.Windows.Forms.DataGridView();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAdjunto = new System.Windows.Forms.Button();
            this.personal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adjunto_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComentarios
            // 
            this.dgvComentarios.AllowUserToAddRows = false;
            this.dgvComentarios.AllowUserToDeleteRows = false;
            this.dgvComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComentarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personal_id,
            this.texto,
            this.fechahora,
            this.adjunto_url});
            this.dgvComentarios.Location = new System.Drawing.Point(16, 31);
            this.dgvComentarios.Name = "dgvComentarios";
            this.dgvComentarios.ReadOnly = true;
            this.dgvComentarios.Size = new System.Drawing.Size(526, 202);
            this.dgvComentarios.TabIndex = 0;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.ForeColor = System.Drawing.Color.White;
            this.lblComentarios.Location = new System.Drawing.Point(12, 9);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(107, 19);
            this.lblComentarios.TabIndex = 12;
            this.lblComentarios.Text = "Comentarios";
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.ForeColor = System.Drawing.Color.White;
            this.lblAgregar.Location = new System.Drawing.Point(12, 257);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(179, 19);
            this.lblAgregar.TabIndex = 13;
            this.lblAgregar.Text = "Añadir un comentario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 279);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 126);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Añadir archivo adjunto:";
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.Transparent;
            this.btnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnSubir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubir.Image = global::Grupo_1_DI.Properties.Resources.upload_icon;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubir.Location = new System.Drawing.Point(418, 418);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(124, 43);
            this.btnSubir.TabIndex = 29;
            this.btnSubir.Text = "Subir Comentario";
            this.btnSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Image = global::Grupo_1_DI.Properties.Resources.exit_icon;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(305, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 43);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "   Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir de los comentarios");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAdjunto
            // 
            this.btnAdjunto.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjunto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdjunto.FlatAppearance.BorderSize = 3;
            this.btnAdjunto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnAdjunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAdjunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjunto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdjunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdjunto.Image = global::Grupo_1_DI.Properties.Resources.file_Icon;
            this.btnAdjunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdjunto.Location = new System.Drawing.Point(338, 306);
            this.btnAdjunto.Name = "btnAdjunto";
            this.btnAdjunto.Size = new System.Drawing.Size(163, 75);
            this.btnAdjunto.TabIndex = 30;
            this.btnAdjunto.Text = "  Subir Archivo";
            this.btnAdjunto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdjunto.UseVisualStyleBackColor = false;
            this.btnAdjunto.Click += new System.EventHandler(this.btnAdjunto_Click);
            // 
            // personal_id
            // 
            this.personal_id.HeaderText = "Persona";
            this.personal_id.Name = "personal_id";
            this.personal_id.ReadOnly = true;
            // 
            // texto
            // 
            this.texto.DataPropertyName = "texto";
            this.texto.HeaderText = "Comentarios";
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            // 
            // fechahora
            // 
            this.fechahora.HeaderText = "Fecha";
            this.fechahora.Name = "fechahora";
            this.fechahora.ReadOnly = true;
            // 
            // adjunto_url
            // 
            this.adjunto_url.HeaderText = "Adjunto";
            this.adjunto_url.Name = "adjunto_url";
            this.adjunto_url.ReadOnly = true;
            // 
            // FrmComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(554, 473);
            this.Controls.Add(this.btnAdjunto);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.dgvComentarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmComentario";
            this.Text = "Comentarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnAdjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn personal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn texto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahora;
        private System.Windows.Forms.DataGridViewTextBoxColumn adjunto_url;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}