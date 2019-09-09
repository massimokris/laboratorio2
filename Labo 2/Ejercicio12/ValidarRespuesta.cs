using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
  class ValidarRespuesta
  {

    public static bool ValidaS_N(char r)
    {
      bool response = false;

      if(Char.ToLower(r) == 's')
      {

        response = true;
      }

      return response;
    }
  }
}
