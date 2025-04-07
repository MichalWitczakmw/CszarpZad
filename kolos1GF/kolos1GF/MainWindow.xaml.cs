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

namespace kolos1GF
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

        private void btRysuj_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++) 
            {
                double x = 10 + i * 15;
                RysujLinie(x, 50 ,x, 250, Brushes.Black, 3);
            }
        }

        private void RysujLinie(double x1, double y1, double x2, double y2, Brush kolor, double grubosc)
        {
            Line linia = new Line
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = kolor,
                StrokeThickness = grubosc
            };
            cvPlotno.Children.Add(linia);
        }
    }   
}