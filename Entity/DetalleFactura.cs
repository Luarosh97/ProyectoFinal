using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {   
        public int Codigo { get; set; }
        public int Factura { get; set; }
        public Servicio Servicio { get; set; }      
        public Mascota Mascota { get; set; }

        /*public DetalleFactura()
        {
            this.Factura = "";
            this.Servicio = new Servicio();
            this.Mascota = new Mascota();
        }*/

        public DetalleFactura(Servicio servicios, Mascota mascota)
        {
            this.Servicio = servicios;
            this.Mascota = mascota;
        }

        public DetalleFactura()
        {
        }

    }
}
