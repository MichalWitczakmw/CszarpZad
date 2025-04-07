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

namespace lab2_1
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

        private double Iloczyn(double liczba1, double liczba2)
        {
            return liczba1 * liczba2;
        }

        private double Kwadrat(double liczba)
        {
            return Iloczyn(liczba, liczba);
        }

        private double PoleKola(double promien)
        {
            return Iloczyn(Math.PI, Kwadrat(promien));
        }

        private double ObjetoscWalca(double wysokosc, double promien)
        {
            return Iloczyn(wysokosc, PoleKola(promien));
        }

        private double ObjetoscWalca(double wysokosc)
        {
            return ObjetoscWalca(wysokosc, wysokosc);
        }

        private void btTest1_Click(object sender, RoutedEventArgs e)
        {
            lbxListaWynikow.Items.Clear();

            double liczbaA = 3;
            double liczbaB = 4;
            double promien = 5;
            double wysokosc = 10;

            lbxListaWynikow.Items.Add($"Iloczyn({liczbaA}, {liczbaB}) = {Iloczyn(liczbaA, liczbaB)}");
            lbxListaWynikow.Items.Add($"Kwadrat({liczbaA}) = {Kwadrat(liczbaA)}");
            lbxListaWynikow.Items.Add($"PoleKola({promien}) = {PoleKola(promien)}");
            lbxListaWynikow.Items.Add($"ObjetoscWalca({wysokosc}, {promien}) = {ObjetoscWalca(wysokosc, promien)}");
            lbxListaWynikow.Items.Add($"ObjetoscWalca({wysokosc}) = {ObjetoscWalca(wysokosc)}");
        }
    }


}