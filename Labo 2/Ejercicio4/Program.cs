using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro 4";

            int num,
                acumulado = 0,
                flag = 0;
            string aux;

            Console.WriteLine("Ingrese un numero");
            aux = Console.ReadLine();

            if(int.TryParse(aux, out num))
            {

                for(int i = 1; i <= num; i++)
                {
                    for (int j = 1; j < i; j++)
                    {

                        if (i % j == 0)
                        {

                            acumulado = acumulado + j;
                        }
                    }

                    if(acumulado == i)
                    {
                        Console.WriteLine("Es perfecto: {0:#,###0.0}", acumulado);
                        flag++;
                    }
                    if(flag == 4)
                    {
                        break;
                    }
                    acumulado = 0;
                }

                if (flag == 0)
                {

                    Console.WriteLine("No hay perfectos");
                }
            }
            else
            {

                Console.WriteLine("ERROR, ingrese un numero");
            }

            Console.ReadKey();
        }
    }
}
