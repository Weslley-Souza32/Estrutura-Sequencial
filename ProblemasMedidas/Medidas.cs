using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasMedidas
{
    public class Medidas
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Medidas ( double a, double b, double c )
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalcularAreaQuadrado ()
        {
            return Math.Pow (A, 2);
        }

        public double CalcularAreaTriangulo ()
        {
            return (A * B) / 2;
        }

        public double CalcularAreaTrapezio ()
        {
            return ((A + B) * C) / 2;
        }
    }

}
