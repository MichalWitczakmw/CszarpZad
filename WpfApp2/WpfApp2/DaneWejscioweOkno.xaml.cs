using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy DaneWejscioweOkno.xaml
    /// </summary>
    public partial class DaneWejscioweOkno : Window
    {
        public DaneWejscioweOkno()
        {
            InitializeComponent();
        }
        public double Szerokość
        {
            get { return Convert.ToDouble(txtSzerokosc.Text); }
        }
        public double Wysokość
        {
            get => Convert.ToDouble(TxtWysokosc.Text);
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
