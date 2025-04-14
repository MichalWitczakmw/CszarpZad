using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp3
{
    public static class ListBoxExtensions
    {
        public static void Dodaj(this ListBox listBox, IWyświetl obiekt)
        {
            listBox.Items.Add(obiekt.PobierzIdentyfikator());
        }
    }
}
