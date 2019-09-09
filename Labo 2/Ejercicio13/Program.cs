using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio 13";

      double num;
      string aux;

      Console.WriteLine("1- Decimal a binario \n2- Binario a decimal\nIngrese una opcion: ");
      aux = Console.ReadLine();

      if(double.TryParse(aux, out num))
      {

        switch (num)
        {

          case 1:
            Console.WriteLine("Ingrese el numero a convertir");
            aux = Console.ReadLine();

            if (double.TryParse(aux, out num))
            {

              aux = Conversor.DecimalBinario(num);
              Console.WriteLine("El numero {0} es {1} en binario", num, aux);
            }
            break;
          case 2:
            Console.WriteLine("Ingrese el numero a convertir");
            aux = Console.ReadLine();

            num = Conversor.BinarioDecimal(aux);
            Console.WriteLine("El numero {0} es {1} en decimal", aux, num);
            break;
        }
        Console.ReadKey();
      }
    }
  }
}
