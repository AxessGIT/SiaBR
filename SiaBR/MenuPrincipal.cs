using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Dapper;
using SiaBR.Helpers;
using SiaBR.Configuracion;
using SiaBR.General;
using SiaBR.Propiedades;
using SiaBR.Facturacion;
using SiaBR.Polizas;
using SiaBR.Arrendatarios;
using SiaBR.Contratos;
using SiaBR.Pagos;

namespace SiaBR
{
    public partial class MenuPrincipal : Form
    {
        private bool _primeraVez = true;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Activated(object sender, EventArgs e)
        {
            if (!_primeraVez)
                return;

            using (NpgsqlConnection db = Utilerias.GetDB()) { 

                if (db==null)
                {
                    ConexionDatos conexionDatos = new ConexionDatos();
                    conexionDatos.ShowDialog();

                    if (conexionDatos._salida == DialogResult.Cancel)
                    {
                        Close();
                        return;
                    }
                    
                }
            }

            Login login = new Login();
            login.ShowDialog();

            if (Properties.Settings.Default.UsrId == 0 || login._salida== DialogResult.Cancel)
            {
                Close();
                return;
            }

            EmpresasListado empresasListado = new EmpresasListado(false);
            empresasListado.ShowDialog();

            if (Properties.Settings.Default.EmpresaId==0)
            {
                Close();
                return;
            }


            _primeraVez = false;

            

        }

        private void cmdPropiedades_Click(object sender, EventArgs e)
        {
            PropiedadesListado propiedadesListado = new PropiedadesListado();
            propiedadesListado.ShowDialog();
        }

        private void cmdConfiguración_Click(object sender, EventArgs e)
        {
            ConfiguracionMenu configuracionMenu = new ConfiguracionMenu();
            configuracionMenu.ShowDialog();
        }

        private void cmdFacturas_Click(object sender, EventArgs e)
        {
            FacturacionMenu facturacionMenu = new FacturacionMenu();
            facturacionMenu.ShowDialog();
        }

        private void cmdPolizas_Click(object sender, EventArgs e)
        {
            PolizasGenerar polizasGenerar = new PolizasGenerar();
            polizasGenerar.ShowDialog();
        }

        private void cmdArrendatarios_Click(object sender, EventArgs e)
        {
            ArrendatariosListado arrendatariosListado = new ArrendatariosListado();
            arrendatariosListado.ShowDialog();
        }

        private void cmdArrendamientos_Click(object sender, EventArgs e)
        {

            ContratosListado contratosListado = new ContratosListado();
            contratosListado.ShowDialog();
            


        }

        private void cmdPagos_Click(object sender, EventArgs e)
        {
            PagosListado pagosListado = new PagosListado();
            pagosListado.ShowDialog();
        }
    }
}
