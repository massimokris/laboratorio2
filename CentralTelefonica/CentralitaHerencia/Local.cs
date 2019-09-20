using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Local : Llamada
  {

    protected float costo;
    private float costoLlamada;

    public float CostoLlamada
    {
      get { return CalcularCosto(); }
    }

    public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NvoDestino, llamada.NvoOrigen)
    {
      this.costo = costo;
    }

    public Local(float duracion, string origen, string destino, float cost) : base(duracion, destino, origen)
    {
      this.costo = cost;
    }

    public new string Mostrar()
    {
      StringBuilder response = new StringBuilder(base.Mostrar());
      response.AppendLine($"El costo de la llamada: {CostoLlamada}");

      return response.ToString();
    }

    private float CalcularCosto()
    {
      return this.costo * base.duracion;
    }
  }
}
