using SiaBR.Helpers;
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
using SiaBR.Modelo;
using Npgsql;

namespace SiaBR.Pagos
{
    public partial class PagosListado : Form
    {
        private BindingList<PagosDatos> _pagos;

        public PagosListado()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BuscaPagos();
            SetGrid();
        }

        private void BuscaPagos()
        {
            _pagos = new BindingList<PagosDatos>();
            int contratoId = 0;
            int folio = (int) txtContrato.IntegerValue;
            if ( folio > 0)
            {
                string sql = $"select ContratoId From Contratos Where Contratos.Folio = {folio}";

                using (NpgsqlConnection db = Utilerias.GetDB())
                {
                    int? res = db.ExecuteScalar<int?>(sql);
                    if (res != null)
                    {
                        contratoId = (int) res;
                    }
                }
            }
            for (int i = cboMesInicial.SelectedIndex; i <= cboMesFinal.SelectedIndex; i++)
            {
                DateTime fecha = new DateTime((int) spnAnio.Value, i+1, 1);

                string sql = Queries.ContratosPagos(contratoId);

                using (NpgsqlConnection db = Utilerias.GetDB())
                {
                    var res = db.Query<ContratoDatos>(sql, new { Fecha = fecha }).ToList();

                    foreach (var con in res)
                    {
                        string sqlPago = Queries.PagoSelect();
                        PagosDatos pago =db.QueryFirstOrDefault<PagosDatos>(sqlPago, 
                            new {ContratoId = con.ContratoId, Anio=spnAnio.Value, Mes = i});

                        bool nuevo = false;

                        if (pago == null)
                        {
                            pago = new PagosDatos();
                            nuevo = true;

                        }

                        if (nuevo)
                        {
                            pago.ContratoId = con.ContratoId;
                            pago.Fecha = DateTime.Now;

                        }
                        pago.Mes = i+1;
                        pago.Folio = con.Folio;
                        pago.ArrendatarioId = con.ArrendatarioId;
                        pago.Renta = con.Renta;
                        pago.Nombre = con.Nombre;




                        _pagos.Add(pago);

                    }

                }
            }



        }

        private void PagosListado_Load(object sender, EventArgs e)
        {
            spnAnio.Value = DateTime.Now.Year;
            Utilerias.SetComboMeses(ref cboMesInicial);
            Utilerias.SetComboMeses(ref cboMesFinal);

            cboMesInicial.SelectedIndex = DateTime.Now.Month - 1;
            cboMesFinal.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void CargaPagos()
        {

        }

        private void SetGrid()
        {

            grdPagos.Columns.Clear();
            grdPagos.DataSource = null;



            grdPagos.AllowUserToAddRows = false;
            grdPagos.AllowUserToDeleteRows = false;


            grdPagos.AutoGenerateColumns = false;
            grdPagos.ReadOnly = false;
            grdPagos.AllowUserToResizeColumns = false;
            grdPagos.AllowUserToResizeRows = false;

            grdPagos.ColumnCount = 6;

            grdPagos.RowHeadersVisible = true;


            grdPagos.ColumnHeadersDefaultCellStyle.Font = new Font(grdPagos.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdPagos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            DataGridViewCheckBoxColumn curCol = new DataGridViewCheckBoxColumn();
            grdPagos.Columns.Insert(0, curCol);

            grdPagos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdPagos.Columns[0].HeaderText = "Sel.";
            grdPagos.Columns[0].DataPropertyName = "Seleccionado";
            grdPagos.Columns[0].Width = 50;


            grdPagos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdPagos.Columns[1].HeaderText = "Con.";
            grdPagos.Columns[1].DataPropertyName = "Folio";
            grdPagos.Columns[1].Width = 50;

            grdPagos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdPagos.Columns[2].HeaderText = "Mes";
            grdPagos.Columns[2].DataPropertyName = "Mes";
            grdPagos.Columns[2].Width = 50;
            grdPagos.Columns[2].ReadOnly = true;


            grdPagos.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            grdPagos.Columns[3].HeaderText = "Fecha";
            grdPagos.Columns[3].DataPropertyName = "Fecha";
            grdPagos.Columns[3].Width = 100;
            grdPagos.Columns[3].ReadOnly = true;


            grdPagos.Columns[4].HeaderText = "Arrendatario";
            grdPagos.Columns[4].DataPropertyName = "Nombre";
            grdPagos.Columns[4].Width = 350;
            grdPagos.Columns[4].ReadOnly = true;

            grdPagos.Columns[5].DefaultCellStyle.Format = "c2";
            grdPagos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdPagos.Columns[5].HeaderText = "Renta";
            grdPagos.Columns[5].DataPropertyName = "Renta";
            grdPagos.Columns[5].Width = 100;
            grdPagos.Columns[5].ReadOnly = true;


            grdPagos.Columns[6].DefaultCellStyle.Format = "c2";
            grdPagos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdPagos.Columns[6].HeaderText = "Pagado";
            grdPagos.Columns[6].DataPropertyName = "Importe";
            grdPagos.Columns[6].Width = 100;
            grdPagos.Columns[6].ReadOnly = true;


            grdPagos.DataSource = _pagos;

        }

        private void cmdSeleccionarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= _pagos.Count - 1; i++)
            {
                _pagos[i].Seleccionado = true;
            }
            SetGrid();
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= _pagos.Count - 1; i++)
            {
                if (!_pagos[i].Seleccionado || _pagos[i].Importe != 0)
                    continue;
                _pagos[i].Importe = _pagos[i].Renta;
            }
            SetGrid();

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= _pagos.Count - 1; i++)
            {
                if (!_pagos[i].Seleccionado)
                    continue;
                _pagos[i].Importe = 0;
            }
            SetGrid();

        }

        private void cmdInvertirSeleccion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= _pagos.Count - 1; i++)
            {
                _pagos[i].Seleccionado = !_pagos[i].Seleccionado;
            }
            SetGrid();


        }
    }
}
