using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public class Editorial
    {
        public int id { set; get; }
        public string editorial { set; get; }
        public Editorial ()
        {

        }
        public Editorial(int id, string editorial)
        {
            this.id = id;
            this.editorial = editorial;
        }
    }
}
