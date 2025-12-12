using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    public class CafeConLeche : DecoradorCafe
    {
        public CafeConLeche(ICafe cafe) : base(cafe) { }

        public override string Descripcion() => _cafe.Descripcion() + ", Con leche";
        public override double Costo() => _cafe.Costo() + 10.00;
    }
}
