using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class Miclase
    {

        int b;

        public Miclase(string msg)
        {

        }
        public Miclase ()
        {
            try
            {
                new Miclase(5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public Miclase(int a)
        {
            this.b = a;
            try
            {
                Miclase.MiMetodo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        static void MiMetodo ()
        {
            throw new DivideByZeroException();
        }

        public void MiMetodo2 ()
        {
            try
            {
                new Miclase();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new UnaExcepcion($"Mensaje de exception", e);
            }
        }
    }

    public class UnaExcepcion : Exception
    {
        string mensaje;

        public UnaExcepcion(string mensaje, Exception e) : base(mensaje, e)
        {
            this.mensaje = mensaje;
        }

        public UnaExcepcion(string mensaje) : base(mensaje)
        {
            this.mensaje = mensaje;
        }
    }
}
