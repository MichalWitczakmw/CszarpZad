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

namespace Wpfkol6
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

        private void btnInstancjęProduktów_Click(object sender, RoutedEventArgs e)
        {
            
            Produkt produkt1 = new Produkt("Produkt A", 100m);
            Produkt produkt2 = new Produkt("Produkt B", 200m);
            
            produkt1.AktualizujCenę(cena => cena * 1.1m); 
            produkt2.AktualizujCenę(cena => cena - 20m);  

            lbProdukty.Items.Clear();
            lbProdukty.Items.Add(produkt1.ToString());
            lbProdukty.Items.Add(produkt2.ToString());
        }
    }
}