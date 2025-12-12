using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    public interface ICafeEstado
    {
        void Siguiente(CafeContexto contexto);
        string ObtenerEstado();
    }
}
