using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio 11";

      int num,
        max = 0,
        min = 0,
        acumulador = 0;
      double promedio = 0;
      string aux;
      for (int i = 0; i < 10; i++)
      {

        Console.WriteLine("Ingrese un numero entre -100/100");
        aux = Console.ReadLine();

        if (int.TryParse(aux, out num))
        {

          if (Validacion.Validar(num, -100, 100))
          {

            if (i == 0)
            {

              max = num;
              min = num;
            }

            if (num < min)
            {

              min = num;
            }

            if (num > max)
            {

              max = num;
            }

            acumulador = acumulador + num;
          }
          else
          {

            Console.WriteLine("Numero fuera de rango");
          }
        }
        else
        {

          Console.WriteLine("Ingrese solo numeros");
        }
      }

      promedio = acumulador / 10;

      Console.Clear();
      Console.WriteLine("el numero menor: {0:#,###0.0} \n el numero mayor: {1:#,###0.0} \n el promedio: {2:#,###0.0}", min, max, promedio);
      Console.ReadKey();
    }
  }
}
