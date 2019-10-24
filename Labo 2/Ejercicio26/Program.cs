using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
  class Program
  {
    static void Main(string[] args)
    {
      
      ///<summary>
      ///26. Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de
      ///cero de forma aleatoria utilizando la clase Random.
      ///a.Mostrar el vector tal como fue ingresado
      ///b.Luego mostrar los positivos ordenados en forma decreciente.
      ///c.Por último, mostrar los negativos ordenados en forma creciente.
      /// </summary>

      int[] random = new int[20];
      int[] positivos = new int[20];
      int[] negativos = new int[20];
      Random rand = new Random();

      
      for(int i = 0; i < 20; i++)
      {

        if(i % 2 == 0)
        {
          random[i] = rand.Next(0, 100);
        }
        else
        {
          random[i] = -rand.Next(0, 100);
        }
        Console.Write($"{random[i]} ");
      }

      for(int j = 0; j < 20; j++)
      {
        if (random[j] >= 0)
        {
          positivos[j] = random[j];
        }
        else
        {
          negativos[j] = random[j];
        }
      }

      Array.Sort(positivos);
      Array.Reverse(positivos);
      Array.Sort(negativos);
      Console.WriteLine("");
      for (int k = 0; k < positivos.Length; k++)
      {
        if (positivos[k] > 0)
        {
          Console.Write($"{positivos[k]} ");
        }
      }

      Console.WriteLine("");

      for (int l = 0; l < negativos.Length; l++)
      {
        if (negativos[l] < 0)
        {
          Console.Write($"{negativos[l]} ");
        }
      }
      Console.ReadKey();
    }
  }
}
