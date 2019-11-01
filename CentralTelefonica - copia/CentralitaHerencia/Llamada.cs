using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public abstract class Llamada
  {

    protected float duracion;
    protected string nvoDestino;
    protected string nvoOrigen;

    public abstract float CostoLlamada
    {
      get;
    }

    public float Duracion
    {
      get { return this.duracion; }
    }

    public string NvoDestino
    {
      get { return this.nvoDestino; }
    }

    public string NvoOrigen
    {
      get { return this.nvoOrigen; }
    }

    public Llamada(float duracion, string nvoDestino, string nvoOrigen)
    {
      this.duracion = duracion;
      this.nvoDestino = nvoDestino;
      this.nvoOrigen = nvoOrigen;
    }

    protected virtual string Mostrar()
    {
      StringBuilder response = new StringBuilder($"El numero: {this.nvoOrigen}, llamo al numero: {this.nvoDestino}, durante {this.duracion} ");
      
      return response.ToString();
    }

    public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
    {
      int response;
      if(l1.duracion == l2.duracion)
      {
        response = 0;
      }else if(l1.duracion > l2.duracion)
      {
        response = 1;
      }
      else
      {
        response = -1;
      }

      return response;
    }

    public static bool operator ==(Llamada l1, Llamada l2)
    {
      return l1.Equals(l2) && l1.NvoDestino == l2.NvoDestino && l1.NvoOrigen == l2.NvoOrigen;
    }

    public static bool operator !=(Llamada l1, Llamada l2)
    {
      return !(l1 == l2);
    }

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }
  }
}
