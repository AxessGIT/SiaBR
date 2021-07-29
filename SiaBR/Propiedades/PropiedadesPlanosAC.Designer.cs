
namespace SiaBR.Propiedades
{
    partial class PropiedadesPlanosAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropiedadesPlanosAC));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdDocumentoSubir = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "suba de nuevo el archivo o seleccione otro.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(475, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "*) Indica desde cual archivo se alimentó la base de  datos, si desea actualizarlo" +
    "s,";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(321, 146);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(127, 49);
            this.cmdCerrar.TabIndex = 29;
            this.cmdCerrar.Text = "&Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(186, 146);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(127, 49);
            this.cmdGuardar.TabIndex = 28;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdDocumentoSubir
            // 
            this.cmdDocumentoSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDocumentoSubir.Image = ((System.Drawing.Image)(resources.GetObject("cmdDocumentoSubir.Image")));
            this.cmdDocumentoSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDocumentoSubir.Location = new System.Drawing.Point(409, 85);
            this.cmdDocumentoSubir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmdDocumentoSubir.Name = "cmdDocumentoSubir";
            this.cmdDocumentoSubir.Size = new System.Drawing.Size(92, 34);
            this.cmdDocumentoSubir.TabIndex = 27;
            this.cmdDocumentoSubir.Text = "&Subir";
            this.cmdDocumentoSubir.UseVisualStyleBackColor = true;
            this.cmdDocumentoSubir.Click += new System.EventHandler(this.cmdDocumentoSubir_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(110, 41);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(491, 23);
            this.txtArchivo.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Último archivo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(110, 12);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(491, 23);
            this.txtDescripcion.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripción";
            // 
            // PropiedadesPlanosAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdDocumentoSubir);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropiedadesPlanosAC";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PropiedadesPlanosAC";
            this.Load += new System.EventHandler(this.PropiedadesPlanosAC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdDocumentoSubir;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
    }
}