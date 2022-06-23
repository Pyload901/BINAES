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
        public static void Insertar(Coleccion coleccion)
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

        public static void Update(Coleccion coleccion)
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
    