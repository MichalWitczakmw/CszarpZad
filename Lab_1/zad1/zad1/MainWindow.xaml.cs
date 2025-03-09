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

namespace zad1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    /*
     1. Stworzyć aplikację WPF obliczającą pierwiastki równania kwadratowego. 
    Zabezpieczyć przedniepoprawnymi danymi. Ukrywać niepotrzebne w danym kontekście kontrolki. 
    Do rozmieszczenia kontrolek na okne proszę użyć kontenerów StackPanel.
    */
    double LiczDelte(double a, double b, double c)
    {
        return b * b - 4 * a * c;
    }

    private void btnOblicz_Click(object sender, RoutedEventArgs e)
    {
        
        if (!double.TryParse(txtA.Text, out var a))
        {
            MessageBox.Show("Proszę wprowadzić poprawną liczbę dla a.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (!double.TryParse(txtB.Text, out var b))
        {
            MessageBox.Show("Proszę wprowadzić poprawną liczbę dla b.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (!double.TryParse(txtC.Text, out var c))
        {
            MessageBox.Show("Proszę wprowadzić poprawną liczbę dla c.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        double delta = LiczDelte(a, b, c);

        txtBlok.Visibility = Visibility.Visible;
        if (delta < 0)
        {
            txtBlok.Text = "Brak rozwiązań";
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            txtBlok.Text = $"Wynik:\nx = {x:F2}";
        }
        else
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            txtBlok.Text = $"Wynik:\nx1 = {x1:F2}\nx2 = {x2:F2}";
        }
    }
}