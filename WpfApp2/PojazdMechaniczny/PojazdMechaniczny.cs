using Motoryzacja;
namespace Mechaniczny
{
    public class PojazdMechaniczny : Pojazd
    {
        private int _mocSilnika;
        public int MocSilnika
        {
            get { return _mocSilnika; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Moc silnika musi być większa niż 0.");
                _mocSilnika = value;
            }
        }
        public PojazdMechaniczny(string nazwa, int liczbaKol, int predkosc, int mocSilnika)
            : base(nazwa, liczbaKol, predkosc)
        {
            MocSilnika = mocSilnika;
        }
        public PojazdMechaniczny(string nazwa, int predkosc, int mocSilnika)
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