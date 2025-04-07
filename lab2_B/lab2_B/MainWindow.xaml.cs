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

namespace lab2_B
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

        private double Potega(double podstawa, int wykladnik)
        {
            if (wykladnik < 0)
            {
                throw new ArgumentException("Wykladnik mu si byc naturalny!");
            }

            if (wykladnik == 0)
            {
                return 1;
            }

            return Potega(podstawa, wykladnik - 1) * podstawa;
        }

        private void btPotega_Click(object sender, RoutedEventArgs e)
        {
                double podstawa = double.Parse(tbxPodstawa.Text);
                int wykladnik = int.Parse(tbxWykladnik.Text);

                double wynik = Potega(podstawa, wykladnik);
                lblWynik.Content = $"Wynik: {wynik}";
        }
    }
}