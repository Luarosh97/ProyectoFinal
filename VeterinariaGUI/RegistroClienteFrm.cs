using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using System.Configuration;

namespace VeterinariaGUI
{
    public partial class RegistroClienteFrm : Form
    {

        ClienteService clienteService;

        public RegistroClienteFrm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
            clienteService= new ClienteService(connectionString);

            InitializeComponent();
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarMascotaBtn_Click(object sender, EventArgs e)
        {   Cliente cliente = MapearCliente();
            string mensaje = clienteService.Guardar(cliente);
            MessageBox.Show(mensaje);
        }

        private Cliente MapearCliente()
        {
           Cliente cliente  = new Cliente();
           cliente.Identificacion= CedulaTxt.Text;
           cliente.Nombre= NombreClienteTxt.Text;
           cliente.Apellido= ApellidoClienteTxt.Text;
            cliente.Telefono= TelefonoTxt.Text;
            cliente.FechaRegistro= dateFecha.Value;
            cliente.Correo= CorreoTxt.Text;
            cliente.Direccion = DireccionTxt.Text;
            
            return cliente;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           CedulaTxt.Text="";
           NombreClienteTxt.Text="";
           ApellidoClienteTxt.Text="";
           TelefonoTxt.Text="";
           CorreoTxt.Text="";
           DireccionTxt.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResponseClienteBusqueda respuesta = new ResponseClienteBusqueda();
            string identificacion= CedulaTxt.Text;

            if (identificacion != "")
            {
                 respuesta = clienteService.Buscar(identificacion);

                if (respuesta.cliente != null)
                {
                 //  Cliente cliente = respuesta.cliente;
                   NombreClienteTxt.Text= respuesta.cliente.Nombre.ToString();
                   ApellidoClienteTxt.Text= respuesta.cliente.Apellido.ToString();
                   TelefonoTxt.Text= respuesta.cliente.Telefono.ToString();
                   dateFecha.Value= respuesta.cliente.FechaRegistro;
                   CorreoTxt.Text= respuesta.cliente.Correo.ToString();
                   DireccionTxt.Text = respuesta.cliente.Direccion.ToString();
                }
                else
                {
                    MessageBox.Show($"El cliente con la identificación {identificacion} no se encuentra registrada");
                }

            }
            else
            {
                MessageBox.Show("digite una identificacion a buscar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string identificacion = CedulaTxt.Text;
            if (identificacion != "")
            {
                ResponseClienteBusqueda respuesta = clienteService.Buscar(identificacion);
                if (respuesta.cliente!= null)
                {
                    identificacion = CedulaTxt.Text;
                    var mensaje = clienteService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Confirmacion de ELiminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"La persona con la identificación {identificacion} no se encuentra registrada");
                }


            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes) { 
                Cliente cliente = MapearCliente();
                string mensaje = clienteService.Modificar(cliente);

                MessageBox.Show("Cliente Modificado Correctamente");
            }
        }
    }
}
