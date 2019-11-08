using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
  public delegate void DelegadoString(string msg);
  public class Persona
  {
    private string nombre;
    private string apellido;
    public event DelegadoString EventoString;

    public string Apellido
    {
      get { return this.apellido; }
      set
      {
        if(this.apellido != value)
        {
          this.apellido = value;
          this.EventoString.Invoke($"Cambio el usuario: {this.Mostrar()}");
        }
      }
    }

    public string Nombre
    {
      get { return this.nombre; }
      set { this.nombre = value; }
    }

    public Persona ()
    {
      this.nombre = "Massimo";
      this.apellido = "Di Berardino";
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Nombre: {this.nombre}");
      sb.AppendLine($"Apellido: {this.apellido}");
      return sb.ToString();
    }
  }
}
