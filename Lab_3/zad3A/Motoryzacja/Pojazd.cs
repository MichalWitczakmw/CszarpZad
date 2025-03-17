namespace Motoryzacja
{
    public class Pojazd
    {
        private static int liczbaPojazdów;

        public string Nazwa { get; set; } = "";

        private int liczbaKół;
        private double predkość;

        
        public int Lp { get; private set; }



        public int LiczbaKół
        {
            get { return liczbaKół; }

            set
            {
                if (value < 1 || value > 20)
                {
                    throw new ArgumentException("Liczba kół musi być między 1 a 20.");
                }
                liczbaKół = value;
            }
        }

        public double Predkość
        {
            get { return predkość; }

            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("Prędkość musi być między 0 a 10000 km/h.");
                }
                predkość = value;
            }
        }
        static Pojazd() { liczbaPojazdów=0; }

        public Pojazd() { Lp = ++liczbaPojazdów; }

        public Pojazd(string nazwa, int liczbaKol, double predkosc) :this()
        {
            Nazwa = nazwa;
            LiczbaKół = liczbaKol;
            Predkość = predkosc;
        }

        public Pojazd(string nazwa, double predkosc) : this(nazwa, 4, predkosc){}

        public override string ToString()
        {
            return $"{Lp}/{liczbaPojazdów} - {Nazwa} - {LiczbaKół} kół - {Predkość} km/h";
        }
    }
}
