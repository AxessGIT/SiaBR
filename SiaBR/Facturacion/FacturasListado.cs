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

namespace SiaBR.Facturacion
{
    public partial class FacturasListado : Form
    {
        private BindingList<FacturasDatos> _facturas;

        public FacturasListado()
        {
            InitializeComponent();
        }

        private void FacturasListado_Load(object sender, EventArgs e)
        {
            CargaFacturas();
            SetGrid();

        }

        private void CargaFacturas()
        {
            _facturas = new BindingList<FacturasDatos>();
            DateTime fec = new DateTime(DateTime.Now.Year,DateTime.Now.Month,15);

            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30578, Arrendatario = "GRUPO COMERCIAL CENTELLA SA DE CV", ClavePropiedad = "C090878", Importe = 7578.57M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30579, Arrendatario = "JUAN MARTINEZ CENICEROS", ClavePropiedad = "B990875", Importe = 8500.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30580, Arrendatario = "LA FONTAINE BOUTIQUE", ClavePropiedad = "C225478", Importe = 4300.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30581, Arrendatario = "RESTAURANTE EL BUEN COMER SA DE CV", ClavePropiedad = "A854578", Importe = 9900.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30582, Arrendatario = "CLINICA DERMATOLOGICA MIPIEL", ClavePropiedad = "H325689", Importe = 10478.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30583, Arrendatario = "GRUPO DE RADIO NAVA", ClavePropiedad = "L748596", Importe = 3257.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30584, Arrendatario = "CECILIA RIVERA GONZALEZ", ClavePropiedad = "K475896", Importe = 4725.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30585, Arrendatario = "DULCERIA COMETA", ClavePropiedad = "M215632", Importe = 9900.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30586, Arrendatario = "MARTIN DE JESUS RIOS CESEÑAS", ClavePropiedad = "T748596", Importe = 7578.57M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30587, Arrendatario = "TALLER DE PINTURA AUTOPAINT", ClavePropiedad = "S321245", Importe = 14789.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30588, Arrendatario = "TAPICERIA MINESOTA SA DE CV", ClavePropiedad = "R324578", Importe = 19700.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30589, Arrendatario = "GABRIELA MARTINEZ RAMIREZ", ClavePropiedad = "W741265", Importe = 4322.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30590, Arrendatario = "MARIA JOSE PEREZ CISNEROS", ClavePropiedad = "T489652", Importe = 1874.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30591, Arrendatario = "RUBEN CABRAL GOMEZ", ClavePropiedad = "Q369875", Importe = 2500.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30592, Arrendatario = "HECTOR UGARTE MARTINEZ", ClavePropiedad = "P368452", Importe = 3300.00M, Fecha = fec });
            _facturas.Add(new FacturasDatos { FacturaId = 1, Serie = "A", Folio = 30593, Arrendatario = "DAVID LOPEZ GONZALEZ", ClavePropiedad = "L953421", Importe = 6600.00M, Fecha = fec });



        }

        private void SetGrid()
        {
            grdFacturas.DataSource = null;



            grdFacturas.AllowUserToAddRows = false;
            grdFacturas.AllowUserToDeleteRows = false;


            grdFacturas.AutoGenerateColumns = false;
            grdFacturas.ReadOnly = true;
            grdFacturas.AllowUserToResizeColumns = false;
            grdFacturas.AllowUserToResizeRows = false;

            grdFacturas.ColumnCount = 6;

            grdFacturas.RowHeadersVisible = true;


            grdFacturas.ColumnHeadersDefaultCellStyle.Font = new Font(grdFacturas.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdFacturas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdFacturas.Columns[0].HeaderText = "Serie";

            grdFacturas.Columns[0].DataPropertyName = "Serie";
            grdFacturas.Columns[0].Width = 70;

            grdFacturas.Columns[1].HeaderText = "Folio";
            grdFacturas.Columns[1].DataPropertyName = "Folio";
            grdFacturas.Columns[1].Width = 70;

            grdFacturas.Columns[2].HeaderText = "Fecha";
            grdFacturas.Columns[2].DataPropertyName = "Fecha";
            grdFacturas.Columns[2].Width = 80;

            grdFacturas.Columns[3].HeaderText = "Propiedad";
            grdFacturas.Columns[3].DataPropertyName = "ClavePropiedad";
            grdFacturas.Columns[3].Width = 100;

            grdFacturas.Columns[4].HeaderText = "Arrendatario";
            grdFacturas.Columns[4].DataPropertyName = "Arrendatario";
            grdFacturas.Columns[4].Width = 200;

            grdFacturas.Columns[5].DefaultCellStyle.Format = "c";
            grdFacturas.Columns[5].HeaderText = "Importe";
            grdFacturas.Columns[5].DataPropertyName = "Importe";
            grdFacturas.Columns[5].Width = 100;




            grdFacturas.DataSource = _facturas;

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            FacturasGenerar facturasGenerar = new FacturasGenerar();
            facturasGenerar.ShowDialog();
        }
    }
}
