using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public static class EjemplarDAO
    {
        public static string LeerAutores (int id)
        {
            List<string> list = new List<string>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT A.nombre
                                FROM AUTOR A
                                    INNER JOIN AUTORXEJEMPLAR AXE
                                        ON AXE.id_autor = A.id
                                    INNER JOIN EJEMPLAR E
                                        ON AXE.id_ejemplar = E.id
                                WHERE E.id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.HasRows)
                        {
                            list.Add("Anónimo");
                            break;
                        }
                        list.Add(reader["nombre"].ToString());
                    }
                }
                conn.Close();
            }
            return String.Join(", ", list);
        }

        public static string LeerPalabrasClave(int id)
        {
            List<string> list = new List<string>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT PC.palabra
                                FROM PALABRA_CLAVE PC
                                    INNER JOIN EJEMPLAR E
                                        ON E.id = PC.id_ejemplar
                                WHERE E.id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader["palabra"].ToString());
                    }
                }
                conn.Close();
            }
            return String.Join(", ", list);
        }

        public static void LeerEtiquetas(Ejemplar ejemplar)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT NET.nombre 'nombre_etiqueta', ET.etiqueta
                                FROM ETIQUETA ET
                                    INNER JOIN EJEMPLAR EJ
                                        ON EJ.id = ET.id_ejemplar
                                    INNER JOIN NOMBRE_ETIQUETA NET
                                        ON NET.id = ET.id_nombre_etiqueta
                                WHERE EJ.id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ejemplar.id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["nombre_etiqueta"].ToString() == "ISBN")
                            ejemplar.ISBN = reader["etiqueta"].ToString();
                        else if (reader["nombre_etiqueta"].ToString() == "ISSN")
                            ejemplar.ISSN = reader["etiqueta"].ToString();
                        else if (reader["nombre_etiqueta"].ToString() == "DOI")
                            ejemplar.DOI = reader["etiqueta"].ToString();
                    }
                }
                conn.Close();
            }
        }

        public static List<Ejemplar> Leer(string texto, FiltroEnumerate filtro)
        {
            List<Ejemplar> list = new List<Ejemplar>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {

                string query = @"SELECT EJ.id, EJ.nombre 'nombre_ejemplar', EJ.imagen, EJ.fecha_publicacion, EJ.stock, C.nombre 'coleccion', IE.idioma 'idioma', ED.editorial 'editorial', F.formato 'formato'
                                FROM EJEMPLAR EJ
                                    INNER JOIN COLECCION C
                                        ON EJ.id_coleccion = C.id
                                    INNER JOIN IDIOMA_EJEMPLAR IE
                                        ON EJ.id_idioma = IE.id
                                    INNER JOIN EDITORIAL ED
                                        ON EJ.id_editorial = ED.id
                                    INNER JOIN FORMATO_EJEMPLAR F
                                        ON EJ.id_formato = F.id ";

                SqlCommand cmd = null;
                switch (filtro)
                {
                    case FiltroEnumerate.Titulo:
                        query += "WHERE EJ.nombre LIKE @titulo";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@titulo", texto);
                        break;
                    case FiltroEnumerate.Autor:
                        query += @"INNER JOIN AUTORXEJEMPLAR AXE
                                        ON AXE.id_ejemplar = EJ.id
                                    INNER JOIN AUTOR A
                                        ON AXE.id_autor = A.id
                                    WHERE A.nombre LIKE '%'+@nombre_autor+'%'";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nombre_autor", texto);
                        break;
                    default:
                        break;
                }

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ejemplar ejemplar = new Ejemplar();
                        ejemplar.id = Convert.ToInt32(reader["id"]);
                        ejemplar.nombre = reader["nombre_ejemplar"].ToString();
                        ejemplar.imagen = reader["imagen"].ToString();
                        ejemplar.fecha_publicacion = reader["fecha_publicacion"].ToString();
                        ejemplar.stock = Convert.ToInt32(reader["stock"]);
                        ejemplar.coleccion = reader["coleccion"].ToString();
                        ejemplar.idioma = reader["idioma"].ToString();
                        ejemplar.editorial = reader["editorial"].ToString();
                        ejemplar.formato = reader["formato"].ToString();
                        ejemplar.autores = LeerAutores(ejemplar.id);

                        ejemplar.palabras_clave = LeerPalabrasClave(ejemplar.id);

                        LeerEtiquetas(ejemplar);
                        DataGridViewComposer.GetNullProperties(ejemplar);
                        list.Add(ejemplar);
                    }
                }
                conn.Close();
            }
            return list;
        }

        public static Ejemplar FiltrarPorTituloExacto(string Titulo)
        {
            string cadena = Properties.Resources.CadenaConexion;

            Ejemplar ejem = new Ejemplar();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM EJEMPLAR where Busqueda.nombre = @nombrebuscado";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombrebuscado", Titulo);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ejem.id = Convert.ToInt32(reader["id"].ToString());
                        ejem.nombre = reader["nombre"].ToString();
                        ejem.imagen = reader["imagen"].ToString();
                        ejem.fecha_publicacion = reader["fecha_publicacion"].ToString();

                    }
                }
                connection.Close();
            }
            return ejem;
        }
    }
}
