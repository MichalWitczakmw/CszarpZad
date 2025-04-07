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

namespace lab2_C
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

        private void Prostokat(double szerkosc, double wysokosc, out double pole, out double obwod, out double przekatna)
        {
            pole = szerkosc * wysokosc;
            obwod = 2 * (szerkosc + wysokosc);
            przekatna = Math.Sqrt(szerkosc * szerkosc + wysokosc * wysokosc);
        }

        private void btnTest3_Click(object sender, RoutedEventArgs e)
        {
           double szerkosc = double.Parse(txtSzerokosc.Text);
           double wysokosc = double.Parse(txtWysokosc.Text);

            if (szerkosc <= 0 || wysokosc <= 0) 
            {
                throw new ArgumentException("Szerokosc i wysokosc musza byc dodatnie");
            }

            Prostokat(szerkosc, wysokosc, out double pole, out double obowd, out double przekatna);

            string 
        }
    }
}