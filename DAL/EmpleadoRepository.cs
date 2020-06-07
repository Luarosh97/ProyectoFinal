using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class EmpleadoRepository
    {

        private readonly SqlConnection _connection;

        public EmpleadoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Empleado empleado)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into empleados (Identificacion,Nombre,Apellido,Cargo,Telefono,FechaIngreso,Correo,Direccion) 
                                        values (@Identificacion,@Nombre,@Apellido,@Cargo,@Telefono,@FechaIngreso,@Correo,@Direccion)";
                command.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);
                command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                command.Parameters.AddWithValue("@Apellido",empleado.Apellido);
                command.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                command.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
                command.Parameters.AddWithValue("@Correo", empleado.Correo);
                command.Parameters.AddWithValue("@Direccion", empleado.Direccion);
           
                var filas = command.ExecuteNonQuery();
            }
        }

        public void Eliminar(Empleado empleado)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from empleados where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);
                command.ExecuteNonQuery();
            }
        }

        public IList<Empleado> ConsultarEmpleados()
        {
            SqlDataReader dataReader;
            List<Empleado> empleados = new List<Empleado>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from empleados";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                      Empleado empleado= MapearEmpleado(dataReader);
                        empleados.Add(empleado);
                    }
                }
            }
            return empleados;
        }

        private Empleado MapearEmpleado(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
           Empleado empleado =new Empleado();
           empleado.Identificacion = (string)dataReader["Identificacion"];
           empleado.Nombre = (string)dataReader["Nombre"];
            empleado.Apellido = (string)dataReader["Apellido"];
            empleado.Cargo= (string)dataReader["Cargo"];
            empleado.Telefono = (string)dataReader["Telefono"];
            empleado.FechaIngreso = (DateTime)dataReader["FechaIngreso"];
            empleado.Correo = (string)dataReader["Correo"];
            empleado.Direccion = (string)dataReader["Direccion"];
            return empleado;
        }

        public Empleado Buscar(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from empleados where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return MapearEmpleado(dataReader);
            }
        }


        public void Modificar(Empleado empleado)

        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update empleados set  nombre=@Nombre, apellido=@Apellido,cargo=@Cargo,telefono=@Telefono,fechaingreso=@FechaIngreso,correo=@Correo,direccion=@Direccion where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);
                command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                command.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                command.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                command.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
                command.Parameters.AddWithValue("@Correo", empleado.Correo);
                command.Parameters.AddWithValue("@Direccion", empleado.Direccion);

                var filas = command.ExecuteNonQuery();
            }
        }
    }
}
