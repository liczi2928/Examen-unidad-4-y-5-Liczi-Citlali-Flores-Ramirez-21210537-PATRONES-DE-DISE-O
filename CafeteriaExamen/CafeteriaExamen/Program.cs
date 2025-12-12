using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using CafeteriaExamen.Model;
using CafeteriaExamen.Controlar;
using CafeteriaExamen.Vista;


namespace CafeteriaExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "CAFETERÍA EXPRESS";

            // Pantalla de bienvenida compacta
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CAFETERÍA EXPRESS\n");
            Console.ResetColor();

            Console.WriteLine("Bienvenido. Personaliza tu café paso a paso.\n");

            // Ejecutar controlador (Builder + Decorador + State)
            CafeController controlador = new CafeController();
            ICafe miCafe = controlador.Ejecutar();

            // Adaptador para convertir precio
            ISistemaPrecios adaptador = new AdaptadorSistemaPrecios();
            double totalDolares = adaptador.ObtenerPrecioEnDolares(miCafe.Costo());

            // Ticket final simple, todo junto
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("             TICKET");
            Console.WriteLine("----------------------------------");

            Console.WriteLine($"Café: {miCafe.Descripcion()}");
            Console.WriteLine($"Total en pesos:   ${miCafe.Costo():0.00}");
            Console.WriteLine($"Total en dólares: ${totalDolares:0.00} USD");

            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gracias por tu compra :)");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}