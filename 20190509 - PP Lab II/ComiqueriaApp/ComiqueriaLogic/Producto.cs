using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {

    private Guid codigo;
    private string descripcion;
    private double precio;
    private int stock;

    public string Descripcion
    {
      get { return this.descripcion; }
    }

    public double Precio
    {
      get { return this.precio; }
    }

    public int Stock
    {
      get { return this.stock; }
      set
      {
        if (value >= 0)
        {
          this.stock = value;
        }
      }
    }

    protected Producto (string descripcion, int stock, double precio)
    {
      this.codigo = new Guid();
      this.descripcion = descripcion;
      this.stock = stock;
      this.precio = precio;
    }

    static public explicit operator Guid(Producto p)
    {
      return p.codigo;
    }

    public override string ToString()
    {
      StringBuilder str = new StringBuilder();
      str.AppendLine($"Descripción: {this.descripcion}");
      str.AppendLine($"Código: {this.codigo}");
      str.AppendLine($"Precio: ${this.precio}");
      str.AppendLine($"Stock: {this.stock}");

      return str.ToString();
    }
  }
}
