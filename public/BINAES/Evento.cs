using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Evento
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string imagen { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int numero_asistentes { get; set; }
        public int id_area { get; set; }

        public Evento (int id, string titulo, string imagen, DateTime fechaInicio, DateTime fechaFin, int numero_asistentes, int id_area)
        {
            this.id = id;
            this.titulo = titulo;
            this.imagen = imagen;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.numero_asistentes = numero_asistentes;
            this.id_area = id_area;
        }
        public Evento()
        {

        }

    }
}
