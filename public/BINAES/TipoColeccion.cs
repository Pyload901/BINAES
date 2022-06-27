using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class TipoColeccion
    {
        public int id { get; set; }
        public string tipo { get; set; }

        public TipoColeccion(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }

        public TipoColeccion()
        {

        }
    }
}
