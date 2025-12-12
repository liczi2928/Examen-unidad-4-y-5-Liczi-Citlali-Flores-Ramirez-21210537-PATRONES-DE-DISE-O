using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaExamen.Model;
using CafeteriaExamen.Controlar;

namespace CafeteriaExamen.Vista
{
    internal class CafeView
    {
        
        public static void MostrarBienvenida()
        {
            Console.Title = "Simulador de Café";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== CAFE EXPRESS ===\n");
            Console.ResetColor();
        }

        public static void MostrarCafe(string descripcion, double costo)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nTu café actual es: {descripcion}");
            Console.WriteLine($"Costo actual: ${costo:0.00} pesos");
            Console.ResetColor();
        }
    }
}

