using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    public class CafeConAzucar : DecoradorCafe
    {
        public CafeConAzucar(ICafe cafe) : base(cafe) { }

        public override string Descripcion() => _cafe.Descripcion() + ", Con azúcar";
        public override double Costo() => _cafe.Costo() + 5.00;
    }
}
