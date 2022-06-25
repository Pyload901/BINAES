using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Formato
    {
        public int id { get; set; }
        public string formato { get; set; }

        public Formato(int id, string formato)
        {
            this.id = id;
            this.formato = formato;
        }

        public Formato()
        {

        }
    }
}
