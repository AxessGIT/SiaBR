using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiaBR.Polizas
{
    public partial class PolizasGenerar : Form
    {
        public PolizasGenerar()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se generaron las pólizas","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
