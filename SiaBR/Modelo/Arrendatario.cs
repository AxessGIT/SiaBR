using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class Arrendatario
    {
        public int ArrendatarioId { get; set; }
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public int CiudadId { get; set; }
        public int EstadoId { get; set; }

        public string Pais { get; set; }
        public string CP { get; set; }
        public string Telefonos { get; set; }
        public string Correos { get; set; }
        public string IdentificacionNombre { get; set; }
        public byte[] IdentificacionArchivo { get; set; }

        public string ComprobanteNombre { get; set; }
        public byte[] ComprobanteArchivo { get; set; }

        public string AvalNombre { get; set; }
        public byte[] AvalArchivo { get; set; }

    }
}
