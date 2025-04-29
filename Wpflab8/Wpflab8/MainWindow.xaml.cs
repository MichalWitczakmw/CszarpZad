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

namespace Wpflab8
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

        private void btnPokażTowary_Click(object sender, RoutedEventArgs e)
        {
            string polacz = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sklep;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string zapytanie = "SELECT * FROM Towary WHERE TowarId IS NOT NULL";

            using (SqlConnection polaczenie = new SqlConnection(polacz))
            {
                polaczenie.Open();

                SqlCommand komenda = new SqlCommand(zapytanie, polaczenie);
                SqlDataAdapter adapter = new SqlDataAdapter(komenda);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                lbPokażTowary.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                   lbPokażTowary.Items.Add($"{row["Nazwa"]} - Cena: {row["Cena"]}, Ilość: {row["Ilosc"]}");
                }

                var ceny = dataTable.AsEnumerable()
                    .Where(row => row["Cena"] != DBNull.Value)
                    .Select(row => Convert.ToDecimal(row["Cena"]));
                decimal sredniaCena = ceny.Any() ? ceny.Average() : 0;

                lblśredniaTowaty.Content = $"Średnia cena: {sredniaCena:C}";
            }
        }
    }
}