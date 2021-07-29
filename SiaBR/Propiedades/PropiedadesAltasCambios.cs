using SiaBR.Helpers;
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
using Npgsql;
using System.IO;

namespace SiaBR.Propiedades
{
    public partial class PropiedadesAltasCambios : Form
    {
        private bool _esAlta;
        private int _propiedadId;
        private Propiedad _propiedad;
        private BindingList<PropiedadDocumento> _documentos;
        private BindingList<Propietario> _propietarios;
        private BindingList<PropiedadPermiso> _permisos;
        private List<PropiedadRecibo> _recibos;
        private BindingList<PropiedadPlano> _planos;
        private BindingList<ContratoDatos> _contratos;
        private ContratoUltimoDatos _ultimoContrato = new ContratoUltimoDatos();


        public PropiedadesAltasCambios(bool esAlta, int propiedadId)
        {
            _esAlta = esAlta;
            _propiedadId = propiedadId;
            InitializeComponent();
        }

        private void PropiedadesAltasCambios_Load(object sender, EventArgs e)
        {
            SetCombos();
            if (_esAlta)
            {
                Text = "Agregar propiedad";
                _propiedad = new Propiedad();
                _propiedad.EmpresaId = Properties.Settings.Default.EmpresaId;
            }
            else
            {
                string sql = Queries.PropiedadSelect();

                using (NpgsqlConnection db = Utilerias.GetDB())
                {
                    _propiedad = db.QueryFirstOrDefault<Propiedad>(sql, new { PropiedadId = _propiedadId });
                }

                PropiedadesAControles();

            }
            SetDataSources();
            cboMonedas.SelectedIndex = 0;
        }
        private void SetCombos()
        {
            Utilerias.ConfiguraCombo(ref cboTiposPropiedades, "TIP");
            Utilerias.ConfiguraCombo(ref cboDesarrollos, "DES");
            Utilerias.ConfiguraCombo(ref cboUbicaciones, "UBI");
            Utilerias.ConfiguraCombo(ref cboCiudades, "CIU");
            Utilerias.ConfiguraCombo(ref cboEstados, "EDO");

        }

        private void SetDataSources()
        {
            _documentos = new BindingList<PropiedadDocumento>();
            _propietarios = new BindingList<Propietario>();
            _permisos = new BindingList<PropiedadPermiso>();
            _planos = new BindingList<PropiedadPlano>();

            _recibos = new List<PropiedadRecibo>();
            for (int i=0;i<=7;i++)
            {
                _recibos.Add(new PropiedadRecibo { Anio = DateTime.Now.Year, Mes = DateTime.Now.Month, Tipo = i });
            }


        }

