using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    public class CafeConCanela : DecoradorCafe
    {
        public CafeConCanela(ICafe cafe) : base(cafe) { }

        public override string Descripcion() => _cafe.Descripcion() + ", Con canela";
        public override double Costo() => _cafe.Costo() + 8.00;
    }
}
