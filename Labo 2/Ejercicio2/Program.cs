using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro 2";
            Console.WriteLine("Ingrese un numero:");

            int num;
            double cubo, cuadrado;
            string aux;

            

            do
            {
                aux = Console.ReadLine();

                if (int.TryParse(aux, out num))
                {

                    if (num > 0)
                    {

                        cuadrado = Math.Pow(num, 2);
                        cubo = Math.Pow(num, 3);

                        Console.WriteLine("el numero: {0:#,###.00} \n" +
                            "Al cuadrado: {1:#,###.00} \n" +
                            "Al cubo: {2:#,###.00}", num, cuadrado, cubo);
                    }
                    else
                    {

                        Console.WriteLine("ERROR, reingresar numero!");
                    }
                }
                else
                {

                    Console.WriteLine("ERROR, reingresar numero!");
                }
            } while (!(int.TryParse(aux, out num)) || num <= 0);

            Console.ReadKey();
        }
    }
}
