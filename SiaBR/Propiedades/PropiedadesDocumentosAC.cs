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
using System.IO;

namespace SiaBR.Propiedades
{
    public partial class PropiedadesDocumentosAC : Form
    {
        private bool _esAlta;
        public PropiedadDocumento Documento { get; set; }
        public bool Guardar { get; set; }

        public PropiedadesDocumentosAC(bool esAlta,PropiedadDocumento documento)
        {
            _esAlta = esAlta;

            if (_esAlta)
                Documento = new PropiedadDocumento();
            else
                Documento = documento;
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Guardar = false;

            Close();
        }

       

        private void PropiedadesDocumentosAC_Load(object sender, EventArgs e)
        {

            cboTipos.DataSource = Utilerias.DevuelveTiposDocumento();
            cboTipos.DisplayMember = "Descripcion";
            cboTipos.ValueMember = "DocumentoTipoId";

            if (_esAlta)
            {
                Text = "Agregar documento";
            }
            else{
                Text = "Modificar Documento";
                PropiedadesAControles();

            } 

        }

        private void PropiedadesAControles()
        {
            cboTipos.SelectedValue = Documento.TipoId;
            txtArchivo.Text = Documento.Archivo;
            txtObservaciones.Text = Documento.Observaciones;
        }

        private void ControlesAPropiedades()
        {
            Documento.TipoId = (int)cboTipos.SelectedValue;
            Documento.Archivo = txtArchivo.Text;
            Documento.Tipo = cboTipos.Text;
            Documento.Observaciones = txtObservaciones.Text;

            if (!string.IsNullOrEmpty(Documento.Archivo) && File.Exists(Documento.Archivo))
                Documento.Contenido = Utilerias.CargaDocumento(Documento.Archivo);

                

        }

        private void cmdEscriturasSubir_Click(object sender, EventArgs e)
        {
            txtArchivo.Text = Utilerias.SubeDocumento();



        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            ControlesAPropiedades();

            Guardar = true;

            Close();
        }

        private void cmdDocumentoVer_Click(object sender, EventArgs e)
        {

        }
    }
}
