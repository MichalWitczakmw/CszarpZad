using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFKOLA
{
    internal class Prostopadloscian
    {
        public double Wysokosc { get; set; }
        public double Szerokosc { get; set; }
        public double Grubosc { get; set; }

       
        public Prostopadloscian(double bok) : this(bok, bok, bok)
        {
        }

        public Prostopadloscian(double wysokosc, double szerokosc, double grubosc)
        {
            Wysokosc = wysokosc;
            Szerokosc = szerokosc;
            Grubosc = grubosc;
        }

        public override string ToString()
        {
            return $"Wysokość: {Wysokosc}, Szerokość: {Szerokosc}, Grubość: {Grubosc}";
        }
    }
}
