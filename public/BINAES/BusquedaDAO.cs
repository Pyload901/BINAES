using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public static class BusquedaDAO
    {

        public static Ejemplar FiltrarPorTituloExacto(string Titulo)
        {
            string cadena = Properties.Resources.CadenaConexion;

            Ejemplar ejem = new Ejemplar();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM EJEMPLAR where Busqueda.nombre = @nombrebuscado";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombrebuscado", Titulo);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ejem.id = Convert.ToInt32(reader["id"].ToString());
                        ejem.nombre = reader["nombre"].ToString();
                        ejem.imagen = reader["imagen"].ToString();
                        ejem.fecha_publicacion = reader["fecha_publicacion"].ToString();

                    }
                }
                connection.Close();
            }
            return ejem;
        }
    }
}
