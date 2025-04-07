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
using Generyki;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, Student> studenci;
        public MainWindow()
        {
            InitializeComponent();

            studenci = new Dictionary<string, Student>
            {
                {"1111", new Student("Kowalski",4.5) },
                {"2222", new Student("Chunctwot",4.0) },
                {"3333", new Student("Nowak",3.0) },
                {"4444", new Student("Kołodziejscki",2.5) }
            };
        }

        private void btnStożek_Click(object sender, RoutedEventArgs e)
        {
            Stożek stożek = new Stożek();
            stożek.Błąd += Stożek_Błąd_MessageBox;
            stożek.Błąd += Stożek_Błąd_Label;

            try
            {
                stożek.Wysokość = Convert.ToDouble(txtWyskość.Text);
                stożek.Promień = Convert.ToDouble(txtPromień.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Proszę wprowadzić prawidłowe liczby.");
            }


        }
        private void Stożek_Błąd_MessageBox(string opisBłędu)
        {
            MessageBox.Show(opisBłędu, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Stożek_Błąd_Label(string opisBłędu)
        {
            lblBłędy.Content = opisBłędu;
        }

        private void btnZnajdżStudenta_Click(object sender, RoutedEventArgs e)
        {
            string nrAlbumu = txtWpiszNrAlbumu.Text;

            if(studenci.TryGetValue(nrAlbumu, out Student student))
            {
                MessageBox.Show($"Nazwisko: {student.Nazwisko}, Ocena: {student.Ocena}","Znaleziono Studenta", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else
            {
                MessageBox.Show("Nie znaleziono", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnSprawdź_Click(object sender, RoutedEventArgs e)
        {
            string testStringu = Generyczną.ZnajdźWiększy("Koń", "Woda");
            MessageBox.Show($"Większy string: {testStringu}", "TestStringu");

            double testDoubla = Generyczną.ZnajdźWiększy(2.51, 3.12);
            MessageBox.Show($"Większy double: {testDoubla}", "TestDoubla");

            Student testStudenta = Generyczną.ZnajdźWiększy(studenci["1111"], studenci["3333"]);
            MessageBox.Show($"Większy student: \nNazwisko: {testStudenta.Nazwisko}\nOcena: {testStudenta.Ocena}", "TestStudenta");
        }

        private void btnSprawdźRegał_Click(object sender, RoutedEventArgs e)
        {
            Regał<double> regałDouble = new Regał<double>();
            regałDouble.Półka1 = 5.21;
            regałDouble.WolnaPółka = 2.513;
            regałDouble.WstawNaWolnąPółkę(10.2);
            MessageBox.Show(regałDouble.ToString(), "Regał Double");

            Regał<Student> regałStudent = new Regał<Student>();
            regałStudent.Półka1 = studenci["1111"];
            regałStudent.WolnaPółka = studenci["2222"];
            regałStudent.WstawNaWolnąPółkę(studenci["3333"]);
            MessageBox.Show(regałStudent.ToString(), "Regał Student");
        }
    }
}