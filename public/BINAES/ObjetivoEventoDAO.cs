using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BINAES
{
    public static class ObjetivoEventoDAO
    {
        public static List<ObjetivoEvento> Leer (int id_evento)
        {
            List<ObjetivoEvento> list = new List<ObjetivoEvento>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = "SELECT * FROM OBJETIVO_EVENTO WHERE id_evento = @id_evento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_evento", id_evento);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ObjetivoEvento(
                            Convert.ToInt32(reader["id"]),
                            reader["objetivo"].ToString(),
                            Convert.ToInt32(reader["id_evento"])
                        ));
                    }
                }
                conn.Close();
            }
            return list;
        }

        public static int ContarElementosPorIdEvento (int id_evento)
        {
            int cont = 0;
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = "SELECT COUNT(O.id) 'cont' FROM OBJETIVO_EVENTO WHERE id_evento = @id_evento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_evento", id_evento);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cont = Convert.ToInt32(reader["cont"]);
                    }
                }
                conn.Close();
            }
            return cont;
        }
    }
}
