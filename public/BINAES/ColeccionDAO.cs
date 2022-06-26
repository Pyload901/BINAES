using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{

    public static class ColeccionDAO
    {
        public static Coleccion Leer()
        {
            Coleccion cole = new Coleccion();
            string cadena = Properties.Resources.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string query = @"SELECT c.nombre, tc.tipo, gc.genero FROM
                    COLECCION c
                    INNER JOIN TIPO_COLECCION tc
                        ON c.id_tipo = tc.id
                    INNER JOIN GENERO_COLECCION gc
                        ON c.id_genero = gc.id ";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cole.nombre = reader["nombre"].ToString();
                        cole.tipo_coleccion = reader["tipo"].ToString();
                        cole.genero_coleccion = reader["genero"].ToString();
                    }
                }

                conn.Close();
            }
            return cole;
        } 

        public static void Crear(Coleccion coleccion)
        {
            string cadena = Properties.Resources.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string query = "INSERT INTO COLECCION (nombre, id_tipo, id_genero) VALUES (@nombre, @id_tipo, @id_genero)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", coleccion.nombre);
                cmd.Parameters.AddWithValue("@id_tipo", coleccion.id_tipo_coleccion);
                cmd.Parameters.AddWithValue("@id_genero", coleccion.id_genero);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static void Eliminar(Coleccion coleccion)
        {
            string cadena = Properties.Resources.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string query = "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", coleccion.nombre);
                cmd.Parameters.AddWithValue("@id_tipo", coleccion.id_tipo_coleccion);
                cmd.Parameters.AddWithValue("@id_genero", coleccion.id_genero);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static void Actualizar(Coleccion coleccion)
        {
            string cadena = Properties.Resources.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string query = "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", coleccion.nombre);
                cmd.Parameters.AddWithValue("@id_tipo", coleccion.id_tipo_coleccion);
                cmd.Parameters.AddWithValue("@id_genero", coleccion.id_genero);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }
    }


}
    