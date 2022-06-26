using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Ocupacion
    {
        public int id { set; get; }
        public string ocupacion { set; get; }

        public Ocupacion(int id, string ocupacion)
        {
            this.id = id;
            this.ocupacion = ocupacion;
        }

        public Ocupacion()
        {

        }
    }
}
