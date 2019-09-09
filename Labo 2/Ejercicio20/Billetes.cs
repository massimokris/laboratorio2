using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Peso
    {

        private double cantidad;
        private static double cotizacion;

        public Peso()
        {
            this.cantidad = 0;
            cotizacion = 38.33;
        }

        public Peso(double cantidad)
        {

            this.cantidad = cantidad;
            cotizacion = 38.33;
        }

        public Peso(double cantidad, double cotiza) : this(cantidad)
        {

            this.cantidad = cantidad;
            cotizacion = cotiza;
        }

        public double GetCantidad()
        {

            return this.cantidad;
        }

        public double GetCotizacion()
        {

            return cotizacion;
        }

        public static explicit operator Euro(Peso p)
        {

            Euro euro = new Euro(p.GetCantidad(), p.GetCotizacion());

            return euro;
        }

        public static explicit operator Dolar(Peso p)
        {

            Dolar dolar = new Dolar(p.GetCantidad(), p.GetCotizacion());

            return dolar;
        }

        public static implicit operator Peso(Double d)
        {

            Peso peso = new Peso(d);

            return peso;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {

            return p1.GetCantidad().Equals(p2.GetCantidad());
        }

        public static bool operator !=(Peso p1, Peso p2)
        {

            return !(p1 == p2);
        }

        public static bool operator ==(Dolar d, Peso p)
        {

            return d.GetCantidad().Equals(p.GetCantidad());
        }

        public static bool operator !=(Dolar d, Peso p)
        {

            return !(d == p);
        }

        public static bool operator ==(Euro e, Peso p)
        {

            return e.GetCantidad().Equals(p.GetCantidad());
        }

        public static bool operator !=(Euro e, Peso p)
        {

            return !(e == p);
        }

        public static Peso operator +(Peso d, Euro p)
        {

            Peso europ = (Peso)p;
            double cant = p.GetCantidad() + d.GetCantidad();
            Peso Euro = new Peso(cant);

            return Euro;
        }

        public static Peso operator -(Peso e, Euro p)
        {

            Peso Pesop = (Peso)p;
            double cant = e.GetCantidad() - p.GetCantidad();
            Peso Peso = new Peso(cant);

            return Peso;
        }

        public static Peso operator +(Peso e, Dolar d)
        {

            Peso Pesop = (Peso)d;
            double cant = e.GetCantidad() + d.GetCantidad();
            Peso Peso = new Peso(cant);

            return Peso;
        }

        public static Peso operator -(Peso e, Dolar d)
        {

            Peso Pesop = (Peso)d;
            double cant = e.GetCantidad() - d.GetCantidad();
            Peso Peso = new Peso(cant);

            return Peso;
        }
    }

    class Euro
    {

        private double cantidad;
        private static double cotizacion;

        public Euro()
        {
            this.cantidad = 0;
            cotizacion = 1.16;
        }

        public Euro(double cantidad)
        {

            this.cantidad = cantidad;
            cotizacion = 1.16;
        }

        public Euro(double cantidad, double cotiza) : this(cantidad)
        {

            this.cantidad = cantidad;
            cotizacion = cotiza;
        }

        public double GetCantidad()
        {

            return this.cantidad;
        }

        public double GetCotizacion()
        {

            return cotizacion;
        }

        public static explicit operator Peso(Euro e)
        {

            Peso peso = new Peso(e.GetCantidad(), e.GetCotizacion());

            return peso;
        }

        public static explicit operator Dolar(Euro e)
        {

            Dolar dolar = new Dolar(e.GetCantidad(), e.GetCotizacion());

            return dolar;
        }

        public static implicit operator Euro(double e)
        {

            Euro euro = new Euro(e);

            return euro;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {

            return e1.GetCantidad().Equals(e2.GetCantidad());
        }

        public static bool operator !=(Euro e1, Euro e2)
        {

            return !(e1 == e2);
        }

        public static bool operator ==(Peso p, Euro e)
        {

            return p.GetCantidad().Equals(e.GetCantidad());
        }

        public static bool operator !=(Peso p, Euro e)
        {

            return !(p == e);
        }

        public static bool operator ==(Dolar d, Euro e)
        {

            return d.GetCantidad().Equals(e.GetCantidad());
        }

        public static bool operator !=(Dolar d, Euro e)
        {

            return !(d == e);
        }

        public static Euro operator +(Euro d, Peso p)
        {

            Euro europ = (Euro)p;
            double cant = p.GetCantidad() + d.GetCantidad();
            Euro Euro = new Euro(cant);

            return Euro;
        }

        public static Euro operator -(Euro e, Peso p)
        {

            Euro Europ = (Euro)p;
            double cant = e.GetCantidad() - p.GetCantidad();
            Euro Euro = new Euro(cant);

            return Euro;
        }

        public static Euro operator +(Euro e, Dolar d)
        {

            Euro Europ = (Euro)d;
            double cant = e.GetCantidad() + d.GetCantidad();
            Euro Euro = new Euro(cant);

            return Euro;
        }

        public static Euro operator -(Euro e, Dolar d)
        {

            Euro Europ = (Euro)d;
            double cant = e.GetCantidad() - d.GetCantidad();
            Euro Euro = new Euro(cant);

            return Euro;
        }
    }

    class Dolar
    {

        private double cantidad;
        private static double cotizacion;

        public Dolar()
        {
            this.cantidad = 0;
            cotizacion = 1;
        }

        public Dolar(double cantidad)
        {

            this.cantidad = cantidad;
            cotizacion = 1;
        }

        public Dolar(double cantidad, double cotiza) : this(cantidad)
        {

            this.cantidad = cantidad;
            cotizacion = cotiza;
        }

        public double GetCantidad()
        {

            return this.cantidad;
        }

        public double GetCotizacion()
        {

            return cotizacion;
        }

        public static explicit operator Peso(Dolar d)
        {

            Peso peso = new Peso(d.GetCantidad(), d.GetCotizacion());

            return peso;
        }

        public static explicit operator Euro(Dolar d)
        {

            Euro euro = new Euro(d.GetCantidad(), d.GetCotizacion());

            return euro;
        }

        public static implicit operator Dolar(double d)
        {

            Dolar dolar = new Dolar(d);

            return dolar;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {

            return d1.GetCantidad().Equals(d2.GetCantidad());
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {

            return !(d1 == d2);
        }

        public static bool operator ==(Peso p, Dolar d)
        {

            return p.GetCantidad().Equals(d.GetCantidad());
        }

        public static bool operator !=(Peso p, Dolar d)
        {

            return !(p == d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {

            return e.GetCantidad().Equals(d.GetCantidad());
        }

        public static bool operator !=(Euro e, Dolar d)
        {

            return !(e == d);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {

            Dolar dolarp = (Dolar)p;
            double cant = p.GetCantidad() + d.GetCantidad();
            Dolar dolar = new Dolar(cant);

            return dolar;
        }

        public static Dolar operator -(Dolar d, Peso p)
        {

            Dolar dolarp = (Dolar)p;
            double cant = d.GetCantidad() - p.GetCantidad();
            Dolar dolar = new Dolar(cant);

            return dolar;
        }

        public static Dolar operator +(Dolar d, Euro p)
        {

            Dolar dolarp = (Dolar)p;
            double cant = p.GetCantidad() + d.GetCantidad();
            Dolar dolar = new Dolar(cant);

            return dolar;
        }

        public static Dolar operator -(Dolar d, Euro p)
        {

            Dolar dolarp = (Dolar)p;
            double cant = d.GetCantidad() - p.GetCantidad();
            Dolar dolar = new Dolar(cant);

            return dolar;
        }
    }

}
