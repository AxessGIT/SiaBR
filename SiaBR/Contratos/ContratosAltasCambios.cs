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
using SiaBR.Arrendatarios;
using SiaBR.Helpers;
using SiaBR.Modelo;
using SiaBR.Propiedades;

namespace SiaBR.Contratos
{
    public partial class ContratosAltasCambios : Form
    {

        private bool _esAlta;
        private Contrato _contrato;
        private int _contratoId;
        private Fol _folio;

        public ContratosAltasCambios(bool esAlta, int contratoId)
        {
            _esAlta = esAlta;
            _contratoId = contratoId;
            InitializeComponent();
        }

        private void cmdBuscarPropiedad_Click(object sender, EventArgs e)
        {
            PropiedadesBuscar propiedadesBuscar = new PropiedadesBuscar();
            propiedadesBuscar.ShowDialog();
            if (propiedadesBuscar.Aceptar)
            {
                _contrato.PropiedadId = propiedadesBuscar.PropiedadId;
                MuestraPropiedad();
            }
        }

        private void ContratosAltasCambios_Load(object sender, EventArgs e)
        {

            if (_esAlta)
            {
                _contrato = new Contrato();
                Text = "Nuevo contrato";
                _folio = Utilerias.GetFolio("CON");
                txtFolio.Text = _folio.Folio.ToString();

            }
            else
            {
                Text = "Modificar contrato";
                string sql = Queries.ContratoSelect();

                using (NpgsqlConnection db = Utilerias.GetDB())
                {
                    _contrato = db.QueryFirstOrDefault<Contrato>(sql, new { ContratoId = _contratoId });
                }

                PropiedadesAControles();
                txtFolio.Text = _contrato.Folio.ToString();

            }

        }


        private void MuestraPropiedad()
        {

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                string sql = Queries.PropiedadDatosSelect();
                PropiedadDatos prop = db.QueryFirstOrDefault<PropiedadDatos>(sql, new { PropiedadId = _contrato.PropiedadId });

                txtPropiedad.Text = prop.Clave+" "+prop.Tipo+" "+ prop.Desarrollo+" "+prop.Ubicacion+" "+ prop.Direccion;

            }


        }


        private void PropiedadesAControles()
        {
            MuestraPropiedad();
            MuestraArrendatario();

            txtFolio.Text = _contrato.Folio.ToString();
            txtRenta.DecimalValue = _contrato.Renta;
            dtpFechaInicial.Value = _contrato.FechaInicial;
            dtpFechaFinal.Value = _contrato.FechaFinal;

            chkFacturar.Checked = _contrato.Facturar;


        }

        private void ControlesAPropiedades()
        {
            if (_esAlta)
                _contrato.Folio = Convert.ToInt32(txtFolio.Text);


            _contrato.FechaInicial = dtpFechaInicial.Value;
            _contrato.FechaFinal = dtpFechaFinal.Value;
            _contrato.Renta = txtRenta.DecimalValue;
            _contrato.Facturar = chkFacturar.Checked;


        }



        private void MuestraArrendatario()
        {

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                string sql = Queries.ArrendatarioSelect();
                Arrendatario arr = db.QueryFirstOrDefault<Arrendatario>(sql, new { ArrendatarioId = _contrato.ArrendatarioId });
                txtArrendatario.Text = arr.Nombre;
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdBuscarArrendatario_Click(object sender, EventArgs e)
        {
            ArrendatariosBuscar arrendatariosBuscar = new ArrendatariosBuscar();
            arrendatariosBuscar.ShowDialog();
            if (arrendatariosBuscar.Aceptar)
            {
                _contrato.ArrendatarioId = arrendatariosBuscar.ArrendatarioId;
                MuestraArrendatario();
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            ControlesAPropiedades();


            string sql = _esAlta?Queries.ContratoInsert():Queries.ContratoUpdate();


            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                db.Execute(sql, _contrato);

            }

            if (_esAlta)
            {
                _folio.Folio++;
                Utilerias.SetFolio(_folio.Tipo, _folio.Folio);

            }

            Close();
        }

        private void cmdContratoSubir_Click(object sender, EventArgs e)
        {
            _contrato.ContratoNombre= Utilerias.SubeDocumento();
            _contrato.ContratoArchivo= Utilerias.CargaDocumento(_contrato.ContratoNombre);

        }

        private void cmdContratoVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(_contrato.ContratoNombre, _contrato.ContratoArchivo);

        }

        private void cmdFianzaSubir_Click(object sender, EventArgs e)
        {
            _contrato.FianzaNombre = Utilerias.SubeDocumento();
            _contrato.FianzaArchivo = Utilerias.CargaDocumento(_contrato.FianzaNombre);

        }

        private void cmdFianzaVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(_contrato.FianzaNombre, _contrato.FianzaArchivo);

        }
    }
}
