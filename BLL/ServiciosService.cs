using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ServiciosService
    {
        private readonly ConnectionManager conexion;
        private readonly ServiciosRepository serviciorepositorio;

        public ServiciosService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            serviciorepositorio = new ServiciosRepository(conexion);
        }

        public string Guardar(Servicio servicio)
        {
            try
            {
                conexion.Open();
                serviciorepositorio.Guardar(servicio);
                conexion.Close();
                return $"Se guardaron los datos del servicio satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }


        public string Eliminar(int codigo)
        {
            try
            {
                conexion.Open();
                var servicio = serviciorepositorio.Buscar(codigo);
                if (servicio != null)
                {
                    serviciorepositorio.Eliminar(servicio);
                    conexion.Close();
                    return ($"El Servicio {servicio.Nombre} con codigo {servicio.Codigo} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el servicio {codigo} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public ResponseBusquedaServicio Buscar(int codigo)
        {
            ResponseBusquedaServicio respuesta = new ResponseBusquedaServicio();

            try
            {
                conexion.Open();
                respuesta.servicio = serviciorepositorio.Buscar(codigo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.servicio != null) ? "Se encontró el servicio solicitado" : "el servicio solicitado no existe";
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




        public RespuestaConsultaServicio Consultar()
        {
            RespuestaConsultaServicio respuesta = new RespuestaConsultaServicio();
            try
            {

                conexion.Open();
                respuesta.servicios = serviciorepositorio.ConsultarServicios();
                conexion.Close();
                if (respuesta.servicios.Count > 0)
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



        public string Modificar(Servicio servicioNuevo)
        {
            try
            {
                conexion.Open();
                var servicioantiguo = serviciorepositorio.Buscar(servicioNuevo.Codigo);
                if (servicioantiguo != null)
                {
                    serviciorepositorio.Modificar(servicioNuevo);
                    conexion.Close();
                    return ($"El registro {servicioNuevo.Nombre} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {servicioNuevo.Codigo} no se encuentra registrada.");
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
