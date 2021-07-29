using Npgsql;
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

namespace SiaBR.Configuracion
{
    public partial class EmpresasListado : Form
    {
        private BindingList<Empresa> _empresas = null;
        private bool _seleccionar = false;

        public EmpresasListado(bool seleccionar)
        {
            _seleccionar = seleccionar;
            InitializeComponent();
        }

        private void EmpresaSeleccionar_Load(object sender, EventArgs e)
        {
            CargaEmpresas();
            SetGrid();


        }

        private void CargaEmpresas()
        {

            string sql = Helpers.Queries.EmpresasSelect();

            using(NpgsqlConnection db= Utilerias.GetDB()){

                var res = db.Query<Empresa>(sql).ToList();

                _empresas = new BindingList<Empresa>(res);
            }
        }

        private void SetGrid()
        {
            grdEmpresas.DataSource = null;



            grdEmpresas.AllowUserToAddRows = false;
            grdEmpresas.AllowUserToDeleteRows = false;


            grdEmpresas.AutoGenerateColumns = false;
            grdEmpresas.ReadOnly = true;
            grdEmpresas.AllowUserToResizeColumns = false;
            grdEmpresas.AllowUserToResizeRows = false;

            grdEmpresas.ColumnCount = 1;

            grdEmpresas.RowHeadersVisible = true;


            grdEmpresas.ColumnHeadersDefaultCellStyle.Font = new Font(grdEmpresas.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdEmpresas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdEmpresas.Columns[0].HeaderText = "Nombre";

            grdEmpresas.Columns[0].DataPropertyName = "RazonSocial";
            grdEmpresas.Columns[0].Width = 400;


            grdEmpresas.DataSource = _empresas;

        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            if (grdEmpresas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una empresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            Properties.Settings.Default.EmpresaId = _empresas[grdEmpresas.CurrentRow.Index].EmpresaId;
            Close();

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            if (_seleccionar)
                Properties.Settings.Default.EmpresaId = 0;
            Close();
        }
    }
}
