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
    public partial class ArrendatariosAltasCambios : Form
    {
        private bool _esAlta;
        private int _arrendatarioId;
        private Arrendatario _arrendatario;

        public ArrendatariosAltasCambios(bool esAlta, int arrendatarioId)
        {

            _esAlta = esAlta;
            _arrendatarioId = arrendatarioId;
            

            InitializeComponent();
        }

        private void ArrendatariosAltasCambios_Load(object sender, EventArgs e)
        {
            SetCombos();

            if (_esAlta){ 
                Text = "Agregar arrendatario";
                _arrendatario = new Arrendatario();
            }
            else {

                Text = "Modificar arrendatario";

                string sql = Queries.ArrendatarioSelect();

                using (NpgsqlConnection db = Utilerias.GetDB())
                {
                    _arrendatario = db.QueryFirstOrDefault<Arrendatario>(sql, new { ArrendatarioId = _arrendatarioId });
                }

                PropiedadesACampos();
                
            }

        }


        private void SetCombos()
        {
            Utilerias.ConfiguraCombo(ref cboCiudades, "CIU");
            Utilerias.ConfiguraCombo(ref cboEstados, "EDO");

        }

        private void PropiedadesACampos()
        {
            txtRFC.Text = _arrendatario.RFC;
            txtNombre.Text = _arrendatario.Nombre;
            txtCalle.Text = _arrendatario.Calle;
            txtNumeroExterior.Text = _arrendatario.NumExt;
            txtNumeroInterior.Text = _arrendatario.NumInt;
            txtColonia.Text = _arrendatario.Colonia;
            cboCiudades.SelectedValue = _arrendatario.CiudadId;
            cboEstados.SelectedValue = _arrendatario.EstadoId;
            txtPais.Text = _arrendatario.Pais;
            txtCP.Text = _arrendatario.CP;

            txtTelefonos.Text = _arrendatario.Telefonos;
            txtCorreos.Text = _arrendatario.Correos;
        }


        private void CamposAPropiedades()
        {
            _arrendatario.RFC= txtRFC.Text;
            _arrendatario.Nombre= txtNombre.Text;
            _arrendatario.Calle= txtCalle.Text;
            _arrendatario.NumExt = txtNumeroExterior.Text;
            _arrendatario.NumInt= txtNumeroInterior.Text;
            _arrendatario.Colonia = txtColonia.Text;
            _arrendatario.CiudadId= Convert.ToInt32(cboCiudades.SelectedValue);
            _arrendatario.EstadoId= Convert.ToInt32(cboEstados.SelectedValue);
            _arrendatario.Pais= txtPais.Text;
            _arrendatario.CP= txtCP.Text;

            _arrendatario.Telefonos = txtTelefonos.Text;
            _arrendatario.Correos= txtCorreos.Text;

        }

        private void CargaDocumento()
        {


        }
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            CamposAPropiedades();

            string sql = _esAlta ? Queries.ArrendatarioInsert() : Queries.ArrendatarioUpdate();

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                db.Execute(sql,_arrendatario);
            }
            Close();

        }

        private void cmdIdentificacionSubir_Click(object sender, EventArgs e)
        {
            _arrendatario.IdentificacionNombre = Utilerias.SubeDocumento();
            _arrendatario.IdentificacionArchivo = Utilerias.CargaDocumento(_arrendatario.IdentificacionNombre);
        }

        private void cmdIdentificacionver_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(_arrendatario.IdentificacionNombre, _arrendatario.IdentificacionArchivo);
        }

        private void cmdComprobanteSubir_Click(object sender, EventArgs e)
        {
            _arrendatario.ComprobanteNombre = Utilerias.SubeDocumento();
            _arrendatario.ComprobanteArchivo = Utilerias.CargaDocumento(_arrendatario.ComprobanteNombre);

        }

        private void cmdComprobanteVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(_arrendatario.ComprobanteNombre, _arrendatario.ComprobanteArchivo);

        }

        private void cmdAvalSubir_Click(object sender, EventArgs e)
        {
            _arrendatario.AvalNombre = Utilerias.SubeDocumento();
            _arrendatario.AvalArchivo = Utilerias.CargaDocumento(_arrendatario.AvalNombre);


        }

        private void cmdAvalVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(_arrendatario.AvalNombre, _arrendatario.AvalArchivo);

        }
    }
}
