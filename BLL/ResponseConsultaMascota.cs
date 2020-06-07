using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ResponseConsultaMascota
    {
        
            public bool Error { get; set; }
            public string Mensaje {get; set;}
            public IList<Mascota> mascotas {get; set;}
        }

    }

