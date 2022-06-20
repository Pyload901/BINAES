using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public interface ICRUD
    {
        void Create();
        void Read();
        void Update(int id);
        void Delete(int id);
    }
}
