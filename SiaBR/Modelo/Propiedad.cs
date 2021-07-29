using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class Propiedad
    {
        public int PropiedadId { get; set; }
        public int EmpresaId { get; set; }

        public string Clave { get; set; }
        public int TipoId { get; set; }
        public int DesarrolloId { get; set; }
        public int UbicacionId { get; set; }
        public string Coordenadas { get; set; }
        public string Calle { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string CP { get; set; }
        public int CiudadId { get; set; }
        public int EstadoId { get; set; }
        public string Pais { get; set; }
        public byte[] Foto { get; set; }
        public decimal Renta { get; set; }
        public decimal Moneda { get; set; }


        public string ClaveCatastral { get; set; }
        public decimal AreaTerreno { get; set; }
        public decimal AreaConstruccion { get; set; }
        public decimal Frente { get; set; }
        public decimal Fondo { get; set; }
        public decimal ValorCatastral { get; set; }
        public decimal ValorComercial { get; set; }
        public string EscriturasNombre { get; set; }
        public byte[] EscriturasArchivo { get; set; }
        public string CertificadoLGNombre { get; set; }
        public byte[] CertificadoLGArchivo { get; set; }
        public string FotosNombre { get; set; }
        public byte[] FotosArchivo { get; set; }
        public string UsoSueloNombre { get; set; }
        public byte[] UsoSueloArchivo { get; set; }
        public string PresupuestosNombre { get; set; }
        public byte[] PresupuestosArchivo { get; set; }
        public string PredialNombre { get; set; }
        public byte[] PredialArchivo { get; set; }

        public string LevantamientoNombre { get; set; }
        public byte[] LevantamientoArchivo { get; set; }



    }
}
