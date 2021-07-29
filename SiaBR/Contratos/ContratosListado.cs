using Npgsql;
using SiaBR.Helpers;
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

namespace SiaBR.Contratos
{
    public partial class ContratosListado : Form
    {
        private BindingList<ContratoDatos> _contratos;

        public ContratosListado()
        {
            InitializeComponent();
        }

        private void ContratosListado_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            CargaContratos();
            SetGrid();

    }
    private void CargaContratos()
        {
            string sql = Queries.ContratosSelect();

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                var res = db.Query<ContratoDatos>(sql).ToList();
                _contratos = new BindingList<ContratoDatos>(res);

            }

        }

        private void SetGrid()
        {

            grdContratos.DataSource = null;



            grdContratos.AllowUserToAddRows = false;
            grdContratos.AllowUserToDeleteRows = false;


            grdContratos.AutoGenerateColumns = false;
            grdContratos.ReadOnly = true;
            grdContratos.AllowUserToResizeColumns = false;
            grdContratos.AllowUserToResizeRows = false;

            grdContratos.ColumnCount = 4;

            grdContratos.RowHeadersVisible = true;


            grdContratos.ColumnHeadersDefaultCellStyle.Font = new Font(grdContratos.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdContratos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdContratos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdContratos.Columns[0].HeaderText = "Folio";
            grdContratos.Columns[0].DataPropertyName = "Folio";
            grdContratos.Columns[0].Width = 50;

            grdContratos.Columns[1].HeaderText = "Propiedad";
            grdContratos.Columns[1].DataPropertyName = "Clave";
            grdContratos.Columns[1].Width = 100;


            grdContratos.Columns[2].HeaderText = "Arrendatario";
            grdContratos.Columns[2].DataPropertyName = "Nombre";
            grdContratos.Columns[2].Width = 350;

            grdContratos.Columns[3].DefaultCellStyle.Format = "c2";
            grdContratos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdContratos.Columns[3].HeaderText = "Renta";
            grdContratos.Columns[3].DataPropertyName = "Renta";
            grdContratos.Columns[3].Width = 100;


            grdContratos.DataSource = _contratos;

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            AltasCambios(true);

        }

        private void AltasCambios(bool esAlta)
        {
            int contratoId = 0;

            if (!esAlta)
            {
                contratoId = _contratos[grdContratos.CurrentRow.Index].ContratoId;
            }
            ContratosAltasCambios contratosAltasCambios = new ContratosAltasCambios(esAlta, contratoId); ;
            contratosAltasCambios.ShowDialog();
            Actualizar();

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if(grdContratos.CurrentRow==null)
            {
                MessageBox.Show("Indique el contrato a modificar", "Confirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            AltasCambios(false);
        }
    }
}
