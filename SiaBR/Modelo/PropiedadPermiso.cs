using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class PropiedadPermiso
    {
        public int PropiedadPermisoId { get; set; }
        public int PropiedadId { get; set; }
        public string Nombre { get; set; }
        public byte[] Archivo { get; set; }
        public string Descripcion { get; set; }

    }
}
