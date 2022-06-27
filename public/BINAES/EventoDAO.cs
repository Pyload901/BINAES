using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BINAES
    
{
    public static class EventoDAO
    {
        // CRUDE

        // CREATE
        public static bool Crear(Evento evento)
        {
            bool exito = true;
            try
            {
                string cadena = Properties.Resources.CadenaConexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "INSERT INTO USUARIO (nombre, imagen, fecha_inicio, fecha_fin, numero_asistentes, id_area) VALUES (@nombre, @imagen, @fecha_inicio, @fecha_fin, @numero_asistentes, @id_area)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@nombre", evento.titulo);
                    command.Parameters.AddWithValue("@imagen", evento.imagen);
                    command.Parameters.AddWithValue("@fecha_inicio", evento.fechaInicio);
                    command.Parameters.AddWithValue("@fecha_fin", evento.fechaFin);
                    command.Parameters.AddWithValue("@numero_asistentes", evento.numero_asistentes);
                    command.Parameters.AddWithValue("@id_area", evento.id_area);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                exito = false;
            }
            return exito;
        }

        // READ

        public static List<Evento> Leer()
        {
            List<Evento> list = new List<Evento>();
            try
            {
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = "SELECT * FROM EVENTO";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Evento evento = new Evento(
                               Convert.ToInt32(reader["id"]),
                               reader["titulo"].ToString(),
                               reader["imagen"].ToString(),
                               Convert.ToDateTime(reader["fecha_inicio"]),
                               Convert.ToDateTime(reader["fecha_fin"]),
                               Convert.ToInt32(reader["numero_asistentes"]),
                               Convert.ToInt32(reader["id_area"])
                            );
                            list.Add(evento);
                        }
                        DataGridViewComposer.GetNullProperties(list[0]);
                    }
                }
                conn.Close();
            }
            }catch(Exception e)
            {

            }
            return list;
        }

        //UPDATE
        public static bool Editar(Evento evento)
        {
            bool exito = true;
            try
            {
                string cadena = Properties.Resources.CadenaConexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "UPDATE EVENTO SET titulo = @titulo, imagen = @imagen, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, numero_asistentes = @numero_asistentes, id_area = @id_area";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@titulo", evento.titulo);
                    command.Parameters.AddWithValue("@imagen", evento.imagen);
                    command.Parameters.AddWithValue("@fecha_inicio", evento.fechaInicio);
                    command.Parameters.AddWithValue("@fecha_fin", evento.fechaFin);
                    command.Parameters.AddWithValue("@numero_asistentes", evento.numero_asistentes);
                    command.Parameters.AddWithValue("@id_area", evento.id_area);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                exito = false;
            }
            return exito;
        }

        // DELETE

        public static bool Eliminar(int id)
        {
            bool exito = true;
            try
            {
                string cadena = Properties.Resources.CadenaConexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE FROM EVENTO WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                exito = false;
            }
            return exito;
        }

        // ----------------------------------------------------------------------------
        public static Evento LeerUno (int id)
        {
            Evento evento = null;

            try
            {
               using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = "SELECT * FROM EVENTO WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            evento = new Evento(
                                Convert.ToInt32(reader["id"]),
                                reader["titulo"].ToString(),
                                reader["imagen"].ToString(),
                                Convert.ToDateTime(reader["fecha_inicio"]),
                                Convert.ToDateTime(reader["fecha_fin"]),
                                Convert.ToInt32(reader["numero_asistentes"]),
                                Convert.ToInt32(reader["id_area"])
                            );
                        }
                    }
                    conn.Close();
                }
            }catch(Exception e)
            {

            }
            return evento;
        }
    }
}
