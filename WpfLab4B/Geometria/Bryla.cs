using Wyświetlanie;

namespace Geometria
{
    public abstract class Bryla :IWyświetl
    {
        public abstract string Nazwa { get; }
        public double Gestosc { get; set; }
        public double CenaZaKg { get; set; }

        protected Bryla( double gestosc, double cenaZaKg)
        {
            Gestosc = gestosc;
            CenaZaKg = cenaZaKg;
        }

        public abstract double ObliczObjetosc();
        public double ObliczMase()
        {
            return Gestosc * ObliczObjetosc();
        }

        public double ObliczCene()
        {
            return ObliczMase() * CenaZaKg;
        }

        public override string ToString()
        {
            return $"{Nazwa}: Objętość = {ObliczObjetosc():F2}, Masa = {ObliczMase():F2}, Cena = {ObliczCene():F2}";
        }

        public string PobierzIdentyfikator()
        {
            return this.ToString();
        }

    }
}
