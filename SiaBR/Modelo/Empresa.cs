using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
        public string Direccion { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public int CiudadId { get; set; }
        public int EstadoId { get; set; }
        public string CP { get; set; }
    }
}
