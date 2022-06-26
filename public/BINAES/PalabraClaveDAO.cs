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
    }
}
