using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {

        const short cantidadTintaMaxima = 100;
        private short tinta;
        private ConsoleColor color;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public Boligrafo() :this(100, ConsoleColor.Blue){ }

        public ConsoleColor GetColor()
        {

            return this.color;
        }

        public short GetTinta()
        {

            return this.tinta;
        }

        private void SetTinta(short t)
        {

            if (t > 0)
            {

                if (100 - this.tinta >= t)
                {

                    this.tinta += t;
                }
                else
                {

                    this.tinta = 100;
                }
            }
            else
            {

                if (this.tinta - t >= 0)
                {

                    this.tinta -= t;
                }
                else
                {

                    this.tinta = 0;
                }
            }
        }

        public void Recargar()
        {

            SetTinta(100);
        }

        public bool Pintar(short g, out string d)
        {

            bool response = false;
            d = "";

            if (this.tinta > 0)
            {

                response = true;
                
               
                for(int i = 0; i < g; i++)
                {

                    if (i > this.tinta) break;
                    d += "*";
                }

                this.SetTinta(g);
            }

            return response;
        }
    }
}
