﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class ContratoDatos
    {
        public int ContratoId { get; set; }
        public int Folio { get; set; }
        public int PropiedadId { get; set; }
        public string Clave { get; set; }
        public int ArrendatarioId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public short Moneda { get; set; }
        public decimal Renta { get; set; }
        public bool Facturar { get; set; }

        public string Mon 
        { get 
            { 
                return Moneda==1?"USD":"MXN";
            }
        }

    }
}
