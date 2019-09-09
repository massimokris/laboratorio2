using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
  class Estante
  {

    private Producto[] productos;
    private int ubicacionEstante;

    private Estante(int capacidad)
    {

      this.productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {

      this.ubicacionEstante = ubicacion;
    }

    public Producto[] GetProductos()
    {

      return this.productos;
    }
    
    public static string MostrarEstante(Estante e)
    {
      string productos = "";

      foreach(Producto prod in e.productos)
      {

        productos += "\n" + Producto.MostrarProducto(prod);
      }
      string response = string.Format("Ubicacion: {0} \nProductos: {1}", e.ubicacionEstante, productos);

      return response;
    }

    public static bool operator ==(Estante e, Producto p)
    {

      return e.productos.Contains<Producto>(p);
    }

    public static bool operator !=(Estante e, Producto p)
    {

      return !(e == p);
    }

    public static bool operator +(Estante e, Producto p)
    {

      bool response = false;

      if(e != p)
      {

        for(int i = 0; i < e.productos.Length; i++)
        {

          if(e.productos[i] is null)
          {

            e.productos[i] = p;
            response = true;
            break;
          }
        }
      }

      return response;
    }
    
    public static Estante operator -(Estante e, Producto p)
    {

      Estante response = new Estante(e.productos.Length);

      if (e == p)
      { 

        for (int i = 0; i < e.productos.Length; i++)
        {

          if (e.productos[i].Equals(p))
          {

            response.productos[i] = e.productos[i];
          }
        }
      }

      return response;
    }
  }
}
