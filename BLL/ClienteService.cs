using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ClienteService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRepository clienterepositorio;
        private readonly MascotaRepository mascotas;

        public ClienteService(string connectionString)
        {
           conexion = new ConnectionManager(connectionString);
            clienterepositorio = new ClienteRepository(conexion);
            mascotas = new MascotaRepository(conexion);
        }
        public string Guardar(Cliente cliente)
        {
            try
            {
                conexion.Open();
                clienterepositorio.Guardar(cliente);
                conexion.Close();
                return $"Se guardaron los datos del cliente satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }


        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var cliente = clienterepositorio.Buscar(identificacion);
                if (cliente != null)
                {
                    clienterepositorio.Eliminar(cliente);
                    conexion.Close();
                    return ($"El cliente {cliente.Nombre} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public ResponseClienteBusqueda Buscar(string identificacion)
        {
            ResponseClienteBusqueda respuesta = new ResponseClienteBusqueda();
            try
            {
                conexion.Open();
                respuesta.cliente= clienterepositorio.Buscar(identificacion);
                var mascota = mascotas.BuscarCliente(respuesta.cliente.Identificacion);
                respuesta.cliente.mascotas = mascota;
                conexion.Close();
                respuesta.Mensaje = (respuesta.cliente != null) ? "Se encontró el cliente solicitado" : "El cliente buscado no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }




        public ResponseClienteConsulta Consultar()
        {
           ResponseClienteConsulta respuesta = new ResponseClienteConsulta();
            try
            {

                conexion.Open();
                respuesta.clientes = clienterepositorio.ConsultarClientes();
                conexion.Close();
                if (respuesta.clientes.Count > 0)
                {
                    respuesta.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuesta.Mensaje = "No hay datos para consultar";
                }
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }



        public string Modificar(Cliente clienteNuevo)
        {
            try
            {
                conexion.Open();
                var clienteantiguo= clienterepositorio.Buscar(clienteNuevo.Identificacion);
                if (clienteantiguo != null)
                {
                    clienterepositorio.Modificar(clienteNuevo);
                    conexion.Close();
                    return ($"El registro {clienteNuevo.Nombre} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {clienteNuevo.Identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }


    }
    




    
}
