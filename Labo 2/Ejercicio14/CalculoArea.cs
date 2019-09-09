using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
  class CalculoArea
  {

    public static double CalcularCuadrado(double num)
    {
      double response;

      response = num * num;

      return response;
    }

    public static double CalcularCirculo(double num)
    {
      double response;
      const double pi = 3.14;

      response = pi * (num * num);

      return response;
    }

    public static double CalcularTriangulo(double num, double num2)
    {
      double response;

      response = (num * num2)/2;

      return response;
    }
  }
}
