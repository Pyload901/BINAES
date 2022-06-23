using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BCrypt;

namespace BINAES
{
    public static class UsuarioDAO
    {
        public static bool Login (Usuario usuario)
        {
            bool flag = true;
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = "SELECT nombre, contrasenia FROM USUARIO WHERE nombre = @nombre";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre", usuario.nombre);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!BCrypt.Net.BCrypt.Verify(usuario.contrasenia, reader["contrasenia"].ToString()))
                        {
                            flag = false;
                        }
                    }
                }
                conn.Close();
            }
            return flag;
        }
    }
}
