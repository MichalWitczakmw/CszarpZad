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

namespace k1;

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
    Stworzyć aplikację, gdzie użytkownik podaj swoje wagę,wzrost w kontrolkach textbox. 
    Po naciśnięciu przycisku.Sprawedź pojawia się okienko MessageBox ze wskaźnikiem BMI i informacją, 
    czy osoba ma niedowagę, wagę prawidłową, czy nad wagę

    private void CheckBMI_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(WeightTextBox.Text, out double weight) && double.TryParse(HeightTextBox.Text, out double height))
            {
                double bmi = weight / (height * height);
                string message;

                if (bmi < 18.5)
                {
                    message = $"Twoje BMI wynosi {bmi:F2}. Masz niedowagę.";
                }
                else if (bmi >= 18.5 && bmi < 24.9)
                {
                    message = $"Twoje BMI wynosi {bmi:F2}. Masz wagę prawidłową.";
                }
                else
                {
                    message = $"Twoje BMI wynosi {bmi:F2}. Masz nadwagę.";
                }

                MessageBox.Show(message, "Wynik BMI", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić prawidłowe wartości dla wagi i wzrostu.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

     */

    /*
     Zrobić prosty program graficzyn. Za pomocą grupy RadioButton użytkownik wybiera, 
    jaką figurę chce narysować: prostokąt lub elipsę. W polach tekstowym podaje położenie i rozmiat figury, po naciśnięciu przycisku Dodaj pojawia się na kontenetrze Canvas narysowana figura. 
    Zabezpieczyć program przez błędnymi danymi wprowadzanymi przez użytkownika. 
    Uzupełnić program o przycisk Czyść.
    
     private void AddShape_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(XTextBox.Text, out double x) &&
                double.TryParse(YTextBox.Text, out double y) &&
                double.TryParse(WidthTextBox.Text, out double width) &&
                double.TryParse(HeightTextBox.Text, out double height))
            {
                Shape shape;
                if (RectangleRadioButton.IsChecked == true)
                {
                    shape = new Rectangle
                    {
                        Width = width,
                        Height = height,
                        Stroke = Brushes.Black,
                        StrokeThickness = 2
                    };
                }
                else
                {
                    shape = new Ellipse
                    {
                        Width = width,
                        Height = height,
                        Stroke = Brushes.Black,
                        StrokeThickness = 2
                    };
                }

                Canvas.SetLeft(shape, x);
                Canvas.SetTop(shape, y);
                DrawingCanvas.Children.Add(shape);
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić prawidłowe wartości dla położenia i rozmiaru figury.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearCanvas_Click(object sender, RoutedEventArgs e)
        {
            DrawingCanvas.Children.Clear();
        }
     */

    /*
     Zdefiniować metody RysujProstokąt i RysujKoło z parametrami pozwalającymi rysować 
    dowolne wypełnione figury z danego rodzaju. Po naciśnięciu przycisku Rysuj pojawia się schemat czołgu. 
    4 równo oddalone koło powinny być narysowane przy pomocy pętli for

    private void AddShape_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(XTextBox.Text, out double x) &&
                double.TryParse(YTextBox.Text, out double y) &&
                double.TryParse(WidthTextBox.Text, out double width) &&
                double.TryParse(HeightTextBox.Text, out double height))
            {
                if (RectangleRadioButton.IsChecked == true)
                {
                    RysujProstokąt(x, y, width, height, Brushes.Black);
                }
                else
                {
                    RysujKoło(x, y, width, height, Brushes.Black);
                }
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić prawidłowe wartości dla położenia i rozmiaru figury.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearCanvas_Click(object sender, RoutedEventArgs e)
        {
            DrawingCanvas.Children.Clear();
        }

        private void DrawTank_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas_Click(sender, e);

            // Rysowanie korpusu czołgu
            RysujProstokąt(50, 100, 200, 50, Brushes.Green);

            // Rysowanie wieży czołgu
            RysujProstokąt(100, 70, 100, 50, Brushes.Green);

            // Rysowanie lufy czołgu
            RysujProstokąt(190, 80, 60, 10, Brushes.Green);

            // Rysowanie kół czołgu
            for (int i = 0; i < 4; i++)
            {
                RysujKoło(60 + i * 50, 150, 30, 30, Brushes.Black);
            }
        }

        private void RysujProstokąt(double x, double y, double width, double height, Brush color)
        {
            Rectangle rectangle = new Rectangle
            {
                Width = width,
                Height = height,
                Fill = color
            };
            Canvas.SetLeft(rectangle, x);
            Canvas.SetTop(rectangle, y);
            DrawingCanvas.Children.Add(rectangle);
        }

        private void RysujKoło(double x, double y, double width, double height, Brush color)
        {
            Ellipse ellipse = new Ellipse
            {
                Width = width,
                Height = height,
                Fill = color
            };
            Canvas.SetLeft(ellipse, x);
            Canvas.SetTop(ellipse, y);
            DrawingCanvas.Children.Add(ellipse);
        }
     */

}

