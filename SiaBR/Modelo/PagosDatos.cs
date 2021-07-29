using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class PagosDatos
    {
        public int PagoId { get; set; }
        public int ContratoId { get; set; }

        public bool Seleccionado { get; set; }
        public int Folio { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int ArrendatarioId { get; set; }

        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Renta { get; set; }
        public decimal Importe { get; set; }
    }
}
