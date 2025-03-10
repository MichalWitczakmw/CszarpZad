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

namespace WpfAppkol1
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

        private void Window_Activated(object sender, EventArgs e)
        {
            double pionowaBelkaWysokość = 20;
            double poziomaBelkaSzerokość = 10;
            double poziomaBelkaWysokość = 200;
            double odstęp = 10;
            double SzerokośćSztachety = 20 * (poziomaBelkaSzerokość + odstęp) - odstęp;
            double górnaBelka = 50;
            double dolnaBelka = 50 + poziomaBelkaWysokość - pionowaBelkaWysokość;

           
            Rectangle górnaSztacheta= new Rectangle
            {
                
                Width = SzerokośćSztachety,
                Height = pionowaBelkaWysokość,
                Fill = Brushes.Brown
            };
            Canvas.SetLeft(górnaSztacheta, 0);
            Canvas.SetTop(górnaSztacheta, górnaBelka);
            cnvPłotek.Children.Add(górnaSztacheta);


            Rectangle dolnysztacheta = new Rectangle
            {
                
                Width = SzerokośćSztachety,
                Height = pionowaBelkaWysokość,
                Fill = Brushes.Brown
            };
            Canvas.SetLeft(dolnysztacheta, 0);
            Canvas.SetTop(dolnysztacheta, dolnaBelka);
            cnvPłotek.Children.Add(dolnysztacheta);

            
            for (int i = 0; i < 20; i++)
            {
                double x = i * (poziomaBelkaSzerokość + odstęp);
                Rectangle belka = new Rectangle
                {
                    Width = poziomaBelkaSzerokość,
                    Height = poziomaBelkaWysokość,
                    Fill = Brushes.Brown
                };
                Canvas.SetLeft(belka, x);
                Canvas.SetTop(belka, górnaBelka);
                cnvPłotek.Children.Add(belka);
            }
        }


    }
}