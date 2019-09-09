using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
  class Validacion
  {

    public static bool Validar(int num, int min, int max)
    {
      bool response = false;

      if(min < max)
      {

        if(num > min || num < max)
        {

          response = true;
        }
        else
        {

          response = false;
        }
      }

      return response;
    } 
  }
}
