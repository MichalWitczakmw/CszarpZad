using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public static class Filtruj
    {
        public static List<T> FiltrujWiększeNiż<T>(T prog, params T[] dane) where T : IComparable<T>
        {
            var wynik = new List<T>();
            foreach (var item in dane)
            {
                if (item.CompareTo(prog) > 0)
                {
                    wynik.Add(item);
                }
            }
            return wynik;
        }
    }
}