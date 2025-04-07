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

namespace Wpflab4
{
    /// <summary>
    /// Logika interakcji dla klasy DaneWyjścioweOkno.xaml
    /// </summary>
    public partial class DaneWyjścioweOkno : Window
    {
        public DaneWyjścioweOkno()
        {
            InitializeComponent();
        }

        public DaneWyjścioweOkno(double P,double O):this()
        {
            tbkPole.Text = $"Obwód={O:F2}";
            tbkObwód.Text = $"Pole={P:F2}";
        }

        private void btnOKPO_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
