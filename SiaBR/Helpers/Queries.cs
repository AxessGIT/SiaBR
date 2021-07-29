using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Helpers
{
    public static class Queries
    {
        #region Pagos


        public static string ContratosPagos(int contratoId=0)
        {


            string sql = "Select Contratos.ContratoId,Contratos.Folio," +
                "Propiedades.PropiedadId,Propiedades.Clave," +
                "Contratos.ArrendatarioId,Arrendatarios.Nombre," +
                "Contratos.FechaInicial,Contratos.FechaFinal," +
                "Contratos.Moneda,Contratos.Renta,Contratos.Facturar " +
                "From Contratos " +
                "Inner Join Propiedades On Contratos.PropiedadId = Propiedades.PropiedadId " +
                "Inner Join Arrendatarios on Contratos.ArrendatarioId = Arrendatarios.ArrendatarioId " +
                "Where @Fecha Between Contratos.FechaInicial And Contratos.FechaFinal ";

            sql += contratoId == 0 ? "" : $" And ContratoId={contratoId}";

                sql += "Order By Folio";

            return sql;

        }
        public static string PagoSelect()
        {
            string sql = "";
            sql = "Select Fecha,Importe " +
                "from Pagos " +
                "Where ContratoId=@ContratoId And Anio=@Anio And Mes = @Mes";
            return sql;
        }

        #endregion

        #region Folios

        public static string FolioSelect()
        {
            string sql = "";
            sql = "Select FolioId,Tipo,Serie,Folio  From Folios Where FolioId=@FolioId";
            return sql;
        }

        public static string FolioxTipoSelect(string tipo)
        {
            string sql = "";
            sql = $"Select FolioId,Tipo,Serie,Folio  From Folios Where Tipo='{tipo}'";
            return sql;
        }

        public static string FolioInsert()
        {
            string sql = "";
            sql = "Insert Into Folios(Tipo,Serie,Folio) values (@Tipo,@Serie,@Folio) Returning FolioId";
            return sql;
        }

        public static string FolioUpdatexTipo(string tipo, int folio, string serie="")
        {
            string sql = "";
            sql = "Update Folios Set " +
                "Folio=@Folio " +
                "Where Tipo=@Tipo";
            return sql;
        }

        public static string FolioUpdate()
        {
            string sql = "";
            sql = "Update Folios Set " +
                "Tipo=@Tipo," +
                "Serie=@Serie," +
                "Folio=@Folio " +
                "Where FolioId=@FolioId";
            return sql;
        }
        public static string FolioDelete()
        {
            string sql = "";
            sql = "Delete From Folios " +
                "Where FolioId=@FolioId";
            return sql;
        }

        #endregion
        #region Contratos
        public static string ContratosSelect()
        {
            string sql = "Select Contratos.ContratoId,Contratos.Folio," +
                "Propiedades.PropiedadId,Propiedades.Clave," +
                "Contratos.ArrendatarioId,Arrendatarios.Nombre," +
                "Contratos.FechaInicial,Contratos.FechaFinal," +
                "Contratos.Moneda,Contratos.Renta," +
                "Contratos.ContratoNombre,Contratos.ContratoArchivo," +
                "FianzaNombre,FianzaArchivo,Facturar " +
                "From Contratos " +
                "Inner Join Propiedades On Contratos.PropiedadId = Propiedades.PropiedadId " +
                "Inner Join Arrendatarios on Contratos.ArrendatarioId = Arrendatarios.ArrendatarioId " +
                "Order By Folio";
            return sql;
        }

        public static string ContratosSelectxPropiedad()
        {
            string sql = "Select Contratos.ContratoId,Contratos.Folio," +
                "Contratos.ArrendatarioId,Arrendatarios.Nombre," +
                "Contratos.FechaInicial,Contratos.FechaFinal," +
                "Contratos.Moneda,Contratos.Renta, " +
                "Contratos.ContratoNombre,Contratos.ContratoArchivo," +
                "FianzaNombre,FianzaArchivo,Facturar " +
                "From Contratos " +
                "Inner Join Arrendatarios on Contratos.ArrendatarioId = Arrendatarios.ArrendatarioId " +
                "Where Contratos.PropiedadId=@PropiedadId " +
                "Order By Contratos.FechaFinal Desc";
            return sql;
        }


        public static string ContratoSelectUltimo()
        {
            string sql = "Select Contratos.ContratoId,Contratos.Folio," +
                "Contratos.ArrendatarioId,Arrendatarios.Nombre,Arrendatarios.Telefonos,Arrendatarios.Correos," +
                "Arrendatarios.IdentificacionNombre,Arrendatarios.IdentificacionArchivo," +
                "Arrendatarios.ComprobanteNombre,Arrendatarios.ComprobanteArchivo," +
                "Arrendatarios.AvalNombre,Arrendatarios.AvalArchivo," +
                "Contratos.FechaInicial,Contratos.FechaFinal," +
                "Contratos.Moneda,Contratos.Renta, " +
                "Contratos.ContratoNombre,Contratos.ContratoArchivo," +
                "Contratos.FianzaNombre,Contratos.FianzaArchivo,Facturar " +
                "From Contratos " +
                "Inner Join Arrendatarios on Contratos.ArrendatarioId = Arrendatarios.ArrendatarioId " +
                "Where Contratos.PropiedadId=@PropiedadId " +
                "Order By Contratos.FechaFinal Desc";
            return sql;
        }


        public static string ContratoSelect()
        {
            string sql = "Select ContratoId,Folio,PropiedadId,ArrendatarioId,FechaInicial,FechaFinal,Moneda,Renta,ContratoNombre,ContratoArchivo," +
                "FianzaNombre,FianzaArchivo,Facturar From Contratos Where ContratoId=@ContratoId";
            return sql;
        }
        public static string ContratoInsert()
        {
            string sql = "Insert Into Contratos " +
                "(Folio,PropiedadId,ArrendatarioId,FechaInicial,FechaFinal,Moneda,Renta,ContratoNombre,ContratoArchivo," +
                "FianzaNombre,FianzaArchivo,Facturar) " +
                "values" +
                "(@Folio,@PropiedadId,@ArrendatarioId,@FechaInicial,@FechaFinal,@Moneda,@Renta,@ContratoNombre,@ContratoArchivo," +
                "@FianzaNombre,@FianzaArchivo,@Facturar) " +
                " returning ContratoId";
            return sql;
        }
        public static string ContratoUpdate()
        {
            string sql = "Update Contratos Set " +
                "Folio=@Folio," +
                "PropiedadId=@PropiedadId," +
                "ArrendatarioId=@ArrendatarioId," +
                "FechaInicial=@FechaInicial," +
                "FechaFinal=@FechaFinal," +
                "Moneda=@Moneda," +
                "Renta=@Renta," +
                "ContratoNombre=@ContratoNombre," +
                "ContratoArchivo=@ContratoArchivo," +
                "FianzaNombre=@FianzaNombre," +
                "FianzaArchivo=@FianzaArchivo," +
                "Facturar=@Facturar " +
                " Where ContratoId=@ContratoId";
            return sql;
        }

        public static string ContratoDelete()
        {
            string sql = "Delete From Contratos " +
                " Where ContratoId=@ContratoId";
            return sql;
        }




        #endregion
        #region Arrendatarios
        public static string ArrendatariosSelect() {
            string sql = "Select ArrendatarioId,Rfc,Nombre,Calle,NumExt,NumInt,Colonia,CiudadId,EstadoId,Pais,CP,Telefonos,Correos," +
                "IdentificacionNombre,IdentificacionArchivo,ComprobanteNombre,ComprobanteArchivo,AvalNombre,AvalArchivo From Arrendatarios Order By Nombre";
            return sql;
        }

        public static string ArrendatariosBuscarSelect(string buscar)
        {
            string sql = "Select ArrendatarioId,Rfc,Nombre,Calle,NumExt,NumInt,Colonia,CiudadId,EstadoId,Pais,CP,Telefonos,Correos," +
                "IdentificacionNombre,IdentificacionArchivo,ComprobanteNombre,ComprobanteArchivo,AvalNombre,AvalArchivo " +
                "From Arrendatarios ";
            sql += $"Where Rfc like'%{buscar}%' Or ";
            sql += $"Nombre like'%{buscar}%' Or ";
            sql += $"Telefonos like'%{buscar}%' Or ";
            sql += $"Correos like'%{buscar}%' ";
            sql += "Order By Nombre";

            return sql;
        }


        public static string ArrendatarioSelect()
        {
            string sql = "Select ArrendatarioId,Rfc,Nombre,Calle,NumExt,NumInt,Colonia,CiudadId,EstadoId,Pais,CP,Telefonos,Correos," +
                "IdentificacionNombre,IdentificacionArchivo,ComprobanteNombre,ComprobanteArchivo,AvalNombre,AvalArchivo From Arrendatarios Where ArrendatarioId=@ArrendatarioId";
            return sql;
        }


        public static string ArrendatarioInsert()
        {
            string sql = "Insert Into Arrendatarios" +
                " (Rfc,Nombre,Calle,NumExt,NumInt,Colonia,CiudadId,EstadoId,Pais,CP,Telefonos,Correos," +
                "IdentificacionNombre,IdentificacionArchivo,ComprobanteNombre,ComprobanteArchivo,AvalNombre,AvalArchivo)" +
                " values" +
                " (@Rfc,@Nombre,@Calle,@NumExt,@NumInt,@Colonia,@CiudadId,@EstadoId,@Pais,@CP,@Telefonos,@Correos," +
                "@IdentificacionNombre,@IdentificacionArchivo,@ComprobanteNombre,@ComprobanteArchivo,@AvalNombre,@AvalArchivo) " +
                " Returning ArrendatarioId";
            return sql;
        }

        public static string ArrendatarioUpdate()
        {
            string sql = "Update Arrendatarios Set " +
                "Rfc=@Rfc," +
                "Nombre=@Nombre," +
                "Calle=@Calle," +
                "NumExt=@NumExt," +
                "NumInt=@NumInt," +
                "Colonia=@Colonia," +
                "CiudadId=@CiudadId," +
                "EstadoId=@EstadoId," +
                "Pais=@Pais," +
                "CP=@CP," +
                "Telefonos=@Telefonos," +
                "Correos=@Correos," +
                "IdentificacionNombre=@IdentificacionNombre," +
                "IdentificacionArchivo=@IdentificacionArchivo," +
                "ComprobanteNombre=@ComprobanteNombre," +
                "ComprobanteArchivo=@ComprobanteArchivo, " +
                "AvalNombre=@AvalNombre," +
                "AvalArchivo=@AvalArchivo " +
                "Where ArrendatarioId=@ArrendatarioId";
            return sql;
        }

        public static string ArrendatarioDelete()
        {
            string sql = "Delete From Arrendatarios " +
                "Where ArrendatarioId=@ArrendatarioId";
            return sql;
        }


        #endregion
        #region Planos

        public static string PlanosSelect()
        {
            string sql = "Select PropiedadPlanoId,Nombre,Archivo,Descripcion From PropiedadesPlanos Where PropiedadId=@PropiedadId";
            return sql;
        }


        public static string PlanoSelect()
        {
            string sql = "Select PropiedadPlanoId,Nombre,Archivo,Descripcion From PropiedadesPlanos Where PropiedadPlanoId=@PropiedadPlanoId";
            return sql;
        }
        public static string PlanoInsert()
        {
            string sql = "Insert Into PropiedadesPlanos (PropiedadId,Nombre,Archivo,Descripcion) values (@PropiedadId,@Nombre,@Archivo,@Descripcion)" +
                " Returning PropiedadPlanoId";
            return sql;
        }
        public static string PlanoUpdate()
        {
            string sql = "Update PropiedadesPlanos Set Nombre=@Nombre,Archivo=@Archivo,Descripcion=@Descripcion Where PropiedadPlanoId=@PropiedadPlanoId ";
            return sql;
        }
        public static string PlanoDelete()
        {
            string sql = "Delete From PropiedadesPlanos Where PropiedadPlanoId=@PropiedadPlanoId ";
            return sql;
        }
        public static string PlanosDelete()
        {
            string sql = "Delete From PropiedadesPlanos Where PropiedadId=@PropiedadId ";
            return sql;
        }

        #endregion
        #region Recibos
        public static string  RecibosSelect()
        {

            string sql = "Select PropiedadReciboId,Tipo,Nombre,Archivo From PropiedadesRecibos Where PropiedadId=@PropiedadId And Anio=@Anio And Mes=@Mes Order By Tipo";
            return sql;

        }

        public static string ReciboSelect()
        {

            string sql = "Select PropiedadId,Tipo,Mes,Anio, Nombre,Archivo From PropiedadesRecibos Where PropiedadReciboId=@PropiedadReciboId";
            return sql;

        }


        public static string ReciboInsert()
        {

            string sql = "Insert Into PropiedadesRecibos (PropiedadId,Tipo,Mes,Anio, Nombre,Archivo) Values (@PropiedadId,@Tipo,@Mes,@Anio, @Nombre,@Archivo)  Returning PropiedadReciboId";
            return sql;

        }
        public static string ReciboUpdate()
        {

            string sql = "Update PropiedadesRecibos Set Nombre=@Nombre,Archivo=@Archivo Where PropiedadReciboId = @PropiedadReciboId";
            return sql;

        }
        public static string ReciboDelete()
        {

            string sql = "Delete From  PropiedadesRecibos Where PropiedadReciboId = @PropiedadReciboId";
            return sql;

        }
        public static string RecibosDelete()
        {

            string sql = "Delete From  PropiedadesRecibos Where PropiedadId = @PropiedadId and Anio=@Anio And Mes=@Mes";
            return sql;

        }


        #endregion


        #region Permisos
        public static string PermisosSelect()
        {
            string sql = "Select PropiedadPermisoId,Nombre,Archivo,Descripcion From PropiedadesPermisos Where PropiedadId=@PropiedadId";
            return sql;
        }


        public static string PermisoSelect()
        {
            string sql = "Select PropiedadPermisoId,Nombre,Archivo,Descripcion From PropiedadesPermisos Where PropiedadPermisoId=@PropiedadPermisoId";
            return sql;
        }
        public static string PermisoInsert()
        {
            string sql = "Insert Into PropiedadesPermisos (PropiedadId,Nombre,Archivo,Descripcion) values (@PropiedadId,@Nombre,@Archivo,@Descripcion)" +
                " Returning PropiedadPermisoId";
            return sql;
        }
        public static string PermisoUpdate()
        {
            string sql = "Update PropiedadesPermisos Set Nombre=@Nombre,Archivo=@Archivo,Descripcion=@Descripcion Where PropiedadPermisoId=@PropiedadPermisoId ";
            return sql;
        }
        public static string PermisoDelete()
        {
            string sql = "Delete From PropiedadesPermisos Where PropiedadPermisoId=@PropiedadPermisoId ";
            return sql;
        }
        public static string PermisosDelete()
        {
            string sql = "Delete From PropiedadesPermisos Where PropiedadId=@PropiedadId ";
            return sql;
        }

        #endregion
        #region Propietarios
        public static string PropietariosSelect()
        {
            string sql = "Select PropiedadPropietarioId,Nombre,Porcentaje From PropiedadesPropietarios Where PropiedadId=@PropiedadId";
            return sql;
        }

        public static string PropietarioSelect()
        {
            string sql = "Select PropiedadId,Nombre,Porcentaje From PropiedadesPropietarios Where PropiedadPropietarioId=@PropiedadPropietarioId";
            return sql;
        }
        public static string PropietarioInsert()
        {
            string sql = "Insert Into PropiedadesPropietarios (PropiedadId,Nombre,Porcentaje)  Values (@PropiedadId,@Nombre,@Porcentaje) Returning PropiedadPropietarioId";
            return sql;
        }
        public static string PropietarioUpdate()
        {
            string sql = "Update PropiedadesPropietarios Set " +
                "Nombre=@Nombre, Porcentaje=@Porcentaje" +
                " Where PropiedadPropietarioId=@PropiedadPropietarioId";
            return sql;
        }
        public static string PropietarioDelete()
        {
            string sql = "Delete From PropiedadesPropietarios " +
                " Where PropiedadPropietarioId=@PropiedadPropietarioId";
            return sql;
        }

        public static string PropietariosDelete()
        {
            string sql = "Delete From PropiedadesPropietarios " +
                " Where PropiedadId=@PropiedadId";
            return sql;
        }

        #endregion
        #region Propiedades

        public static string PropiedadesSelect()
        {
            string sql = "Select PropiedadId,EmpresaId,Clave,Tipos.TipoId,DesarrolloId,UbicacionId," +
                "Coordenadas,Calle,NumExt,NumInt,Colonia,Cp,CiudadId,EstadoId,Pais,Foto,Renta,Moneda," +
                "EscriturasNombre,EscriturasArchivo," +
                "CertificadoLGNombre,CertificadoLGArchivo," +
                "FotosNombre,FotosArchivo," +
                "UsoSueloNombre,UsoSueloArchivo," +
                "PresupuestosNombre,PresupuestosArchivo," +
                "PredialNombre,PredialArchivo," +
                "LevantamientoNombre,LevantamientoArchivo," +
                "ClaveCatastral,AreaTerreno,AreaConstruccion,Frente,Fondo,ValorCatastral,ValorComercial From Propiedades Where EmpresaId = @EmpresaId";
            return sql;
        }
        public static string PropiedadesDatosSelect()
        {
            string sql = "Select Propiedades.PropiedadId,Propiedades.Clave,Propiedades.TipoId,Tipos.Descripcion As Tipo," +
                "Propiedades.DesarrolloId, Desarrollos.Descripcion as Desarrollo," +
                "Propiedades.UbicacionId, Ubicaciones.Descripcion As Ubicacion," +
                "Coordenadas," +
                "Propiedades.Calle,Propiedades.NumExt,Propiedades.NumInt,Propiedades.Colonia,Propiedades.Cp," +
                "Propiedades.CiudadId, Ciudades.Descripcion as Ciudad," +
                "Propiedades.estadoId, Estados.Descripcion as Estado," +
                "Propiedades.Renta " +
                " From Propiedades" +
                " Left Join Descripciones as Tipos On Propiedades.TipoId = Tipos.DescripcionId " +
                " Left Join Descripciones as Desarrollos On Propiedades.DesarrolloId = Desarrollos.DescripcionId " +
                " Left Join Descripciones as Ubicaciones On Propiedades.UbicacionId = Ubicaciones.DescripcionId " +
                " Left Join Descripciones as Ciudades On Propiedades.CiudadId = Ciudades.DescripcionId " +
                " Left Join Descripciones as Estados On Propiedades.EstadoId = Estados.DescripcionId " +
                "Where EmpresaId = @EmpresaId " +
                "Order By Propiedades.Clave";
            return sql;
        }
        public static string PropiedadDatosSelect()
        {
            string sql = "Select Propiedades.PropiedadId,Propiedades.Clave,Propiedades.TipoId,Tipos.Descripcion As Tipo," +
                "Propiedades.DesarrolloId, Desarrollos.Descripcion as Desarrollo," +
                "Propiedades.UbicacionId, Ubicaciones.Descripcion As Ubicacion," +
                "Coordenadas," +
                "Propiedades.Calle,Propiedades.NumExt,Propiedades.NumInt,Propiedades.Colonia,Propiedades.Cp," +
                "Propiedades.CiudadId, Ciudades.Descripcion as Ciudad," +
                "Propiedades.estadoId, Estados.Descripcion as Estado," +
                "Propiedades.Renta " +
                " From Propiedades" +
                " Left Join Descripciones as Tipos On Propiedades.TipoId = Tipos.DescripcionId " +
                " Left Join Descripciones as Desarrollos On Propiedades.DesarrolloId = Desarrollos.DescripcionId " +
                " Left Join Descripciones as Ubicaciones On Propiedades.UbicacionId = Ubicaciones.DescripcionId " +
                " Left Join Descripciones as Ciudades On Propiedades.CiudadId = Ciudades.DescripcionId " +
                " Left Join Descripciones as Estados On Propiedades.EstadoId = Estados.DescripcionId " +
                "Where PropiedadId = @PropiedadId ";
            return sql;
        }

        public static string PropiedadesDatosFiltradosSelect(int empresaId, string clave , int tipoId,
            int desarrolloId,int ubicacionId,int ciudadId, int estadoId)
        {
            string sql = "Select Propiedades.PropiedadId,Propiedades.Clave,Propiedades.TipoId,Tipos.Descripcion As Tipo," +
                "Propiedades.DesarrolloId, Desarrollos.Descripcion as Desarrollo," +
                "Propiedades.UbicacionId, Ubicaciones.Descripcion As Ubicacion," +
                "Coordenadas," +
                "Propiedades.Calle,Propiedades.NumExt,Propiedades.NumInt,Propiedades.Colonia,Propiedades.Cp," +
                "Propiedades.CiudadId, Ciudades.Descripcion as Ciudad," +
                "Propiedades.estadoId, Estados.Descripcion as Estado," +
                "Propiedades.Renta " +
                " From Propiedades" +
                " Left Join Descripciones as Tipos On Propiedades.TipoId = Tipos.DescripcionId " +
                " Left Join Descripciones as Desarrollos On Propiedades.DesarrolloId = Desarrollos.DescripcionId " +
                " Left Join Descripciones as Ubicaciones On Propiedades.UbicacionId = Ubicaciones.DescripcionId " +
                " Left Join Descripciones as Ciudades On Propiedades.CiudadId = Ciudades.DescripcionId " +
                " Left Join Descripciones as Estados On Propiedades.EstadoId = Estados.DescripcionId " +
                "Where EmpresaId = @EmpresaId ";
            sql += string.IsNullOrEmpty(clave) ? "" : $" And Propiedades.Clave like '%{clave.Trim()}%' ";
            sql += tipoId == 0 ? "" : $" And Propiedades.TipoId={tipoId} ";
            sql += desarrolloId == 0 ? "" : $" And Propiedades.DesarrolloId={desarrolloId} ";
            sql += ubicacionId == 0 ? "" : $" And Propiedades.ubicacionId={ubicacionId} ";
            sql += ciudadId == 0 ? "" : $" And Propiedades.ciudadId={ciudadId} ";
            sql += estadoId == 0 ? "" : $" And Propiedades.estadoId={estadoId} ";
            sql += "Order By Propiedades.Clave";
            return sql;
        }

        public static string PropiedadSelect()
        {
            string sql = "Select PropiedadId,EmpresaId,Clave,TipoId,DesarrolloId,UbicacionId," +
                "Coordenadas,Calle,NumExt,NumInt,Colonia,Cp,CiudadId,EstadoId,Pais,Foto,Renta,Moneda," +
                "EscriturasNombre,EscriturasArchivo," +
                "CertificadoLGNombre,CertificadoLGArchivo," +
                "FotosNombre,FotosArchivo," +
                "UsoSueloNombre,UsoSueloArchivo," +
                "PresupuestosNombre,PresupuestosArchivo," +
                "PredialNombre,PredialArchivo," +
                "LevantamientoNombre,LevantamientoArchivo," +
                " ClaveCatastral,AreaTerreno,AreaConstruccion,Frente,Fondo,ValorCatastral,ValorComercial From Propiedades Where PropiedadId=@PropiedadId";
            return sql;
        }

        public static string PropiedadInsert()
        {
            string sql =
                "Insert Into Propiedades(EmpresaId,Clave,TipoId,DesarrolloId," +
                "UbicacionId,Coordenadas,Calle,NumExt,NumInt,Colonia,Cp,CiudadId,EstadoId,Pais,Foto,Renta,Moneda," +
                "EscriturasNombre,EscriturasArchivo," +
                "CertificadoLGNombre,CertificadoLGArchivo," +
                "FotosNombre,FotosArchivo," +
                "UsoSueloNombre,UsoSueloArchivo," +
                "PresupuestosNombre,PresupuestosArchivo," +
                "PredialNombre,PredialArchivo," +
                "LevantamientoNombre,LevantamientoArchivo," +
              "ClaveCatastral,AreaTerreno,AreaConstruccion,Frente,Fondo,ValorCatastral,ValorComercial) " +
                "Values " +
                "(@EmpresaId,@Clave,@TipoId,@DesarrolloId,@UbicacionId,@Coordenadas,@Calle,@NumExt," +
                "@NumInt,@Colonia,@Cp,@CiudadId,@EstadoId,@Pais,@Foto,@Renta,@Moneda," +
                "@EscriturasNombre,@EscriturasArchivo," +
                "@CertificadoLGNombre,@CertificadoLGArchivo," +
                "@FotosNombre,@FotosArchivo," +
                "@UsoSueloNombre,@UsoSueloArchivo," +
                "@PresupuestosNombre,@PresupuestosArchivo," +
                "@PredialNombre,@PredialArchivo," +
                "@LevantamientoNombre,@LevantamientoArchivo," +
                "@ClaveCatastral,@AreaTerreno,@AreaConstruccion,@Frente,@Fondo,@ValorCatastral,@ValorComercial) Returning PropiedadId";
            return sql;
        }
        public static string PropiedadUpdate()
        {
            string sql =
                "Update Propiedades Set " +
                "EmpresaId=@EmpresaId," +
                "Clave=@Clave," +
                "TipoId=@TipoId," +
                "DesarrolloId=@DesarrolloId," +
                "UbicacionId=@UbicacionId," +
                "Coordenadas=@Coordenadas," +
                "Calle=@Calle," +
                "NumExt=@NumExt," +
                "NumInt=@NumInt," +
                "Colonia=@Colonia," +
                "Cp=@Cp," +
                "CiudadId=@CiudadId," +
                "EstadoId=@EstadoId," +
                "Pais=@Pais," +
                "Foto=@Foto," +
                "Renta = @Renta," +
                "Moneda=@Moneda," +
                "EscriturasNombre=@EscriturasNombre," +
                "EscriturasArchivo=@EscriturasArchivo," +
                "CertificadoLGNombre=@CertificadoLGNombre," +
                "CertificadoLGArchivo=@CertificadoLGArchivo," +
                "FotosNombre=@FotosNombre," +
                "FotosArchivo=@FotosArchivo," +
                "UsoSueloNombre=@UsoSueloNombre," +
                "UsoSueloArchivo=@UsoSueloArchivo," +
                "PresupuestosNombre=@PresupuestosNombre," +
                "PresupuestosArchivo=@PresupuestosArchivo," +
                "PredialNombre=@PredialNombre," +
                "PredialArchivo=@PredialArchivo," +
                "LevantamientoNombre=@LevantamientoNombre," +
                "LevantamientoArchivo=@LevantamientoArchivo," +
                "ClaveCatastral=@ClaveCatastral," +
                "AreaTerreno=@AreaTerreno," +
                "AreaConstruccion=@AreaConstruccion," +
                "Frente=@Frente," +
                "Fondo=@Fondo," +
                "ValorCatastral=@ValorCatastral," +
                "ValorComercial=@ValorComercial " +
                " Where Propiedades.PropiedadId = @PropiedadId";

            return sql;
        }
        public static string PropiedadDelete()
        {
            string sql ="Delete From Propiedaes Where PropiedadId = @PropiedadId";
            return sql;
        }


        #region PropiedadesDocumentos
        #region TiposDocumentos
        public static string TiposDocumentosSelect()
        {
            string sql = "Select DocumentoTipoId,Descripcion,Requerido From DocumentosTipos";
            return sql;
        }
        public static string TipoDocumentoSelect()
        {
            string sql = "Select DocumentoTipoId,Descripcion,Requerido From DocumentosTipos Where DocumentoTipoId=@DocumentoTipoId";
            return sql;
        }


        public static string TipoDocumentoSelectXDescripcion()
        {
            string sql;
            sql = "Select DocumentoTipoId,Descripcion,Requerido From DocumentosTipos ";
            sql += " Where Descripcion = @Descripcion";
            return sql;

        }

        public static string TipoDocumentoInsert()
        {
            string sql = "Insert into DocumentosTipos  (Descripcion,Requerido) Values(@Descripcion,@Requerido) Returning DocumentoTipoId";
            return sql;
        }
        public static string TipoDocumentoUpdate()
        {
            string sql = "Update DocumentosTipos  Set " +
                " Descripcion=@Descripcion," +
                " Requerido=@Requerido " +
                " Where DocumentoTipoId=@DocumentoTipoId";
            return sql;
        }

        public static string TipoDocumentoDelete()
        {
            string sql = "Delete From DocumentosTipos  " +
                " Where DocumentoTipoId=@DocumentoTipoId";
            return sql;
        }


        #endregion
        public static string PropiedadDocumentosSelect()
        {
            string sql = "Select PropiedadDocumentoId,DocumentosTipos.Descripcion as Tipo, TipoId,Archivo,Contenido,Observaciones " +
                " From PropiedadesDocumentos" +
                " Left Join DocumentosTipos On PropiedadesDocumentos.TipoId = DocumentosTipos.DocumentoTipoId " +
                " Where PropiedadId=@PropiedadId";
            return sql;
        }

        public static string PropiedadDocumentosDelete()
        {
            string sql = "Delete From PropiedadesDocumentos  Where PropiedadId=@PropiedadId";
            return sql;
        }

        public static string PropiedadDocumentoSelect()
        {
            string sql = "Select PropiedadDocumentoId,PropiedadId,TipoId,Archivo,Contenido,Observaciones From PropiedadesDocumentos Where PropiedadDocumentoId=@PropiedadDocumentoId";
            return sql;
        }
        public static string PropiedadDocumentoInsert()
        {
            string sql = "Insert into PropiedadesDocumentos  (PropiedadId,TipoId,Archivo,Contenido,Observaciones) Values (@PropiedadId,@TipoId,@Archivo,@Contenido,@Observaciones) Returning PropiedadDocumentoId";
            return sql;
        }


        public static string PropiedadDocumentoUpdate()
        {
            string sql = "Update PropiedadesDocumentos  Set " +
                " PropiedadId=@PropiedadId," +
                "TipoId=@TipoId," +
                "Archivo=@Archivo," +
                "Contenido=@Contenido, " +
                " Observaciones=@Observaciones " +
                " Where PropiedadDocumentoId=@PropiedadDocumentoId";
            return sql;
        }

        public static string PropiedadDocumentoDelete()
        {
            string sql = "Delete From  PropiedadesDocumentos  " +
                " Where PropiedadDocumentoId=@PropiedadDocumentoId";
            return sql;
        }

        #endregion

        #endregion


        #region Empresas
        public static string EmpresasSelect()
        {
            string sql = "";
            sql = "Select EmpresaId,RazonSocial,RFC,Direccion,NumExt,NumInt,Colonia,CiudadId,EstadoId,CP From Empresas";
            return sql;
        }
        public static string EmpresaSelect()
        {
            string sql = "";
            sql = "Select EmpresaId,RazonSocial,RFC,Direccion,NumExt,NumInt,Colonia,CiudadId,EstadoId,CP From Empresas Where EmpresaId=@EmpresaId";
            return sql;
        }

        #endregion
        #region Usuarios
        public static string UsuariosSelect()
        {
            string sql = "";
            sql = "Select UsuarioId,Nombre,Usuario,PassWord From Usuarios Order By Usuario";
            return sql;
        }
        public static string UsuarioSelect()
        {
            string sql = "";
            sql = "Select UsuarioId,Nombre,Usuario,PassWord From Usuarios Where UsuarioId=@UsuarioId";
            return sql;
        }
        public static string UsuarioSelectxUsuario()
        {
            string sql = "";
            sql = "Select UsuarioId,Nombre,Usuario,PassWord From Usuarios Where Usuario=@Usuario And PassWord = @PassWord";
            return sql;
        }

        public static string UsuarioInsert()
        {
            string sql = "";
            sql = "Insert Into Usuarios (Nombre,Usuario,PassWord) Values (@Nombre,@Usuario,@PassWord) Returning UsuarioId";
            return sql;
        }
        public static string UsuarioUpdate()
        {
            string sql = "";
            sql = "Update Usuarios set Nombre=@Nombre,Usuario=@Usuario,PassWord=@PassWord Where UsuarioId=@UsuarioId";
            return sql;
        }
        public static string UsuarioDelete()
        {
            string sql = "";
            sql = "Delete From Usuarios Where UsuarioId=@UsuarioId";
            return sql;
        }


        #endregion


        #region Descripciones
        public static string DescripcionesSelect()
        {
            string sql;
            sql = "Select DescripcionId,Tipo, Descripcion From Descripciones Where Tipo=@Tipo ";
            sql += " Order By Descripcion";
            return sql;

        }

        public static string DescripcionSelect()
        {
            string sql;
            sql = "Select DescripcionId,Tipo, Descripcion From Descripciones ";
            sql += " Where DescripcionId = @DescripcionId";
            return sql;

        }

        public static string DescripcionesSelectxTipo()
        {
            string sql;
            sql = "Select DescripcionId,Tipo, Descripcion From Descripciones ";
            sql += " Where Tipo=@Tipo Order By Descripcion";
            return sql;

        }


        public static string DescripcionSelectxTipo()
        {
            string sql;
            sql = "Select DescripcionId,Tipo, Descripcion From Descripciones ";
            sql += " Where Tipo=@Tipo And DescripcionId = @DescripcionId";
            return sql;

        }
        public static string DescripcionSelectxDescripcion()
        {
            string sql;
            sql = "Select DescripcionId,Tipo, Descripcion From Descripciones ";
            sql += " Where Tipo=@Tipo And Descripcion = @Descripcion";
            return sql;

        }

        public static string DescripcionInsert()
        {
            string sql;
            sql = "Insert into Descripciones (Tipo, Descripcion) values (@Tipo, @Descripcion) Returning DescripcionId";
            return sql;

        }

        public static string DescripcionUpdate()
        {
            string sql;
            sql = "Update Descripciones Set Descripcion = @Descripcion Where DescripcionId = @DescripcionId";
            return sql;

        }
        #endregion
    }
}
