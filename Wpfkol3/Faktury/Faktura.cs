namespace Faktury
{
    public class Faktura
    {
        private decimal cena;
        private int ilosc;
        public static decimal? NajwyższaWartość { get; private set; }

        public decimal Cena
        {
            get { return cena; }
            set
            {
                if (NajwyższaWartość.HasValue && value < NajwyższaWartość.Value)
                {
                    throw new ArgumentException("Cena nie może być niższa niż najwyższa dotychczasowa wartość.");
                }
                cena = value;
                if (!NajwyższaWartość.HasValue || value > NajwyższaWartość.Value)
                {
                    NajwyższaWartość = value;
                }
            }
        }

        public int Ilosc
        {
            get { return ilosc; }
            set { ilosc = value; }
        }
    }
}