        private void PropiedadesAControles()
        {
            txtClave.Text = _propiedad.Clave;
            cboTiposPropiedades.SelectedValue = _propiedad.TipoId;
            cboDesarrollos.SelectedValue = _propiedad.DesarrolloId;
            cboUbicaciones.SelectedValue = _propiedad.UbicacionId;
            txtCoordenadas.Text= _propiedad.Coordenadas;

            txtCalle.Text = _propiedad.Calle;
            txtNumeroExterior.Text = _propiedad.NumExt;
            txtNumeroInterior.Text = _propiedad.NumInt;
            txtColonia.Text = _propiedad.Colonia;
            cboCiudades.SelectedValue = _propiedad.CiudadId;
            cboEstados.SelectedValue = _propiedad.EstadoId;
            txtPais.Text = _propiedad.Pais;
            txtCP.Text = _propiedad.CP;

            if (_propiedad.Foto != null)
            {
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = _propiedad.Foto;
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                picFoto.Image = Image.FromStream(stmBLOBData);
            }

            txtRenta.DecimalValue = _propiedad.Renta;
            cboMonedas.SelectedIndex = (int)_propiedad.Moneda;


            txtEscrituras.Text = _propiedad.EscriturasNombre;
            txtCertificado.Text = _propiedad.CertificadoLGNombre;
            txtFotos.Text = _propiedad.FotosNombre;
            txtUsoDeSuelo.Text = _propiedad.UsoSueloNombre;
            txtPresupuestos.Text = _propiedad.PresupuestosNombre;
            txtPredial.Text = _propiedad.PredialNombre;

            txtClaveCatastral.Text = _propiedad.ClaveCatastral;
            txtAreaTerreno.Value = (double)_propiedad.AreaTerreno;
            txtAreaConstruccion.Value = (double)_propiedad.AreaConstruccion;
            txtFondo.Value = (double)_propiedad.Fondo;
            txtFrente.Value = (double)_propiedad.Frente;
            txtValorCatastral.DecimalValue = _propiedad.ValorCatastral;
            txtValorComercial.DecimalValue = _propiedad.ValorComercial;

            txtLevantamiento.Text = _propiedad.LevantamientoNombre;




        }
        private void ControlesAPropiedades()
        {
            _propiedad.Clave= txtClave.Text;
            _propiedad.TipoId = (int)Utilerias.DevuelveValorCombo(cboTiposPropiedades, "TIP");
            _propiedad.DesarrolloId = (int)Utilerias.DevuelveValorCombo(cboDesarrollos, "DES");
            _propiedad.UbicacionId= (int)Utilerias.DevuelveValorCombo(cboUbicaciones, "UBI");
            _propiedad.Coordenadas = txtCoordenadas.Text;
            _propiedad.Calle = txtCalle.Text;
            _propiedad.NumExt = txtNumeroExterior.Text;
            _propiedad.NumInt = txtNumeroInterior.Text;
            _propiedad.Colonia = txtColonia.Text;
            _propiedad.CiudadId = (int)Utilerias.DevuelveValorCombo(cboCiudades, "CIU");
            _propiedad.EstadoId = (int)Utilerias.DevuelveValorCombo(cboEstados, "EDO");
            _propiedad.Pais = txtPais.Text;
            _propiedad.CP = txtCP.Text;

            var ms = new MemoryStream();

            picFoto.Image.Save(ms, picFoto.Image.RawFormat);

            _propiedad.Foto = ms.ToArray();
            _propiedad.Renta = txtRenta.DecimalValue;
            _propiedad.Moneda = cboMonedas.SelectedIndex;



            _propiedad.ClaveCatastral= txtClaveCatastral.Text;
            _propiedad.AreaTerreno= (decimal) txtAreaTerreno.Value;
            _propiedad.AreaConstruccion= (decimal) txtAreaConstruccion.Value;
            _propiedad.Fondo= (decimal) txtFondo.Value;
            _propiedad.Frente= (decimal) txtFrente.Value;
            _propiedad.ValorCatastral= txtValorCatastral.DecimalValue;
            _propiedad.ValorComercial= txtValorComercial.DecimalValue;

        }


        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            ControlesAPropiedades();
            string sql = _esAlta ? Queries.PropiedadInsert() : Queries.PropiedadUpdate();

            using (NpgsqlConnection db = Utilerias.GetDB()) { 

                if (_esAlta) { 
                    _propiedadId = db.QuerySingle<int>(sql, _propiedad);
                    _propiedad.PropiedadId = _propiedadId;
                }
                else {                     
                    db.Execute(sql, _propiedad);                   
                }
            }

            BorraPermisos();
            GuardaPermisos();

            BorraPropietarios();
            GuardaPropietarios();

            BorraRecibos();
            GuardaRecibos();

            BorraPlanos();
            GuardaPlanos();


            Close();

        }



        private void pagGenerales_Click(object sender, EventArgs e)
        {

        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdPropietarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Propietarios

        private void pagPropietarios_Enter(object sender, EventArgs e)
        {
            if (!_esAlta)
                CargaPropietarios();

            SetGridPropietarios();

        }


        private void CargaPropietarios()
        {

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                string sql = Queries.PropietariosSelect();
                var res = db.Query<Propietario>(sql, new { PropiedadId = _propiedadId }).ToList();
                _propietarios = new BindingList<Propietario>(res);
            }
        }

