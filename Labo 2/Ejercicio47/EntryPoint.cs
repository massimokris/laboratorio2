using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Torneo<EquipoBasquet> nba = new Torneo<EquipoBasquet>("NBA");
      Torneo<EquipoFutbol> laLiga = new Torneo<EquipoFutbol>("La Liga");
      EquipoBasquet e1 = new EquipoBasquet("denver", DateTime.Now);
      EquipoBasquet e2 = new EquipoBasquet("dallas", DateTime.Now);
      EquipoBasquet e3 = new EquipoBasquet("colorado", DateTime.Now);
      EquipoFutbol f1 = new EquipoFutbol("Barsa", DateTime.Now);
      EquipoFutbol f2 = new EquipoFutbol("Boca", DateTime.Now);
      EquipoFutbol f3 = new EquipoFutbol("Real", DateTime.Now);

      nba += e1;
      nba += e2;
      nba += e3;
      laLiga += f1;
      laLiga += f2;
      laLiga += f3;

      Console.WriteLine($"{nba.Mostrar()}");
      Console.WriteLine($"{laLiga.Mostrar()}");

      Console.WriteLine($"{nba.JugarPartido}");
      Console.WriteLine($"{nba.JugarPartido}");
      Console.WriteLine($"{nba.JugarPartido}");
      Console.WriteLine($"{nba.JugarPartido}");

      Console.WriteLine($"{laLiga.JugarPartido}");
      Console.WriteLine($"{laLiga.JugarPartido}");
      Console.WriteLine($"{laLiga.JugarPartido}");
      Console.WriteLine($"{laLiga.JugarPartido}");

      Console.ReadKey();
    }
  }
}
