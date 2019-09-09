using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            int altura;
            string aux;

            Console.WriteLine("Ingrese la cantidad de pisos que tendra su piramide");
            aux = Console.ReadLine();
            Console.Clear();

            if (int.TryParse(aux, out altura))
            {

                for (int i = 1; i <= altura; i++)
                {

                    for (int k = altura; k > 0; k--)
                    {

                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {

                        if (j < i)
                        {
                            Console.Write("*");
                        }
                        else
                        {

                            Console.WriteLine("*");
                        }
                    }

                    
                }
            }
            else
            {

                Console.WriteLine("Error, ingrese solo numeros");
            }

            Console.ReadKey();
        }
    }
}
