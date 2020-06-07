using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class EmpleadoService
    {
        private readonly ConnectionManager conexion;
        private readonly EmpleadoRepository empleadorepositorio;

        public EmpleadoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
           empleadorepositorio = new EmpleadoRepository(conexion);
        }

        public string Guardar(Empleado empleado)
        {
            try
            {
                conexion.Open();
                empleadorepositorio.Guardar(empleado);
                conexion.Close();
                return $"Se guardaron los datos del veterinario satisfactoriamente";
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
                var empleado = empleadorepositorio.Buscar(identificacion);
                if (empleado != null)
                {
                   empleadorepositorio.Eliminar(empleado);
                    conexion.Close();
                    return ($"El cliente {empleado.Nombre} se ha eliminado satisfactoriamente.");
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
        public ResponseBusquedaEmpleado Buscar(string identificacion)
        {
            ResponseBusquedaEmpleado respuesta = new ResponseBusquedaEmpleado();

            try
            {
                conexion.Open();
                respuesta.empleado = empleadorepositorio.Buscar(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.empleado!= null) ? "Se encontró la mascota solicitada" : "la mascota buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje= $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }




        public ResponseEmpleado Consultar()
        {
            ResponseEmpleado respuesta = new ResponseEmpleado();
            try
            {

                conexion.Open();
                respuesta.empleados = empleadorepositorio.ConsultarEmpleados();
                conexion.Close();
                if (respuesta.empleados.Count > 0)
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



        public string Modificar(Empleado empleadonuevo)
        {
            try
            {
                conexion.Open();
                var empleadoantiguo=empleadorepositorio.Buscar(empleadonuevo.Identificacion);
                if (empleadoantiguo != null)
                {
                    empleadorepositorio.Modificar(empleadonuevo);
                    conexion.Close();
                    return ($"El registro {empleadonuevo.Nombre} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {empleadonuevo.Identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }

        public IList<Empleado> ConsultarXFecha(DateTime fecha)
        {
            conexion.Open();
            IList<Empleado> empleados = empleadorepositorio.ConsultarXFecha(fecha);
            conexion.Close();
            return empleados;
        }




    }
}
