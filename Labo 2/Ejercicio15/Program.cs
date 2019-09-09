using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio Nro 15";

      double num1,
        num2,
        resultado;
      string aux,
        operador;
      char seguir = 's';

      do
      {

        Console.WriteLine("Ingrese un numero");
        aux = Console.ReadLine();

        if(double.TryParse(aux, out num1))
        {
          Console.Clear();
          Console.WriteLine("Ingrese otro numero");
          aux = Console.ReadLine();

          if (double.TryParse(aux, out num2))
          {

            Console.Clear();
            Console.WriteLine("Ingrese que operacion quiere realizar");
            operador = Console.ReadLine();

            resultado = Calculadora.calcular(num1, num2, operador);

            Console.Clear();
            Console.WriteLine("El resultado de la operacion es: {0:#,###0.0}", resultado);

          }
          else
          {

            Console.WriteLine("Ingrese solo numeros");
          }
        }
        else
        {

          Console.WriteLine("Ingrese solo numeros");
        }

                Console.WriteLine("Desea continuar ? (s/n)");
                seguir = Console.ReadKey().KeyChar;
      } while (seguir == 's');
       
      Console.ReadKey();
    }
  }
}
