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

namespace Wpflab7B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DbUczelnia db;

        public MainWindow()
        {
            InitializeComponent();
            db = new DbUczelnia();
            OdswiezListeStudentow();
        }

        private void OdswiezListeStudentow()
        {
            
            lstStudenci.ItemsSource = db.Studenci.OrderBy(s => s.Nazwisko).ThenBy(s => s.Imię).ToList();

           
            if (db.Studenci.Any())
            {
                var srednia = db.Studenci.Average(s => s.Ocena);
                lblŚrednia.Content = $"Średnia ocen: {srednia:F2}";
            }
            else
            {
                lblŚrednia.Content = "Średnia ocen: brak danych";
            }
        }
        

        private void btnDodajStudenta_Click(object sender, RoutedEventArgs e)
        {
            var imie = txtImię.Text;
            var nazwisko = txtNazwisko.Text;
            var wiek = byte.Parse(txtWiek.Text);
            var ocena = double.Parse(txtOcena.Text);

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) || wiek <= 0 || ocena < 0 || ocena > 5)
            {
                MessageBox.Show("Proszę uzupełnić poprawnie wszystkie pola.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var student = new Student
            {
                Imię = imie,
                Nazwisko = nazwisko,
                Wiek = wiek,
                Ocena = ocena
            };

            db.Studenci.Add(student);
            db.SaveChanges();

            txtImię.Clear();
            txtNazwisko.Clear();
            txtWiek.Clear();
            txtOcena.Clear();


            OdswiezListeStudentow();
        }
    }
}