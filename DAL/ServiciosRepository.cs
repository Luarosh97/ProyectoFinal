using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class ServiciosRepository
    {
        private readonly SqlConnection _connection;
        public ServiciosRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public void Guardar(Servicio Servicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Serviciosx (Codigo,Nombre,Base) 
                                        values (@Codigo,@Nombre,@Base)";
                command.Parameters.AddWithValue("@Codigo", Servicio.Codigo);
                command.Parameters.AddWithValue("@Nombre", Servicio.Nombre);
                command.Parameters.AddWithValue("@Base", Servicio.Base);

                var filas = command.ExecuteNonQuery();
            }

        }

        public void Eliminar(Servicio Servicio)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from Serviciosx where codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", Servicio.Codigo);
                command.ExecuteNonQuery();
            }
        }


        public Servicio Buscar(int codigo)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Serviciosx where codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return Mapear(dataReader);
            }
        }

        private Servicio Mapear(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Servicio servicio = new Servicio();
            servicio.Codigo = (int)dataReader["Codigo"];
            servicio.Nombre = (string)dataReader["Nombre"];
            servicio.Base = (int)dataReader["Base"];

            return servicio;
        }



        public IList<Servicio> ConsultarServicios()
        {
            SqlDataReader dataReader;
            List<Servicio> servicios = new List<Servicio>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Serviciosx";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Servicio servicio = Mapear(dataReader);
                        servicios.Add(servicio);
                    }
                }
            }
            return servicios;
        }


        public void Modificar(Servicio Servicio)

        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update Serviciosx set  nombre=@Nombre, base=@Base where codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", Servicio.Codigo);
                command.Parameters.AddWithValue("@Nombre", Servicio.Nombre);
                command.Parameters.AddWithValue("@Base", Servicio.Base);
                var filas = command.ExecuteNonQuery();
            }
        }
    }
}
