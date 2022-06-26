using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Reserva
    {
        public int id { get; set; }
        public DateTime fechaReserva { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public DateTime fechaDevolucion { get; set; }
        public int id_ejemplar { get; set; }
        public string ejemplar { get; set; }
        public int id_usuario { get; set; }
        public string usuario { get; set; }
        public Reserva()
        {
            this.id_ejemplar = -1;
            this.id_usuario = -1;
        }
        public Reserva (int id, DateTime fechaReserva, DateTime fechaPrestamo, DateTime fechaDevolucion, int id_ejemplar, int id_usuario)
        {
            this.id = id;
            this.fechaReserva = fechaReserva;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
            this.id_ejemplar = id_ejemplar;
            this.id_usuario = id_usuario;
        }

    }
}
