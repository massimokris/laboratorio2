using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            Console.WriteLine("Ingrese 5 numeros");

            int num,
                menor = 0,
                mayor = 0,
                acumulador = 0;
            float promedio = 0;
            String aux;
            bool flag = true;

            for(int i = 0; i < 5; i++)
            {

                aux = Console.ReadLine();

                if (int.TryParse(aux, out num))
                {

                    acumulador = acumulador + num;

                    if (flag)
                    {
                        menor = num;
                        mayor = num;
                        flag = false;
                    }
                    else
                    {

                        if (num > mayor)
                        {

                            mayor = num;
                        }

                        if (num < menor)
                        {

                            menor = num;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Dato ingresado no valido");
                }
            }

            promedio = acumulador / 5;

            Console.WriteLine("menor: {0:#,###.00} \n" +
                "mayor: {1:#,###.00} \n" +
                "acumulado: {2:#,###.00} \n" +
                "promedio: {3:#,###.00}", menor, mayor, acumulador, promedio);
            Console.ReadKey();
        }
    }
}
