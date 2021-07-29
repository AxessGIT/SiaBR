using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class PropiedadDocumento
    {
        public int PropiedadDocumentoId { get; set; }
        public int PropiedadId { get; set; }
        public int TipoId { get; set; }
        public string Tipo { get; set; }
        public string Archivo { get; set; }
        public string Observaciones { get; set; }
        public byte[] Contenido { get; set; }

    }
}
