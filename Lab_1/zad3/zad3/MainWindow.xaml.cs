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

namespace zad3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    /*
    3. Narysować przy pomocy dwóch zagnieżdżonych pętli for i klasy Rectangle szachownicę na kontenerzeGrid 
    wykorzystując odpowiednią definicję kolumn i wierszy.
    */

   
    private void DrawChessboard(object sender, EventArgs e)
    {
        int rows = 8;
        int columns = 8;
        char[] columnLabels = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        // Dodaj wiersze i kolumny tylko raz, w tym dodatkowy wiersz i kolumnę na etykiety
        for (int i = 0; i <= rows; i++)
        {
            RowDefinition row = new RowDefinition();
            row.Height = new GridLength(1, GridUnitType.Star);
            gdSzachownica.RowDefinitions.Add(row);
        }

        for (int j = 0; j <= columns; j++)
        {
            ColumnDefinition column = new ColumnDefinition();
            column.Width = new GridLength(1, GridUnitType.Star);
            gdSzachownica.ColumnDefinitions.Add(column);
        }

        // Dodaj etykiety kolumn
        for (int j = 0; j < columns; j++)
        {
            TextBlock columnLabel = new TextBlock
            {
                Text = columnLabels[j].ToString(),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetRow(columnLabel, 0);
            Grid.SetColumn(columnLabel, j + 1);
            gdSzachownica.Children.Add(columnLabel);
        }

        // Dodaj etykiety wierszy
        for (int i = 0; i < rows; i++)
        {
            TextBlock rowLabel = new TextBlock
            {
                Text = (i + 1).ToString(),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetRow(rowLabel, i + 1);
            Grid.SetColumn(rowLabel, 0);
            gdSzachownica.Children.Add(rowLabel);
        }

        // Dodaj prostokąty do grida
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Fill = (i + j) % 2 == 0 ? Brushes.Black : Brushes.White;
                Grid.SetRow(rectangle, i + 1);
                Grid.SetColumn(rectangle, j + 1);
                gdSzachownica.Children.Add(rectangle);
            }
        }
    }
}