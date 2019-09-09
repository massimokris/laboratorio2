using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
  class Producto
  {

    private string codigoDeBarra;
    private string marca;
    private float precio;

    public Producto(string marca, string codigo, float precio) {

      this.marca = marca;
      this.precio = precio;
      this.codigoDeBarra = codigo;
    }

    public string GetMarca()
    {

      return this.marca;
    }

    public float GetPrecio()
    {

      return this.precio;
    }

    public static string MostrarProducto(Producto p)
    {

      string response = string.Format("Marca:{0}, Precio:{1:#,###0.0}, Codigo:{2}", p.marca, p.precio, p.codigoDeBarra);

      return response;
    }

    public static explicit operator string(Producto p)
    {

      return p.codigoDeBarra;
    }

    public static bool operator == (Producto p1, Producto p2)
    {

      return (p1.marca.Equals(p2.marca) && p1.codigoDeBarra.Equals(p2.codigoDeBarra));
    }

    public static bool operator !=(Producto p1, Producto p2)
    {

      return !(p1 == p2);
    }

    public static bool operator ==(Producto p, string marca)
    {

      return (p.marca.Equals(marca));
    }

    public static bool operator !=(Producto p, string marca)
    {

      return !(p == marca);
    }



  }
}
