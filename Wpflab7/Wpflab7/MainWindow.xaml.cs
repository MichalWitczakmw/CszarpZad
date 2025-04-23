using System.IO;
using System.Windows;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Wpflab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ścieżkaRejest = "rejestr.txt";
        private const string ścieżkaDane = @"C:\Users\Student\Documents\GitHub\CszarpZad\Wpflab7\Wpflab7\bin\Debug\net8.0-windows\dane.txt";

        private Grupa grupa;
        public MainWindow()
        {
            InitializeComponent();
            grupa = new Grupa
            {
                Nazwa = "I16",
                Studenci = new List<Student>
                {
                    new Student { Nazwisko = "Kowalski", Ocena = 4.5, Przedmioty = new List<string> { "Matma", "JP" } },
                    new Student { Nazwisko = "Wiśniewski", Ocena = 5.0, Przedmioty = new List<string> { "Angielski", "Fizyka" } },
                    new Student { Nazwisko = "Nowak", Ocena = 4.0, Przedmioty = new List<string> { "Historia", "Biologia" } }
                }
            };
        }

        private void btnMelduj_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream(ścieżkaRejest, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                sw.WriteLine($"{DateTime.Now}: Naciśnięto: Melduj");
            }
            catch
            {

                MessageBox.Show("Nie udało się zapisać do pliu", "Błąd");
            }
            finally
            {
                if (sw != null)
                    sw.Close();
                if (fs != null)
                    fs.Close();
            }
        }

        private void btnCzytaj_Click(object sender, RoutedEventArgs e)
        {
            List<double> liczby = new List<double>();

            using (StreamReader czytaj = new StreamReader(ścieżkaDane))
            {
                string linia;
                while ((linia = czytaj.ReadLine()) != null)
                {
                    if (double.TryParse(linia, out double liczba))
                        liczby.Add(liczba);
                    else
                        liczby.Add(0);
                }
            }

            lbPokażLiczby.Items.Clear();
            lbPokażLiczby.ItemsSource = liczby.Select(x => x.ToString("F3"));

            double największa = liczby.Max();
            double średnia = liczby.Average();
            double najmniejsza = liczby.Min();

            lblNajwiększa.Content = $"Największa: {największa:F3}";
            lblśrednia.Content = $"Średnia: {średnia:F3}";
            lblNajmniejsza.Content = $"Najmniejsza: {najmniejsza:F3}";

        }

        private void btnZapiszXML_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml"
            };

            if (dialog.ShowDialog() == true)
            {
                using (var writer = new StreamWriter(dialog.FileName))
                {
                    var serializer = new XmlSerializer(typeof(Grupa));
                    serializer.Serialize(writer, grupa);
                }
                MessageBox.Show("Grupa została zapisana w formacie XML.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnWyświetlXML_Click(object sender, RoutedEventArgs e)
        {
            lbLista.Items.Clear();
            lbLista.Items.Add($"Grupa: {grupa.Nazwa}");
            foreach (var student in grupa.Studenci)
            {
                lbLista.Items.Add($"{student.Nazwisko} {student.Ocena:F1}");
                lbLista.Items.Add("Przedmioty:");
                foreach (var przedmiot in student.Przedmioty)
                {
                    lbLista.Items.Add($"- {przedmiot}");
                }
            }
        }

        private void btnWczytajMXL_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml"
            };

            if (dialog.ShowDialog() == true)
            {
                using (var reader = new StreamReader(dialog.FileName))
                {
                    var serializer = new XmlSerializer(typeof(Grupa));
                    grupa = (Grupa)serializer.Deserialize(reader);
                }
                MessageBox.Show("Grupa została wczytana z pliku XML.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
                btnWyświetlXML_Click(sender, e);
            }
        }

        private void btnZapiszXMLBinarnie_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "Binary Files (*.bin)|*.bin"
            };

            if (dialog.ShowDialog() == true)
            {
                using (var stream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write))
                {
                    var format = new BinaryFormatter();
                    format.Serialize(stream, grupa);
                }
                MessageBox.Show("Grupa została zapisana w formacie binarnym.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnWyświetlXMLBinarnie_Click(object sender, RoutedEventArgs e)
        {
            lbLista.Items.Clear();
            lbLista.Items.Add($"Grupa: {grupa.Nazwa}");
            foreach (var student in grupa.Studenci)
            {
                lbLista.Items.Add($"{student.Nazwisko} {student.Ocena:F1}");
                lbLista.Items.Add("Przedmioty:");
                foreach (var przedmiot in student.Przedmioty)
                {
                    lbLista.Items.Add($"- {przedmiot}");
                }
            }
        }

        private void btnWczytajXMLBinarnie_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Binary Files (*.bin)|*.bin"
            };

            if (dialog.ShowDialog() == true)
            {
                using (var stream = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    grupa = (Grupa)formatter.Deserialize(stream);
                }
                MessageBox.Show("Grupa została wczytana z pliku binarnego.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
                btnWyświetlXMLBinarnie_Click(sender, e); // Wyświetlenie wczytanych danych
            }
        }
    }
}