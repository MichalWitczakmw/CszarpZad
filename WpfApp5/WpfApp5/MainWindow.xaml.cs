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
using System;
using System.Reflection.Emit;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        private List<Towar> towary;
        public MainWindow()
        {
            InitializeComponent();
            towary = new List<Towar>
            {
                new Towar { Nazwa = "Laptop", Cena = 3500, Ilość = 8, Kategoria = KategoriaTowaru.Elektronika },
                new Towar { Nazwa = "Smartfon", Cena = 2200, Ilość = 12, Kategoria = KategoriaTowaru.Elektronika },
                new Towar { Nazwa = "Słuchawki", Cena = 150, Ilość = 20, Kategoria = KategoriaTowaru.Elektronika },

                new Towar { Nazwa = "Chleb", Cena = 4, Ilość = 30, Kategoria = KategoriaTowaru.Żywność },
                new Towar { Nazwa = "Mleko", Cena = 5, Ilość = 25, Kategoria = KategoriaTowaru.Żywność },
                new Towar { Nazwa = "Czekolada", Cena = 6, Ilość = 5, Kategoria = KategoriaTowaru.Żywność },

                new Towar { Nazwa = "Koszulka", Cena = 60, Ilość = 15, Kategoria = KategoriaTowaru.Odzież },
                new Towar { Nazwa = "Spodnie", Cena = 120, Ilość = 10, Kategoria = KategoriaTowaru.Odzież },
                new Towar { Nazwa = "Buty", Cena = 250, Ilość = 6, Kategoria = KategoriaTowaru.Odzież },
                new Towar { Nazwa = "Kurtka", Cena = 400, Ilość = 3, Kategoria = KategoriaTowaru.Odzież },
            };
            KategoriaComboBox.ItemsSource = Enum.GetValues(typeof(KategoriaTowaru)).Cast<KategoriaTowaru>().ToList();
            KategoriaComboBox.SelectedIndex = 0;

        }

        private void Funkcja1_Click(object sender, RoutedEventArgs e)
        {
            double rosenbrock(double x, double y)
            {
                return 100 * Math.Pow(y - x * x, 2) + Math.Pow(1 - x, 2);
            };
            var wynik = Class1.ZnajdźMinimumFunkcji2D(-10, 10, -10, 10, 100000000, rosenbrock);
            LabelX.Content = $"x = {wynik.x:F10}";
            LabelY.Content = $"y = {wynik.y:F10}";
            LabelF.Content = $"f(x,y) = {wynik.fxy:F10}";
            var (minTowar, maxTowar) = towary.MinMax(t => t.Cena);
            Console.WriteLine($"Najtańszy towar: {minTowar.Nazwa} - Cena: {minTowar.Cena}");
            Console.WriteLine($"Najdroższy towar: {maxTowar.Nazwa} - Cena: {maxTowar.Cena}");
        }

        private void Funkcja2_Click(object sender, RoutedEventArgs e)
        {
            var wynik = Class1.ZnajdźMinimumFunkcji2D(-10,10,-10,10,1000000,
                (x, y) => (x - 4) * (x - 4) + (y + 2) * (y + 2)
            );
            LabelX.Content = $"x = {wynik.x:F10}";
            LabelY.Content = $"y = {wynik.y:F10}";
            LabelF.Content = $"f(x,y) = {wynik.fxy:F10}";
        }

        private void Funkcja3_Click(object sender, RoutedEventArgs e)
        {
            var wynik = Class1.ZnajdźMinimumFunkcji2D(-5, 5,-5, 5,1000000,
                (x, y) =>
                {
                    if (x > -1 && x < 1 && y > -2 && y < 2)
                        return 2 + y * y;
                    else
                        return 30;
                }
            );
            LabelX.Content = $"x = {wynik.x:F10}";
            LabelY.Content = $"y = {wynik.y:F10}";
            LabelF.Content = $"f(x,y) = {wynik.fxy:F10}";
        }
        private void Filtr1_Click(object sender, RoutedEventArgs e)
        {
            var wynik = towary
                .Where(t => t.Ilość > 5)
                .OrderByDescending(t => t.Ilość)
                .ToList();
            ListaWyników.ItemsSource = wynik;
        }
        private void Filtr2_Click(object sender, RoutedEventArgs e)
        {
            {
                if (KategoriaComboBox.SelectedItem is KategoriaTowaru wybranaKategoria)
                {
                    int liczba = towary.Count(t => t.Kategoria == wybranaKategoria);
                    ListaWyników.ItemsSource = new List<string> { $"Liczba towarów w kategorii {wybranaKategoria}: {liczba}" };
                }
            }
        }
        private void Filtr3_Click(object sender, RoutedEventArgs e)
        {
            decimal średnia = towary.Average(t => t.Cena);
            var wynik = towary
                .Where(t => t.Cena > średnia)
                .Select(t => $"{t.Nazwa} – {t.Cena:F2} zł (>{średnia:F2})")
                .ToList();
            ListaWyników.ItemsSource = wynik;
        }
        private void Filtr4_Click(object sender, RoutedEventArgs e)
        {
            var wynik = towary
                .GroupBy(t => t.Kategoria)
                .Select(g => $"{g.Key}: Ilość = {g.Sum(t => t.Ilość)}, Śr. cena = {g.Average(t => t.Cena):F2} zł")
                .ToList();
            ListaWyników.ItemsSource = wynik;
        }
        private void Filtr5_Click(object sender, RoutedEventArgs e)
        {
            var najdroższy = towary
                .OrderByDescending(t => t.Cena)
                .FirstOrDefault();
            if (najdroższy != null)
            {
                ListaWyników.ItemsSource = new List<string> {
                    $"Najdroższy towar: {najdroższy.Nazwa} – {najdroższy.Cena:F2} zł"
                };
            }
        }
        private void KategoriaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (KategoriaComboBox.SelectedItem != null)
            {
                var wybranaKategoria = (KategoriaTowaru)KategoriaComboBox.SelectedItem;
            }
        }

        private void TestMinMax_Click(object sender, RoutedEventArgs e)
        {
            var (minTowar, maxTowar) = towary.MinMax(t => t.Cena);
            ListaWyników.Items.Clear();
            ListaWyników.Items.Add($"Najtańszy towar: {minTowar.Nazwa} - Cena: {minTowar.Cena}");
            ListaWyników.Items.Add($"Najdroższy towar: {maxTowar.Nazwa} - Cena: {maxTowar.Cena}");
        }
    }
}