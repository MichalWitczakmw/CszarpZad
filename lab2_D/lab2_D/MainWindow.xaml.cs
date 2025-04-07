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

namespace lab2_D
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

        private void RysujLinie(double x1, double y1, double x2, double y2, Brush kolor, double grubosc)
        {
            Line linia = new Line
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = kolor,
                StrokeThickness = grubosc,
            };
            cvPlotno.Children.Add(linia);
        }

        private void btnTest4_Click(object sender, RoutedEventArgs e)
        {
            double[,] linieTrzepaka = { { 50, 50, 50, 250 }, { 250, 50, 250, 250 }, { 50, 100, 250, 100 }, { 50, 50, 250, 50 } };

            Brush[] kolory = {Brushes.Green, Brushes.Green, Brushes.Red, Brushes.Black };

            for (int i = 0; i < 4; i++) 
            {
                RysujLinie(linieTrzepaka[i, 0], linieTrzepaka[i, 1], linieTrzepaka[i, 2], linieTrzepaka[i, 3], kolory[i], 4);
            }
        }
    }
}