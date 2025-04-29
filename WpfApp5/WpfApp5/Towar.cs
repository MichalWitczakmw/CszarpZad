using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public enum KategoriaTowaru
    {
        Elektronika,
        Żywność,
        Odzież
    }
    public class Towar
    {
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public int Ilość { get; set; }
        public KategoriaTowaru Kategoria { get; set; }
        public override string ToString()
        {
            return $"{Nazwa} – {Cena} zł";
        }
    }
}