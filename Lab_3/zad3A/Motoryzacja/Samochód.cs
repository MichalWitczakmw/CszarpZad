using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motoryzacja
{
    public class Samochód : PojazdMechaniczny
    {
        private int liczbaPasażerów;

        public int LiczbaPasażerów
        {
            get { return liczbaPasażerów; }

            set
            {
                if (value < 1 || value > 9)
                {
                    throw new ArgumentException("Liczba pasażerów musi być między 1 a 9.");
                }
                liczbaPasażerów = value;
            }
        }

        public string Marka { get; set; }

        public Samochód() { }

        public Samochód(string nazwa, int liczbaKol, double predkosc, double mocSilnika, int liczbaPasażerów, string marka)
            : base(nazwa, liczbaKol, predkosc, mocSilnika)
        {
            LiczbaPasażerów = liczbaPasażerów;
            Marka = marka;
        }

        public Samochód(string nazwa, double predkosc, double mocSilnika, int liczbaPasażerów, string marka)
            : base(nazwa, predkosc, mocSilnika)
        {
            LiczbaPasażerów = liczbaPasażerów;
            Marka = marka;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Marka: {Marka} - Liczba pasażerów: {LiczbaPasażerów}";
        }
    }
}
