using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public static class RolDAO
    {
        public static List<Rol> Leer()
        {
            List<Rol> list = new List<Rol>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = "SELECT * FROM ROL";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                 
                        while (reader.Read())
                        {
                            Rol rol = new Rol (
                               reader["id"].ToString(),
                               reader["rol"].ToString()
                
                            );
                            list.Add(rol);
                        }
                        
                }
                conn.Close();
            }
            return list;
        }

    }
}
