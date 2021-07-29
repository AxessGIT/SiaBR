using SiaBR.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using SiaBR.Helpers;
using Npgsql;
using SiaBR.Configuracion;

namespace SiaBR.General
{
    public partial class Login : Form
    {
        public DialogResult _salida { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            Usr usr = new Usr();
            usr.Usuario = txtUsuario.Text.Trim();
            usr.PassWord = txtPassWord.Text.Trim();

            string sql = Queries.UsuarioSelectxUsuario();
            
            using (NpgsqlConnection db = Utilerias.GetDB()) {
                usr = db.QueryFirstOrDefault<Usr>(sql, usr);

                if(usr==null)
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Confirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            };

            SiaBR.Properties.Settings.Default.Usr = usr.Usuario;
            SiaBR.Properties.Settings.Default.UsrId = usr.UsuarioId;
            SiaBR.Properties.Settings.Default.Save();
            _salida = DialogResult.OK;
            Close();






        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Properties.Settings.Default.Usr;
        }

        private void cmdConexion_Click(object sender, EventArgs e)
        {
            ConexionDatos conexionDatos = new ConexionDatos();
            conexionDatos.ShowDialog();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            _salida = DialogResult.Cancel;
            Close();
        }

        private void cmdVerPassWord_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassWord.PasswordChar = '\0';
        }

        private void cmdVerPassWord_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassWord.PasswordChar = '*';

        }
    }
}
