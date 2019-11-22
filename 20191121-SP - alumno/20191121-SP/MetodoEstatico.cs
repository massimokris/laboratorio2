using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191121_SP
{
  public static class MetodoEstatico
  {

    public static string EstadoSimulacion(this String strg, bool estado)
    {
      string str = "Detenido";
      if (estado)
      {
        str = "Orbitando";
      }

      return str;
    }
  }
}
