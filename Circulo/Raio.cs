using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    public class Raio
    {
        public double ValorRaio { get; set; }

        public Raio ( double valorRaio )
        {
            ValorRaio = valorRaio;
        }

        public double CalcularRaio ()
        {
            return Math.PI * Math.Pow (ValorRaio, 2);
        }
    }
}
