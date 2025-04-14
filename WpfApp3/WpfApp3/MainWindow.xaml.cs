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

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IWyświetl[] tablicaObiektów = new IWyświetl[]
            {
                new Kula(5, 7.8, 10),
                new Kula(3, 8.0, 12),
                new Stożek(4, 10, 9.5, 14),
                new Student("Jan", "Kowalski"),
                new Student("Anna", "Nowak"),
                new Student("Marek", "Wiśniewski")
            };
            Array.Sort(tablicaObiektów);
            foreach (var obiekt in tablicaObiektów)
            {
                listBox1.Dodaj(obiekt);
            }
        }
    }
}