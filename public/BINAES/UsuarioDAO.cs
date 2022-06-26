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
        public static Usuario Login (Usuario usuario)
        {
            
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = "SELECT U.nombre, U.contrasenia, R.rol 'rol' FROM USUARIO U INNER JOIN ROL R ON U.id_rol = R.id WHERE nombre = @nombre";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre", usuario.nombre);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!BCrypt.Net.BCrypt.Verify(usuario.contrasenia, reader["contrasenia"].ToString()))
                        {
                            usuario = null;
                        }
                        else
                        {
                            usuario.rol = reader["rol"].ToString();
                        }
                    }
                }
                conn.Close();
            }
            return usuario;
        }
    }
}
