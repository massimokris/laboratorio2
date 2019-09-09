using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio Nro 12";

      int num,
        acumulador = 0;
      string aux;
      char seguir = 's';

      do
      {

        Console.WriteLine("Ingrese un numero");
        aux = Console.ReadLine();
        Console.Clear();

        if(int.TryParse(aux, out num))
        {

          acumulador = acumulador + num;

          Console.WriteLine("Desea continuar? (S/N)");
          seguir = Console.ReadKey().KeyChar;
          Console.Clear();
        }
        else
        {

          Console.WriteLine("Ingrese solo numeros");
          Console.Clear();
        }

      } while (ValidarRespuesta.ValidaS_N(seguir));

      Console.WriteLine("Acumulado: {0:#,###0.0}", acumulador);
      Console.ReadKey();
    }
  }
}
