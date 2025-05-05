using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
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

namespace Wpflab9
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

        public async Task<(double, double, double)> ZnajdźMinimumFunkcji2D(double minX, double maxX, double minY, double maxY, Func<double, double, double> funkcja, long dokładność = 100)
        {
            double? minimum = null;
            double? minimumX = null;
            double? minimumY = null;
            object semafor = new object();
            Random random = new Random();

            if (dokładność <= 0) throw new ArgumentException("Nie wolno.");
            //for (long i = 0; i < dokładność; i++)
            ParallelOptions po = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 5
            };

            await Task.Factory.StartNew(() =>
            {



                Parallel.For(0, dokładność, po, i =>
                {
                    double tempX, tempY;
                    lock (random)
                    {
                        tempX = (random.NextDouble() * (maxX - minX)) + minX;
                        tempY = (random.NextDouble() * (maxY - minY)) + minY;
                    }


                    double wynik = funkcja(
                    tempX,
                    tempY
                    );
                    lock (semafor)
                    {
                        if (minimum == null || minimum > wynik)
                        {
                            minimum = wynik;
                            minimumX = tempX;
                            minimumY = tempY;
                        }
                    }

                });
            });
            return ((double)minimum!, (double)minimumX!, (double)minimumY!);

        }

        private async void btnWczytaj_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection połączenie = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Uczelnia;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                połączenie.Open();
                SqlCommand polecenie = new SqlCommand("EXEC [dbo].[sp_GetStudents]",połączenie);
                //var dr = await polecenie.ExecuteReader();
                lsttab.Items.Clear();
                //while (dr.Read()) {
                //    lsttab.Items.Add($"{dr["nazwisko"]}");
                //}
            }
        }

        private async void btnMinimalizuj_Click(object sender, RoutedEventArgs e)
        {
            var wynik = await ZnajdźMinimumFunkcji2D(-5,5,-5,5,(x,y)=>x*x+y*y,1000000000);
            MessageBox.Show(wynik.ToString());
        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            using(var s = new Student { Nazwisko = "Kowalski" })
            {

                MessageBox.Show(s.Nazwisko);
            }

        }
    }
}