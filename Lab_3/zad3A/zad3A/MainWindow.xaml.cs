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
using Motoryzacja;

namespace zad3A
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

        public void WyświetlPojazd(IEnumerable<Pojazd> pojazdy)
        {
            lsbPojazdy.Items.Clear();

            foreach (var p in pojazdy)
            {
                lsbPojazdy.Items.Add(p);
            }
        }

        private void btnZadanieA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pojazd[] pojazdy = new Pojazd[]
                {
                    new Pojazd("Maluch",100),
                    new Pojazd("Mustang",4,350),
                    new Pojazd("Pagani",8,800),
                    new PojazdMechaniczny("Czołg", 4, 120, 9000),
                    new Samochód("Sedan", 4, 180, 120, 5, "Toyota")
                };

                WyświetlPojazd(pojazdy);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,"Błąd");
            }
        }

        
    }
}