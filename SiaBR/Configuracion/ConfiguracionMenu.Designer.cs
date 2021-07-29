
namespace SiaBR.Configuracion
{
    partial class ConfiguracionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionMenu));
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdEstados = new System.Windows.Forms.Button();
            this.cmdCiudades = new System.Windows.Forms.Button();
            this.cmdUbicaciones = new System.Windows.Forms.Button();
            this.cmdDesarrollos = new System.Windows.Forms.Button();
            this.cmdTipos = new System.Windows.Forms.Button();
            this.cmdUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(384, 234);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(143, 56);
            this.cmdSalir.TabIndex = 11;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdEstados
            // 
            this.cmdEstados.Image = global::SiaBR.Properties.Resources.estado32;
            this.cmdEstados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEstados.Location = new System.Drawing.Point(187, 74);
            this.cmdEstados.Name = "cmdEstados";
            this.cmdEstados.Size = new System.Drawing.Size(165, 56);
            this.cmdEstados.TabIndex = 9;
            this.cmdEstados.Text = "&Estados";
            this.cmdEstados.UseVisualStyleBackColor = true;
            this.cmdEstados.Click += new System.EventHandler(this.cmdEstados_Click);
            // 
            // cmdCiudades
            // 
            this.cmdCiudades.Image = global::SiaBR.Properties.Resources.Ciudad32;
            this.cmdCiudades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCiudades.Location = new System.Drawing.Point(12, 74);
            this.cmdCiudades.Name = "cmdCiudades";
            this.cmdCiudades.Size = new System.Drawing.Size(165, 56);
            this.cmdCiudades.TabIndex = 8;
            this.cmdCiudades.Text = "&Ciudades";
            this.cmdCiudades.UseVisualStyleBackColor = true;
            this.cmdCiudades.Click += new System.EventHandler(this.cmdCiudades_Click);
            // 
            // cmdUbicaciones
            // 
            this.cmdUbicaciones.Image = ((System.Drawing.Image)(resources.GetObject("cmdUbicaciones.Image")));
            this.cmdUbicaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdUbicaciones.Location = new System.Drawing.Point(362, 12);
            this.cmdUbicaciones.Name = "cmdUbicaciones";
            this.cmdUbicaciones.Size = new System.Drawing.Size(165, 56);
            this.cmdUbicaciones.TabIndex = 7;
            this.cmdUbicaciones.Text = "&Ubicaciones";
            this.cmdUbicaciones.UseVisualStyleBackColor = true;
            this.cmdUbicaciones.Click += new System.EventHandler(this.cmdUbicaciones_Click);
            // 
            // cmdDesarrollos
            // 
            this.cmdDesarrollos.Image = global::SiaBR.Properties.Resources.Desarrollo32;
            this.cmdDesarrollos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDesarrollos.Location = new System.Drawing.Point(187, 12);
            this.cmdDesarrollos.Name = "cmdDesarrollos";
            this.cmdDesarrollos.Size = new System.Drawing.Size(165, 56);
            this.cmdDesarrollos.TabIndex = 6;
            this.cmdDesarrollos.Text = "&Desarrollos";
            this.cmdDesarrollos.UseVisualStyleBackColor = true;
            this.cmdDesarrollos.Click += new System.EventHandler(this.cmdDesarrollos_Click);
            // 
            // cmdTipos
            // 
            this.cmdTipos.Image = ((System.Drawing.Image)(resources.GetObject("cmdTipos.Image")));
            this.cmdTipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdTipos.Location = new System.Drawing.Point(12, 12);
            this.cmdTipos.Name = "cmdTipos";
            this.cmdTipos.Size = new System.Drawing.Size(165, 56);
            this.cmdTipos.TabIndex = 5;
            this.cmdTipos.Text = "&Tipos de prop.";
            this.cmdTipos.UseVisualStyleBackColor = true;
            this.cmdTipos.Click += new System.EventHandler(this.cmdTipos_Click);
            // 
            // cmdUsuarios
            // 
            this.cmdUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("cmdUsuarios.Image")));
            this.cmdUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdUsuarios.Location = new System.Drawing.Point(362, 74);
            this.cmdUsuarios.Name = "cmdUsuarios";
            this.cmdUsuarios.Size = new System.Drawing.Size(165, 56);
            this.cmdUsuarios.TabIndex = 12;
            this.cmdUsuarios.Text = "&Usuarios";
            this.cmdUsuarios.UseVisualStyleBackColor = true;
            this.cmdUsuarios.Click += new System.EventHandler(this.cmdUsuarios_Click);
            // 
            // ConfiguracionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 302);
            this.Controls.Add(this.cmdUsuarios);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdEstados);
            this.Controls.Add(this.cmdCiudades);
            this.Controls.Add(this.cmdUbicaciones);
            this.Controls.Add(this.cmdDesarrollos);
            this.Controls.Add(this.cmdTipos);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguracionMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguracionMenu";
            this.Load += new System.EventHandler(this.ConfiguracionMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdEstados;
        private System.Windows.Forms.Button cmdCiudades;
        private System.Windows.Forms.Button cmdUbicaciones;
        private System.Windows.Forms.Button cmdDesarrollos;
        private System.Windows.Forms.Button cmdTipos;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdUsuarios;
    }
}