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

        public static List<Ejemplar> Leer(string texto, FiltroEnumerate filtroEjemplar, FiltroEnumerate filtroBusqueda, FiltroEnumerate filtroFormato)
        {
            List<Ejemplar> list = new List<Ejemplar>();
            SqlCommand cmd = null;

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
                if (filtroEjemplar == FiltroEnumerate.Autor)
                    query += @"INNER JOIN AUTORXEJEMPLAR AXE
                                    ON AXE.id_ejemplar = EJ.id
                                INNER JOIN AUTOR A
                                    ON AXE.id_autor = A.id ";
                switch (filtroFormato)
                {
                    case FiltroEnumerate.Digital:
                        query += "WHERE F.id = 2 ";
                        break;
                    case FiltroEnumerate.Fisico:
                        query += "WHERE F.id = 1 ";
                        break;
                    default:
                        break;
                }
                switch (filtroEjemplar)
                {
                    case FiltroEnumerate.Titulo:
                        query += "AND EJ.nombre ";
                        if (filtroBusqueda == FiltroEnumerate.Exacta)
                            query += "= @titulo ";
                        else
                            query += "LIKE '%'+@titulo+'%' ";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@titulo", texto);
                        break;
                    case FiltroEnumerate.Autor:
                        query += "AND A.nombre ";
                        if (filtroBusqueda == FiltroEnumerate.Exacta)
                            query += "= @nombre_autor";
                        else
                            query += "LIKE '%'+@nombre_autor+'%' ";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nombre_autor", texto);
                        break;
                    case FiltroEnumerate.PalabrasClave:
                        if (texto.Contains(", "))
                        {
                            texto.Replace(", ", ",");
                        }
                        texto.Replace(' ', ',');
                        query += "AND EJ.id IN (SELECT * FROM dbo.GET_EJEMPLARES_IN_PALABRA_CLAVE(@palabras_clave))";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@palabras_clave", texto);
                        break;
                    default:
                        break;
                }

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
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
                }
                conn.Close();
            }
            return list;
        }

        //Evento de Buscar ejemplar Prestamo
        public static Ejemplar Buscar()
        {
            Ejemplar prestamo = new Ejemplar();
            string cadena = Properties.Resources.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                //Falta la query
                string query = "";

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
            return prestamo;
        }
        //Para insertar datos en Al darle al boton de commpletar "Prestamo Ejemplar"
        public static void Insertar(Ejemplar ejemplar)
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

