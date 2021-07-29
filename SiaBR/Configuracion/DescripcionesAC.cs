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
using Npgsql;

namespace SiaBR.Configuracion
{
    public partial class DescripcionesAC : Form
    {
        private bool _esAlta;
        private string _tipo;
        private DescripcionCat _descripcion;
        public int DescripcionId { get; set; }
        public string Descripcion { get; set; }

        public DescripcionesAC(string tipo, bool esAlta, int descripcionId)
        {
            _tipo = tipo;
            _esAlta = esAlta;
            DescripcionId = descripcionId;
            InitializeComponent();
        }

        private void DescripcionesAC_Load(object sender, EventArgs e)
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

            lblLetrero.Text = Text;
            if (_esAlta)
            {
                _descripcion = new DescripcionCat();
            }
            else
            {
                CargaDescripcion();
            }


        }

        private void CargaDescripcion()
        {
            string sql = Queries.DescripcionSelect();

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                _descripcion = db.QuerySingleOrDefault<DescripcionCat>(sql, new { DescripcionId = DescripcionId });

            }

            if (_descripcion != null)
            {
                PropiedadesAControles();

            }
        }

        private void PropiedadesAControles()
        {
            txtDescripcion.Text = _descripcion.Descripcion;


        }


        private void ControlesAPropiedades()
        {
            _descripcion.Tipo = _tipo;
            _descripcion.Descripcion = txtDescripcion.Text;
        }


        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            ControlesAPropiedades();
            string sql = _esAlta ? Queries.DescripcionInsert() : Queries.DescripcionUpdate();

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                db.Execute(sql, _descripcion);

            }
            Close();
        }
    }
}
