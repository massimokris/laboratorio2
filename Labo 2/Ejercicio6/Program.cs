using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio Nro 6";

      int añoBase,
        añoFinal;
      string aux;
      bool bisiesto = false;

      Console.WriteLine("Ingrese el año base:");
      aux = Console.ReadLine();

      if(int.TryParse(aux, out añoBase))
      {

        Console.WriteLine("Ingrese el año final:");
        aux = Console.ReadLine();

        if(int.TryParse(aux, out añoFinal))
        {

          for(int i = añoBase; i <= añoFinal; i++)
          {

            if(i % 4 == 0)
            {
              if(i % 100 == 0) {

                if(i % 400 == 0)
                {

                  Console.WriteLine("{0:#,###0.0} es bisiesto", i);
                  bisiesto = true;
                }
              } else {

                Console.WriteLine("{0:#,###0.0} es bisiesto", i);
                bisiesto = true;
              }
            }
          }

          if (!bisiesto)
          {

            Console.WriteLine("No hay años bisiestos!");
          }
        }
        else
        {

          Console.WriteLine("ERROR, ingrese solo numero!");
        }
      }
      else
      {

        Console.WriteLine("ERROR, ingrese solo numero!");
      }

      Console.ReadKey();
    }
  }
}
