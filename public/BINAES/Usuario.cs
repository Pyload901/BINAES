using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Usuario
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string instutcion { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string fotografia { get; set; }
        public string email { get; set; }
        public string contrasenia { get; set; }
        public int id_rol { get; set; }
        public int id_ocupacion { get; set; }
        public string rol { set; get; }
        public string ocupacion { set; get; }

        public Usuario()
        {

        }
    }
}
