using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public static class ReservaDAO
    {
        public static List<Reserva> Leer ()
        {
            List<Reserva> list = new List<Reserva>();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = @"SELECT R.id, R.fecha_reserva, R.fecha_prestamo, R.fecha_devolucion, EJ.nombre 'ejemplar', U.nombre 'usuario'
                FROM RESERVA R
                    INNER JOIN EJEMPLAR EJ
                        ON EJ.id = R.id_ejemplar
                    INNER JOIN USUARIO U
                        ON U.id = R.id_usuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.id = Convert.ToInt32(reader["id"]);
                        reserva.fechaReserva = Convert.ToDateTime(reader["fecha_reserva"]);
                        reserva.fechaPrestamo = Convert.ToDateTime(reader["fecha_prestamo"]);
                        reserva.fechaDevolucion = Convert.ToDateTime(reader["fecha_devolucion"]);
                        reserva.ejemplar = reader["ejemplar"].ToString();
                        reserva.usuario = reader["usuario"].ToString();
                        DataGridViewComposer.GetNullProperties(reserva);
                        list.Add(reserva);
                    }

                }
                conn.Close();
            }
            return list;
        }
        public static bool Create(int idEjemplar, int idUsuario)
        {
            bool result = true;
            DateTime fecha_prestamo = DateTime.Now;
            DateTime fecha_devolucion = fecha_prestamo.AddDays(15);
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = "INSERT INTO RESERVA (fecha_reserva, fecha_prestamo, fecha_devolucion, id_ejemplar, id_usuario) VALUES (GETDATE(), @fecha_prestamo, @fecha_devolucion, @id_ejemplar, @id_usuario)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fecha_prestamo", fecha_prestamo);
                    cmd.Parameters.AddWithValue("@fecha_devolucion", fecha_devolucion);
                    cmd.Parameters.AddWithValue("@id_ejemplar", idEjemplar);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    cmd.Dispose();
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
