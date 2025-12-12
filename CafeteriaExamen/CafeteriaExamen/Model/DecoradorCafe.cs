using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaExamen

  //Clase abstracta DecoradorCafe – sirve como plantilla para todos los cafés decorados.
{
    public abstract class DecoradorCafe : ICafe
    {
        protected ICafe _cafe;  // // referencia al objeto que se decora  


        //actúa como envoltura para añadir comportamiento sin tocar la clase base.

        public DecoradorCafe(ICafe cafe)
        {
            _cafe = cafe;
        }

        public virtual string Descripcion() => _cafe.Descripcion();
        public virtual double Costo() => _cafe.Costo();
    }
}

