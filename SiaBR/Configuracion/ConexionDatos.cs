using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using SiaBR.Helpers;
using SiaBR.Properties;
namespace SiaBR.Configuracion
{
    public partial class ConexionDatos : Form
    {
        public DialogResult _salida { get; set; }
        public ConexionDatos()
        {
            InitializeComponent();
        }

        private void ConexionDatos_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.Default.Servidor))
                txtServidor.Text = Settings.Default.Servidor;

            if (!string.IsNullOrEmpty(Settings.Default.Usuario))
                txtUsuario.Text = Settings.Default.Usuario;

            if (!string.IsNullOrEmpty(Settings.Default.PassWord))
                txtPassWord.Text = Settings.Default.PassWord;

            if (Settings.Default.Puerto != 0)
                spnPuerto.Value= Settings.Default.Puerto;

            if (!string.IsNullOrEmpty(Settings.Default.BaseDeDatos))
                txtBaseDeDatos.Text = Settings.Default.BaseDeDatos;

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            _salida = DialogResult.Cancel;

            Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
                return;

            Settings.Default.Servidor = txtServidor.Text;
            Settings.Default.Usuario= txtUsuario.Text;
            Settings.Default.PassWord= txtPassWord.Text;
            Settings.Default.Puerto= (int) spnPuerto.Value;
            Settings.Default.BaseDeDatos= txtBaseDeDatos.Text;
            Settings.Default.Save();
            _salida = DialogResult.OK;
            Close();


        }

        private bool ValidaDatos()
        {
            bool esValido = false;

            string caderr = "";

            if (string.IsNullOrEmpty(txtServidor.Text))
                caderr = "* Teclee el nombre del servidor";

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {

                caderr = string.IsNullOrEmpty(caderr) ? caderr : caderr += "\n";
                caderr += "* Teclee el nombre del usuario";
            }
            if (string.IsNullOrEmpty(txtPassWord.Text))
            {

                caderr = string.IsNullOrEmpty(caderr) ? caderr : caderr += "\n";
                caderr += "* Teclee el password";
            }
            if (string.IsNullOrEmpty(txtBaseDeDatos.Text))
            {

                caderr = string.IsNullOrEmpty(caderr) ? caderr : caderr += "\n";
                caderr += "* Teclee el nombre de la base de datos";
            }
            if (spnPuerto.Value<1)
            {

                caderr = string.IsNullOrEmpty(caderr) ? caderr : caderr += "\n";
                caderr += "* Teclee un puerto válido";
            }

            if (!string.IsNullOrEmpty(caderr))
            {
                MessageBox.Show(caderr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            esValido = string.IsNullOrEmpty(caderr);

            return esValido;

        }

        private void cmdProbar_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
            {
                return;
            }

            NpgsqlConnectionStringBuilder csb = new NpgsqlConnectionStringBuilder();

            csb.Host = txtServidor.Text.Trim();
            csb.Username = txtUsuario.Text.Trim();
            csb.Password = txtPassWord.Text.Trim();
            csb.Port =(int) spnPuerto.Value;
            csb.Database = txtBaseDeDatos.Text.Trim();

            NpgsqlConnection conn = new NpgsqlConnection();
            conn.ConnectionString = csb.ToString();
            bool success = true;

            try
            {
                conn.Open();
            }
            catch(NpgsqlException err)
            {
                MessageBox.Show(err.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;

            }
            finally
            {
                conn.Close();
            }

            if (success)
                MessageBox.Show("Conexión exitosa","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmdVerPassWord_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassWord.PasswordChar = '\0';
        }

        private void cmdVerPassWord_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassWord.PasswordChar = '*';

        }

        private void cmdVerPassWord_Click(object sender, EventArgs e)
        {

        }
    }
}
