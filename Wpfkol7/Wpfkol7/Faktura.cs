using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace Wpfkol7
{


    public class Faktura
    {
        public string NumerFaktury { get; set; }
        public DateTime DataWystawienia { get; set; }
        public string NazwaKlienta { get; set; }
        public List<PozycjaFaktury> Pozycje { get; set; }

        public Faktura()
        {
            Pozycje = new List<PozycjaFaktury>();
        }
    }

    public class PozycjaFaktury
    {
        public string NazwaProduktu { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaJednostkowa { get; set; }
    }
}
