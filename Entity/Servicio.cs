using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public int Codigo {get;set;}
        public string Nombre {get; set;}
        //public string Desc { get; set; } //DESCRIPCION DEL SERVICIO
        public double Base {get;set;} //PRECIO BASE DEL SERVICIO
       
  
        public Servicio()
        {
            this.Base = 0;
            this.Codigo = 0;
            this.Nombre = "";
            //this.Desc = "";
        }

        public Servicio(int Codigo)
        {
            this.Base = 0;
            this.Codigo = Codigo;
            this.Nombre = "";
            //this.Desc = "";
        }

        public Servicio(string nombre, double valor)
        { 
            this.Codigo = 0; //SE AUTOGENERA EN DB
            this.Nombre = nombre;
           // this.Desc = descripcion;
            this.Base = valor;
        }

        public Servicio(int codigo, string nombre, double valor)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Base = valor;
        }


    }
}
