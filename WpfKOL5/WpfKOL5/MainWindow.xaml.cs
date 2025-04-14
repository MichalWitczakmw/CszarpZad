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

namespace WpfKOL5
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnWyświetl_Click(object sender, RoutedEventArgs e)
        {
            Stack<IWyświetlana> stos = new Stack<IWyświetlana>();

            stos.Push(new Towar("Jabłka", 3.5));
            stos.Push(new Towar("Mleko", 2.99));
            stos.Push(new Towar("Chleb", 4.2));


            stos.Push(new Mieszkanie("Warszawa, ul. Marszałkowska 10", 3));
            stos.Push(new Mieszkanie("Kraków, ul. Floriańska 5", 2));
            stos.Push(new Mieszkanie("Gdańsk, ul. Długa 1", 4));

            libWyświetl.Items.Clear();
            foreach (var element in stos)
            {
                element.WyświetlDane(libWyświetl);
            }
        }
    }
}