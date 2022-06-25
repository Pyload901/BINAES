using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Area
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public int piso { set; get; }
        public Area ()
        {

        }
        public Area(int id, string nombre, int piso)
        {
            this.id = id;
            this.nombre = nombre;
            this.piso = piso;
        }
    }
}
