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
using Edukacja.Data;
using Edukacja.Models;
using System.Linq;
using System.Windows;
using Wpfkol8.Models;

namespace Wpfkol8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private EdukacjaContext _context; 

        public MainWindow()
        {
            InitializeComponent();
            _context = new EdukacjaContext();
            LoadKursy();
        }

        private void LoadKursy()
        {
            var kursy = _context.Kursy.ToList();
            lstKursy.ItemsSource = kursy;

       
            var maxLiczbaGodzin = kursy.Any() ? kursy.Max(k => k.LiczbaGodzin) : 0;
            lblMaxLiczbaGodzin.Content = $"Maksymalna liczba godzin: {maxLiczbaGodzin}";
        }

     
        private void btnDodajKurs_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
             
                var kurs = new Kurs
                {
                    NazwaKursu = txtNazwaKursu.Text,
                    Prowadzący = txtprowadzacy.Text,
                    LiczbaGodzin = int.TryParse(txtLiczbaGodzin.Text, out var liczbaGodzin) ? liczbaGodzin : 0,
                    CzyObowiązkowy = chkCzyObowiazkowy.IsChecked ?? false
                };

                // Dodanie kursu do bazy danych
                _context.Kursy.Add(kurs);
                _context.SaveChanges();
                MessageBox.Show("Kurs został dodany.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);

            
                LoadKursy();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania kursu: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Obsługa kliknięcia przycisku "Usuń"
        private void btnUsuńKurs_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lstKursy.SelectedItem is Kurs selectedKurs)
                {
            
                    _context.Kursy.Remove(selectedKurs);
                    _context.SaveChanges();
                    MessageBox.Show("Kurs został usunięty.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);

              
                    LoadKursy();
                }
                else
                {
                    MessageBox.Show("Proszę wybrać kurs do usunięcia.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas usuwania kursu: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
