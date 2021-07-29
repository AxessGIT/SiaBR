
namespace SiaBR.Pagos
{
    partial class PagosListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosListado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMesInicial = new System.Windows.Forms.ComboBox();
            this.cboMesFinal = new System.Windows.Forms.ComboBox();
            this.spnAnio = new System.Windows.Forms.NumericUpDown();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdGuardarySalir = new System.Windows.Forms.Button();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.cmdTimbrar = new System.Windows.Forms.Button();
            this.cmdCorreo = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.grdPagos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrato = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.cmdPagar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdSeleccionarTodo = new System.Windows.Forms.Button();
            this.cmdInvertirSeleccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mes inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mes final";
            // 
            // cboMesInicial
            // 
            this.cboMesInicial.FormattingEnabled = true;
            this.cboMesInicial.Location = new System.Drawing.Point(507, 22);
            this.cboMesInicial.Name = "cboMesInicial";
            this.cboMesInicial.Size = new System.Drawing.Size(113, 24);
            this.cboMesInicial.TabIndex = 5;
            // 
            // cboMesFinal
            // 
            this.cboMesFinal.FormattingEnabled = true;
            this.cboMesFinal.Location = new System.Drawing.Point(709, 22);
            this.cboMesFinal.Name = "cboMesFinal";
            this.cboMesFinal.Size = new System.Drawing.Size(113, 24);
            this.cboMesFinal.TabIndex = 7;
            // 
            // spnAnio
            // 
            this.spnAnio.Location = new System.Drawing.Point(345, 23);
            this.spnAnio.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.spnAnio.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spnAnio.Name = "spnAnio";
            this.spnAnio.Size = new System.Drawing.Size(74, 23);
            this.spnAnio.TabIndex = 3;
            this.spnAnio.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spnAnio.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscar.Image")));
            this.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscar.Location = new System.Drawing.Point(828, 17);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(93, 34);
            this.cmdBuscar.TabIndex = 8;
            this.cmdBuscar.Text = "&Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(22, 527);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(119, 60);
            this.cmdGuardar.TabIndex = 10;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // cmdGuardarySalir
            // 
            this.cmdGuardarySalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardarySalir.Image")));
            this.cmdGuardarySalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdGuardarySalir.Location = new System.Drawing.Point(152, 527);
            this.cmdGuardarySalir.Name = "cmdGuardarySalir";
            this.cmdGuardarySalir.Size = new System.Drawing.Size(119, 60);
            this.cmdGuardarySalir.TabIndex = 11;
            this.cmdGuardarySalir.Text = "&Guardar y salir";
            this.cmdGuardarySalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGuardarySalir.UseVisualStyleBackColor = true;
            // 
            // cmdExportar
            // 
            this.cmdExportar.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.Image")));
            this.cmdExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdExportar.Location = new System.Drawing.Point(282, 527);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(119, 60);
            this.cmdExportar.TabIndex = 12;
            this.cmdExportar.Text = "&Exportar";
            this.cmdExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdExportar.UseVisualStyleBackColor = true;
            // 
            // cmdReporte
            // 
            this.cmdReporte.Image = ((System.Drawing.Image)(resources.GetObject("cmdReporte.Image")));
            this.cmdReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdReporte.Location = new System.Drawing.Point(412, 527);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(119, 60);
            this.cmdReporte.TabIndex = 13;
            this.cmdReporte.Text = "&Reporte";
            this.cmdReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdReporte.UseVisualStyleBackColor = true;
            // 
            // cmdTimbrar
            // 
            this.cmdTimbrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdTimbrar.Image")));
            this.cmdTimbrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdTimbrar.Location = new System.Drawing.Point(542, 527);
            this.cmdTimbrar.Name = "cmdTimbrar";
            this.cmdTimbrar.Size = new System.Drawing.Size(119, 60);
            this.cmdTimbrar.TabIndex = 14;
            this.cmdTimbrar.Text = "&Timbrar";
            this.cmdTimbrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdTimbrar.UseVisualStyleBackColor = true;
            // 
            // cmdCorreo
            // 
            this.cmdCorreo.Image = ((System.Drawing.Image)(resources.GetObject("cmdCorreo.Image")));
            this.cmdCorreo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdCorreo.Location = new System.Drawing.Point(672, 527);
            this.cmdCorreo.Name = "cmdCorreo";
            this.cmdCorreo.Size = new System.Drawing.Size(119, 60);
            this.cmdCorreo.TabIndex = 15;
            this.cmdCorreo.Text = "&Mandar correo";
            this.cmdCorreo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCorreo.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSalir.Location = new System.Drawing.Point(802, 527);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(119, 60);
            this.cmdSalir.TabIndex = 16;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // grdPagos
            // 
            this.grdPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPagos.Location = new System.Drawing.Point(14, 64);
            this.grdPagos.Name = "grdPagos";
            this.grdPagos.Size = new System.Drawing.Size(907, 403);
            this.grdPagos.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contrato";
            // 
            // txtContrato
            // 
            this.txtContrato.BeforeTouchSize = new System.Drawing.Size(61, 23);
            this.txtContrato.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContrato.IntegerValue = ((long)(0));
            this.txtContrato.Location = new System.Drawing.Point(80, 23);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(61, 23);
            this.txtContrato.TabIndex = 1;
            // 
            // cmdPagar
            // 
            this.cmdPagar.Image = ((System.Drawing.Image)(resources.GetObject("cmdPagar.Image")));
            this.cmdPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPagar.Location = new System.Drawing.Point(282, 473);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(82, 33);
            this.cmdPagar.TabIndex = 17;
            this.cmdPagar.Text = "&Pagar";
            this.cmdPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPagar.UseVisualStyleBackColor = true;
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdBorrar.Image")));
            this.cmdBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBorrar.Location = new System.Drawing.Point(370, 473);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(82, 33);
            this.cmdBorrar.TabIndex = 18;
            this.cmdBorrar.Text = "&Borrar";
            this.cmdBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdSeleccionarTodo
            // 
            this.cmdSeleccionarTodo.Image = ((System.Drawing.Image)(resources.GetObject("cmdSeleccionarTodo.Image")));
            this.cmdSeleccionarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSeleccionarTodo.Location = new System.Drawing.Point(22, 473);
            this.cmdSeleccionarTodo.Name = "cmdSeleccionarTodo";
            this.cmdSeleccionarTodo.Size = new System.Drawing.Size(82, 33);
            this.cmdSeleccionarTodo.TabIndex = 19;
            this.cmdSeleccionarTodo.Text = "&Todo";
            this.cmdSeleccionarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSeleccionarTodo.UseVisualStyleBackColor = true;
            this.cmdSeleccionarTodo.Click += new System.EventHandler(this.cmdSeleccionarTodo_Click);
            // 
            // cmdInvertirSeleccion
            // 
            this.cmdInvertirSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("cmdInvertirSeleccion.Image")));
            this.cmdInvertirSeleccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdInvertirSeleccion.Location = new System.Drawing.Point(110, 473);
            this.cmdInvertirSeleccion.Name = "cmdInvertirSeleccion";
            this.cmdInvertirSeleccion.Size = new System.Drawing.Size(82, 33);
            this.cmdInvertirSeleccion.TabIndex = 20;
            this.cmdInvertirSeleccion.Text = "&Invertir";
            this.cmdInvertirSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdInvertirSeleccion.UseVisualStyleBackColor = true;
            this.cmdInvertirSeleccion.Click += new System.EventHandler(this.cmdInvertirSeleccion_Click);
            // 
            // PagosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 602);
            this.Controls.Add(this.cmdInvertirSeleccion);
            this.Controls.Add(this.cmdSeleccionarTodo);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdPagar);
            this.Controls.Add(this.txtContrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdPagos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCorreo);
            this.Controls.Add(this.cmdTimbrar);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdGuardarySalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.spnAnio);
            this.Controls.Add(this.cboMesFinal);
            this.Controls.Add(this.cboMesInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PagosListado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura de pagos";
            this.Load += new System.EventHandler(this.PagosListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMesInicial;
        private System.Windows.Forms.ComboBox cboMesFinal;
        private System.Windows.Forms.NumericUpDown spnAnio;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdGuardarySalir;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.Button cmdTimbrar;
        private System.Windows.Forms.Button cmdCorreo;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridView grdPagos;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtContrato;
        private System.Windows.Forms.Button cmdPagar;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdSeleccionarTodo;
        private System.Windows.Forms.Button cmdInvertirSeleccion;
    }
}