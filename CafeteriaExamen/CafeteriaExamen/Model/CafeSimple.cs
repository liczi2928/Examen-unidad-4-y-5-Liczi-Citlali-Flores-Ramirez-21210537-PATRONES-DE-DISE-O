using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    //Clase concreta que representa el café base sin ingredientes.
    public class CafeSimple : ICafe
    {
        public string Descripcion() => "Café simple"; // descripción base
        public double Costo() => 20.00;  // precio base en pesos
    }
}
