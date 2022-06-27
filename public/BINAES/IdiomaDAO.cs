using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BINAES
{
    public static class IdiomaDAO
    {
        public static List<Idioma> Leer ()
        {
            List<Idioma> list = new List<Idioma>();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = @"SELECT * FROM IDIOMA_EJEMPLAR";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Idioma(
                                Convert.ToInt32(reader["id"]),
                                reader["idioma"].ToString()
                            ));
                        }
                    }
                    conn.Close();
                }
            }
            catch(Exception e)
            {

            }
            return list;
        }
    }
}
