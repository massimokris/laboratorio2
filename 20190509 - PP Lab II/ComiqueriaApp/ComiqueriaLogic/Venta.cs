using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  sealed class Venta
  {

    private DateTime fecha;
    static int porcentajeIva;
    private double precioFinal;
    private Producto producto;

    public DateTime Fecha
    {
      get { return this.fecha; }
    }

    static Venta ()
    {
      porcentajeIva = 21;
    }

    private void Vender (int cantidad)
    {
      this.producto.Stock = this.producto.Stock - cantidad;
      this.fecha = DateTime.Now;
      this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
    }
    
    public static double CalcularPrecioFinal (double precio, int cantidad)
    {
      double rs = 0;
      if (!(cantidad < 1))
      {
         rs = (precio * cantidad) * porcentajeIva / 100;
      }
      return rs;
    }

    ///
    ///El método ObtenerDescripcionBreve devuelve un string breve y en una sola línea indicando
    //fecha, descripción del producto y precio final.De esta forma: “fecha – descripción –
    //precioFinal”. El precio deberá mostrarse con 2 decimales.
    ///

    public string ObtenerDescripcionBreve ()
    {    
      string rs = $"{this.fecha} - {this.producto.Descripcion} - ";
      rs = rs + string.Format("{0:0.00}", this.precioFinal);
      return  rs;
    }

  }
}
