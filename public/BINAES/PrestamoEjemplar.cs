using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    internal class PrestamoEjemplar
    {
        //Clase
        public int id { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string fecha_publicacion { get; set; }
        public int stock { get; set; }
        public int id_coleccion { get; set; }
        public string coleccion { get; set; }
        public int id_idioma { get; set; }
        public string idioma { get; set; }
        public int id_editorial { get; set; }
        public string editorial { get; set; }
        public int id_formato { get; set; }
        public string formato { get; set; }

        public PrestamoEjemplar (int id, string nombre, string imagen, string fecha_publicacion, int stock,
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

        public PrestamoEjemplar ()
        {
            id_coleccion = -1;
            id_editorial = -1;
            id_formato = -1;
            id_idioma = -1;
        }
    }
}
 
