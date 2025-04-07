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
using Geometria;

namespace WpfLab4B
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

        private void btnKula_Click(object sender, RoutedEventArgs e)
        {
            Kula kula = new Kula(3, 2.7, 10);
            MessageBox.Show(kula.ToString());
        }

        private void btnStożek_Click(object sender, RoutedEventArgs e)
        {
            Stozek stozek= new Stozek(3,5, 2.7, 10);
            MessageBox.Show(stozek.ToString());
        }
    }
}