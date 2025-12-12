using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen
{
    public class CafeConCaramelo : DecoradorCafe
    {
        public CafeConCaramelo(ICafe cafe) : base(cafe) { }

        public override string Descripcion() => _cafe.Descripcion() + ", Con caramelo";
        public override double Costo() => _cafe.Costo() + 12.00;
    }
}
