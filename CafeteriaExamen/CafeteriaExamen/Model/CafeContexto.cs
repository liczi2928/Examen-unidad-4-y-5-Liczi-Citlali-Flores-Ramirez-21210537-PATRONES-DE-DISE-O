using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    public class CafeContexto   
    {
        public ICafeEstado EstadoActual { get; private set; }

        public CafeContexto()
        {
            EstadoActual = new EstadoInicial();   // estado inicial
        }

        public void CambiarEstado(ICafeEstado nuevoEstado)
        {
            EstadoActual = nuevoEstado;   // transición entre estados
        }

        public void Avanzar()
        {
            EstadoActual.Siguiente(this); // // ejecuta el cambio
        }
    }
}


