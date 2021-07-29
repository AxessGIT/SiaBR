using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class Propietario
    {
        public int PropiedadPropietarioId { get; set; }
        public int PropiedadId { get; set; }
        public string Nombre { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
