using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
  class Conversor
  {

    public static string DecimalBinario(double num)
    {

      string response = "";

      while(num > 0)
      {

        if(num % 2 == 0)
        {

          response = "0" + response;
        }
        else
        {

          response = "1" + response;
        }

        num = (int)(num / 2);
      }

      return response;
    }

    public static double BinarioDecimal(string num)
    {

      double response = 0;

      char[] array = num.ToCharArray();

      Array.Reverse(array);

      for(int i = 0; i < array.Length; i++)
      {

        if(array[i] == '1')
        {

          response += (int)Math.Pow(2, i);
        }
      }

      return response;
    }
  }
}
