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

namespace SiaBR.Configuracion
{
    public partial class UsuariosAltasCambios : Form
    {
        private bool _esAlta;
        private Usr _usuario;
        public int UsuarioId { get; set; }


        public UsuariosAltasCambios(bool esAlta, int usuarioId)
        {
            _esAlta = esAlta;
            UsuarioId = usuarioId;

            InitializeComponent();
        }

        private void UsuariosAltasCambios_Load(object sender, EventArgs e)
        {
            if (_esAlta)
            {
                Text = "Agregar usuario";
                _usuario = new Usr();
            }
            else
            {
                txtUsuario.Enabled = false;
                txtUsuario.BackColor = Color.White;
                txtUsuario.ForeColor = Color.Black;

                Text = "Modificar usuario";
                string sql = Queries.UsuarioSelect();


                using (NpgsqlConnection db = Utilerias.GetDB())
                {
                    _usuario = db.QueryFirstOrDefault<Usr>(sql, new { Usuarioid = UsuarioId });

                }

                PropiedadesAControles();
            }

        }

        private void PropiedadesAControles()
        {

            txtUsuario.Text = _usuario.Usuario;
            txtNombre.Text = _usuario.Nombre;
            txtPassWord.Text = _usuario.PassWord;


        }

        private void ControlesAPropiedades()
        {

            _usuario.Usuario = txtUsuario.Text.Trim();
            _usuario.Nombre = txtNombre.Text.Trim();
            _usuario.PassWord = txtPassWord.Text.Trim();



        }

        private bool ValidaDatos()
        {

            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                MessageBox.Show("Teclee el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Teclee el nombre del usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtPassWord.Text.Trim()))
            {
                MessageBox.Show("Teclee la contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }



            return true;
        }


        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos() == false)
                return;

            ControlesAPropiedades();

            string sql = "";
            if (_esAlta)
            {
                sql = Queries.UsuarioInsert();

                using (NpgsqlConnection db = Utilerias.GetDB())
                {
                    UsuarioId = db.QuerySingle<int>(sql, _usuario);

                }

            }
            else
            {
                sql = Queries.UsuarioUpdate();

                using (NpgsqlConnection db = Utilerias.GetDB())
                {
                    db.Execute(sql, _usuario);

                }
            }
            Close();

        }

        private void cmdMuestraPassWord_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassWord.PasswordChar = '\0';

        }

        private void cmdMuestraPassWord_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassWord.PasswordChar = '*';

        }
    }
}

