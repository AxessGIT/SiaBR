using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class PropiedadRecibo
    {
        public int PropiedadReciboId { get; set; }
        public int PropiedadId { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Tipo { get; set; }

        public string Nombre { get; set; }

        public byte[] Archivo { get; set; }
    }
}
