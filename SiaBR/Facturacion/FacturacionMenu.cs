using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiaBR.Facturacion
{
    public partial class FacturacionMenu : Form
    {
        public FacturacionMenu()
        {
            InitializeComponent();
        }

        private void cmdsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdRevisarFacturas_Click(object sender, EventArgs e)
        {
            FacturasListado facturasListado = new FacturasListado();
            facturasListado.ShowDialog();
        }
    }
}
