﻿namespace Grupo_1_DI
{
    partial class FrmIncidencia
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.cmbTipoIncidencia = new System.Windows.Forms.ComboBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnRegIncidencia = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdjunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(8, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 19);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Incidencia:";
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Items.AddRange(new object[] {
            "Equipos",
            "Cuentas",
            "WiFi",
            "Internet",
            "Software"});
            this.cmbIncidencia.Location = new System.Drawing.Point(107, 11);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(200, 21);
            this.cmbIncidencia.TabIndex = 12;
            this.cmbIncidencia.SelectedIndexChanged += new System.EventHandler(this.cmbIncidencia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Etiqueta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Aula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Adjunto";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(107, 65);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(200, 20);
            this.txtAula.TabIndex = 18;
            // 
            // cmbTipoIncidencia
            // 
            this.cmbTipoIncidencia.FormattingEnabled = true;
            this.cmbTipoIncidencia.Location = new System.Drawing.Point(107, 38);
            this.cmbTipoIncidencia.Name = "cmbTipoIncidencia";
            this.cmbTipoIncidencia.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoIncidencia.TabIndex = 19;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(107, 117);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(200, 20);
            this.txtPuesto.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Puesto:";
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.Location = new System.Drawing.Point(107, 91);
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(200, 20);
            this.txtEtiqueta.TabIndex = 22;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(12, 173);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(295, 112);
            this.txtDesc.TabIndex = 23;
            // 
            // btnRegIncidencia
            // 
            this.btnRegIncidencia.BackColor = System.Drawing.Color.Transparent;
            this.btnRegIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegIncidencia.FlatAppearance.BorderSize = 0;
            this.btnRegIncidencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnRegIncidencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnRegIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegIncidencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegIncidencia.ForeColor = System.Drawing.Color.Silver;
            this.btnRegIncidencia.Image = global::Grupo_1_DI.Properties.Resources.register_icon;
            this.btnRegIncidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegIncidencia.Location = new System.Drawing.Point(189, 404);
            this.btnRegIncidencia.Name = "btnRegIncidencia";
            this.btnRegIncidencia.Size = new System.Drawing.Size(118, 43);
            this.btnRegIncidencia.TabIndex = 26;
            this.btnRegIncidencia.Text = "Registrar Incidencia";
            this.btnRegIncidencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegIncidencia.UseVisualStyleBackColor = false;
            this.btnRegIncidencia.Click += new System.EventHandler(this.btnRegIncidencia_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.Image = global::Grupo_1_DI.Properties.Resources.cancel_Icon;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(76, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 43);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdjunto
            // 
            this.btnAdjunto.BackColor = System.Drawing.Color.White;
            this.btnAdjunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjunto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdjunto.FlatAppearance.BorderSize = 5;
            this.btnAdjunto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdjunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAdjunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjunto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdjunto.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdjunto.Image = global::Grupo_1_DI.Properties.Resources.file_Icon;
            this.btnAdjunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdjunto.Location = new System.Drawing.Point(43, 312);
            this.btnAdjunto.Name = "btnAdjunto";
            this.btnAdjunto.Size = new System.Drawing.Size(236, 53);
            this.btnAdjunto.TabIndex = 28;
            this.btnAdjunto.Text = "           Subir Archivo";
            this.btnAdjunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdjunto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdjunto.UseVisualStyleBackColor = false;
            this.btnAdjunto.Click += new System.EventHandler(this.btnAdjunto_Click);
            // 
            // FrmIncidencia
            // 
            this.AcceptButton = this.btnRegIncidencia;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(316, 454);
            this.Controls.Add(this.btnAdjunto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegIncidencia);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtEtiqueta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.cmbTipoIncidencia);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIncidencia);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmIncidencia";
            this.Text = "Incidencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.ComboBox cmbTipoIncidencia;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEtiqueta;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnRegIncidencia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdjunto;
    }
}