using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiaBR.Configuracion
{
    public partial class ConfiguracionMenu : Form
    {
        public ConfiguracionMenu()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosListado usuariosListado = new UsuariosListado();
            usuariosListado.ShowDialog();
        }

        private void ConfiguracionMenu_Load(object sender, EventArgs e)
        {

        }

        private void MantenimientoCatalogo(string tipo)
        {
            DescripcionesListado cat = new DescripcionesListado(tipo);
            cat.ShowDialog();
        }

        private void cmdTipos_Click(object sender, EventArgs e)
        {
            MantenimientoCatalogo("TIP");
        }

        private void cmdDesarrollos_Click(object sender, EventArgs e)
        {
            MantenimientoCatalogo("DES");

        }

        private void cmdUbicaciones_Click(object sender, EventArgs e)
        {
            MantenimientoCatalogo("UBI");

        }

        private void cmdCiudades_Click(object sender, EventArgs e)
        {
            MantenimientoCatalogo("CIU");

        }

        private void cmdEstados_Click(object sender, EventArgs e)
        {
            MantenimientoCatalogo("EDO");

        }

        private void cmdTiposDocs_Click(object sender, EventArgs e)
        {
            MantenimientoCatalogo("TID");

        }
    }
}
