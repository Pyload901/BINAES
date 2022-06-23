using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{ 

    public static class ColeccionDAO
    {
        public static void Insertar(Coleccion cole)
        {
            string cadena = Properties.Resources.CadenaConexion;

            using (SqlConnection conn = new SqlConnection(cadena))
            {

                conn.Open();
            }
        }
    }


}
    