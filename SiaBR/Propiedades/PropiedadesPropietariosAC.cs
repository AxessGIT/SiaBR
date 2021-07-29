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

namespace SiaBR.Propiedades
{
    public partial class PropiedadesPropietariosAC : Form
    {
        private bool _esAlta;
        public Propietario Propietario { get; set; }
        public bool Guardar { get; set; }


        public PropiedadesPropietariosAC(bool esAlta, Propietario propietario)
        {
            _esAlta = esAlta;

            if (_esAlta)
                Propietario = new Propietario();
            else
                Propietario = propietario;

            InitializeComponent();
        }

        private void PropiedadesPropietariosAC_Load(object sender, EventArgs e)
        {

            if (_esAlta)
            {
                Text = "Agregar propietario";
            }
            else
            {
                Text = "Modificar propietario";
                PropiedadesAControles();

            }


            txtPorcentaje.NumberFormatInfo = Utilerias.GetFormatoDecimal();
        }


        private void PropiedadesAControles()
        {
            txtNombre.Text = Propietario.Nombre;
            txtPorcentaje.Value =(double) Propietario.Porcentaje;
        }

        private void ControlesAPropiedades()
        {
            Propietario.Nombre= txtNombre.Text;
            Propietario.Porcentaje= (decimal)txtPorcentaje.Value;



        }


        private bool ValidaDatos()
        {
            string CadenaDeErrores = "";
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                CadenaDeErrores = "*) Teclee el nombre del propietario";

            }

            if(txtPorcentaje.Value<=0)
            {
                CadenaDeErrores += string.IsNullOrEmpty(CadenaDeErrores) ? "" : "\n";
                CadenaDeErrores += "*) Teclee el porcentaje";
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
                return;

            ControlesAPropiedades();
            Guardar = true;
            Close();
        }
    }
}
