using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
   public class MascotaRepository
    {
        private readonly SqlConnection _connection;
        public MascotaRepository(ConnectionManager connection) {
            _connection = connection._conexion;
        }

  
        public void Guardar(Mascota Mascota)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Mascotasx (NombreMascota,IdCliente,TipoMascota,LaRaza,Color,FechaNacimiento) 
                                        values (@NombreMascota,@IdCliente,@TipoMascota,@LaRaza,@Color,@FechaNacimiento)";
                 command.Parameters.AddWithValue("@NombreMascota", Mascota.NombreMascota);
                command.Parameters.AddWithValue("@IdCliente", Mascota.IdCliente);
                command.Parameters.AddWithValue("@TipoMascota", Mascota.TipoMascota);
                command.Parameters.AddWithValue("@LaRaza", Mascota.laRaza);
                command.Parameters.AddWithValue("@Color", Mascota.Color);
                command.Parameters.AddWithValue("@FechaNacimiento", Mascota.FechaNacimiento);
            
                var filas = command.ExecuteNonQuery();
            }

        }

     


   

        public IList<Mascota> BuscarCliente(string codigo)
        {
            SqlDataReader dataReader;
            IList<Mascota> mascotas = new List<Mascota>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Mascotasx where IdCliente=@IdCliente";
                command.Parameters.AddWithValue("@IdCliente", codigo);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Mascota _m = Mapear(dataReader);
                        mascotas.Add(_m);
                    }
                }
                return mascotas;
            }
        }

        private Mascota Mapear(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
           Mascota mascota = new Mascota();
            mascota.Codigo = (int)dataReader["Codigo"];
            mascota.NombreMascota = (string)dataReader["NombreMascota"];
            mascota.IdCliente = (string)dataReader["IdCliente"];
            mascota.TipoMascota= (string)dataReader["TipoMascota"];
            mascota.laRaza = (string)dataReader["LaRaza"];
            mascota.Color = (string)dataReader["Color"];
            mascota.FechaNacimiento= (DateTime)dataReader["FechaNacimiento"];
           
          
            return mascota;
        }



        public IList<Mascota> ConsultarMascotas()
        {
            SqlDataReader dataReader;
            List<Mascota> mascotas = new List<Mascota>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Mascotasx";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Mascota mascota = Mapear(dataReader);
                        mascotas.Add(mascota);
                    }
                }
            }
            return mascotas;
        }

        public int Totalizar()
        {
          return ConsultarMascotas().Count();
        }

        public int TotalizarTipo(string tipo)
        {

            return ConsultarMascotas().Where(p => p.TipoMascota.Equals(tipo)).Count();
        }
        public IList<Mascota> ConsultarPerros()
        {
            return ConsultarMascotas().Where(p => p.TipoMascota == "Perro").ToList();
        }

        public IList<Mascota> ConsultarLoros()
        {
            return ConsultarMascotas().Where(p => p.TipoMascota == "Loro").ToList();
        }

        public IList<Mascota> ConsultarGatos()
        {
            return ConsultarMascotas().Where(p => p.TipoMascota == "Gato").ToList();
        }

    }


    }

