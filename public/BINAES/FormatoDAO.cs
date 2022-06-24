using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BINAES
{
    public static class FormatoDAO
    {
        public static List<Formato> Leer ()
        {
            List<Formato> list = new List<Formato>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = "SELECT * FROM FORMATO_EJEMPLAR";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Formato(
                            Convert.ToInt32(reader["id"]),
                            reader["formato"].ToString()
                        ));
                    }
                }
                conn.Close();
            }
            return list;
        }
    }
}
