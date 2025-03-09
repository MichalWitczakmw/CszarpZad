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

namespace zad2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void RysujPiramideschodkowa(object sender, EventArgs e)
    {
        /* WYJEZDZA ZA CANVAS 
        double baseWidth = 50; // Szerokość prostokąta
        double baseHeight = 20; // Wysokość prostokąta
        double offsetX = cnvPiramida.ActualWidth / 2; // Środek płótna w poziomie
        double offsetY = 10; // Początkowe przesunięcie w pionie

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Width = baseWidth;
                rectangle.Height = baseHeight;
                rectangle.Fill = Brushes.Black;
                Canvas.SetTop(rectangle, offsetY + i * baseHeight);
                Canvas.SetLeft(rectangle, offsetX + j * baseWidth - (i * baseWidth / 2));
                cnvPiramida.Children.Add(rectangle);
            }
        }
        */
        // SKALUJE SIE DO CANVAS
        double canvasWidth = cnvPiramida.ActualWidth;
        double canvasHeight = cnvPiramida.ActualHeight;
        int levels = 10; // Liczba poziomów piramidy
        double baseHeight = canvasHeight / levels; // Wysokość każdego poziomu
        double offsetY = canvasHeight - baseHeight; // Początkowe przesunięcie w pionie

        for (int i = 0; i < levels; i++)
        {
            double levelWidth = canvasWidth * (levels - i) / levels; // Szerokość poziomu
            double offsetX = (canvasWidth - levelWidth) / 2; // Środek poziomu w poziomie

            Rectangle rectangle = new Rectangle();
            rectangle.Width = levelWidth;
            rectangle.Height = baseHeight;
            rectangle.Fill = Brushes.Black;
            Canvas.SetTop(rectangle, offsetY - i * baseHeight);
            Canvas.SetLeft(rectangle, offsetX);
            cnvPiramida.Children.Add(rectangle);
        }
    }
}