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
    /// Logika interakcji dla klasy DaneWejścioweOkno.xaml
    /// </summary>
    public partial class DaneWejścioweOkno : Window
    {
        public DaneWejścioweOkno()
        {
            InitializeComponent();
        }

        public double Szerokość
        {  get
           {
                return Convert.ToDouble(txtSzerokość.Text);
           } 
        }

        public double Wysokość
        {
            get
            {
                return Convert.ToDouble(txtWysokość.Text);
            }
        }


        private void btnOKWysokośćISzerokość_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
