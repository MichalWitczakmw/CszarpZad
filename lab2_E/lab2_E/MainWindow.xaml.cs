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

namespace lab2_E
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

        private enum RodzajObliczen { Sum, Min, Max}

        private int Oblicz (RodzajObliczen rodzaj, params int[] liczby)
        {
            switch (rodzaj)
            {
                case RodzajObliczen.Sum: return liczby.Sum();
                case RodzajObliczen.Min: return liczby.Min();
                case RodzajObliczen.Max: return liczby.Max();
                default: throw new ArgumentException("!?");
            }
        }

        private void btnTest5_Click(object sender, RoutedEventArgs e)
        {
            int[] liczbyTestowe = { 12, 7, 20, 5, 15 };

            listListaLiczb.Items.Clear();
        }
    }
}