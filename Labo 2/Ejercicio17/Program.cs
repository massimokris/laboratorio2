using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {

            Boligrafo boli1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boli2 = new Boligrafo(50, ConsoleColor.Red);
            string pintaBoli1;
            string pintaboli2;

            boli1.Pintar(10, out pintaBoli1);

            Console.ForegroundColor = boli1.GetColor();
            Console.WriteLine("{0}", pintaBoli1);

            boli1.Pintar(90, out pintaBoli1);

            Console.WriteLine(" ");
            Console.WriteLine("{0}", pintaBoli1);

            boli1.Pintar(10, out pintaBoli1);

            Console.WriteLine(" ");
            Console.WriteLine("{0}", pintaBoli1);

            Console.ReadKey();
        }
    }
}
