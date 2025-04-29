using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

static class Rozszerzenie
{
    public static (T min, T max) MinMax<T, U>(this IEnumerable<T> kolekcja, Func<T, U> filtr) where U : IComparable<U>
    {
        T minElement = kolekcja.First();
        T maxElement = kolekcja.First();

        U minValue = filtr(minElement);
        U maxValue = filtr(maxElement);

        foreach (var item in kolekcja.Skip(1))
        {
            U currentValue = filtr(item);
            if (currentValue.CompareTo(minValue) < 0)
            {
                minElement = item;
                minValue = currentValue;
            }
            if (currentValue.CompareTo(maxValue) > 0)
            {
                maxElement = item;
                maxValue = currentValue;
            }
        }
        return (minElement, maxElement);
    }
}