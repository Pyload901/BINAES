using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Coleccion{
        public int id_coleccion { get; set; }
        public string nombre { get; set; }
        public string tipo_coleccion { set; get; }
        public string genero_coleccion { set; get; }

        public Coleccion(int id_coleccion, string nombre, string tipo_coleccion, string genero_coleccion)
        {
            this.id_coleccion = id_coleccion;
            this.nombre= nombre;
            this.tipo_coleccion = tipo_coleccion;
            this.genero_coleccion= genero_coleccion;
        }

        public Coleccion()
        {

        }
    }
}
