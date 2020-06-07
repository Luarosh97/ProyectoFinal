using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
  

    public class ResponseClienteConsulta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Cliente> clientes{ get; set; }
    }

    public class ResponseClienteBusqueda
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente cliente { get; set; }
    }


}
