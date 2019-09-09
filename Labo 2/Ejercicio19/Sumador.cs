using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
  class Sumador
  {

        /*
        a. Crear dos constructores:
        i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
        ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
        b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
        siguiente lógica:
        i. En el caso de Sumar(long, long) sumará los valores numéricos
        ii. En el de Sumar(string, string) concatenará las cadenas de texto.
        Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.
        */
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {

            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) { }

        public long Sumar(long a, long b)
        {

            this.cantidadSumas++;

            return a + b;
        }

        public string Sumar(string a, string b)
        {

            this.cantidadSumas++;

            return a + b;
        }

        public static explicit operator int (Sumador sumador)
        {

            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador sum1, Sumador sum2)
        {

            return sum1.cantidadSumas + sum2.cantidadSumas;
        }

        public static bool operator |(Sumador sum1, Sumador sum2)
        {

            return sum1.cantidadSumas.Equals(sum2.cantidadSumas);
        }

  }
}
