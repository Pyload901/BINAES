using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    internal class PrestamoDAO
    {
        public static Ejemplar Leer()
        {
            Ejemplar prestamo = new Ejemplar();
            string cadena = Properties.Resources.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                try
                {
                    //Falta la query
                    string query = "SELECT ";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            prestamo.id = Convert.ToInt32(reader["id"]);
                            prestamo.nombre = reader["nombre_ejemplar"].ToString();
                            prestamo.imagen = reader["imagen"].ToString();
                            prestamo.fecha_publicacion = reader["fecha_publicacion"].ToString();
                            prestamo.stock = Convert.ToInt32(reader["stock"]);
                            prestamo.coleccion = reader["coleccion"].ToString();
                            prestamo.idioma = reader["idioma"].ToString();
                            prestamo.editorial = reader["editorial"].ToString();
                            prestamo.formato = reader["formato"].ToString();
                        }
                    }

                    conn.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return prestamo;
        }
        public static void Crear(Ejemplar ejemplar)
        {
            string cadena = Properties.Resources.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                //Falta la query correspondiente
                string query = @"SELECT EJ.id, EJ.nombre 'nombre_ejemplar', EJ.imagen, EJ.fecha_publicacion, EJ.stock, C.nombre 'coleccion', IE.idioma 'idioma', ED.editorial 'editorial', F.formato 'formato'
                                FROM EJEMPLAR EJ
                                    INNER JOIN COLECCION C
                                        ON EJ.id_coleccion = C.id
                                    INNER JOIN IDIOMA_EJEMPLAR IE
                                        ON EJ.id_idioma = IE.id
                                    INNER JOIN EDITORIAL ED
                                        ON EJ.id_editorial = ED.id
                                    INNER JOIN FORMATO_EJEMPLAR F
                                        ON EJ.id_formato = F.id";
                SqlCommand cmd = new SqlCommand(query, conn);
                //Mostrar informacion
                cmd.Parameters.AddWithValue("@nombre", ejemplar.nombre);
                cmd.Parameters.AddWithValue("@imagen", ejemplar.imagen);
                cmd.Parameters.AddWithValue("@fecha_publicacion", ejemplar.fecha_publicacion);
                cmd.Parameters.AddWithValue("@stock", ejemplar.stock);
                cmd.Parameters.AddWithValue("@id_coleccion", ejemplar.id_coleccion);
                cmd.Parameters.AddWithValue("@id_idioma", ejemplar.id_idioma);
                cmd.Parameters.AddWithValue("@id_editorial", ejemplar.id_editorial);
                cmd.Parameters.AddWithValue("@id_formato", ejemplar.id_formato);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}


