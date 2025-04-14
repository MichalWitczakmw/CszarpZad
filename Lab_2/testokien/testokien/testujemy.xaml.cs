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

namespace testokien
{
    /// <summary>
    /// Logika interakcji dla klasy testujemy.xaml
    /// </summary>
    public partial class testujemy : Window
    {
        public testujemy()
        {
            InitializeComponent();
        }

        private void btntestokna2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
