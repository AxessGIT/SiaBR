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
    public partial class PropiedadesPermisosAC : Form
    {
        private bool _esAlta;
        public PropiedadPermiso Permiso { get; set; }
        public bool Guardar { get; set; }

        public PropiedadesPermisosAC(bool esAlta, PropiedadPermiso permiso)
        {
            _esAlta = esAlta;

            if (_esAlta)
                Permiso = new PropiedadPermiso();
            else
                Permiso = permiso;


            InitializeComponent();
        }


        private void PropiedadesAControles()
        {
            txtArchivo.Text = Permiso.Nombre;
            txtDescripcion.Text = Permiso.Descripcion;
        }

        private void ControlesAPropiedades()
        {
            Permiso.Nombre = txtArchivo.Text.Trim().ToUpper();
            Permiso.Descripcion = txtDescripcion.Text;


            if (!string.IsNullOrEmpty(Permiso.Nombre) && File.Exists(Permiso.Nombre))
                Permiso.Archivo = Utilerias.CargaDocumento(Permiso.Nombre);



        }

        private void PropiedadesPermisosAC_Load(object sender, EventArgs e)
        {
            if (_esAlta)
            {
                Text = "Agregar permiso / licencia";
            }
            else
            {
                Text = "Modificar permiso/licencia";
                PropiedadesAControles();

            }

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
                return;
            ControlesAPropiedades();
            Guardar = true;
            Close();

        }

        private bool ValidaDatos()
        {
            string CadenaDeErrores = "";
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                CadenaDeErrores = "*) Teclee la descripción del documento";

            }

            if (string.IsNullOrEmpty(txtArchivo.Text.Trim()))
            {
                CadenaDeErrores += string.IsNullOrEmpty(CadenaDeErrores) ? "" : "\n";
                CadenaDeErrores += "*) Indique el archivo";
            }

            if (!string.IsNullOrEmpty(CadenaDeErrores))
            {
                MessageBox.Show(CadenaDeErrores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return string.IsNullOrEmpty(CadenaDeErrores);


        }



        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Guardar = false;

            Close();


        }

        private void cmdDocumentoSubir_Click(object sender, EventArgs e)
        {
            txtArchivo.Text = Utilerias.SubeDocumento();

        }

        private void cmdDocumentoVer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
