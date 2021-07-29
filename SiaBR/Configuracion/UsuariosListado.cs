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
using SiaBR.Modelo;
using SiaBR.Helpers;
using Npgsql;

namespace SiaBR.Configuracion
{
    public partial class UsuariosListado : Form
    {
        private BindingList<Usr> _usuarios;

        public UsuariosListado()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UsuariosListado_Load(object sender, EventArgs e)
        {
            CargaUsuarios();
            SetGrid();
        }

        private void CargaUsuarios()
        {

            string sql = Queries.UsuariosSelect();

            using (NpgsqlConnection db = Utilerias.GetDB()) {

                var res = db.Query<Usr>(sql).ToList();
                _usuarios = new BindingList<Usr>(res);

            }

        }

        private void SetGrid()
        {
            grdUsuarios.DataSource = null;



            grdUsuarios.AllowUserToAddRows = false;
            grdUsuarios.AllowUserToDeleteRows = false;


            grdUsuarios.AutoGenerateColumns = false;
            grdUsuarios.ReadOnly = true;
            grdUsuarios.AllowUserToResizeColumns = false;
            grdUsuarios.AllowUserToResizeRows = false;

            grdUsuarios.ColumnCount = 1;

            grdUsuarios.RowHeadersVisible = true;


            grdUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font(grdUsuarios.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdUsuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdUsuarios.Columns[0].HeaderText = "Nombre";

            grdUsuarios.Columns[0].DataPropertyName = "Nombre";
            grdUsuarios.Columns[0].Width = 200;
            grdUsuarios.DataSource = _usuarios;

        }

        private void AltasCambios(bool esAlta)
        {

            int id = 0;
            if (esAlta == false)
            {
                id = (int)_usuarios[grdUsuarios.CurrentRow.Index].UsuarioId;
            }
            UsuariosAltasCambios usrAC = new UsuariosAltasCambios(esAlta, id);
            usrAC.ShowDialog();

            CargaUsuarios();
            SetGrid();


        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            AltasCambios(true);
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            AltasCambios(false);
        }
    }
}
