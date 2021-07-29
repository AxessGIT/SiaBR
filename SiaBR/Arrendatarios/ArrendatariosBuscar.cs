using Dapper;
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

namespace SiaBR.Arrendatarios
{
    public partial class ArrendatariosBuscar : Form
    {
        private BindingList<Arrendatario> _arrendatarios;
        public bool Aceptar { get; set; }
        public int ArrendatarioId { get; set; }

        public ArrendatariosBuscar()
        {
            InitializeComponent();
        }

        private void ArrendatariosBuscar_Load(object sender, EventArgs e)
        {

        }

        private void CargaArrendatarios()
        {
            string buscar = txtBuscar.Text.Trim().ToUpper();
            string sql = Queries.ArrendatariosBuscarSelect(buscar);

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                var res = db.Query<Arrendatario>(sql).ToList();
                _arrendatarios = new BindingList<Arrendatario>(res);

            }

        }

        private void SetGrid()
        {
            Utilerias.SetGridArrendatarios(ref grdArrendatarios, _arrendatarios);


        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim())) 
            {
                MessageBox.Show("Indique el criterio a buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CargaArrendatarios();
            SetGrid();

        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            if (grdArrendatarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un arrendatario","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            ArrendatarioId = _arrendatarios[grdArrendatarios.CurrentRow.Index].ArrendatarioId;
            Aceptar = true;
            Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            ArrendatarioId = _arrendatarios[grdArrendatarios.CurrentRow.Index].ArrendatarioId;
            Aceptar = true;
            Close();

        }
    }
}
