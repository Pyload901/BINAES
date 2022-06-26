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
       
        public static List<Evento> Leer()
        {
            List<Evento> list = new List<Evento>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = "SELECT * FROM EVENTO";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
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
                        DataGridViewComposer.GetNullProperties(evento);
                        list.Add(evento);
                    }
                }
                conn.Close();
            }
            return list;
        }
        public static void Editar(int id)
        {

        }
        public static void Eliminar(int id)
        {
            Console.WriteLine("Eliminando...");
        }
        public static Evento LeerUno (int id)
        {
            Evento evento = null;
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
            return evento;
        }
    }
}
