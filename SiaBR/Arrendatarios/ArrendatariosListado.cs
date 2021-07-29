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

namespace SiaBR.Arrendatarios
{
    public partial class ArrendatariosListado : Form
    {
        private BindingList<Arrendatario> _arrendatarios;

        public ArrendatariosListado()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            AltasCambios(true);
        }

        private void AltasCambios(bool esAlta)
        {
            int arrendatarioId = 0;

            if (!esAlta) {
                arrendatarioId = _arrendatarios[grdArrendatarios.CurrentRow.Index].ArrendatarioId;

            }
            ArrendatariosAltasCambios arrendatariosAltasCambios = new ArrendatariosAltasCambios(esAlta,arrendatarioId);
            arrendatariosAltasCambios.ShowDialog();
            CargaArrendatarios();
            SetGrid();


        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            AltasCambios(false);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ArrendatariosListado_Load(object sender, EventArgs e)
        {
            CargaArrendatarios();
            SetGrid();
        }


        private void CargaArrendatarios()
        {
            string sql = Queries.ArrendatariosSelect();

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

    }
}
