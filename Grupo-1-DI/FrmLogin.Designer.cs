namespace Grupo_1_DI
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pbImageLogin = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImageLogin
            // 
            this.pbImageLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbImageLogin.Image = global::Grupo_1_DI.Properties.Resources.logo_IES_Miguel_Herrero;
            this.pbImageLogin.Location = new System.Drawing.Point(12, 12);
            this.pbImageLogin.Name = "pbImageLogin";
            this.pbImageLogin.Size = new System.Drawing.Size(380, 100);
            this.pbImageLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageLogin.TabIndex = 0;
            this.pbImageLogin.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(59, 185);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(94, 19);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "texto carga";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupo_1_DI.Properties.Resources.bg_Login;
            this.ClientSize = new System.Drawing.Size(404, 273);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbImageLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImageLogin;
        private System.Windows.Forms.Label lblUser;
    }
}

