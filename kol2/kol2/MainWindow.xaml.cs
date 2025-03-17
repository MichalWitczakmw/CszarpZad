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

namespace kol2
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

        private void btnTablica_Click(object sender, RoutedEventArgs e)
        {
            int[,] tablicaDoListy = new int[4, 5];
            int wypełnienieTablicy = 1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablicaDoListy[i, j] = wypełnienieTablicy++;
                }
            }

            lbxLista.Items.Clear();

            for (int i = 0; i < 4; i++)
            {
                lbxLista.Items.Add(tablicaDoListy[i, 1]);
            }
        }
    }
}