        private void SetGridPropietarios()
        {
            grdPropietarios.DataSource = null;



            grdPropietarios.AllowUserToAddRows = false;
            grdPropietarios.AllowUserToDeleteRows = false;


            grdPropietarios.AutoGenerateColumns = false;
            grdPropietarios.ReadOnly = true;
            grdPropietarios.AllowUserToResizeColumns = false;
            grdPropietarios.AllowUserToResizeRows = false;

            grdPropietarios.ColumnCount = 2;

            grdPropietarios.RowHeadersVisible = true;


            grdPropietarios.ColumnHeadersDefaultCellStyle.Font = new Font(grdPropietarios.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdPropietarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdPropietarios.Columns[0].HeaderText = "Nombre /razon social";
            grdPropietarios.Columns[0].DataPropertyName = "Nombre";
            grdPropietarios.Columns[0].Width = 200;

            grdPropietarios.Columns[1].HeaderText = "Porcentaje";
            grdPropietarios.Columns[1].DataPropertyName = "Porcentaje";
            grdPropietarios.Columns[1].Width = 200;

            grdPropietarios.DataSource = _propietarios;

        }

        private void pagPropietarios_Click(object sender, EventArgs e)
        {

        }

        private void cmdPropietariosAgregar_Click(object sender, EventArgs e)
        {

            PropietariosAltasCambios(true);
        }

        private void PropietariosAltasCambios(bool esAlta)
        {
            Propietario prop = new Propietario();

            if (!esAlta)
            {
                prop = _propietarios[grdPropietarios.CurrentRow.Index];
            }


            PropiedadesPropietariosAC propiedadesPropietariosAC = new PropiedadesPropietariosAC(esAlta,prop);
            propiedadesPropietariosAC.ShowDialog();

            if (propiedadesPropietariosAC.Guardar)
            {
                if (esAlta)
                {
                    _propietarios.Add(propiedadesPropietariosAC.Propietario);
                }
                else
                {
                    var propFind = _propietarios.SingleOrDefault(x => x.PropiedadPropietarioId == prop.PropiedadPropietarioId);
                    if (propFind != null)
                    {
                        _propietarios[_propietarios.IndexOf(propFind)] = propiedadesPropietariosAC.Propietario;
                    }

                }

            }
            SetGridPropietarios();

        }

        private void cmdPropietariosModificar_Click(object sender, EventArgs e)
        {
            PropietariosAltasCambios(false);

        }



        private void BorraPropietarios()
        {

            string sql = Queries.PropietariosDelete();
            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                db.Execute(sql, new { PropiedadId = _propiedadId });
            }


        }

