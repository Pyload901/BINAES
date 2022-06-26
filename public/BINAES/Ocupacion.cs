using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Ocupacion
    {
        public int id;
        public string nombre;

        public Ocupacion(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Ocupacion()
        {

        }
    }
}
