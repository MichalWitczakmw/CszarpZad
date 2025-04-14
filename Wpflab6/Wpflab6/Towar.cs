using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpflab6
{
    public enum Kategoria
    {
        Elektronika,
        Odzież,
        Żywność
    }

    public class Towar
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public int Ilość { get; set; }
        public Kategoria Kategoria { get; set; }

        public override string ToString()
        {
            return $"{Nazwa} - Cena: {Cena:C}, Ilość: {Ilość}, Kategoria: {Kategoria}";
        }
    }
}