        private void GuardaPropietarios()
        {
            string sql = Queries.PropietarioInsert();

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                foreach (var prop in _propietarios)
                {
                    prop.PropiedadId = _propiedadId;
                    db.Execute(sql, prop);


                }
            }

        }


        #endregion 

        #region Documentos


        #region Permisos
        private void cmdPermisosAgregar_Click(object sender, EventArgs e)
        {
            PermisosAltasCambios(true);
        }


        private void cmdPermisosVer_Click(object sender, EventArgs e)
        {
            if (grdPermisos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un permiso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int indice = grdPermisos.CurrentRow.Index;

            Utilerias.VeDocumento(_permisos[indice].Nombre,_permisos[indice].Archivo);
        }

        private void cmdPermisosModificar_Click(object sender, EventArgs e)
        {
            if (grdPermisos.CurrentRow==null)
            {
                MessageBox.Show("Seleccione un permiso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            PermisosAltasCambios(false);
        }


        private void cmdPermisosBorrar_Click(object sender, EventArgs e)
        {
            if (grdPermisos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un permiso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _permisos.RemoveAt(grdPermisos.CurrentRow.Index);

        }

        private void PermisosAltasCambios(bool esAlta)
        {

            PropiedadPermiso perm = new PropiedadPermiso();

            if (esAlta == false)
            {
                perm = _permisos[grdPermisos.CurrentRow.Index];
            }
            PropiedadesPermisosAC propiedadesPermisosAC  = new PropiedadesPermisosAC(esAlta, perm);
            propiedadesPermisosAC.ShowDialog();

            if (propiedadesPermisosAC.Guardar)
            {
                if (esAlta)
                {
                    _permisos.Add(propiedadesPermisosAC.Permiso);
                }
                else
                {
                    var permFind = _permisos.SingleOrDefault(x => x.PropiedadPermisoId == perm.PropiedadPermisoId);
                    if (permFind != null)
                    {
                        _permisos[_permisos.IndexOf(permFind)] = propiedadesPermisosAC.Permiso;
                    }

                }

            }
            SetGridPermisos();


        }

        private void pagDocumentos_Enter(object sender, EventArgs e)
        {


            if (_esAlta == false)
                CargaPermisos();

            SetGridPermisos();
        }

        private void CargaPermisos()
        {

            using (NpgsqlConnection db = Utilerias.GetDB())
            {

                string sql = Queries.PermisosSelect();
                var res = db.Query<PropiedadPermiso>(sql, new { PropiedadId = _propiedadId }).ToList();
                _permisos = new BindingList<PropiedadPermiso>(res);

            }
        }

        private void SetGridPermisos()
        {
            grdPermisos.DataSource = null;



            grdPermisos.AllowUserToAddRows = false;
            grdPermisos.AllowUserToDeleteRows = false;


            grdPermisos.AutoGenerateColumns = false;
            grdPermisos.ReadOnly = true;
            grdPermisos.AllowUserToResizeColumns = false;
            grdPermisos.AllowUserToResizeRows = false;

            grdPermisos.ColumnCount = 1;

            grdPermisos.RowHeadersVisible = true;


            grdPermisos.ColumnHeadersDefaultCellStyle.Font = new Font(grdPlanos.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdPermisos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdPermisos.Columns[0].HeaderText = "Descripción";
            grdPermisos.Columns[0].DataPropertyName = "Descripcion";
            grdPermisos.Columns[0].Width = 200;


            grdPermisos.DataSource = _permisos;

        }


        private void GuardaPermisos()
        {
            string sql = Queries.PermisoInsert();
            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                foreach (var per in _permisos)
                {
                    per.PropiedadId = _propiedadId;
                    db.Execute(sql, per);


                }
            }

        }

        #endregion


        private void BorraPermisos()
        {

            string sql = Queries.PermisosDelete();
            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                db.Execute(sql, new { PropiedadId = _propiedadId });
            }


        }





        #endregion

        private void pagDocumentos_Click(object sender, EventArgs e)
        {

        }

        private void lnkAbrirMapa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCoordenadas.Text.Trim()))
            {
                MessageBox.Show("indique las coordenadas de la propiedad","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            string url="https://www.google.com/maps/place/"+txtCoordenadas.Text.Trim();
            Task.Run(() => System.Diagnostics.Process.Start(url));
        }

        private void pagInformacionTecnica_Click(object sender, EventArgs e)
        {

        }

        private void pagInformacionTecnica_Enter(object sender, EventArgs e)
        {
            txtAreaTerreno.NumberFormatInfo = Utilerias.GetFormatoDecimal();
            txtAreaConstruccion.NumberFormatInfo = Utilerias.GetFormatoDecimal();

            txtFrente.NumberFormatInfo = Utilerias.GetFormatoDecimal();
            txtFondo.NumberFormatInfo = Utilerias.GetFormatoDecimal();
            CargaPlanos();
            SetGridPlanos();

        }


        private void CargaPlanos()
        {

            using (NpgsqlConnection db = Utilerias.GetDB())
            {

                string sql = Queries.PlanosSelect();
                var res = db.Query<PropiedadPlano>(sql, new { PropiedadId = _propiedadId }).ToList();
                _planos = new BindingList<PropiedadPlano>(res);

            }
        }

        private void SetGridPlanos()
        {
            grdPlanos.DataSource = null;



            grdPlanos.AllowUserToAddRows = false;
            grdPlanos.AllowUserToDeleteRows = false;


            grdPlanos.AutoGenerateColumns = false;
            grdPlanos.ReadOnly = true;
            grdPlanos.AllowUserToResizeColumns = false;
            grdPlanos.AllowUserToResizeRows = false;

            grdPlanos.ColumnCount = 1;

            grdPlanos.RowHeadersVisible = true;


            grdPlanos.ColumnHeadersDefaultCellStyle.Font = new Font(grdPlanos.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdPlanos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdPlanos.Columns[0].HeaderText = "Descripción";
            grdPlanos.Columns[0].DataPropertyName = "Descripcion";
            grdPlanos.Columns[0].Width = 200;


            grdPlanos.DataSource = _planos;

        }


        private void cmdEscriturasSubir_Click(object sender, EventArgs e)
        {
            
            _propiedad.EscriturasArchivo = Utilerias.CargaDocumento(ref txtEscrituras);
            _propiedad.EscriturasNombre = txtEscrituras.Text.Trim().ToUpper();
        }

        private void cmdEscriturasVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(txtEscrituras.Text.Trim().ToUpper(), _propiedad.EscriturasArchivo);
        }

        private void cmdCertificadoSubir_Click(object sender, EventArgs e)
        {
            _propiedad.CertificadoLGArchivo = Utilerias.CargaDocumento(ref txtCertificado);
            _propiedad.CertificadoLGNombre = txtCertificado.Text.Trim().ToUpper();

        }

        private void cmdCertificadoVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(txtCertificado.Text.Trim().ToUpper(), _propiedad.CertificadoLGArchivo);

        }

        private void cmdFotosSubir_Click(object sender, EventArgs e)
        {
            _propiedad.FotosArchivo = Utilerias.CargaDocumento(ref txtFotos);
            _propiedad.FotosNombre = txtFotos.Text.Trim().ToUpper();

        }

        private void cmdFotosVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(txtFotos.Text.Trim().ToUpper(), _propiedad.FotosArchivo);

        }

        private void cmdUsoDeSueloSubir_Click(object sender, EventArgs e)
        {
            _propiedad.UsoSueloArchivo = Utilerias.CargaDocumento(ref txtUsoDeSuelo);
            _propiedad.UsoSueloNombre= txtUsoDeSuelo.Text.Trim().ToUpper();

        }

        private void cmdUsoDeSueloVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(txtUsoDeSuelo.Text.Trim().ToUpper(), _propiedad.UsoSueloArchivo);

        }

        private void cmdPresupuestosSubir_Click(object sender, EventArgs e)
        {
            _propiedad.PresupuestosArchivo = Utilerias.CargaDocumento(ref txtPresupuestos);
            _propiedad.PresupuestosNombre = txtPresupuestos.Text.Trim().ToUpper();

        }

        private void cmdPresupuestosVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(txtPresupuestos.Text.Trim().ToUpper(), _propiedad.PresupuestosArchivo);

        }

        private void cmdPredialSubir_Click(object sender, EventArgs e)
        {
            _propiedad.PredialArchivo = Utilerias.CargaDocumento(ref txtPredial);
            _propiedad.PredialNombre = txtPredial.Text.Trim().ToUpper();

        }

        private void cmdPredialVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(txtPredial.Text.Trim().ToUpper(), _propiedad.PredialArchivo);

        }

        private void cmdPropietariosBorrar_Click(object sender, EventArgs e)
        {
            if (grdPropietarios.CurrentRow==null)
            {
                MessageBox.Show("Seleccione el propietario","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            _propietarios.RemoveAt(grdPropietarios.CurrentRow.Index);
        }

        #region Recibos
        private void pagRecibosServicios_Enter(object sender, EventArgs e)
        {

            CargaRecibos();
        }

        private void CargaRecibos()
        {
            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                string sql = Queries.RecibosSelect();
                var res = db.Query<PropiedadRecibo>(sql, new { PropiedadId = _propiedadId, Anio = DateTime.Now.Year, mes = DateTime.Now.Month }).ToList();

                foreach (var rec in res)
                {
                    _recibos[rec.Tipo].Nombre = rec.Nombre;
                    _recibos[rec.Tipo].Archivo = rec.Archivo;
                }
            }

        }

        private void cmdAguaSubir_Click(object sender, EventArgs e)
        {
            SubirRecibo(0);
        }


        private void cmdElectricidadSubir_Click(object sender, EventArgs e)
        {
            SubirRecibo(1);

        }

        private void cmdGasSubir_Click(object sender, EventArgs e)
        {
            SubirRecibo(2);

        }

        private void cmdTelefonoSubir_Click(object sender, EventArgs e)
        {
            SubirRecibo(3);

        }

        private void cmdInternetSubir_Click(object sender, EventArgs e)
        {
            SubirRecibo(4);

        }

        private void cmdOtrosSubir_Click(object sender, EventArgs e)
        {
            SubirRecibo(5);

        }

        private void cmdMantenimientoSubir_Click(object sender, EventArgs e)
        {
            SubirRecibo(6);

        }

        private void cmdContratosSubir_Click(object sender, EventArgs e)
        {
            SubirRecibo(7);

        }


        private void cmdAguaVer_Click(object sender, EventArgs e)
        {
            VerRecibos(0);
        }

        private void cmdElectricidadVer_Click(object sender, EventArgs e)
        {
            VerRecibos(1);

        }

        private void cmdGasVer_Click(object sender, EventArgs e)
        {
            VerRecibos(2);

        }

        private void cmdTelefonoVer_Click(object sender, EventArgs e)
        {
            VerRecibos(3);

        }

        private void cmdInternetVer_Click(object sender, EventArgs e)
        {
            VerRecibos(4);

        }

        private void cmdOtrosVer_Click(object sender, EventArgs e)
        {
            VerRecibos(5);

        }

        private void cmdMantenimientoVer_Click(object sender, EventArgs e)
        {
            VerRecibos(6);

        }

        private void cmdContratosVer_Click(object sender, EventArgs e)
        {
            VerRecibos(7);

        }


        private void SubirRecibo (int tipo)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            _recibos[tipo].Nombre = openFileDialog.FileName;
            _recibos[tipo].Archivo = Utilerias.CargaDocumento(openFileDialog.FileName);
        }

        private void VerRecibos(int tipo)
        {
            Utilerias.VeDocumento(_recibos[tipo].Nombre, _recibos[tipo].Archivo);
        }


        private void BorraRecibos()
        {
            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                string sql = Queries.RecibosDelete();
                db.Execute(sql, new { PropiedadId = _propiedadId, Anio = DateTime.Now.Year, Mes = DateTime.Now.Month });


            }
        }

        private void GuardaRecibos()
        {
            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                string sql = Queries.ReciboInsert();

                foreach (var rec in _recibos)
                {
                    if (string.IsNullOrEmpty(rec.Nombre))
                        continue;

                    rec.PropiedadId = _propiedadId;
                    db.Execute(sql, rec);

                }


            }
        }



        #endregion

        private void cmdLevantamientoSubir_Click(object sender, EventArgs e)
        {
            _propiedad.LevantamientoArchivo = Utilerias.CargaDocumento(ref txtLevantamiento);
            _propiedad.LevantamientoNombre = txtLevantamiento.Text.Trim().ToUpper();

        }

        private void cmdLevantamientoVer_Click(object sender, EventArgs e)
        {
            Utilerias.VeDocumento(_propiedad.LevantamientoNombre, _propiedad.LevantamientoArchivo);
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbreArchivo = new OpenFileDialog();
            ofdAbreArchivo.ShowDialog();
            if (ofdAbreArchivo.FileName == string.Empty)
            {
                return;
            }

            picFoto.Image = Image.FromFile(ofdAbreArchivo.FileName);

        }

        private void pagArrendamientoActual_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void cboAnios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdPlanosAgregar_Click(object sender, EventArgs e)
        {

            PlanosAltasCambios(true);
        }

        private void PlanosAltasCambios(bool esAlta)
        {
            PropiedadPlano plano = new PropiedadPlano();

            if (esAlta == false)
            {
                plano = _planos[grdPlanos.CurrentRow.Index];
            }

            PropiedadesPlanosAC propiedadesPlanosAC = new PropiedadesPlanosAC(esAlta,plano);
            propiedadesPlanosAC.ShowDialog();

            if (propiedadesPlanosAC.Guardar)
            {
                if (esAlta)
                {
                    _planos.Add(propiedadesPlanosAC.Plano);
                }
                else
                {
                    var planoFind = _planos.SingleOrDefault(x => x.PropiedadPlanoId == plano.PropiedadPlanoId);
                    if (planoFind != null)
                    {
                        _planos[_planos.IndexOf(planoFind)] = propiedadesPlanosAC.Plano;
                    }

                }

            }
            SetGridPlanos();



        }

        private void cmdPlanosModificar_Click(object sender, EventArgs e)
        {
            PlanosAltasCambios(false);

        }


        private void BorraPlanos()
        {

            string sql = Queries.PlanosDelete();
            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                db.Execute(sql, new { PropiedadId = _propiedadId });
            }


        }

        private void GuardaPlanos()
        {
            string sql = Queries.PlanoInsert();

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                foreach (var plano in _planos)
                {
                    plano.PropiedadId = _propiedadId;
                    db.Execute(sql, plano);


                }
            }

        }

        private void cmdPlanosVer_Click(object sender, EventArgs e)
        {
            if (grdPlanos.CurrentRow == null)
            {
                MessageBox.Show("seleccione el plano a ver","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            string nombre = _planos[grdPlanos.CurrentRow.Index].Nombre;
            byte[] archivo = _planos[grdPlanos.CurrentRow.Index].Archivo;
            Utilerias.VeDocumento(nombre,archivo);

        }

        private void cmdPlanosBorrar_Click(object sender, EventArgs e)
        {
            if (grdPlanos.CurrentRow == null)
            {
                MessageBox.Show("seleccione el plano a borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _planos.RemoveAt(grdContratos.CurrentRow.Index);
        }

        private void pagContratos_Click(object sender, EventArgs e)
        {

        }

        private void pagContratos_Enter(object sender, EventArgs e)
        {
            CargaContratos();
            SetGridContratos();
        }

        private void CargaContratos()
        {
            string sql = Queries.ContratosSelectxPropiedad();

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                var res = db.Query<ContratoDatos>(sql, new {PropiedadId = _propiedadId }).ToList();
                _contratos = new BindingList<ContratoDatos>(res);

            }

        }

        private void SetGridContratos()
        {

            grdContratos.DataSource = null;



            grdContratos.AllowUserToAddRows = false;
            grdContratos.AllowUserToDeleteRows = false;


            grdContratos.AutoGenerateColumns = false;
            grdContratos.ReadOnly = true;
            grdContratos.AllowUserToResizeColumns = false;
            grdContratos.AllowUserToResizeRows = false;

            grdContratos.ColumnCount = 5;

            grdContratos.RowHeadersVisible = true;


            grdContratos.ColumnHeadersDefaultCellStyle.Font = new Font(grdContratos.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdContratos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdContratos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdContratos.Columns[0].HeaderText = "Folio";
            grdContratos.Columns[0].DataPropertyName = "Folio";
            grdContratos.Columns[0].Width = 50;

            grdContratos.Columns[1].HeaderText = "Arrendatario";
            grdContratos.Columns[1].DataPropertyName = "Nombre";
            grdContratos.Columns[1].Width = 350;

            grdContratos.Columns[2].HeaderText = "Fecha inicial";
            grdContratos.Columns[2].DataPropertyName = "FechaInicial";
            grdContratos.Columns[2].Width = 100;

            grdContratos.Columns[3].HeaderText = "Fecha final";
            grdContratos.Columns[3].DataPropertyName = "FechaFinal";
            grdContratos.Columns[3].Width = 100;



            grdContratos.Columns[4].DefaultCellStyle.Format = "c2";
            grdContratos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdContratos.Columns[4].HeaderText = "Renta";
            grdContratos.Columns[4].DataPropertyName = "Renta";
            grdContratos.Columns[4].Width = 150;


            grdContratos.DataSource = _contratos;

        }

        private void pagArrendamientoActual_Enter(object sender, EventArgs e)
        {
            CargaUltimoArrendamiento();
        }

        private void CargaUltimoArrendamiento()
        {


            string sql = Queries.ContratoSelectUltimo();

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                _ultimoContrato = db.QueryFirstOrDefault<ContratoUltimoDatos>(sql, new { PropiedadId = _propiedadId });

            }

            if (_ultimoContrato == null)
                return;

            txtArrendatarioActual.Text = _ultimoContrato.Nombre;
            txtTelefonosArrActual.Text = _ultimoContrato.Telefonos;
            txtCorreosArrActual.Text = _ultimoContrato.Correos;
            dtpFechaInicial.Value = _ultimoContrato.FechaInicial;
            dtpFechaFinal.Value = _ultimoContrato.FechaFinal;
            txtRentaActual.DecimalValue = _ultimoContrato.Renta;

        }


        private void VerDocumentoUltimoContrato(string nombre, byte[] archivo)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No está registrado el documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Utilerias.VeDocumento(nombre, archivo);

        }
        private void cmdVerIdentificacion_Click(object sender, EventArgs e)
        {
            VerDocumentoUltimoContrato(_ultimoContrato.IdentificacionNombre, _ultimoContrato.IdentificacionArchivo);
        }

        private void cmdVerComprobanteDomicilio_Click(object sender, EventArgs e)
        {
            VerDocumentoUltimoContrato(_ultimoContrato.ComprobanteNombre, _ultimoContrato.ComprobanteArchivo);

        }

        private void cmdVerAval_Click(object sender, EventArgs e)
        {
            VerDocumentoUltimoContrato(_ultimoContrato.AvalNombre, _ultimoContrato.AvalArchivo);

        }

        private void cmdVerContrato_Click(object sender, EventArgs e)
        {
            VerDocumentoUltimoContrato(_ultimoContrato.ContratoNombre, _ultimoContrato.ContratoArchivo);

        }

        private void cmdVerFianza_Click(object sender, EventArgs e)
        {
            VerDocumentoUltimoContrato(_ultimoContrato.FianzaNombre, _ultimoContrato.FianzaArchivo);

        }
    }
}
