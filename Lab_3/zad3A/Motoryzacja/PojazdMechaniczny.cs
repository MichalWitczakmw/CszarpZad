using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motoryzacja
{
    public class PojazdMechaniczny : Pojazd
    {

        private double mocSilnika;

        public double MocSilnika
        {
            get { return mocSilnika; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Moc silnika nie może być ujemna.");
                }
                mocSilnika = value;
            }
        }

        public PojazdMechaniczny() { }

        public PojazdMechaniczny(string nazwa, int liczbaKol, double predkosc, double mocSilnika)
            : base(nazwa, liczbaKol, predkosc)
        {
            MocSilnika = mocSilnika;
        }

        public PojazdMechaniczny(string nazwa, double predkosc, double mocSilnika)
            : base(nazwa, predkosc)
        {
            MocSilnika = mocSilnika;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Moc silnika: {MocSilnika} KM";
        }
    }
}
