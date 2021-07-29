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
    public partial class PropiedadesBuscar : Form
    {
        private BindingList<PropiedadDatos> _propiedades = null;
        public bool Aceptar { get; set; }
        public int PropiedadId { get; set; }

        public PropiedadesBuscar()
        {
            InitializeComponent();
        }

        private void PropiedadesBuscar_Load(object sender, EventArgs e)
        {

            SetCombos();

        }

        private void CargaPropiedades()
        {



            string clave = txtClave.Text.Trim();
            int tipoId = cboTipos.SelectedIndex < 0 ? 0 : Convert.ToInt32(cboTipos.SelectedValue);
            int desarrolloId = cboDesarrollos.SelectedIndex < 0 ? 0 : Convert.ToInt32(cboDesarrollos.SelectedValue);
            int ubicacionId = cboUbicaciones.SelectedIndex < 0 ? 0 : Convert.ToInt32(cboUbicaciones.SelectedValue);
            int ciudadId = cboCiudades.SelectedIndex < 0 ? 0 : Convert.ToInt32(cboCiudades.SelectedValue);
            int estadoId = cboEstados.SelectedIndex < 0 ? 0 : Convert.ToInt32(cboEstados.SelectedValue);

            string sql = Queries.PropiedadesDatosFiltradosSelect(
                Properties.Settings.Default.EmpresaId,
                clave,tipoId,desarrolloId,
                ubicacionId,ciudadId,estadoId);

            using (NpgsqlConnection db = Utilerias.GetDB())
            {


                var res = db.Query<PropiedadDatos>(sql, new { EmpresaId = Properties.Settings.Default.EmpresaId }).ToList();
                _propiedades = new BindingList<PropiedadDatos>(res);
            }
        }

        private void SetGrid()
        {
            Utilerias.SetGridPropiedades(ref grdPropiedades, _propiedades);
        }


        private void SetCombos()
        {
            Utilerias.ConfiguraCombo(ref cboTipos, "TIP");
            Utilerias.ConfiguraCombo(ref cboDesarrollos, "DES");
            Utilerias.ConfiguraCombo(ref cboUbicaciones, "UBI");
            Utilerias.ConfiguraCombo(ref cboCiudades, "CIU");
            Utilerias.ConfiguraCombo(ref cboEstados, "EDO");

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Aceptar = false;
            PropiedadId = 0;
            Close();
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            if (grdPropiedades.CurrentRow==null)
            {
                MessageBox.Show("Seleccione la propiedad","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Aceptar = true;
            PropiedadId = _propiedades[grdPropiedades.CurrentRow.Index].PropiedadId;
            Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            CargaPropiedades();
            SetGrid();

        }

        private void cmdInicializar_Click(object sender, EventArgs e)
        {
            txtClave.Text = "";
            cboTipos.SelectedIndex = -1;
            cboDesarrollos.SelectedIndex = -1;
            cboUbicaciones.SelectedIndex = -1;
            cboCiudades.SelectedIndex = -1;
            cboEstados.SelectedIndex = -1;
        }
    }
}
