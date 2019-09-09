using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {

        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {

            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            int verticeX2 = vertice3.GetX();
            int verticeY2 = vertice1.GetY();

            this.vertice2 = new Punto(verticeX2, verticeY2);

            int puntoX4, puntoY4, dif;

            dif = Math.Abs(vertice1.GetX() - vertice3.GetX());
            puntoX4 = vertice3.GetX() - dif;
            puntoX4 = Math.Abs(puntoX4);

            dif = Math.Abs(vertice3.GetY() - vertice1.GetY());
            puntoY4 = vertice1.GetY() - dif;
            puntoY4 = Math.Abs(puntoY4);

            this.vertice4 = new Punto(puntoX4, puntoY4);
        }

        public float GetArea()
        {

            if(this.area == 0)
            {

                this.area = Area();
            }

            return this.area;
        }

        public float GetPerimetro()
        {

            if(this.perimetro == 0)
            {

                perimetro = Perimetro();
            }

            return this.perimetro;
        }

        private float Area()
        {
            float area;
            int b, altura;

            b = vertice4.GetX() - vertice3.GetX();
            b = Math.Abs(b);

            altura = vertice2.GetY() - vertice3.GetY();
            altura = Math.Abs(altura);

            area = b * altura;

            return area;
        }

        private float Perimetro()
        {
            float perimetro;
            int b, altura;

            b = vertice4.GetX() - vertice3.GetX();
            b = Math.Abs(b);

            altura = vertice2.GetY() - vertice3.GetY();

            perimetro = (b + altura) * 2;

            return perimetro;

        }
    }
}
