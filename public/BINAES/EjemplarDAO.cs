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
            try
            {
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
            }
            catch (Exception e)
            {

            }
            return String.Join(", ", list);
        }

        public static string LeerPalabrasClave(int id)
        {
            List<string> list = new List<string>();
            try
            {
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
            }
            catch(Exception e)
            {

            }
            return String.Join(", ", list);
        }

        public static void LeerEtiquetas(Ejemplar ejemplar)
        {
            try
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
            catch(Exception e)
            {

            }
        }

        public static List<Ejemplar> LeerFiltrado(string texto, FiltroEnumerate filtroEjemplar, FiltroEnumerate filtroBusqueda, FiltroEnumerate filtroFormato)
        {
            List<Ejemplar> list = new List<Ejemplar>();
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {

                    string query = @"SELECT EJ.id, EJ.nombre 'nombre_ejemplar', EJ.imagen, EJ.autor, EJ.fecha_publicacion, EJ.disponibilidad, C.nombre 'coleccion', IE.idioma 'idioma', ED.editorial 'editorial', F.formato 'formato'
                                FROM EJEMPLAR EJ
                                    INNER JOIN COLECCION C
                                        ON EJ.id_coleccion = C.id
                                    INNER JOIN IDIOMA_EJEMPLAR IE
                                        ON EJ.id_idioma = IE.id
                                    INNER JOIN EDITORIAL ED
                                        ON EJ.id_editorial = ED.id
                                    INNER JOIN FORMATO_EJEMPLAR F
                                        ON EJ.id_formato = F.id ";
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
                            query += "AND EJ.nombre ";
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
                                ejemplar.autor = reader["autor"].ToString();
                                ejemplar.fecha_publicacion = Convert.ToDateTime(reader["fecha_publicacion"]).Date;
                                ejemplar.disponibilidad = Convert.ToBoolean(reader["disponibilidad"]);
                                ejemplar.coleccion = reader["coleccion"].ToString();
                                ejemplar.idioma = reader["idioma"].ToString();
                                ejemplar.editorial = reader["editorial"].ToString();
                                ejemplar.formato = reader["formato"].ToString();

                                ejemplar.palabras_clave = LeerPalabrasClave(ejemplar.id);

                                LeerEtiquetas(ejemplar);
                                list.Add(ejemplar);
                            }
                            DataGridViewComposer.GetNullProperties(list[0]);
                        }
                    }
                    conn.Close();
                }
            }
            catch(Exception e)
            {

            }
            return list;
        }
        public static List<Ejemplar> Leer ()
        {
            List<Ejemplar> list = new List<Ejemplar>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = @"SELECT E.id, E.nombre, E.imagen, E.autor, E.fecha_publicacion, E.disponibilidad, C.nombre 'coleccion', I.idioma, ED.editorial, F.formato  FROM EJEMPLAR E
                    INNER JOIN COLECCION C
                        ON C.id = E.id_coleccion
                    INNER JOIN IDIOMA_EJEMPLAR I
                        ON I.id = E.id_idioma
                    INNER JOIN EDITORIAL ED
                        ON ED.id = E.id_editorial
                    INNER JOIN FORMATO_EJEMPLAR F
                        ON F.id = E.id_formato";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Ejemplar ejemplar = new Ejemplar();
                                ejemplar.id = Convert.ToInt32(reader["id"]);
                                ejemplar.nombre = reader["nombre"].ToString();
                                ejemplar.imagen = reader["imagen"].ToString();
                                ejemplar.autor = reader["autor"].ToString();
                                ejemplar.fecha_publicacion = Convert.ToDateTime(reader["fecha_publicacion"]);
                                ejemplar.disponibilidad = Convert.ToBoolean(reader["disponibilidad"]);
                                ejemplar.coleccion = reader["coleccion"].ToString();
                                ejemplar.formato = reader["formato"].ToString();
                                list.Add(ejemplar);
                            }
                            DataGridViewComposer.GetNullProperties(list[0]);
                        }
                    }
                    conn.Close();
                }
            }
            catch(Exception e)
            {

            }
            return list;
        }
        public static Ejemplar LeerPorId(int id)
        {
            Ejemplar ejemplar = new Ejemplar();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = @"SELECT * FROM EJEMPLAR WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ejemplar.id = Convert.ToInt32(reader["id"]);
                            ejemplar.nombre = reader["nombre"].ToString();
                            ejemplar.nombre = reader["nombre"].ToString();
                            ejemplar.imagen = reader["imagen"].ToString();
                            ejemplar.autor = reader["autor"].ToString();
                            ejemplar.fecha_publicacion = Convert.ToDateTime(reader["fecha_publicacion"]);
                            ejemplar.disponibilidad = Convert.ToBoolean(reader["disponibilidad"]);
                            ejemplar.id_coleccion = Convert.ToInt32(reader["id_coleccion"]);
                            ejemplar.id_idioma = Convert.ToInt32(reader["id_idioma"]);
                            ejemplar.id_editorial = Convert.ToInt32(reader["id_editorial"]);
                            ejemplar.id_formato = Convert.ToInt32(reader["id_formato"]);
                        }
                    }
                    conn.Close();
                }
            }
            catch(Exception e)
            {

            }
            return ejemplar;
        }
        public static bool VerificarDisponibilidad(int id)
        {
            bool result = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = @"SELECT disponibilidad FROM EJEMPLAR WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (Convert.ToInt32(reader["disponibilidad"]) > 0)
                                result = true;
                        }
                    }
                    conn.Close();
                }
            }
            catch(Exception e)
            {

            }
            return result;
        }
        public static bool ActualizarDisponibilidad (bool disponible, int id)
        {
            bool result = true;
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = @"UPDATE EJEMPLAR SET disponibilidad = "+ Convert.ToInt32(disponible).ToString() +" WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                result = false;
            }
            return result;
        }
        //Para insertar datos en Al darle al boton de commpletar "Prestamo Ejemplar"
        public static int Crear(Ejemplar ejemplar)
        {
            int result = 0;
            try
            {
                string cadena = Properties.Resources.CadenaConexion;
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    //Falta la query correspondiente
                    string query = @"INSERT INTO EJEMPLAR (nombre, imagen, autor, fecha_publicacion, disponibilidad, id_coleccion, id_idioma, id_editorial, id_formato) OUTPUT INSERTED.ID VALUES (@nombre, @imagen, @autor, CONVERT(DATE, @fecha_publicacion, 103), @disponibilidad, @id_coleccion, @id_idioma, @id_editorial, @id_formato)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //Mostrar informacion
                    cmd.Parameters.AddWithValue("@nombre", ejemplar.nombre);
                    cmd.Parameters.AddWithValue("@imagen", ejemplar.imagen);
                    cmd.Parameters.AddWithValue("@autor", ejemplar.autor);
                    cmd.Parameters.AddWithValue("@fecha_publicacion", ejemplar.fecha_publicacion);
                    cmd.Parameters.AddWithValue("@disponibilidad", ejemplar.disponibilidad);
                    cmd.Parameters.AddWithValue("@id_coleccion", ejemplar.id_coleccion);
                    cmd.Parameters.AddWithValue("@id_idioma", ejemplar.id_idioma);
                    cmd.Parameters.AddWithValue("@id_editorial", ejemplar.id_editorial);
                    cmd.Parameters.AddWithValue("@id_formato", ejemplar.id_formato);
                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 0;
            }
            return result;
        }
        public static bool Actualizar(Ejemplar ejemplar)
        {
            bool result = true;
            try
            {
                string cadena = Properties.Resources.CadenaConexion;
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    //Falta la query correspondiente
                    string query = @"UPDATE EJEMPLAR SET nombre = @nombre, imagen = @imagen, autor = @autor, fecha_publicacion = CONVERT(DATE, @fecha_publicacion, 103), disponibilidad = @disponibilidad, id_coleccion = @id_coleccion, id_idioma = @id_idioma, id_editorial = @id_editorial, id_formato = @id_formato WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //Mostrar informacion
                    cmd.Parameters.AddWithValue("@id", ejemplar.id);
                    cmd.Parameters.AddWithValue("@nombre", ejemplar.nombre);
                    cmd.Parameters.AddWithValue("@imagen", ejemplar.imagen);
                    cmd.Parameters.AddWithValue("@autor", ejemplar.autor);
                    cmd.Parameters.AddWithValue("@fecha_publicacion", ejemplar.fecha_publicacion);
                    cmd.Parameters.AddWithValue("@disponibilidad", ejemplar.disponibilidad);
                    cmd.Parameters.AddWithValue("@id_coleccion", ejemplar.id_coleccion);
                    cmd.Parameters.AddWithValue("@id_idioma", ejemplar.id_idioma);
                    cmd.Parameters.AddWithValue("@id_editorial", ejemplar.id_editorial);
                    cmd.Parameters.AddWithValue("@id_formato", ejemplar.id_formato);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }
            return result;
        }
    }
}

