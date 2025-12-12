using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    public class EstadoPersonalizado :ICafeEstado
    {
        public string ObtenerEstado() => "Café personalizado con ingredientes.";

        public void Siguiente(CafeContexto contexto)
        {
            contexto.CambiarEstado(new EstadoPrecioConvertido());
        }
    }
}
