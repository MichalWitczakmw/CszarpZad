namespace Motoryzacja
{
    public class Pojazd
    {
        private static int liczbaPojazdow;
        public string Nazwa { get; set; }
        public int Lp { get; set; }

        private int pLiczbaKol;

        private int pPredkosc;
        public int LiczbaKol
        {
            get { return pLiczbaKol; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Liczba kół musi być większa niż 0!");
                pLiczbaKol = value;
            }
        }
        public int Predkosc
        {
            get { return pPredkosc; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Prędkość nie może być mniejsza niż 0!");
            }
        }
        static Pojazd()
        {
            liczbaPojazdow = 0;
        }
        public Pojazd()
        {
            Lp = ++liczbaPojazdow;
        }
        public Pojazd(string nazwa, int kola, int predkosc) : this()
        {
            Nazwa = nazwa;
            LiczbaKol = kola;
            Predkosc = predkosc;
        }
        public Pojazd(string nazwa, int predkosc) : this(nazwa, 4, predkosc) { }
        public override string ToString()
        {
            return $"{Nazwa} ({Lp}/{liczbaPojazdow}) - {LiczbaKol} koła - {Predkosc} km/h";
        }
    }
}
