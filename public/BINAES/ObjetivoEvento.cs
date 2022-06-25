using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class ObjetivoEvento
    {
        public int id { get; set; }
        public string objetivo { get; set; }
        public int id_evento { get; set; }

        public ObjetivoEvento()
        {

        }
        public ObjetivoEvento(int id, string objetivo, int id_evento)
        {
            this.id = id;
            this.objetivo = objetivo;
            this.id_evento = id_evento;
        }
    }
}
