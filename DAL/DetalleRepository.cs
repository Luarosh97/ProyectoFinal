using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Entity;

namespace DAL
{
    public class DetalleRepository
    {
        private readonly SqlConnection _connection;

        public DetalleRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(DetalleFactura Detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into detallesx (Factura,IdServicio,IdMascota)
                                        values (@Factura,@IdServicio,@IdMascota)";

                command.Parameters.AddWithValue("@Factura", Detalle.Factura);
                command.Parameters.AddWithValue("@IdServicio", Detalle.Servicio.Codigo);
                command.Parameters.AddWithValue("@IdMascota", Detalle.Mascota.Codigo);
                var filas = command.ExecuteNonQuery();
            }
        }

        public IList<DetalleFactura> ConsultarDetalles()
        {
            SqlDataReader dataReader;
            List<DetalleFactura> detalles = new List<DetalleFactura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from detallesx ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        DetalleFactura Detalle = MapearDetalle(dataReader);
                        detalles.Add(Detalle);
                    }
                }
            }
            return detalles;
        }

        public IList<DetalleFactura> BuscarFac(int id)
        {
            SqlDataReader dataReader;
            List<DetalleFactura> detalles = new List<DetalleFactura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from detallesx where Factura=@fac";
                command.Parameters.AddWithValue("@fac", id);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        DetalleFactura Detalle = MapearDetalle(dataReader);
                        detalles.Add(Detalle);
                    }
                }
            }
            return detalles;
        }

        public DetalleFactura Buscar(int codigo)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from detallesx  where Codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return MapearDetalle(dataReader);
            }
        }

        public void Eliminar(int fact)
        {
            try
            {
                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = "Delete from detallesx  where Factura=@Factura";
                    command.Parameters.AddWithValue("@Factura", fact);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private DetalleFactura MapearDetalle(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            DetalleFactura Detalle = new DetalleFactura();
            Detalle.Codigo = (int)dataReader["Codigo"];
            Detalle.Factura = (int)dataReader["Factura"];
            Detalle.Servicio = new Servicio((int)dataReader["IdServicio"]);
            Detalle.Mascota = new Mascota((int)dataReader["IdMascota"]);
            return Detalle;
        }

    }
}
