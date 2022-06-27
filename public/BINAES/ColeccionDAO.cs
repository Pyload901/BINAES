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

        public static List<Coleccion> Leer()
        {
            List<Coleccion> list = new List<Coleccion>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT c.id, c.nombre 'nombre', tc.tipo 'tipo', tc.id 'id_tipo',gc.genero 'genero', gc.id 'id_genero' FROM
                    COLECCION c
                    INNER JOIN TIPO_COLECCION tc
                        ON c.id_tipo = tc.id
                    INNER JOIN GENERO_COLECCION gc
                        ON c.id_genero = gc.id";

                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Coleccion coleccion = new Coleccion();

                            coleccion.id = Convert.ToInt32(reader["id"]);
                            coleccion.nombre = reader["nombre"].ToString();
                            coleccion.tipo_coleccion = reader["tipo"].ToString();
                            coleccion.id_tipo_coleccion = Convert.ToInt32(reader["id_tipo"]);
                            coleccion.genero_coleccion = reader["genero"].ToString();
                            coleccion.id_genero = Convert.ToInt32(reader["id_genero"]);

                            list.Add(coleccion);
                        }
                        DataGridViewComposer.GetNullProperties(list[0]);
                    }
                }
                conn.Close();
            }
            return list;
        }
        public static List<Coleccion> LeerCatalogo ()
        {
            List<Coleccion> list = new List<Coleccion>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT id, nombre FROM COLECCION";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Coleccion cole = new Coleccion();
                        cole.id = Convert.ToInt32(reader["id"]);
                        cole.nombre = reader["nombre"].ToString();
                        list.Add(cole);
                    }
                }

                conn.Close();
            }
            return list;
        }
        public static List<Coleccion> Leer_2()
        {
            List<Coleccion> list = new List<Coleccion>();
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
                        Coleccion cole = new Coleccion();
                        cole.nombre = reader["nombre"].ToString();
                        cole.tipo_coleccion = reader["tipo"].ToString();
                        cole.genero_coleccion = reader["genero"].ToString();
                        list.Add(cole);
                    }
                }

                conn.Close();
            }
            return list;
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
    