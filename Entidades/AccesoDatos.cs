using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class AccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static AccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog=tpDB;Integrated Security=true";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        //select de tabla usuario
        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM usuario";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        usuarios.Add(new Usuario(dataReader["nombre"].ToString(), dataReader["nombreUsuario"].ToString(), dataReader["contraseña"].ToString(), Convert.ToInt32(dataReader["id"])));
                    }

                    return usuarios;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //insert a tabla usuario
        public static void Guardar(Usuario usuario)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"INSERT INTO usuario (nombre, nombreUsuario, contraseña, victorias, derrotas) " +
                    $"VALUES (@nombre, @nombreUsuario, @contraseña, @victorias, @derrotas)";

                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                command.Parameters.AddWithValue("@victorias", usuario.Victorias);
                command.Parameters.AddWithValue("@derrotas", usuario.Derrotas);
                int filasAfectadas = command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //update de la tabla usuario, columnas victorias y derrotas
        public static void Actualizar(Usuario usuario)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"UPDATE usuario SET victorias = victorias + @victorias, derrotas = derrotas + @derrotas WHERE id = @id";

                command.Parameters.AddWithValue("@victorias", usuario.Victorias);
                command.Parameters.AddWithValue("@derrotas", usuario.Derrotas);
                command.Parameters.AddWithValue("@id", usuario.Id);

                int filasAfectadas = command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //insert de tabla partida
        public static void GuardarPartida(Partida partida)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"INSERT INTO partida (id, nombreUsuario, nombreOponente, ganador) " +
                    $"VALUES (@id, @nombreUsuario, @nombreOponente, @ganador)";

                command.Parameters.AddWithValue("@id", partida.Id);
                command.Parameters.AddWithValue("@nombreUsuario", partida.JugadorUno.Nombre);
                command.Parameters.AddWithValue("@nombreOponente", partida.JugadorDos.Nombre);
                command.Parameters.AddWithValue("@ganador", partida.JugadorGanador.Nombre);

                int filasAfectadas = command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //select de la tabla partida
        public static List<Partida> LeerPartida()
        {
            List<Partida> partidas = new List<Partida>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM partida";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        partidas.Add(new Partida(Convert.ToInt32(dataReader["id"]), dataReader["nombreUsuario"].ToString(), dataReader["nombreOponente"].ToString(), dataReader["ganador"].ToString()));
                    }

                    return partidas;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //select de tabla partida filtrando segun el usuario
        public static List<Partida> LeerFiltrado(Usuario usuario)
        {
            List<Partida> partidas = new List<Partida>();

            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"SELECT * FROM partida WHERE nombreUsuario = @nombreUsuario";
                command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        partidas.Add(new Partida(Convert.ToInt32(dataReader["id"]), dataReader["nombreUsuario"].ToString(), dataReader["nombreOponente"].ToString(), dataReader["ganador"].ToString()));
                    }

                    return partidas;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
