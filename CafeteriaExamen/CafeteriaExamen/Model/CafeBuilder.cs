using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaExamen.Vista;
using CafeteriaExamen.Controlar;

namespace CafeteriaExamen.Model
{
    public class CafeBuilder  // se arma paso a paso 
    {
        private ICafe _cafeActual;

        public CafeBuilder()
        {
            _cafeActual = new CafeSimple();    //  Punto de inicio (producto base)
        }

        public CafeBuilder AgregarLeche()
        {
            _cafeActual = new CafeConLeche(_cafeActual);  // usa decorador dentro del builder
            return this;
        }

        public CafeBuilder AgregarCaramelo()
        {
            _cafeActual = new CafeConCaramelo(_cafeActual);
            return this;
        }

        public CafeBuilder AgregarAzucar()
        {
            _cafeActual = new CafeConAzucar(_cafeActual);
            return this;
        }

        public CafeBuilder AgregarCanela()
        {
            _cafeActual = new CafeConCanela(_cafeActual);
            return this;
        }

        public ICafe Construir()
        {
            return _cafeActual;    //  Entrega el café final
        }
    }
}

