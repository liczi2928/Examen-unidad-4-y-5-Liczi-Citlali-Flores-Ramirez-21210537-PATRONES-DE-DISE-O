using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    // Adaptador: convierte el precio de pesos a dólares

    //el sistema base no necesita saber cómo se hace la conversión, solo usa el adaptador
    public class AdaptadorSistemaPrecios : ISistemaPrecios
    {
        private const double TIPO_CAMBIO = 18.30;

        public double ObtenerPrecioEnDolares(double precioPesos)
        {
            return precioPesos / TIPO_CAMBIO;
        }
    }
}
