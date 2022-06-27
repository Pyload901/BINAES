using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public class GeneroDAO
    {
        public static List<Genero> Leer()
        {
            List<Genero> list = new List<Genero>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT * FROM GENERO_COLECCION";

                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                        while (reader.Read())
                        {
                            Genero genero = new Genero();

                            genero.id = Convert.ToInt32(reader["id"]);
                            genero.genero = reader["genero"].ToString();


                            list.Add(genero);
                        }

                }
                conn.Close();
            }
            return list;
        }
    }
}
