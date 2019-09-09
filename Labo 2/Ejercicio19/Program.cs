using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
  class Program
  {
    static void Main(string[] args)
    {

            Sumador sum1 = new Sumador(2);
            Sumador sum2 = new Sumador();

            bool prueba = (sum1|sum2);

            Console.WriteLine("Misma cantidad de sumas: {0}", prueba);
            Console.WriteLine("Suma: {0}", sum1.Sumar(5,5));
            Console.WriteLine("Concatenar: {0}", sum2.Sumar("hola", "chau"));
            Console.ReadKey();
    }
  }
}
