using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Centralita
  {
    private List<Llamada> listaDeLlamadas;
    protected string razonSocial;

    public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
    public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
    public float GananciasPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }
    public List<Llamada> Llamadas { get { return listaDeLlamadas; } }

    public Centralita()
    {
      listaDeLlamadas = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa) : this()
    {
      razonSocial = nombreEmpresa;
    }

    public string Mostrar()
    {
      Local local;
      Provincial provincial;
      StringBuilder str = new StringBuilder(($"Razon social: {razonSocial} Ganancia total: {GananciasPorTotal}\n"));
      str.AppendLine($"Ganancias Local: {GananciasPorLocal} Ganancias Provincial: {GananciasPorProvincial}");

      foreach (Llamada l in Llamadas)
      {
        if (l is Local)
        {
          local = (Local)l;
          str.AppendLine(local.Mostrar());
        }
        else
        {
          provincial = (Provincial)l;
          str.AppendLine(provincial.Mostrar());
        }
      }

      return str.ToString();
    }

    public void OrdenarLlamadas()
    {
      listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      float acum = 0;
      Local local;
      Provincial provincial;

      foreach (Llamada l in Llamadas)
      {
        if (tipo == Llamada.TipoLlamada.Todas)
        {
          if (l is Local)
          {
            local = (Local)l;
            acum += local.CostoLlamada;
          }
          else
          {
            provincial = (Provincial)l;
            acum += provincial.CostoLlamada;
          }
        }
        else if (tipo == Llamada.TipoLlamada.Local)
        {
          if (l is Local)
          {
            local = (Local)l;
            acum += local.CostoLlamada;
          }
        }
        else if (tipo == Llamada.TipoLlamada.Provincial)
        {
          if (l is Provincial)
          {
            provincial = (Provincial)l;
            acum += provincial.CostoLlamada;
          }
        }
      }

      return acum;
    }


  }
}
