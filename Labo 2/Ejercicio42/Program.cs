using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio54;

namespace Ejercicio42
{
    class Program
    {

        
        static void Main(string[] args)
        {

            Miclase mc = new Miclase("hola");

            try
            {
                mc.MiMetodo2();
            }
            catch (Exception e)
            {
                ArchivoTexto.Guardar(e.ToString());
                Console.WriteLine($"main {e.Message}");
                Console.ReadKey();
            }
        }
    }
}
