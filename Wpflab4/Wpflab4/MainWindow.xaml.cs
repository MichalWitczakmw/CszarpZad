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


namespace Wpflab4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DaneWejścioweOkno okno1 = new DaneWejścioweOkno();
            okno1.ShowDialog();

            double w, h, P, O;

            h = Convert.ToDouble(okno1.Szerokość);
            w = Convert.ToDouble(okno1.Wysokość);
            P = w * h;
            O = 2 * h + 2 * w;

            DaneWyjścioweOkno okno2 =new DaneWyjścioweOkno(P,O);
            //okno2.tbkPole.Text = $"Pole={P:F2}";
            //okno2.tbkObwód.Text = $"Pole={O:F2}";
            okno2.ShowDialog();
        }
    }
}