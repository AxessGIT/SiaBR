using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class Contrato
    {
        public int ContratoId { get; set; }
        public int Folio { get; set; }
        public int PropiedadId { get; set; }
        public int ArrendatarioId { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public short Moneda { get; set; }

        public decimal Renta { get; set; }
        public string ContratoNombre { get; set; }
        public byte[] ContratoArchivo { get; set; }
        public string FianzaNombre { get; set; }
        public byte[] FianzaArchivo { get; set; }
        public bool Facturar { get; set; }
    }
}
