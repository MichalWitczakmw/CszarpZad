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
using System.Threading.Tasks;
using System.IO;

namespace Wpfkol9
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

        private async void btnButton_Click(object sender, RoutedEventArgs e)
        {
            
            Random random = new Random();
            StringBuilder numer = new StringBuilder();

            for (int i = 0; i < 10000; i++)
            {
                numer.Append(random.Next(1, 10001)); 
            }

            string numbersText = numer.ToString();

            string filePath = "wynik.txt";

            try
            {
                using (FileStream fileStream = File.Open(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    byte[] data = Encoding.UTF8.GetBytes(numbersText);
                    await fileStream.WriteAsync(data, 0, data.Length); // Asynchroniczny zapis
                }

                MessageBox.Show($"Liczby zostały zapisane do pliku: {filePath}", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas zapisu pliku: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}