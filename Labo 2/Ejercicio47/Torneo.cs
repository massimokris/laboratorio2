using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Torneo<T> where T : Equipo
    {
      public List<T> equipos;
      public string nombre;

      public Torneo(string nombre)
      {
        this.nombre = nombre;
        this.equipos = new List<T>();
      }

      public string JugarPartido
      {
        get
        {
          Random random = new Random();
          int e1 = random.Next(0, this.equipos.Count());
          int e2;

          do
          {
            e2 = random.Next(0, this.equipos.Count());
          } while (e1 == e2);
          
          return CalcularPartido(this.equipos[e1], this.equipos[e2]);
        }
      }

      public static bool operator ==(Torneo<T> t, T e)
      {
      
        return t.equipos.Contains(e);
      }

      public static bool operator !=(Torneo<T> t, T e)
      {
        return !(t == e);
      }

      public static Torneo<T> operator +(Torneo<T> t, T e)
      {
        if(t != e)
        {
          t.equipos.Add(e);
        }

        return t;
      }

      public string Mostrar()
      {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Torneo: {this.nombre}");

        foreach (var item in this.equipos)
        {
          sb.AppendLine(item.Ficha());
        }

        return sb.ToString();
      }

      private string CalcularPartido(T t1, T t2)
      {
        Random random = new Random();
        int r1 = random.Next(0, 3);
        int r2 = random.Next(0, 3);
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{t1.nombre} {r1} - {r2} {t2.nombre}");

        return sb.ToString();
      }
    }
}
