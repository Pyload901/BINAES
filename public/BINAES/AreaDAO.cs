using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public static class AreaDAO
    {
        public static List<Area> Leer ()
        {
            List<Area> list = new List<Area> ();
            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                string query = "SELECT  A.id, DA.nombre, A.piso FROM AREA A INNER JOIN DESCRIPCION_AREA DA ON DA.id = A.id_descripcion_area";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Area area = new Area ();
                            area.id = Convert.ToInt32(reader["id"]);
                            area.nombre = reader["id"].ToString() + ". Piso " + reader["piso"].ToString() + ' ' + reader["nombre"].ToString();
                            DataGridViewComposer.GetNullProperties(area);
                            list.Add(area);
                        }
                        DataGridViewComposer.GetNullProperties(list[0]);
                    }
                }
                conn.Close();
            }
            return list;
        }
    }
}
