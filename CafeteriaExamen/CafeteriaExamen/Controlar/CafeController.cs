using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaExamen.Model;  
using CafeteriaExamen.Vista;

namespace CafeteriaExamen.Controlar
{
    public class CafeController
    {
        
        private CafeBuilder _builder = new CafeBuilder();
        private CafeContexto _contexto = new CafeContexto();
        private bool _continuar = true;

        public ICafe Ejecutar()
        {
            CafeView.MostrarBienvenida();
            Console.WriteLine(_contexto.EstadoActual.ObtenerEstado());

            while (_continuar)
            {
                var cafeActual = _builder.Construir();
                CafeView.MostrarCafe(cafeActual.Descripcion(), cafeActual.Costo());

                Console.Write("\n¿Deseas agregar algún ingrediente? (s/n): ");
                string respuesta = Console.ReadLine()?.ToLower();

                if (respuesta == "s")
                {
                    MostrarMenuIngredientes();
                }
                else
                {
                    _continuar = false;
                }
            }

            _contexto.Avanzar();
            return _builder.Construir();
        }

        private void MostrarMenuIngredientes()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n1. Leche ($10)");
            Console.WriteLine("2. Caramelo ($12)");
            Console.WriteLine("3. Azúcar ($5)");
            Console.WriteLine("4. Canela ($8)");
            Console.WriteLine("5. Finalizar pedido");
            Console.ResetColor();

            Console.Write("\nSelecciona una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": _builder.AgregarLeche(); break;
                case "2": _builder.AgregarCaramelo(); break;
                case "3": _builder.AgregarAzucar(); break;
                case "4": _builder.AgregarCanela(); break;
                case "5": _continuar = false; break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        }
    }
}
    


