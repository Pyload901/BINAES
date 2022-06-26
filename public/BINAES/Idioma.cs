using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Idioma
    {
        public int id { get; set; }
        public string idioma { get; set; }
        public Idioma ()
        {

        }
        public Idioma(int id, string idioma)
        {
            this.id = id;
            this.idioma = idioma;
        }
    }
}
