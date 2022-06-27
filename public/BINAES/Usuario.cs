using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string institucion { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string fotografia { get; set; }
        public string email { get; set; }
        public string contrasenia { get; set; }
        public string id_rol { get; set; }
        public int id_ocupacion { get; set; }
        public string rol { set; get; }
        public string ocupacion { set; get; }

        public Usuario(int id, string nombre, string institucion, string direccion, string telefono, string fotografia, string email, string contrasenia, string id_rol, int id_ocupacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.institucion = institucion;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fotografia = fotografia;
            this.email = email;
            this.contrasenia = contrasenia;
            this.id_rol = id_rol;
            this.id_ocupacion = id_ocupacion;
        }
        public Usuario()
        {
            this.id_ocupacion = -1;
        }
    }
}
