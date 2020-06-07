using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente : Persona
    {
      public DateTime FechaRegistro {get;set;}
      public IList<Mascota> mascotas {get;set;}
        
        //ESTE CONSTRUCTOR NO SIGUE LOS ESTANDARES DE CODIGO LIMPIO MAX 3 PARAMETROS
        public Cliente(DateTime fechaRegistro, string identificacion, string nombre, string apellidos, string telefono, string correo, string direccion)
            :base( identificacion,nombre, apellidos, telefono, correo,direccion)
        {
            FechaRegistro = fechaRegistro;
           
        }

        public Cliente()
        {
            this.mascotas = new List<Mascota>();
        }

        public Cliente(string identificacion)
        {
            this.Identificacion = identificacion;
            this.mascotas = new List<Mascota>();
        }
    }
}
