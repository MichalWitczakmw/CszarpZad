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
using System.Collections.Generic;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void FiltrujInt_Click(object sender, RoutedEventArgs e)
        {
            var wynik = Filtruj.FiltrujWiększeNiż(5, 1, 3, 5, 6, 9, 2, 7);
            WynikListBox.ItemsSource = wynik;
        }
        private void FiltrujString_Click(object sender, RoutedEventArgs e)
        {
            var wynik = Filtruj.FiltrujWiększeNiż("k", "a", "b", "l", "z", "k", "m", "c");
            WynikListBox.ItemsSource = wynik;
        }
    }
}
