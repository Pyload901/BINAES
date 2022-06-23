using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BINAES
{
    public static class BusquedaDAO
    {

        public static Busqueda FiltrarPorTituloExacto(string Titulo)
        {
            string cadena = Properties.Resources.CadenaConexion;

            Busqueda bus = new Busqueda();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM EJEMPLAR where "
            }


        }
        
    }
}
