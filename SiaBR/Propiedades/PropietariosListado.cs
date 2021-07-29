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
    public partial class PropietariosListado : Form
    {
        public PropietariosListado()
        {
            InitializeComponent();
        }

        private void PropietariosListado_Load(object sender, EventArgs e)
        {

        }

        private void PropietariosAltasCambios(bool esAlta)
        {
            PropietariosAC propietariosAC = new PropietariosAC();
            propietariosAC.ShowDialog();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            PropietariosAltasCambios(true);
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            PropietariosAltasCambios(false);
        }
    }
}
