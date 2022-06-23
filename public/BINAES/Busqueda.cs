using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Busqueda
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string fecha_publicacion { get; set; }
        public int stock { get; set; }
        public int id_coleccion { get; set; }
        public int id_idioma { get; set; }
        public int id_editorial { get; set; }
        public int id_formato { get; set; }

        public Busqueda(int id, string nombre, string imagen, string fecha_publicacion, int stock, 
            int id_coleccion, int id_idioma, int id_editorial, int id_formato)
        {
            this.id = id;
            this.nombre = nombre;
            this.imagen = imagen;
            this.fecha_publicacion = fecha_publicacion;
            this.stock = stock;
            this.id_coleccion = id_coleccion;
            this.id_idioma = id_idioma;
            this.id_editorial = id_editorial;
            this.id_formato = id_formato;
        }
    }
}
