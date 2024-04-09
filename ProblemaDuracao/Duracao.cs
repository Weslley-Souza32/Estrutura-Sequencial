using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDuracao
{
    public class Duracao
    {
        public int DuracaoSegundos { get; set; }

        public Duracao ( int duracaoSegundos )
        {
            DuracaoSegundos = duracaoSegundos;
        }

        public void ImprimirDuracaoFormatada ()
        {
            int horas = DuracaoSegundos / 3600;
            int minutos = (DuracaoSegundos % 3600) / 60;
            int segundos = DuracaoSegundos % 60;

            Console.WriteLine ($"{horas}:{minutos:D2}:{segundos:D2}");
        }
    }
}
