using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Provincial : Llamada
  {

    protected Franja franjaHoraria;

    public new string Mostrar()
    {
      StringBuilder response = new StringBuilder(base.Mostrar());

    }
  }

  public enum Franja
  {
    Franja_1,
    Franja_2,
    Franja_3
  }
}
