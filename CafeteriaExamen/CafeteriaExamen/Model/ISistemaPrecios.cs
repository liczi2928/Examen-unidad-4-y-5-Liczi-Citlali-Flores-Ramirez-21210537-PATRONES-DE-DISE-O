using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen

{

    //define el método de conversión.
    internal interface ISistemaPrecios
    {
        double ObtenerPrecioEnDolares(double precioPesos);  //Permite desacoplar el sistema de conversión del código del café.
    }
}
