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
    public partial class PropiedadesPlanosAC : Form
    {
        private bool _esAlta;
        public PropiedadPlano Plano { get; set; }
        public bool Guardar { get; set; }

        public PropiedadesPlanosAC(bool esAlta, PropiedadPlano plano)
        {
            _esAlta = esAlta;

            if (_esAlta)
                Plano = new PropiedadPlano();
            else
                Plano = plano;


            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Guardar = false;

            Close();

        }

        private void PropiedadesAControles()
        {
            txtArchivo.Text = Plano.Nombre;
            txtDescripcion.Text = Plano.Descripcion;
        }

        private void ControlesAPropiedades()
        {
            Plano.Nombre = txtArchivo.Text.Trim().ToUpper();
            Plano.Descripcion = txtDescripcion.Text;


            if (!string.IsNullOrEmpty(Plano.Nombre) && File.Exists(Plano.Nombre))
                Plano.Archivo = Utilerias.CargaDocumento(Plano.Nombre);



        }

        private void PropiedadesPlanosAC_Load(object sender, EventArgs e)
        {
            if (_esAlta)
            {
                Text = "Agregar plano";
            }
            else
            {
                Text = "Modificar plano";
                PropiedadesAControles();

            }

        }

        private void cmdDocumentoSubir_Click(object sender, EventArgs e)
        {
            txtArchivo.Text = Utilerias.SubeDocumento();

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


    }
}
