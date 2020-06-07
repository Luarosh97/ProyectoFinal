using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
     public class Persona
    {        
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public string Direccion { get; set; }

        public Persona( string identificacion,string nombre, string apellido, string telefono, string correo, string direccion)
        {
        
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        public Persona()
        {

        }

        public string NombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}
