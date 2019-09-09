using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {

        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(int legajo, string nombre, string apellido)
        {

            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public void Estudiar(byte nota1, byte nota2)
        {

            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void CalcularFinal()
        {

            if(this.nota1 > 3 && this.nota2 > 3)
            {

                int rand = new Random().Next(this.nota1, this.nota2);
            }
            else
            {

                this.notaFinal = -1;
            }
        }

        public void Mostrar()
        {
            if (this.notaFinal == -1)
            {

                Console.WriteLine("Legajo   Apellido   Nombre   Nota1   Nota2   NotaFinal");
                Console.WriteLine("{0} {1} {2} {3:#,###0.0} {4:#,###0.0} No aprobo", this.legajo, this.apellido, this.nombre, this.nota1, this.nota2);
            }
            else
            {

                Console.WriteLine("Legajo   Apellido   Nombre   Nota1   Nota2   NotaFinal");
                Console.WriteLine("{0} {1} {2} {3:#,###0.0} {4:#,###0.0} {5:#,###0.0}", this.legajo, this.apellido, this.nombre, this.nota1, this.nota2, this.notaFinal);
            }
        }
    }
}
