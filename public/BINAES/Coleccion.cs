using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Coleccion{
        public int id { get; set; }
        public string nombre { get; set; }
        public string tipo_coleccion { set; get; }
        public int id_tipo_coleccion { set; get; }
        public string genero_coleccion { set; get; }
        public int id_genero { set; get; }

        public Coleccion(int id, string nombre, string tipo_coleccion, int id_tipo_coleccion, string genero_coleccion, int id_genero)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo_coleccion = tipo_coleccion;
            this.genero_coleccion = genero_coleccion;
            this.id_tipo_coleccion= id_tipo_coleccion;
            this.id_genero= id_genero;
        }

        public Coleccion()
        {

        }
    }
}
