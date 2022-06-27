using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BINAES
{
    public static class EtiquetaDAO
    {
        public static bool Crear(Etiqueta etiqueta)
        {
            bool result = true;
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    //Falta la query correspondiente
                    string query = @"INSERT INTO ETIQUETA (etiqueta, id_nombre_etiqueta, id_ejemplar) VALUES (@etiqueta, @id_nombre_etiqueta, @id_ejemplar)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //Mostrar informacion
                    cmd.Parameters.AddWithValue("@etiqueta", etiqueta.etiqueta);
                    cmd.Parameters.AddWithValue("@id_nombre_etiqueta", etiqueta.id_nombre_etiqueta);
                    cmd.Parameters.AddWithValue("@id_ejemplar", etiqueta.id_ejemplar);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                result = false;
                Console.WriteLine(e.Message);
            }
            return result;
        }
        public static List<Etiqueta> Leer(int id_ejemplar)
        {
            List<Etiqueta> list = new List<Etiqueta>();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = "SELECT E.id, E.etiqueta, NE.nombre FROM ETIQUETA E INNER JOIN NOMBRE_ETIQUETA NE ON E.id_nombre_etiqueta = NE.id WHERE E.id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Etiqueta etiqueta = new Etiqueta();
                                etiqueta.id = Convert.ToInt32(reader["id"]);
                                etiqueta.etiqueta = reader["etiqueta"].ToString();
                                etiqueta.nombre_etiqueta = reader["nombre"].ToString();
                                list.Add(etiqueta);
                            }
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
        public static bool Actualizar(Etiqueta etiqueta)
        {
            bool result = true;
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = @"UPDATE ETIQUETA SET etiqueta = @etiqueta WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", etiqueta.id);
                    cmd.Parameters.AddWithValue("@etiqueta", etiqueta.etiqueta);

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
    }
}
