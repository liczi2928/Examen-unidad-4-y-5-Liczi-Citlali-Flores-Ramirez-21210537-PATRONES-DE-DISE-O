using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    public class EstadoPrecioConvertido: ICafeEstado
    {
        public string ObtenerEstado() => "Precio convertido a dólares.";

        public void Siguiente(CafeContexto contexto)
        {
            // Estado final.
        }
    }
}
