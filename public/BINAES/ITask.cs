using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public interface ITask
    {
        void Complete(int id);
    }
}
