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

namespace KolGrupaBsekcja4
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

        private void BtnDraw_Click(object sender, RoutedEventArgs e)
        {
            double srodekX = 100;
            double startY = 50;
            double srednica = 40;
            double odstepGuzikow = 10;
            double korektaGuzikow = 5; 

           
            for (int i = 0; i < 3; i++)
            {
                RysujKolo(srodekX, startY + (i * srednica), srednica, Brushes.White);
            }

            
            for (int i = 1; i < 3; i++) 
            {
                double srodekKuliY = startY + (i * srednica) + (srednica / 2) - korektaGuzikow;

                for (int j = 0; j < 3; j++) 
                {
                    double guzikY = srodekKuliY - (j * odstepGuzikow);
                    RysujKolo(srodekX, guzikY, 5, Brushes.Black);
                }
            }

            
            double srodekGlowyY = startY + (srednica / 2) - 15;
            RysujKolo(srodekX - 8, srodekGlowyY, 5, Brushes.Black); 
            RysujKolo(srodekX + 8, srodekGlowyY, 5, Brushes.Black); 
        }

        private void RysujKolo(double x, double y, double srednica, Brush kolor)
        {
            Ellipse kolo = new Ellipse
            {
                Width = srednica,
                Height = srednica,
                Fill = kolor,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            Canvas.SetLeft(kolo, x - srednica / 2);
            Canvas.SetTop(kolo, y - srednica / 2);
            CnvsDraw.Children.Add(kolo);
        }
    }
}