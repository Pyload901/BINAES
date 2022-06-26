using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Rol
    {
        public string id { get; set; }
        public string nombre { get; set; }

        public Rol(string id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Rol()
        {

        }
    }


}
