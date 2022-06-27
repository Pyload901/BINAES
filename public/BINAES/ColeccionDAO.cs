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

        public static bool Crear(Coleccion coleccion)
        {
            bool exito = true;
            try
            {
                string cadena = Properties.Resources.CadenaConexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "INSERT INTO COLECCION (nombre, id_tipo, id_genero) VALUES (@nombre, @id_tipo, @id_genero)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@nombre", coleccion.nombre);
                    command.Parameters.AddWithValue("@id_tipo", coleccion.id_tipo_coleccion);
                    command.Parameters.AddWithValue("@id_genero", coleccion.id_genero);
       

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                exito = false;
                Console.WriteLine(e.Message);
            }
            return exito;
        }

        public static bool Eliminar(int id)
        {
            bool exito = true;
            try
            {
                string cadena = Properties.Resources.CadenaConexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE FROM COLECCION WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                exito = false;
            }
            return exito;
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
    