using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES
{
    public interface ICRUD
    {
        void Insertar();
        void Leer();
        void Actualizar(int id);
        void Eliminar(int id);
    }
}
