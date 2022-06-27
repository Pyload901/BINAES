using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public class OcupacionDAO
    {
        public static List<Ocupacion> Leer()
        {
            List<Ocupacion> list = new List<Ocupacion>();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
                {
                    string query = "SELECT * FROM OCUPACION_USUARIO";
                    SqlCommand command = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Ocupacion ocupacion = new Ocupacion();

                                ocupacion.id = Convert.ToInt32(reader["id"]);
                                ocupacion.ocupacion = reader["ocupacion"].ToString();

                                list.Add(ocupacion);
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
    }
}
