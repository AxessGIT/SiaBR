
namespace SiaBR.Facturacion
{
    partial class FacturacionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionMenu));
            this.cmdsalir = new System.Windows.Forms.Button();
            this.cmdRevisarFacturas = new System.Windows.Forms.Button();
            this.cmdGenerarFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdsalir
            // 
            this.cmdsalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdsalir.Image")));
            this.cmdsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdsalir.Location = new System.Drawing.Point(42, 123);
            this.cmdsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdsalir.Name = "cmdsalir";
            this.cmdsalir.Size = new System.Drawing.Size(165, 47);
            this.cmdsalir.TabIndex = 2;
            this.cmdsalir.Text = "&Salir";
            this.cmdsalir.UseVisualStyleBackColor = true;
            this.cmdsalir.Click += new System.EventHandler(this.cmdsalir_Click);
            // 
            // cmdRevisarFacturas
            // 
            this.cmdRevisarFacturas.Image = global::SiaBR.Properties.Resources.generar32a;
            this.cmdRevisarFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRevisarFacturas.Location = new System.Drawing.Point(42, 68);
            this.cmdRevisarFacturas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdRevisarFacturas.Name = "cmdRevisarFacturas";
            this.cmdRevisarFacturas.Size = new System.Drawing.Size(165, 47);
            this.cmdRevisarFacturas.TabIndex = 1;
            this.cmdRevisarFacturas.Text = "&Revisar facturas";
            this.cmdRevisarFacturas.UseVisualStyleBackColor = true;
            this.cmdRevisarFacturas.Click += new System.EventHandler(this.cmdRevisarFacturas_Click);
            // 
            // cmdGenerarFacturas
            // 
            this.cmdGenerarFacturas.Image = ((System.Drawing.Image)(resources.GetObject("cmdGenerarFacturas.Image")));
            this.cmdGenerarFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGenerarFacturas.Location = new System.Drawing.Point(42, 13);
            this.cmdGenerarFacturas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdGenerarFacturas.Name = "cmdGenerarFacturas";
            this.cmdGenerarFacturas.Size = new System.Drawing.Size(165, 47);
            this.cmdGenerarFacturas.TabIndex = 0;
            this.cmdGenerarFacturas.Text = "&Generar facturas";
            this.cmdGenerarFacturas.UseVisualStyleBackColor = true;
            // 
            // FacturacionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 207);
            this.Controls.Add(this.cmdsalir);
            this.Controls.Add(this.cmdRevisarFacturas);
            this.Controls.Add(this.cmdGenerarFacturas);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacturacionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú facturación";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGenerarFacturas;
        private System.Windows.Forms.Button cmdRevisarFacturas;
        private System.Windows.Forms.Button cmdsalir;
    }
}