using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Genero
    {
        public int id { get; set; }
        public string genero { get; set; }

        public Genero(int id, string genero)
        {
            this.id = id;
            this.genero = genero;
        }
        public Genero()
        {

        }
    }
}
