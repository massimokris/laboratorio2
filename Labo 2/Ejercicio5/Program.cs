using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio Nro 5";

      int num,
        inferior = 0,
        superior = 0;
      bool centro = false;
      string aux;

      Console.WriteLine("Ingrese un numero:");
      aux = Console.ReadLine();

      if(int.TryParse(aux, out num))
      {

        for(int i = 1; i <= num; i++)
        {

          for(int j = 1; j < i; j++)
          {

            inferior = inferior + j;
          }

          for(int k = i+1; ; k++)
          {

            superior = superior + k;

            if(inferior == superior)
            {

              Console.WriteLine("{0:#,###0.0} es centro numerico", i);
              centro = true;
              break;
            }

            if(superior > inferior)
            {
              break;
            }
          }

          inferior = 0;
          superior = 0;
        }
      }
      else
      {

        Console.WriteLine("ERROR, ingrese solo numeros");
      }

      if (!centro)
      {

        Console.WriteLine("No hay centros numericos!");
      }

      Console.ReadKey();
    }
  }
}
