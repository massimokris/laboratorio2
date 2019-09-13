using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("esto esta hecho con listas");
      List<int> list = new List<int>();
      List<int> positivos = new List<int>();
      List<int> negativos = new List<int>();
      int aux;
      Random rand = new Random();

      for (int i = 0; i < 20; i++)
      {
        aux = rand.Next(-100, 100);
        list.Add(aux);
        Console.Write($"{list[i]} ");
        if (list[i] >= 0)
        {
          positivos.Add(list[i]);
        }
        else
        {
          negativos.Add(list[i]);
        }
      }

      positivos.Sort();
      positivos.Reverse();
      negativos.Sort();

      Console.WriteLine();

      for (int j = 0; j < positivos.Count(); j++)
      {
        Console.Write($"{positivos[j]} ");
      }

      Console.WriteLine();

      for (int k = 0; k < negativos.Count(); k++)
      {
        Console.Write($"{negativos[k]} ");
      }
      Console.WriteLine("fin listas");
      Console.WriteLine("esto esta hecho con colas");

      Queue<int> queue = new Queue<int>();
      Queue<int> positivo = new Queue<int>();
      Queue<int> negativo = new Queue<int>();

      for (int i = 0; i < 20; i++)
      {
        aux = rand.Next(-100, 100);
        queue.Enqueue(aux);
        if(aux >= 0)
        {
          positivo.Enqueue(aux);
        }
        else
        {
          negativo.Enqueue(queue.ElementAt(i));
        }
      }

      List<int> lista = positivo.ToList();
      

      Console.WriteLine("fin colas");
      Console.ReadKey();
    }
  }
}
