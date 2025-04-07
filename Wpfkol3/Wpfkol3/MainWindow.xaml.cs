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
using Faktury;

namespace Wpfkol3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFaktury_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Faktura faktura1 = new Faktura { Cena = 100m, Ilosc = 1 };
                Faktura faktura2 = new Faktura { Cena = 200m, Ilosc = 2 };
                Faktura faktura3 = new Faktura { Cena = 150m, Ilosc = 3 };

                Console.WriteLine("Faktura 1: Cena = " + faktura1.Cena + ", Ilosc = " + faktura1.Ilosc);
                Console.WriteLine("Faktura 2: Cena = " + faktura2.Cena + ", Ilosc = " + faktura2.Ilosc);
                Console.WriteLine("Faktura 3: Cena = " + faktura3.Cena + ", Ilosc = " + faktura3.Ilosc);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message); // wyświetli okienko dla wyglądu, żeby "było coś widać" takto powinno ten błąd wyrzucać do konsoli
            }
        }
    }
}