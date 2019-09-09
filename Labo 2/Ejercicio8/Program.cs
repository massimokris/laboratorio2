using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro 8";

            const int bono = 150;
            int cantidadHoras,
                valorhoras,
                antiguedad,
                bonoAntiguedad;
            double descuento,
                subtotal,
                total;
            string nombre,
                aux,
                continuar = "si";

            do
            {
                Console.WriteLine("Ingrese el valor de las horas a pagar:");
                aux = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(aux, out valorhoras))
                {

                    Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                    aux = Console.ReadLine();
                    Console.Clear();
                    if (int.TryParse(aux, out cantidadHoras))
                    {

                        Console.WriteLine("Ingrese los años de antiguedad:");
                        aux = Console.ReadLine();
                        Console.Clear();
                        if (int.TryParse(aux, out antiguedad))
                        {

                            Console.WriteLine("Ingrese el nombre del empleado:");
                            nombre = Console.ReadLine();
                            Console.Clear();

                            bonoAntiguedad = bono * antiguedad;
                            subtotal = bonoAntiguedad + (valorhoras * cantidadHoras);
                            descuento = subtotal * 0.13;
                            total = subtotal - descuento;

                            Console.WriteLine("Nombre Antiguedad Pago/hora SueldoB Descuentos SueldoN");
                            Console.WriteLine("{0} {1} {2:#,###0.0} {3:#,###0.0} {4:#,###0.0} {5:#,###0.0}", nombre, antiguedad, valorhoras, subtotal, descuento, total);

                            Console.WriteLine("Desea continuar? (si/no)");
                            continuar = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {

                            Console.WriteLine("Error, ingrese solo numeros");
                        }
                    }
                    else
                    {

                        Console.WriteLine("Error, ingrese solo numeros");
                    }
                }
                else
                {

                    Console.WriteLine("Error, ingrese solo numeros");
                }


            } while (continuar == "si");

            Console.ReadKey();
        }
    }
}
