
namespace SiaBR
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cmdPropiedades = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdArrendamientos = new System.Windows.Forms.Button();
            this.cmdPagos = new System.Windows.Forms.Button();
            this.cmdConfiguración = new System.Windows.Forms.Button();
            this.cmdFacturas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdPolizas = new System.Windows.Forms.Button();
            this.cmdArrendatarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(296, 50);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(343, 256);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // cmdPropiedades
            // 
            this.cmdPropiedades.Image = ((System.Drawing.Image)(resources.GetObject("cmdPropiedades.Image")));
            this.cmdPropiedades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPropiedades.Location = new System.Drawing.Point(12, 12);
            this.cmdPropiedades.Name = "cmdPropiedades";
            this.cmdPropiedades.Size = new System.Drawing.Size(179, 57);
            this.cmdPropiedades.TabIndex = 8;
            this.cmdPropiedades.Text = "&Propiedades";
            this.cmdPropiedades.UseVisualStyleBackColor = true;
            this.cmdPropiedades.Click += new System.EventHandler(this.cmdPropiedades_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(743, 485);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(179, 57);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdArrendamientos
            // 
            this.cmdArrendamientos.Image = ((System.Drawing.Image)(resources.GetObject("cmdArrendamientos.Image")));
            this.cmdArrendamientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdArrendamientos.Location = new System.Drawing.Point(12, 136);
            this.cmdArrendamientos.Name = "cmdArrendamientos";
            this.cmdArrendamientos.Size = new System.Drawing.Size(179, 57);
            this.cmdArrendamientos.TabIndex = 10;
            this.cmdArrendamientos.Text = "&Contratos";
            this.cmdArrendamientos.UseVisualStyleBackColor = true;
            this.cmdArrendamientos.Click += new System.EventHandler(this.cmdArrendamientos_Click);
            // 
            // cmdPagos
            // 
            this.cmdPagos.Image = ((System.Drawing.Image)(resources.GetObject("cmdPagos.Image")));
            this.cmdPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPagos.Location = new System.Drawing.Point(12, 260);
            this.cmdPagos.Name = "cmdPagos";
            this.cmdPagos.Size = new System.Drawing.Size(179, 57);
            this.cmdPagos.TabIndex = 11;
            this.cmdPagos.Text = "&Pagos";
            this.cmdPagos.UseVisualStyleBackColor = true;
            this.cmdPagos.Click += new System.EventHandler(this.cmdPagos_Click);
            // 
            // cmdConfiguración
            // 
            this.cmdConfiguración.Image = ((System.Drawing.Image)(resources.GetObject("cmdConfiguración.Image")));
            this.cmdConfiguración.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConfiguración.Location = new System.Drawing.Point(12, 446);
            this.cmdConfiguración.Name = "cmdConfiguración";
            this.cmdConfiguración.Size = new System.Drawing.Size(179, 57);
            this.cmdConfiguración.TabIndex = 12;
            this.cmdConfiguración.Text = "&Configuración";
            this.cmdConfiguración.UseVisualStyleBackColor = true;
            this.cmdConfiguración.Click += new System.EventHandler(this.cmdConfiguración_Click);
            // 
            // cmdFacturas
            // 
            this.cmdFacturas.Image = ((System.Drawing.Image)(resources.GetObject("cmdFacturas.Image")));
            this.cmdFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFacturas.Location = new System.Drawing.Point(12, 198);
            this.cmdFacturas.Name = "cmdFacturas";
            this.cmdFacturas.Size = new System.Drawing.Size(179, 57);
            this.cmdFacturas.TabIndex = 13;
            this.cmdFacturas.Text = "&Facturación";
            this.cmdFacturas.UseVisualStyleBackColor = true;
            this.cmdFacturas.Click += new System.EventHandler(this.cmdFacturas_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 57);
            this.button2.TabIndex = 14;
            this.button2.Text = "&Reportes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmdPolizas
            // 
            this.cmdPolizas.Image = ((System.Drawing.Image)(resources.GetObject("cmdPolizas.Image")));
            this.cmdPolizas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPolizas.Location = new System.Drawing.Point(12, 384);
            this.cmdPolizas.Name = "cmdPolizas";
            this.cmdPolizas.Size = new System.Drawing.Size(179, 57);
            this.cmdPolizas.TabIndex = 15;
            this.cmdPolizas.Text = "&Pólizas";
            this.cmdPolizas.UseVisualStyleBackColor = true;
            this.cmdPolizas.Click += new System.EventHandler(this.cmdPolizas_Click);
            // 
            // cmdArrendatarios
            // 
            this.cmdArrendatarios.Image = ((System.Drawing.Image)(resources.GetObject("cmdArrendatarios.Image")));
            this.cmdArrendatarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdArrendatarios.Location = new System.Drawing.Point(12, 74);
            this.cmdArrendatarios.Name = "cmdArrendatarios";
            this.cmdArrendatarios.Size = new System.Drawing.Size(179, 57);
            this.cmdArrendatarios.TabIndex = 16;
            this.cmdArrendatarios.Text = "&Arrendatarios";
            this.cmdArrendatarios.UseVisualStyleBackColor = true;
            this.cmdArrendatarios.Click += new System.EventHandler(this.cmdArrendatarios_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "SISTEMA DE ADMINISTRACIÓN DE BIENES RAICES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Versión  2022";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdArrendatarios);
            this.Controls.Add(this.cmdPolizas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdFacturas);
            this.Controls.Add(this.cmdConfiguración);
            this.Controls.Add(this.cmdPagos);
            this.Controls.Add(this.cmdArrendamientos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdPropiedades);
            this.Controls.Add(this.picLogo);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú control de bienes raíces";
            this.Activated += new System.EventHandler(this.MenuPrincipal_Activated);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button cmdPropiedades;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdArrendamientos;
        private System.Windows.Forms.Button cmdPagos;
        private System.Windows.Forms.Button cmdConfiguración;
        private System.Windows.Forms.Button cmdFacturas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdPolizas;
        private System.Windows.Forms.Button cmdArrendatarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

