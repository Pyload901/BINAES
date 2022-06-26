using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BINAES
{
    public static class EditorialDAO
    {
        public static List<Editorial> Leer()
        {
            List<Editorial> list = new List<Editorial>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT * FROM EDITORIAL";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Editorial(
                            Convert.ToInt32(reader["id"]),
                            reader["editorial"].ToString()
                        ));
                    }
                }
                conn.Close();
            }
            return list;
        }
    }
}
