using System.IO;
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
using System.Xml.Serialization;

namespace Wpfkol7
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

        private void btnUtwórzFakturę_Click(object sender, RoutedEventArgs e)
        {
            Faktura faktura = new Faktura
            {
                NumerFaktury = "FV/2025/04/001",
                DataWystawienia = DateTime.Now,
                NazwaKlienta = "Jan Kowalski",
                Pozycje = new List<PozycjaFaktury>
                {
                    new PozycjaFaktury { NazwaProduktu = "Monitor", Ilosc = 2, CenaJednostkowa = 899.99m },
                    new PozycjaFaktury { NazwaProduktu = "Klawiatura", Ilosc = 1, CenaJednostkowa = 199.99m },
                    new PozycjaFaktury { NazwaProduktu = "Myszka", Ilosc = 1, CenaJednostkowa = 99.99m }
                }
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Faktura));
            string filePath = "Faktura.xml";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, faktura);
            }

            MessageBox.Show($"Faktura została zapisana do pliku: {filePath}", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
        
        }
    }
}