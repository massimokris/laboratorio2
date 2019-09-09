using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {

            Dolar dolar = new Dolar(100);
            Dolar dolar2 = new Dolar(100);
            Peso peso = new Peso(1000);
            Euro euro = new Euro(100);
            Euro euro2 = new Euro(100);

            Console.WriteLine($"Get cantidad: Euro {euro.GetCantidad()} Dolar {dolar.GetCantidad()} Peso {peso.GetCantidad()}");
            Console.WriteLine($"\nGet cotizacion: Euro {euro.GetCotizacion()} Dolar {dolar.GetCotizacion()} Peso {peso.GetCotizacion()}");

            dolar = (Dolar)peso;
            Console.WriteLine($"\nConv. explicita peso a dolar: {dolar.GetCantidad()}");

            dolar = (Dolar)euro;
            Console.WriteLine($"Conv. explicita euro a dolar: {dolar.GetCantidad()}");

            euro = (Euro)peso;
            Console.WriteLine($"Conv. explicita peso a euro: {euro.GetCantidad()}");

            euro = (Euro)dolar2;
            Console.WriteLine($"Conv. explicita dolar a euro: {euro.GetCantidad()}");

            peso = (Peso)euro2;
            Console.WriteLine($"Conv. explicita euro a peso: {peso.GetCantidad()}");

            peso = (Peso)dolar2;
            Console.WriteLine($"Conv. explicita dolar a peso: {peso.GetCantidad()}");

            Console.WriteLine("\nConv. implicita desde double\n");

            dolar = 100;
            euro = 100;
            peso = 100;

            Console.WriteLine($"Dolar: {dolar.GetCantidad()} Euro: {euro.GetCantidad()} Peso: {peso.GetCantidad()}");

            dolar = (Dolar)peso;
            Console.WriteLine($"\nPeso a dolar {dolar.GetCantidad()}");

            peso = (Peso)dolar;
            Console.WriteLine($"Dolar a peso {peso.GetCantidad()}");

            peso = (Peso)euro;
            Console.WriteLine($"Euro a peso {peso.GetCantidad()}");

            euro = (Euro)peso;
            Console.WriteLine($"Peso a euro {euro.GetCantidad()}");

            dolar = (Dolar)euro;
            Console.WriteLine($"Euro a dolar {dolar.GetCantidad()}");

            euro = (Euro)dolar;
            Console.WriteLine($"Dolar a euro {euro.GetCantidad()}");

            Console.ReadKey();
        }
    }
}
