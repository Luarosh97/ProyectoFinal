using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ResponseEmpleado
    {

        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Empleado> empleados { get; set; }
    }
    public class ResponseBusquedaEmpleado
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Empleado empleado{ get; set; }
    }



}

