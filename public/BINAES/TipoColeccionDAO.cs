using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public class TipoColeccionDAO
    {
        public static List<TipoColeccion> Leer()
        {
            List<TipoColeccion> list = new List<TipoColeccion>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT * FROM TIPO_COLECCION";

                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TipoColeccion tipo = new TipoColeccion();

                        tipo.id = Convert.ToInt32(reader["id"]);
                        tipo.tipo = reader["tipo"].ToString();


                        list.Add(tipo);
                    }

                }
                conn.Close();
            }
            return list;
        }
    }
}
