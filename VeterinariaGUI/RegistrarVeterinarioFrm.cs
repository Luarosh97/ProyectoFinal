using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using Entity;

namespace VeterinariaGUI
{
    public partial class RegistrarVeterinarioFrm : Form
    {
        EmpleadoService EmpleadoService;
        public RegistrarVeterinarioFrm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
           EmpleadoService = new EmpleadoService(connectionString);

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

        private void CancelarVeterinarioBtn_Click(object sender, EventArgs e)
        {
            string identificacion = CedulaTxt.Text;
            if (identificacion != "")
            {
                ResponseBusquedaEmpleado respuesta = EmpleadoService.Buscar(identificacion);
                if (respuesta.empleado != null)
                {
                    identificacion = CedulaTxt.Text;
                    var mensaje = EmpleadoService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Confirmacion de ELiminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"La persona con la identificación {identificacion} no se encuentra registrada");
                }


            }
        }

        private void GuardarVeterinarioBtn_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearEmpleado();
            string mensaje = EmpleadoService.Guardar(empleado);
            MessageBox.Show(mensaje);
        }

        private Empleado MapearEmpleado()
        {
            Empleado empleado = new Empleado();
           empleado.Identificacion = CedulaTxt.Text;
           empleado.Nombre = NombreClienteTxt.Text;
           empleado.Apellido = ApellidoTxt.Text;
           empleado.Cargo =TipoCmb.Text;
           empleado.Telefono = TelefonoTxt.Text;
           empleado.FechaIngreso = date.Value;
           empleado.Correo = CorreoTxt.Text;
           empleado.Direccion = DireccionTxt.Text;

            return empleado;

        }

        private void DireccionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LimpiarVeterinarioBtn_Click(object sender, EventArgs e)
        {
            CedulaTxt.Text = "";
            NombreClienteTxt.Text = "";
            ApellidoTxt.Text = "";
            TelefonoTxt.Text = "";
            CorreoTxt.Text = "";
            DireccionTxt.Text = "";
          TipoCmb.Text = "";

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            ResponseBusquedaEmpleado respuesta = new ResponseBusquedaEmpleado();
            string identificacion = CedulaTxt.Text;

            if (identificacion != "")
            {
                respuesta = EmpleadoService.Buscar(identificacion);

                if (respuesta.empleado!= null)
                {
                   
                    NombreClienteTxt.Text = respuesta.empleado.Nombre;
                    ApellidoTxt.Text = respuesta.empleado.Apellido;
                    TipoCmb.Text = respuesta.empleado.Cargo;
                    TelefonoTxt.Text = respuesta.empleado.Telefono;
                    date.Value = respuesta.empleado.FechaIngreso;
                    CorreoTxt.Text = respuesta.empleado.Correo;
                    DireccionTxt.Text = respuesta.empleado.Direccion;
                }
                else
                {
                    MessageBox.Show($"El empleado con la identificación {identificacion} no se encuentra registrada");
                }

            }
            else
            {
                MessageBox.Show("digite una identificacion a buscar");
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {

            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Empleado Empleado  = MapearEmpleado();
                string mensaje =EmpleadoService.Modificar(Empleado);

                MessageBox.Show("Empleado Modificado Correctamente");
            }
        }
    }
    }

