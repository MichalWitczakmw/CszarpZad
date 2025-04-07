using Mechaniczny;
namespace Auto
{
    public class Samochod : PojazdMechaniczny
    {
        public int LiczbaPasażerów
        {
            get { return liczbaPasażerów; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Liczba pasażerów musi być większa niż 0.");
                liczbaPasażerów = value;
            }
        }
        public string Marka { get; set; }

        private int liczbaPasażerów;
        public Samochod(string nazwa, int liczbaKół, int prędkość, int mocSilnika, int liczbaPasażerów, string marka)
            : base(nazwa, liczbaKół, prędkość, mocSilnika)
        {
            LiczbaPasażerów = liczbaPasażerów;
            Marka = marka;
        }

        public Samochod(string nazwa, int prędkość, int mocSilnika, int liczbaPasażerów, string marka)
            : base(nazwa, prędkość, mocSilnika)
        {
            LiczbaPasażerów = liczbaPasażerów;
            Marka = marka;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Liczba pasażerów: {LiczbaPasażerów} - Marka: {Marka}";
        }
    }
}
