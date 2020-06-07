using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class ClienteRepository
    {
      
            private readonly SqlConnection _connection;
     
         public ClienteRepository(ConnectionManager connection)
            {
            _connection = connection._conexion;
            }
            public void Guardar(Cliente Cliente)
            {
                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = @"Insert Into clientes (Identificacion,Nombre,Apellido,Telefono,FechaRegistro,Correo,Direccion) 
                                        values (@Identificacion,@Nombre,@Apellido,@Telefono,@FechaRegistro,@Correo,@Direccion)";
                    command.Parameters.AddWithValue("@Identificacion", Cliente.Identificacion);
                    command.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
                    command.Parameters.AddWithValue("@Apellido", Cliente.Apellido);
                    command.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                    command.Parameters.AddWithValue("@FechaRegistro", Cliente.FechaRegistro);
                    command.Parameters.AddWithValue("@Correo", Cliente.Correo);
                     command.Parameters.AddWithValue("@Direccion", Cliente.Direccion);
                    var filas = command.ExecuteNonQuery();
                }
            }

        public void Eliminar(Cliente Cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from clientes where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", Cliente.Identificacion);
                command.ExecuteNonQuery();
            }
        }

        public IList<Cliente> ConsultarClientes()
        {
            SqlDataReader dataReader;
            List<Cliente> clientes= new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from clientes";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                      Cliente Cliente = Mapear(dataReader);
                        clientes.Add(Cliente);
                    }
                }
            }
            return clientes;
        }

        private Cliente Mapear(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Cliente Cliente = new Cliente();
            Cliente.Identificacion= (string)dataReader["Identificacion"];
            Cliente.Nombre = (string)dataReader["Nombre"];
            Cliente.Apellido = (string)dataReader["Apellido"];
            Cliente.Telefono = (string)dataReader["Telefono"];
            Cliente.FechaRegistro = (DateTime)dataReader["FechaRegistro"];
            Cliente.Correo= (string)dataReader["Correo"];
            Cliente.Direccion = (string)dataReader["Direccion"];
            return Cliente;
        }

        public Cliente Buscar(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from clientes where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return Mapear(dataReader);
            }
        }


        public void Modificar(Cliente Cliente)
           
        { 
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update clientes set  nombre=@Nombre, apellido=@Apellido, telefono=@Telefono,fechaRegistro=@Fecharegistro,correo=@Correo,direccion=@Direccion where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", Cliente.Identificacion);
                command.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", Cliente.Apellido);
                command.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                command.Parameters.AddWithValue("@FechaRegistro", Cliente.FechaRegistro);
                command.Parameters.AddWithValue("@Correo", Cliente.Correo);
                command.ExecuteNonQuery();
            }
        }

        public IList<Cliente> ConsultarXFecha(DateTime fecha)
        {
            return ConsultarClientes().Where(E => E.FechaRegistro.Year.Equals(fecha.Year) && E.FechaRegistro.Month.Equals(fecha.Month)).ToList();
        }

    }
}
