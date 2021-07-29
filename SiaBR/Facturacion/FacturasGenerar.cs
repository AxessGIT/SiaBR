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
    public partial class FacturasGenerar : Form
    {
        public FacturasGenerar()
        {
            InitializeComponent();
        }

        private void FacturasGenerar_Load(object sender, EventArgs e)
        {
            cboMeses.SelectedIndex = DateTime.Now.Month - 1;
            spnAnios.Value = DateTime.Now.Year;
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se generaron las facturas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
