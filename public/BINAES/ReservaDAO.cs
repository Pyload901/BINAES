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
    }
}
