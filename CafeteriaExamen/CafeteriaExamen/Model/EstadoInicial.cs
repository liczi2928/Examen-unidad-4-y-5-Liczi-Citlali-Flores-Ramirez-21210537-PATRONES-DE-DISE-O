using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    public  class EstadoInicial : ICafeEstado
    {
        public string ObtenerEstado() => "Café base creado.";

        public void Siguiente(CafeContexto contexto)
        {
            contexto.CambiarEstado(new EstadoPersonalizado());


        }
    }
}
