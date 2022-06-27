using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public static class PalabraClaveDAO
    {
        public static List<PalabraClave> Leer (int id)
        {
            List<PalabraClave> list = new List<PalabraClave>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT * FROM PALABRA_CLAVE WHERE id_ejemplar = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PalabraClave palabraClave = new PalabraClave();
                        palabraClave.id = Convert.ToInt32(reader["id"]); 
                        palabraClave.palabra = reader["palabra"].ToString();
                        list.Add(palabraClave);
                    }
                }
                conn.Close();
            }
            return list;
        }
        public static bool Crear(PalabraClave palabraClave)
        {
            bool result = true;
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    //Falta la query correspondiente
                    string query = @"INSERT INTO PALABRA_CLAVE (palabra, id_ejemplar) VALUES(@palabra, @id_ejemplar)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //Mostrar informacion
                    cmd.Parameters.AddWithValue("@palabra", palabraClave.palabra);
                    cmd.Parameters.AddWithValue("@id_ejemplar", palabraClave.id_ejemplar);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        public static bool Eliminar (int id_ejemplar)
        {
            bool result = true;
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    //Falta la query correspondiente
                    string query = @"DELETE FROM PALABRA_CLAVE WHERE id_ejemplar = @id_ejemplar";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //Mostrar informacion
                    cmd.Parameters.AddWithValue("@id_ejemplar", id_ejemplar);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
    }
}
