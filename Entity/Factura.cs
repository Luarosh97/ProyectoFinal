using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura

    {

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
            PcjDescuento = 0;
            PcjGanancia = 30;
            PcjIva = 19;

        }

        public Factura(Cliente cliente, Empleado empleado, List<DetalleFactura> detalles) {
            Cliente = cliente;
            Empleado = empleado;
            Detalles = detalles;
            PcjDescuento = 0;
            PcjGanancia = 30;
            PcjIva = 19;

        }
        /* public string IdEmpleado { get; set; }
         public string IdCliente {get; set;}
         //public string NroComprobante {get; set;}
         public DateTime FechaEmision { get; set; }
         public string Codigo { get; set; }
         public double Subtotal { get { return detallesFactura.Sum(d => d.ValorTotal); } }
         public Cliente Cliente { get; set; }
         public Empleado Empleado { get; set; }
         public string TipoDocumento { get; set; }       
         public List<DetalleFactura> detallesFactura { get; set; }

         public void AgregarDetalleFactura(DetalleFactura detalleFactura)
         {
              detallesFactura.Add(detalleFactura);
         }

         public double Descuento

         {

             get { return detallesFactura.Sum(d => d.Descuento); }

         }


         public double Total
         {
             get
             {
                 return (Descuento > 0) ? Subtotal - Descuento : Subtotal;
             }
         }*/

        public int Codigo { get; set; } 

        public Cliente Cliente { get; set; }

        public Empleado Empleado { get; set; }

        public List<DetalleFactura> Detalles { get; set; }

        public double PcjIva { get; set; }

        public double Iva => this.SubTotal * this.PcjIva / 100;

        public double SubTotal => this.Detalles.Sum(x => x.Servicio.Base);

        public double PcjGanancia { get; set; } //PORCENTAJE DE GANANCIA.

        public double Ganancia => this.SubTotal * this.PcjGanancia / 100; 

        public double PcjDescuento { get; set; }

        public double Descuento => this.SubTotal * this.PcjDescuento / 100; 

        public int NServicios => this.Detalles.Count; //NUMERO DE SERVICIOS COBRADOS

        public double Total => this.SubTotal + this.Iva + this.Ganancia - this.Descuento;

        public override string ToString()
        {
            return $"Cliente: {Cliente.NombreCompleto()}\nEmpleado: {Empleado.NombreCompleto()}\nServicios: {NServicios}\nSubTotal: {SubTotal}\nTotal: {Total}\nDescuento: {Descuento}\nGanancia: {Ganancia}\n";
        }
    }
}


   
