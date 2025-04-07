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

namespace WpfApp2
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

        double Potęga(double z, int p)
        {
            if (p < 0) throw new ArgumentException("ujemna");
            if (p == 0)
                return 1;
            else
            {
                for (int i = 0; i < p; i++) 
                {
                    z *= Potęga(z, i);
                }
            }
            return z;
        }

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (!int.TryParse(txtPotęga.Text, out var potęga))
                    MessageBox.Show("zła potęga", "Błąd");
                if (!double.TryParse(txtZmienna.Text, out var zmienna))
                    MessageBox.Show("zła zmienna", "Błąd");

                double w = Potęga(zmienna, potęga);
                txtWynik.Text = w.ToString();
            }
            catch { };
            
        }
        double Prostokąt(double s, double w, ref double obwód, ref double przekątną)
        {
            obwód = 2 * s + 2 * w;
            przekątną = Math.Sqrt((s*s)+(w*w));
            return s * w;
        }
        private void btnTest3_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtSzerokość.Text, out var szerokość))
                MessageBox.Show("zła szerokość", "Błąd");
            if (!double.TryParse(txtWysokość.Text, out var wysokość))
                MessageBox.Show("zła wysokość", "Błąd");
            else
            {
                double obw = 0, pole = 0, przekatna = 0;
                pole = Prostokąt(szerokość, wysokość, ref obw, ref przekatna);

                MessageBox.Show($"Pole:\t{pole:F2}\nObwód:\t{obw:F2}\nPrzekątna:\t{przekatna:F2}\n", "Wynik");
            }
            
        }

        void RysujLinie(string kolor, params int[] dane)
        {
            Line linia = new Line()
            { 
                X1 = dane[0],
                X2 = dane[1],
                Y1 = dane[2],
                Y2 = dane[3],
               // Stroke = SolidColorBrush()
            
            };

        }

        private void btnTrzepak_Click(object sender, RoutedEventArgs e)
        {
            cnvTrzepak.Children.Clear();

            int[,] wymiary = new int[,] { { 20, 40, 40, 40 }, { 25, 25, 40, 100 }, { 35, 35, 40, 100 }, { 25, 35, 55, 55 } };
            Color kolory = new Color()
            { 
                
            };

        }
    }
}