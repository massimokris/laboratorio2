using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
  class Calculadora
  {

        public static double calcular(double num1, double num2, string operation)
        {

            double response = 0;

            switch (operation)
            {

                case "+":
                    response = num1 + num2;
                    break;
                case "-":
                    response = num1 - num2;
                    break;
                case "*":
                    response = num1 * num2;
                    break;
                case "/":
                    if (validar(num2))
                    {

                        Console.WriteLine("No se puede dividir por 0");
                        Console.ReadKey();
                    }
                    else
                    {

                        response = num1 / num2;
                    }
                    
                    break;
                default:
                    Console.WriteLine("No es una operacion valida");
                    break;
            }

            return response;
        }

        private static bool validar(double num)
        {
            bool response = false;
            if(num == 0)
            {
                response = true;
            }

            return response;
        }
  }
}
