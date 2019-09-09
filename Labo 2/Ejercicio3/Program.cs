using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro 3";

            int num;
            string aux;

            Console.WriteLine("Ingrese un numero: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out num))
            {

                for (int i = 1; i <= num; i++)
                {

                    if (i % 2 != 0)
                    {

                        Console.WriteLine("Es primo: {0:#,###0.0}", i);
                    }
                }
            }
            else {

                Console.WriteLine("ERROR, ingrese solo numero!");
            }

            Console.ReadKey();
        }
    }
}
