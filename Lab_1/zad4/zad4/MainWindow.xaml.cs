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

namespace zad4;

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
     4. Stworzyć w WPF test zawierający pytania wielokrotnego wyboru - typu wszystko albo nic 
     (kontrolki CheckBox), jednokrotnego wyboru (jedno z ComboBox, jedno z ListBox, jedno z RadioButton) 
     i otwarte (TextBox). Po naciśnięciu przycisku „Sprawdź” ma być obliczona łączna punktacja. 
     Pytaniarozmieścić za pomocą kombinacji kontenerów Grid i StackPanel.
    */
    
    string[] pytania = {
        "Pytanie 1:\t ILe jest liczb? \n A) 1\nB) sześć\nC)10111\nD)-41",
        "Pytanie 2:\t 2 + 2 =?",
        "Pytanie 3:\t OK?",
        "Pytanie 4:\t Czy na pewno 2 + 2 = 4?",
        "Pytanie 5:\t Co tam?"
    };

    int ilePunktów = 0;
    int ktorePytanie = 0;

    private void Window_Activated(object sender, EventArgs e)
    {
        txtPytanie.Text = pytania[0];
        stkOdpowiedzi.Children.Add(new CheckBox() { Name = "chkd1", Content = "Wszystkie" });
        stkOdpowiedzi.Children.Add(new CheckBox() { Name = "chkd2", Content = "Żadne" });
    }

    private void btnNastępny_Click(object sender, RoutedEventArgs e)
    {
        // Sprawdzenie odpowiedzi przed przejściem do następnego pytania
        switch (ktorePytanie)
        {
            case 0:
                if (((CheckBox)stkOdpowiedzi.Children[0]).IsChecked == true)
                {
                    ilePunktów++;
                }
                break;
            case 1:
                var comboBox = (ComboBox)stkOdpowiedzi.Children[0];
                if (comboBox.SelectedItem != null)
                {
                    if (comboBox.SelectedItem.ToString() == "4")
                    {
                        ilePunktów++;
                    }
                    else if (comboBox.SelectedItem.ToString() == "5")
                    {
                        ilePunktów += 2;
                    }
                }
                break;
            case 2:
                ilePunktów++;
                break;
            case 3:
                if (((RadioButton)stkOdpowiedzi.Children[1]).IsChecked == true)
                {
                    ilePunktów++;
                }
                break;
            case 4:
                var textBox = (TextBox)stkOdpowiedzi.Children[0];
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    ilePunktów++;
                }
                break;
            default:
                break;
        }

        if (ktorePytanie < pytania.Length - 1)
        {
            ktorePytanie++;
            txtPytanie.Text = pytania[ktorePytanie];
            stkOdpowiedzi.Children.Clear();
            switch (ktorePytanie)
            {
                case 0:
                    stkOdpowiedzi.Children.Add(new CheckBox() { Name = "chkd1", Content = "Wszystkie" });
                    stkOdpowiedzi.Children.Add(new CheckBox() { Name = "chkd2", Content = "Żadne" });
                    break;
                case 1:
                    stkOdpowiedzi.Children.Add(new ComboBox() { Name = "cmbOdpowiedzi" });
                    ((ComboBox)stkOdpowiedzi.Children[0]).Items.Add("1");
                    ((ComboBox)stkOdpowiedzi.Children[0]).Items.Add("2");
                    ((ComboBox)stkOdpowiedzi.Children[0]).Items.Add("3");
                    ((ComboBox)stkOdpowiedzi.Children[0]).Items.Add("4");
                    ((ComboBox)stkOdpowiedzi.Children[0]).Items.Add("5");
                    break;
                case 2:
                    stkOdpowiedzi.Children.Add(new ListBox() { Name = "lstOdpowiedzi" });
                    ((ListBox)stkOdpowiedzi.Children[0]).Items.Add("Tak");
                    ((ListBox)stkOdpowiedzi.Children[0]).Items.Add("Nie");
                    break;
                case 3:
                    stkOdpowiedzi.Children.Add(new RadioButton() { Name = "rdoOdpowiedz1", Content = "Tak" });
                    stkOdpowiedzi.Children.Add(new RadioButton() { Name = "rdoOdpowiedz2", Content = "Nie" });
                    break;
                case 4:
                    stkOdpowiedzi.Children.Add(new TextBox() { Name = "txtOdpowiedz" });
                    break;
                default:
                    break;
            }
        }
        else
        {
            MessageBox.Show("Koniec pytań");
        }
    }

    private void btnSprawdź_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"Zdobyłeś {ilePunktów} punktów na 5 możliwych");
    }
}