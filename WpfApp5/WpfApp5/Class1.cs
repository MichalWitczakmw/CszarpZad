using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    static class Class1
    {
        public static (double x, double y, double fxy) ZnajdźMinimumFunkcji2D(
            double minX, double maxX,
            double minY, double maxY,
            long liczbaIteracji,
            Func<double, double, double> funkcja)
        {
            var rand = new Random();
            double? minFx = null;
            double? najlepszeX = null;
            double? najlepszeY = null;
            for (long i = 0; i < liczbaIteracji; i++)
            {
                double x = rand.NextDouble() * (maxX - minX) + minX;
                double y = rand.NextDouble() * (maxY - minY) + minY;
                double fxy = funkcja(x, y);
                if (minFx == null || fxy < minFx)
                {
                    minFx = fxy;
                    najlepszeX = x;
                    najlepszeY = y;
                }
            }
            if (minFx == null || najlepszeX == null || najlepszeY == null)
            {
                throw new InvalidOperationException("Nie znaleziono minimum funkcji – brak danych.");
            }
            return ((double)najlepszeX, (double)najlepszeY, (double)minFx);
        }
    }
}
