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
using Npgsql;
using SiaBR.Helpers;

namespace SiaBR.Propiedades
{
    public partial class PropiedadesListado : Form
    {
        private BindingList<PropiedadDatos> _propiedades = null;

        public PropiedadesListado()
        {
            InitializeComponent();
        }

        private void PropiedadesListado_Load(object sender, EventArgs e)
        {
            CargaPropiedades();
            SetGrid();

        }


        private void CargaPropiedades()
        {

            string sql = Queries.PropiedadesDatosSelect();

            using (NpgsqlConnection db = Utilerias.GetDB()) { 


                var res = db.Query<PropiedadDatos>(sql, new {EmpresaId = Properties.Settings.Default.EmpresaId}).ToList();
                _propiedades = new BindingList<PropiedadDatos>(res);
            }
        }

        private void SetGrid()
        {

            Utilerias.SetGridPropiedades(ref grdPropiedades, _propiedades);

        }


        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AltasCambios(bool esAlta)
        {
            int propiedadId = 0;
            if (!esAlta)
            {
                propiedadId = _propiedades[grdPropiedades.CurrentRow.Index].PropiedadId;
            }

            PropiedadesAltasCambios propiedadesAltasCambios = new PropiedadesAltasCambios(esAlta,propiedadId);
            propiedadesAltasCambios.ShowDialog();
            CargaPropiedades();
            SetGrid();

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            AltasCambios(true);
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (grdPropiedades.CurrentRow==null)
            {
                MessageBox.Show("Seleccione una propiedad", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AltasCambios(false);
        }
    }
}
