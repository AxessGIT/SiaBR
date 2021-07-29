
namespace SiaBR.Configuracion
{
    partial class ConexionDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConexionDatos));
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaseDeDatos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.spnPuerto = new System.Windows.Forms.NumericUpDown();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdVerPassWord = new System.Windows.Forms.Button();
            this.cmdProbar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnPuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(105, 27);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(239, 23);
            this.txtServidor.TabIndex = 1;
            this.txtServidor.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(105, 56);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(239, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "postgres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(105, 85);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(239, 23);
            this.txtPassWord.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base de datos";
            // 
            // txtBaseDeDatos
            // 
            this.txtBaseDeDatos.Location = new System.Drawing.Point(105, 143);
            this.txtBaseDeDatos.Name = "txtBaseDeDatos";
            this.txtBaseDeDatos.Size = new System.Drawing.Size(239, 23);
            this.txtBaseDeDatos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Puerto";
            // 
            // spnPuerto
            // 
            this.spnPuerto.Location = new System.Drawing.Point(105, 114);
            this.spnPuerto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnPuerto.Name = "spnPuerto";
            this.spnPuerto.Size = new System.Drawing.Size(120, 23);
            this.spnPuerto.TabIndex = 7;
            this.spnPuerto.Value = new decimal(new int[] {
            5432,
            0,
            0,
            0});
            // 
            // cmdSalir
            // 
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(218, 229);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(105, 47);
            this.cmdSalir.TabIndex = 11;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(107, 229);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(105, 47);
            this.cmdGuardar.TabIndex = 10;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdVerPassWord
            // 
            this.cmdVerPassWord.Image = ((System.Drawing.Image)(resources.GetObject("cmdVerPassWord.Image")));
            this.cmdVerPassWord.Location = new System.Drawing.Point(350, 83);
            this.cmdVerPassWord.Name = "cmdVerPassWord";
            this.cmdVerPassWord.Size = new System.Drawing.Size(64, 26);
            this.cmdVerPassWord.TabIndex = 12;
            this.cmdVerPassWord.UseVisualStyleBackColor = true;
            this.cmdVerPassWord.Click += new System.EventHandler(this.cmdVerPassWord_Click);
            this.cmdVerPassWord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdVerPassWord_MouseDown);
            this.cmdVerPassWord.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmdVerPassWord_MouseUp);
            // 
            // cmdProbar
            // 
            this.cmdProbar.Image = ((System.Drawing.Image)(resources.GetObject("cmdProbar.Image")));
            this.cmdProbar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProbar.Location = new System.Drawing.Point(239, 172);
            this.cmdProbar.Name = "cmdProbar";
            this.cmdProbar.Size = new System.Drawing.Size(105, 30);
            this.cmdProbar.TabIndex = 13;
            this.cmdProbar.Text = "&Probar";
            this.cmdProbar.UseVisualStyleBackColor = true;
            this.cmdProbar.Click += new System.EventHandler(this.cmdProbar_Click);
            // 
            // ConexionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 283);
            this.Controls.Add(this.cmdProbar);
            this.Controls.Add(this.cmdVerPassWord);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.spnPuerto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaseDeDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServidor);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConexionDatos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la conexión";
            this.Load += new System.EventHandler(this.ConexionDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnPuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseDeDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spnPuerto;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdVerPassWord;
        private System.Windows.Forms.Button cmdProbar;
    }
}