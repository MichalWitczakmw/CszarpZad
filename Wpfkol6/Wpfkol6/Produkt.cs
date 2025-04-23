using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpfkol6
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }

        public Produkt(string nazwa, decimal cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }

        public void AktualizujCenę(Func<decimal, decimal> aktualizacjaCeny)
        {
            Cena = aktualizacjaCeny(Cena);
        }

        public override string ToString()
        {
            return $"{Nazwa}: {Cena:C}";
        }
    }
}
