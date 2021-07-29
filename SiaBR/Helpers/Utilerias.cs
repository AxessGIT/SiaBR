using SiaBR.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SiaBR.Modelo;
using Npgsql;
using Syncfusion.WinForms.ListView;
using System.ComponentModel;
using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using System.Drawing;

namespace SiaBR.Helpers
{
    public static class Utilerias
    {

        public static void SetComboMeses(ref ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Enero");
            combo.Items.Add("Febrero");
            combo.Items.Add("Marzo");
            combo.Items.Add("Abril");
            combo.Items.Add("Mayo");
            combo.Items.Add("Junio");
            combo.Items.Add("Julio");
            combo.Items.Add("Agosto");
            combo.Items.Add("Septiembre");
            combo.Items.Add("Octubre");
            combo.Items.Add("Noviembre");
            combo.Items.Add("Diciembre");


        }
        public static bool ExisteFolio(string tipo)
        {
            bool existe = false;
            string sql = Queries.FolioxTipoSelect(tipo);

            Fol fol = new Fol();


            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                fol = db.QueryFirstOrDefault<Fol>(sql, new { Tipo = tipo });
                existe = fol != null;
            }

            return existe;
        }
        public static void SetFolio(string tipo, int folio)
        {
            bool existeFolio = ExisteFolio(tipo);

            string sql = ExisteFolio(tipo)?Queries.FolioUpdatexTipo(tipo,folio):Queries.FolioInsert();

            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                if (existeFolio)
                {
                    db.Execute(sql, new { Tipo = tipo, Folio = folio });

                }
                else
                {
                    Fol fol = new Fol();
                    fol.Serie = "";
                    fol.Tipo = tipo;
                    fol.Folio = 1;
                    db.Execute(sql, fol);
                }
            }
            

        }
        public static Fol GetFolio(string tipo,string serie="" )
        {
            string sql = Queries.FolioxTipoSelect(tipo);
            Fol fol = new Fol();


            using (NpgsqlConnection db = Utilerias.GetDB())
            {
                fol = db.QueryFirstOrDefault<Fol>(sql, new { Tipo = tipo });
                if (fol==null)
                {
                    fol = new Fol();
                    fol.Tipo = tipo;
                    fol.Serie = serie;
                    fol.Folio = 1;

                }
            }

            return fol;
        }
        public static  void SetGridArrendatarios(ref DataGridView grdArrendatarios, BindingList<Arrendatario> arrendatarios)
        {

            grdArrendatarios.DataSource = null;
            grdArrendatarios.Columns.Clear();



            grdArrendatarios.AllowUserToAddRows = false;
            grdArrendatarios.AllowUserToDeleteRows = false;


            grdArrendatarios.AutoGenerateColumns = false;
            grdArrendatarios.ReadOnly = true;
            grdArrendatarios.AllowUserToResizeColumns = false;
            grdArrendatarios.AllowUserToResizeRows = false;

            grdArrendatarios.ColumnCount = 3;

            grdArrendatarios.RowHeadersVisible = true;


            grdArrendatarios.ColumnHeadersDefaultCellStyle.Font = new Font(grdArrendatarios.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdArrendatarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdArrendatarios.Columns[0].HeaderText = "RFC";
            grdArrendatarios.Columns[0].DataPropertyName = "Rfc";
            grdArrendatarios.Columns[0].Width = 80;

            grdArrendatarios.Columns[1].HeaderText = "Nombre/razón social";
            grdArrendatarios.Columns[1].DataPropertyName = "Nombre";
            grdArrendatarios.Columns[1].Width = 300;

            grdArrendatarios.Columns[2].HeaderText = "Teléfonos";
            grdArrendatarios.Columns[2].DataPropertyName = "Telefonos";
            grdArrendatarios.Columns[2].Width = 100;

            grdArrendatarios.DataSource = arrendatarios;

        }
        public static void SetGridPropiedades(ref DataGridView grdPropiedades,BindingList<PropiedadDatos> propiedades)
        {
            grdPropiedades.DataSource = null;
            grdPropiedades.Columns.Clear();



            grdPropiedades.AllowUserToAddRows = false;
            grdPropiedades.AllowUserToDeleteRows = false;


            grdPropiedades.AutoGenerateColumns = false;
            grdPropiedades.ReadOnly = true;
            grdPropiedades.AllowUserToResizeColumns = false;
            grdPropiedades.AllowUserToResizeRows = false;

            grdPropiedades.ColumnCount = 5;

            grdPropiedades.RowHeadersVisible = true;


            grdPropiedades.ColumnHeadersDefaultCellStyle.Font = new Font(grdPropiedades.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            grdPropiedades.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdPropiedades.Columns[0].HeaderText = "Clave";
            grdPropiedades.Columns[0].DataPropertyName = "Clave";
            grdPropiedades.Columns[0].Width = 100;

            grdPropiedades.Columns[1].HeaderText = "Tipo";
            grdPropiedades.Columns[1].DataPropertyName = "Tipo";
            grdPropiedades.Columns[1].Width = 160;

            grdPropiedades.Columns[2].HeaderText = "Desarrollo";
            grdPropiedades.Columns[2].DataPropertyName = "Desarrollo";
            grdPropiedades.Columns[2].Width = 200;

            grdPropiedades.Columns[3].HeaderText = "Ubicacion";
            grdPropiedades.Columns[3].DataPropertyName = "Ubicacion";
            grdPropiedades.Columns[3].Width = 200;

            grdPropiedades.Columns[4].HeaderText = "Direccion";
            grdPropiedades.Columns[4].DataPropertyName = "Direccion";
            grdPropiedades.Columns[4].Width = 200;


            grdPropiedades.DataSource = propiedades;

        }

        public static void VeDocumento(string nombre, byte[] archivo)
        {
            if (archivo == null || archivo.Length == 0) return;
            string TempFile = Path.GetTempFileName();
            string Extension = Path.GetExtension(nombre);

            TempFile = Path.GetFileNameWithoutExtension(TempFile);
            TempFile = TempFile + "." + Extension;

            File.WriteAllBytes(TempFile, archivo);



            Process.Start(TempFile);
        }



        public static NumberFormatInfo GetFormatoDecimal()
        {
            NumberFormatInfo numberFormat = new NumberFormatInfo();
            numberFormat.NumberDecimalSeparator = ".";
            numberFormat.NumberGroupSeparator = ",";
            return numberFormat;

        }


        public static string SubeDocumento()
        {
            OpenFileDialog ofdAbreArchivo = new OpenFileDialog();

            ofdAbreArchivo.FileName = string.Empty;
            ofdAbreArchivo.ShowDialog();

            if (ofdAbreArchivo.FileName == string.Empty || File.Exists(ofdAbreArchivo.FileName) == false)
                return "";

            return ofdAbreArchivo.FileName;

        }


        public static  byte[] CargaDocumento(string Archivo)
        {
            byte[] ContenidoArchivo;

            ContenidoArchivo = File.ReadAllBytes(Archivo);
            return ContenidoArchivo;

        }

        public static byte[] CargaDocumento(ref TextBox CuadroTexto)
        {
            byte[] ContenidoArchivo;

            OpenFileDialog ofdAbreArchivo = new OpenFileDialog();
            ofdAbreArchivo.FileName = string.Empty;
            ofdAbreArchivo.ShowDialog();

            if (ofdAbreArchivo.FileName == string.Empty || File.Exists(ofdAbreArchivo.FileName) == false)
                return new byte[0];

            ContenidoArchivo = File.ReadAllBytes(ofdAbreArchivo.FileName);
            CuadroTexto.Text = Path.GetFileName(ofdAbreArchivo.FileName);

            return ContenidoArchivo;

        }


        public static BindingList<DocumentoTipo> DevuelveTiposDocumento()
        {
            BindingList<DocumentoTipo> lista = new BindingList<DocumentoTipo>();
            string sql = Queries.TiposDocumentosSelect();

            using (NpgsqlConnection db = GetDB())
            {
                var res = db.Query<DocumentoTipo>(sql).ToList();
                lista = new BindingList<DocumentoTipo>(res);
            }
            return lista;


        }

        public static long DevuelveValorComboTiposDocs(SfComboBox combo)
        {
            long id = 0;
            if (combo.SelectedIndex >= 0)
                id = Convert.ToInt64(combo.SelectedValue);
            else
            {
                if (string.IsNullOrEmpty(combo.Text.Trim()) == false)
                {
                    string sql = Queries.TipoDocumentoSelectXDescripcion();

                    using (NpgsqlConnection db = GetDB())
                    {
                        DocumentoTipo des = db.QueryFirstOrDefault<DocumentoTipo>(sql, new { Descripcion = combo.Text.Trim() });

                        if (des == null)
                        {
                            sql = Queries.TipoDocumentoInsert();
                            id = db.QuerySingle<long>(sql, new {Descripcion = combo.Text.Trim() });
                        }
                        else
                        {
                            id = des.DocumentoTipoId;
                        }
                    }
                }
            }
            return id;
        }



        public static long DevuelveValorCombo(SfComboBox combo, string tipo)
        {
            long id = 0;
            if (combo.SelectedIndex >= 0)
                id = Convert.ToInt64(combo.SelectedValue);
            else
            {
                if (string.IsNullOrEmpty(combo.Text.Trim()) == false)
                {
                    string sql = Queries.DescripcionSelectxDescripcion();

                    using (NpgsqlConnection db = GetDB()) { 
                        DescripcionCat des = db.QueryFirstOrDefault<DescripcionCat>(sql, new { Tipo = tipo, Descripcion = combo.Text.Trim() });

                        if (des == null)
                        {
                            sql = Queries.DescripcionInsert();
                            id = db.QuerySingle<long>(sql, new { Tipo = tipo, Descripcion = combo.Text.Trim() });
                        }
                        else
                        {
                            id = des.DescripcionId;
                        }
                    }
                }
            }
            return id;
        }

        public static BindingList<DescripcionCat> DevuelveListaDescripcion(string tipo)
        {

            BindingList<DescripcionCat> lista = new BindingList<DescripcionCat>();
            string sql = Queries.DescripcionesSelectxTipo();// "Select Descripcion_Id, Tipo, Descripcion From Descripciones Where Tipo=@Tipo Order By Descripcion";

            using (NpgsqlConnection db=GetDB()) { 
                var res = db.Query<DescripcionCat>(sql, new { Tipo = tipo }).ToList();
                lista = new BindingList<DescripcionCat>(res);
            }
            return lista;

        }

        public static void ConfiguraCombo(ref SfComboBox combo, string tipo)
        {
            combo.DataSource = DevuelveListaDescripcion(tipo);
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "DescripcionId";
        }

        public static DatosConexion GetDatosConexion()
        {
            DatosConexion conexionDatos = null;

            if (! string.IsNullOrEmpty(SiaBR.Properties.Settings.Default.Servidor))
            {
                conexionDatos = new DatosConexion();
                conexionDatos.Servidor = SiaBR.Properties.Settings.Default.Servidor;
                conexionDatos.Usuario = SiaBR.Properties.Settings.Default.Usuario;
                conexionDatos.PassWord = SiaBR.Properties.Settings.Default.PassWord;
                conexionDatos.Puerto = SiaBR.Properties.Settings.Default.Puerto;
                conexionDatos.BaseDeDatos = SiaBR.Properties.Settings.Default.BaseDeDatos;
            }

            return conexionDatos;

        }

        public static string GetCadenaDeConexion()
        {
            string concad = "";

            DatosConexion datosConexion = GetDatosConexion();
            if (datosConexion == null)
                return "";

            NpgsqlConnectionStringBuilder csb = new NpgsqlConnectionStringBuilder();

            csb.Host = datosConexion.Servidor;
            csb.Username = datosConexion.Usuario;
            csb.Password = datosConexion.PassWord;
            csb.Port = datosConexion.Puerto;
            csb.Database = datosConexion.BaseDeDatos;

            concad = csb.ToString();


            return concad;
        }

        public static NpgsqlConnection GetDB()
        {
            NpgsqlConnection conn = null;
            string concad = GetCadenaDeConexion();

            if (string.IsNullOrEmpty(concad))
                return conn;

            conn = new NpgsqlConnection();
            conn.ConnectionString = concad;

            return conn;

        }
    }
}
