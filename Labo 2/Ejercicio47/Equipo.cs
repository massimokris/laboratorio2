using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
  public abstract class Equipo
  {

    public string nombre;
    public DateTime fechaCreacion;

    public Equipo(string nombre, DateTime fecha)
    {
      this.nombre = nombre;
      this.fechaCreacion = fecha;
    }

    public static bool operator ==(Equipo e1, Equipo e2)
    {
      return (e1.nombre.Equals(e2.nombre) && e1.fechaCreacion.Equals(e2.fechaCreacion));
    }

    public static bool operator !=(Equipo e1, Equipo e2)
    {
      return !(e1 == e2);
    }

    public string Ficha()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"{this.nombre} fundado el {this.fechaCreacion}");

      return sb.ToString();
    }
  }
}
