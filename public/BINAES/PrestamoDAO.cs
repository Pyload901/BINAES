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
        public static List<Prestamo> Leer()
        {
            List<Prestamo> list = new List<Prestamo>();
            string cadena = Properties.Resources.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                try
                {
                    //Falta la query
                    string query = "SELECT P.id, P.fecha_prestamo, P.fecha_devolucion, U.nombre 'usuario', E.nombre 'ejemplar'  FROM PRESTAMO P INNER JOIN USUARIO U ON U.id = P.id_usuario INNER JOIN EJEMPLAR E ON E.id = P.id_ejemplar";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Prestamo prestamo = new Prestamo();

                                prestamo.id = Convert.ToInt32(reader["id"]);
                                prestamo.fechaPrestamo = Convert.ToDateTime(reader["fecha_prestamo"]);
                                prestamo.fechaDevolucion = Convert.ToDateTime(reader["fecha_devolucion"]);
                                prestamo.usuario = reader["usuario"].ToString();
                                prestamo.ejemplar = reader["ejemplar"].ToString();
                                list.Add(prestamo);
                            }
                            DataGridViewComposer.GetNullProperties(list[0]);
                        }
                    }

                    conn.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return list;
        }
        public static bool Crear(Prestamo prestamo)
        {
            bool result = true;
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    //Falta la query correspondiente
                    string query = @"INSERT INTO PRESTAMO (fecha_prestamo, fecha_devolucion, id_ejemplar, id_usuario) VALUES (@fecha_prestamo, @fecha_devolucion, @id_ejemplar, @id_usuario)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //Mostrar informacion
                    cmd.Parameters.AddWithValue("@fecha_prestamo", prestamo.fechaPrestamo);
                    cmd.Parameters.AddWithValue("@fecha_devolucion", prestamo.fechaDevolucion);
                    cmd.Parameters.AddWithValue("@id_ejemplar", prestamo.id_ejemplar);
                    cmd.Parameters.AddWithValue("@id_usuario", prestamo.id_usuario);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                EjemplarDAO.ActualizarDisponibilidad(false, prestamo.id_ejemplar);
            }
            catch (Exception e)
            {
                result = false;
            }
            return result;
        }
    }
}


