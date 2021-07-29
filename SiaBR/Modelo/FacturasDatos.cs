using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class FacturasDatos
    {
        public int FacturaId { get; set; }
        public string Serie { get; set; }
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public string ClavePropiedad { get; set; }
        public string Arrendatario { get; set; }
        public decimal Importe { get; set; }
    }
}
