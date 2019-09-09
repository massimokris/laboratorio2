using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio Nro 7";

      DateTime date,
        dateHoy = DateTime.Now;
      string aux;
      TimeSpan timeHoy; 

      Console.WriteLine("Ingrese su fecha de nacimiento separada por espacios (dd mm yyyy)");
            aux = Console.ReadLine();

            date = DateTime.Parse(aux);
            timeHoy = dateHoy - date;

            Console.WriteLine("{0}", timeHoy.Days);

      Console.ReadKey();
    }
  }
}
