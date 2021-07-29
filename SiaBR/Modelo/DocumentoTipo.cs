using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class DocumentoTipo
    {
        public int DocumentoTipoId { get; set; }
        public string Descripcion { get; set; }
        public bool Requerido { get; set; }
    }
}
