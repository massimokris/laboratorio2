using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            Alumno alumno1 = new Alumno(1, "massimo", "di berardino");
            Alumno alumno2 = new Alumno(2, "flaviano", "hernandez");
            Alumno alumno3 = new Alumno(3, "antonio", "perez");

            alumno1.Estudiar(5, 8);
            alumno2.Estudiar(3, 4);
            alumno3.Estudiar(8, 10);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            alumno1.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();

            Console.ReadKey();
        }
    }
}
