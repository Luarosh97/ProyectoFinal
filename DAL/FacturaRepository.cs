using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Entity;

namespace DAL
{
    public class FacturaRepository
    {
        private readonly SqlConnection _connection;

        public FacturaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Factura Factura)
        {
            using (var command = _connection.CreateCommand())
            {
                //command.CommandText = @"Insert Into facturas (Codigo,Cliente,Empleado,PcjIva,Iva,PsjDescuento,Descuento,PsjGanancia,Ganancia,NServicios,SubTotal,Total)
                command.CommandText = @"Insert Into Facturas (IdCliente,IdEmpleado,PcjIva,Iva,PsjDescuento,Descuento,PsjGanancia,Ganancia,NServicios,SubTotal,Total)
                                        values (@IdCliente,@IdEmpleado,@PcjIva,@Iva,@PsjDescuento,@Descuento,@PsjGanancia,@Ganancia,@NServicios,@SubTotal,@Total)";
                //command.Parameters.AddWithValue("@Codigo", Factura.Codigo);
                command.Parameters.AddWithValue("@IdCliente", Factura.Cliente.Identificacion);
                command.Parameters.AddWithValue("@IdEmpleado", Factura.Empleado.Identificacion);
                command.Parameters.AddWithValue("@PcjIva", Factura.PcjIva);
                command.Parameters.AddWithValue("@Iva", Factura.Iva);
                command.Parameters.AddWithValue("@PsjDescuento", Factura.PcjDescuento);
                command.Parameters.AddWithValue("@Descuento", Factura.Descuento);
                command.Parameters.AddWithValue("@PsjGanancia", Factura.PcjGanancia);
                command.Parameters.AddWithValue("@Ganancia", Factura.Ganancia);
                command.Parameters.AddWithValue("@NServicios", Factura.NServicios);
                command.Parameters.AddWithValue("@SubTotal", Factura.SubTotal);
                command.Parameters.AddWithValue("@Total", Factura.Total);
                var filas = command.ExecuteNonQuery();
            }            
        }

        public IList<Factura> Consultar()
        {
            SqlDataReader dataReader;
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Facturas";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura Factura = MapearFactura(dataReader);
                        facturas.Add(Factura);
                    }
                }
            }
            return facturas;
        }

        public Factura Buscar(int codigo)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Facturas where Codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return MapearFactura(dataReader);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = "Delete from Facturas where Codigo=@Codigo";
                    command.Parameters.AddWithValue("@Codigo", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Last()
        {
            try
            {
                //select max(Codigo) from Facturas;
                SqlDataReader dataReader;
                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = "select max(Codigo) as Codigo from Facturas;";
                    dataReader = command.ExecuteReader();
                    dataReader.Read();
                    return (int)dataReader["Codigo"];
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }


        private Factura MapearFactura(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Factura Factura = new Factura();
            Factura.Codigo = (int)dataReader["Codigo"];
            Factura.Cliente = new Cliente((string)dataReader["IdCliente"]);
            Factura.Empleado = new Empleado((string)dataReader["IdEmpleado"]);
            Factura.PcjIva = (double)dataReader["PcjIva"];
            Factura.PcjDescuento = (double)dataReader["PsjDescuento"];
            Factura.PcjGanancia = (double)dataReader["PsjGanancia"];
            return Factura; //SE DESCARGÖ EL PORTATIL ESPARTE AHí :v
        }

    }
}
