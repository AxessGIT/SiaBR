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
using SiaBR.Helpers;

namespace SiaBR.Configuracion
{
    public partial class DescripcionesListado : Form
    {
        private string _tipo;
        private BindingList<DescripcionCat> _descripciones;

        public DescripcionesListado(string tipo)
        {
            _tipo = tipo;
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DescripcionesListado_Load(object sender, EventArgs e)
        {
            switch (_tipo)
            {
                case "CIU":
                    Text = "Catálogo de ciudades";
                    break;
                case "TIP":
                    Text = "Tipos de propiedades";
                    break;
                case "EDO":
                    Text = "Catálogo de estados";
                    break;
                case "DES":
                    Text = "Catálogo de desarrollos";
                    break;
                case "UBI":
                    Text = "Catálogo de ubicaciones";
                    break;

            }
            SetGrid();

        }

        private void SetGrid()
        {
            _descripciones = Utilerias.DevuelveListaDescripcion(_tipo);

            grdDescripciones.DataSource = null;



            grdDescripciones.AllowUserToAddRows = false;
            grdDescripciones.AllowUserToDeleteRows = false;


            grdDescripciones.AutoGenerateColumns = false;
            grdDescripciones.ReadOnly = true;
            grdDescripciones.AllowUserToResizeColumns = false;
            grdDescripciones.AllowUserToResizeRows = false;

            grdDescripciones.ColumnCount = 1;

            grdDescripciones.RowHeadersVisible = true;


            grdDescripciones.ColumnHeadersDefaultCellStyle.Font = new Font(grdDescripciones.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdDescripciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdDescripciones.Columns[0].HeaderText = "Descripcion";

            grdDescripciones.Columns[0].DataPropertyName = "Descripcion";
            grdDescripciones.Columns[0].Width = 200;
            grdDescripciones.DataSource = _descripciones;

        }

        private void AltasCambios(bool esAlta)
        {
            int descripcionId = 0;
            if (!esAlta)
            {
                descripcionId = _descripciones[grdDescripciones.CurrentRow.Index].DescripcionId;
            }
            DescripcionesAC descripcionesAC = new DescripcionesAC(_tipo, esAlta, descripcionId);
            descripcionesAC.ShowDialog();
            SetGrid();
            
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            AltasCambios(true);
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (grdDescripciones.CurrentRow==null)
            {
                MessageBox.Show("Seleccione el registro a modificar", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning );
                return;
            }
            AltasCambios(false);
        }
    }
}
