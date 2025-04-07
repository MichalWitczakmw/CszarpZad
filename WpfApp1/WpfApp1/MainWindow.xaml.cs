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

namespace WpfApp1
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

        double Iloczyn(double a,double b)
        {
            return a * b;
        }

        double Kwadrat(double a)
        {
            return Iloczyn(a, a);
        }

        double PoleKoła(double r)
        {
            return Math.PI * Kwadrat(r);
        }

        double ObjętośćWalca(double r, double h)
        {
            return Iloczyn(h, PoleKoła(r));
        }

        double ObjętośćWalca(double h)
        {
            return ObjętośćWalca(h/2, h);
        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            lsbWyniki.Items.Clear();

            
            lsbWyniki.Items.Add(Iloczyn(2,2));
            lsbWyniki.Items.Add(Kwadrat(2));
            lsbWyniki.Items.Add(PoleKoła(2));
            lsbWyniki.Items.Add(ObjętośćWalca(2,6));
            lsbWyniki.Items.Add(ObjętośćWalca(2));


        }
    }
}