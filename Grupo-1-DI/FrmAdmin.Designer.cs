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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ssAdmin = new System.Windows.Forms.StatusStrip();
            this.tsslRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ssAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ssAdmin
            // 
            this.ssAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRegistros,
            this.tsslFecha});
            this.ssAdmin.Location = new System.Drawing.Point(0, 290);
            this.ssAdmin.Name = "ssAdmin";
            this.ssAdmin.Size = new System.Drawing.Size(569, 22);
            this.ssAdmin.TabIndex = 1;
            this.ssAdmin.Text = "statusStrip1";
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
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 312);
            this.Controls.Add(this.ssAdmin);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmAdmin";
            this.Text = "Incidencias (Administrador)";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ssAdmin.ResumeLayout(false);
            this.ssAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip ssAdmin;
        private System.Windows.Forms.ToolStripStatusLabel tsslRegistros;
        private System.Windows.Forms.ToolStripStatusLabel tsslFecha;
    }
}