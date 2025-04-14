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

namespace WPFKOLA
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var prostopadlosciany = new Prostopadloscian[]
            {
        new Prostopadloscian(2, 3, 5),
        new Prostopadloscian(5),
        new Prostopadloscian(1.5, 2.5, 3.5),
        new Prostopadloscian(8), 
            };

            listBoxProstopadlosciany.ItemsSource = prostopadlosciany;
        }

       
    }
}