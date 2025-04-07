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

namespace Lab2c_
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
        public double Iloczyn(double a, double b)
        {
            return a * b;
        }
        public double Kwadrat(double x)
        {
            return Iloczyn(x, x);
        }
        public double PoleKola(double r)
        {
            return Iloczyn(Math.PI, Kwadrat(r));
        }
        public double ObjWalca(double r,double h)
        {
            return Iloczyn(PoleKola(r), h);
        }

        private void BtnOblicz_Click(object sender, RoutedEventArgs e)
        {
            double r = 5;
            double h = 10;
            LBoblicz.Items.Add($"Iloczyn(4,5)={ Iloczyn(4, 5)}");
            LBoblicz.Items.Add($"Kwadrat(2)={Kwadrat(2)}");
            LBoblicz.Items.Add($"PoleKola(5)={PoleKola(r)}");
            LBoblicz.Items.Add($"ObjWalca(5,10)={ObjWalca(r,h)}");
        }
    }
}
