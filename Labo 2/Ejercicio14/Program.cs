using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio Nro 14";

      int opcion;
      string aux;

      Console.WriteLine("1-Calcular el area de un cuadrado");
      Console.WriteLine("2-Calcular el area de un circulo");
      Console.WriteLine("3-Calcular el area de un triangulo");
      Console.WriteLine("Ingrese una opcion");
      aux = Console.ReadLine();

      if(int.TryParse(aux, out opcion))
      {

        switch (opcion)
        {

          case 1:

            double num;
            Console.WriteLine("Ingrese el largo de un lado");
            aux = Console.ReadLine();

            if(double.TryParse(aux, out num))
            {

              num = CalculoArea.CalcularCuadrado(num);
              Console.WriteLine("El area del cuadrado es: {0}", num);
            }
            else
            {

              Console.WriteLine("Ingrese solo numeros");
            }
            break;
          case 2:

            double radio;
            Console.WriteLine("Ingrese el radio del circulo");
            aux = Console.ReadLine();

            if (double.TryParse(aux, out radio))
            {

              radio = CalculoArea.CalcularCirculo(radio);
              Console.WriteLine("El area del circulo es: {0:#,###0.0}", radio);
            }
            else
            {

              Console.WriteLine("Ingrese solo numeros");
            }
            break;
          case 3:

            double lado1, lado2;
            Console.WriteLine("Ingrese el largo de un lado");
            aux = Console.ReadLine();

            if(double.TryParse(aux, out lado1))
            {

              Console.WriteLine("Ingrese el largo de un lado");
              aux = Console.ReadLine();

              if(double.TryParse(aux, out lado2))
              {

                lado1 = CalculoArea.CalcularTriangulo(lado1, lado2);
                Console.WriteLine("El area del triangulo es: {0:#,###0.0}", lado1);
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
            break;
        }
      }

      Console.ReadKey();
    }
  }
}
