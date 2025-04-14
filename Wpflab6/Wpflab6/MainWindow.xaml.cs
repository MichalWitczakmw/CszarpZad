using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpflab6
{

    public partial class MainWindow : Window
    {
        private List<Towar> towary;

        public MainWindow()
        {
            InitializeComponent();
            InicjalizujTowary();
        }

        private void InicjalizujTowary()
        {
            towary = new List<Towar>
            {
                new Towar { Nazwa = "Laptop", Cena = 3000, Ilość = 10, Kategoria = Kategoria.Elektronika },
                new Towar { Nazwa = "Smartfon", Cena = 2000, Ilość = 8, Kategoria = Kategoria.Elektronika },
                new Towar { Nazwa = "Koszulka", Cena = 50, Ilość = 15, Kategoria = Kategoria.Odzież },
                new Towar { Nazwa = "Spodnie", Cena = 120, Ilość = 5, Kategoria = Kategoria.Odzież },
                new Towar { Nazwa = "Chleb", Cena = 4, Ilość = 50, Kategoria = Kategoria.Żywność },
                new Towar { Nazwa = "Mleko", Cena = 3, Ilość = 30, Kategoria = Kategoria.Żywność },
                new Towar { Nazwa = "Telewizor", Cena = 2500, Ilość = 2, Kategoria = Kategoria.Elektronika },
                new Towar { Nazwa = "Kurtka", Cena = 300, Ilość = 7, Kategoria = Kategoria.Odzież },
                new Towar { Nazwa = "Ser", Cena = 20, Ilość = 25, Kategoria = Kategoria.Żywność },
                new Towar { Nazwa = "Myszka", Cena = 100, Ilość = 20, Kategoria = Kategoria.Elektronika }
            };
        }

        static class Rozszerzenia
        {
            public static 
                (U min,U max) MinMax<T,U>(this IEnumerable<T> kolekcja, Func<T,U> ekstrakcja) 
                where U:IComparable<U>
            {
                U bestMin = ekstrakcja(kolekcja.First());
                U bestMax = ekstrakcja(kolekcja.First());

                foreach(T t in kolekcja)
                {
                    if (ekstrakcja(t).CompareTo(bestMin) < 0)
                        bestMin = ekstrakcja(t);
                    if(ekstrakcja(t).CompareTo(bestMax)> 0)
                        bestMax = ekstrakcja(t);
                }
                return (bestMin,bestMax);
            }
        }


        private (double bestX, double bestY, double bestMinimum) ZnajdźMinmumFunkcji2D(double minX, double maxX, double minY, double maxY, 
            long liczbaWywołań, Func<double,double,double> funkcja)
        {

            Random random = new Random();
            double? bestMinimum = null;
            double? bestX = null;
            double? bestY = null;

            for (long i =0; i <liczbaWywołań; i++)
            {
                double X = random.NextDouble() * (maxX - minX) + minX;
                double Y = random.NextDouble() * (maxY - minY) + minY;
                double wartość = funkcja(X, Y);
                if(bestMinimum == null || wartość < bestMinimum)
                {
                    bestMinimum = wartość;
                    bestX = X;
                    bestY = Y;
                }
            }

            return ((double)bestX, (double)bestY, (double)bestMinimum);
        }

        private void btnZajdźMinimumFunkcji_Click(object sender, RoutedEventArgs e)
        {
            var wynik = ZnajdźMinmumFunkcji2D(-10, 10, -10, 10, 100000, (x, y) => Math.Pow(x - 4, 2) + Math.Pow(y + 2, 2));

            MessageBox.Show($"Minimum znalezione w punkcie: X = {wynik.bestX:F2}, Y = {wynik.bestY:F2}, Minimum = {wynik.bestMinimum:F2}");
            

        }

        private void btnTowarOperacja1_Click(object sender, RoutedEventArgs e)
        {
            var wynik =towary.Where(t => t.Ilość>5).OrderByDescending(t => t.Ilość).ToList();
            libListaTowarów.ItemsSource = wynik;
        }

        private void btnTowarOperacja2_Click(object sender, RoutedEventArgs e)
        {
            Kategoria kategoria = Kategoria.Elektronika;

            var wynik = towary.Count( t => t.Kategoria == kategoria );
            libListaTowarów.ItemsSource = new List<string> { $"Liczba Towarów w kategori {kategoria}: {wynik}" };

        }

        private void btnTowarOperacja3_Click(object sender, RoutedEventArgs e)
        {
            var średniaCena = towary.Average(t => t.Cena);
            var wynik = towary.Where(t => t.Cena >średniaCena).Select(t => $"{t.Nazwa} - {t.Cena:C}").ToList();
            libListaTowarów.ItemsSource = wynik;
        }

        private void btnTowarOperacja4_Click(object sender, RoutedEventArgs e)
        {
            var wynik = towary.GroupBy(t => t.Kategoria)
                .Select(g => new
                {
                    Kategoria = g.Key,
                    ŚredniaCena = g.Average(t => t.Cena),
                    ŁącznaIlość = g.Sum(t => t.Ilość)
                })
                .Select(g => $"{g.Kategoria}: Średnia cena: {g.ŚredniaCena:C}, Łączna ilość: {g.ŁącznaIlość}")
                .ToList();
            libListaTowarów.ItemsSource = wynik;
        }

        private void btnTowarOperacja5_Click(object sender, RoutedEventArgs e)
        {
            var wynik = towary.OrderByDescending(t => t.Cena).FirstOrDefault();
            libListaTowarów.ItemsSource = new List<string> { $"Najdroższy towar: {wynik.Nazwa} - {wynik.Cena:C}" };
        }
    }
}