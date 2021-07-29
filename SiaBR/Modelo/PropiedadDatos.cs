using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaBR.Modelo
{
    public class PropiedadDatos
    {
        public int PropiedadId { get; set; }
        public string Clave { get; set; }
        public string Tipo { get; set; }
        public string Desarrollo { get; set; }
        public string Ubicacion { get; set; }
        public string Calle { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string CP { get; set; }
        public string Direccion { 
            get {
                string dir = "";
                dir = string.IsNullOrEmpty(Calle) ? dir : Calle;
                dir += string.IsNullOrEmpty(NumExt) ? "" : " " + NumExt;
                dir += string.IsNullOrEmpty(NumInt) ? "" : " " + NumInt;
                dir += string.IsNullOrEmpty(Colonia) ? "" : " " + Colonia;
                return dir;
            } 
        }
    }
}


/*Select Propiedades.PropiedadId, Propiedades.Clave, Tipos.Descripcion As Tipo, Desarrollos.Descripcion as Desarrollo," +
                "Ubicaciones.Descripcion As Ubicacion,Propiedades.Calle,Propiedades.NumExt,Propiedades.NumInt,Propiedades.Colonia,Propiedades.Cp" +
                " From Propiedades" +*/