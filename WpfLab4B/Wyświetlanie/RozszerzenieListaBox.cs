using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyświetlanie
{
    public static class RozszerzenieListaBox
    {
        public static void Dodaj(this ListBox listBox, IWyswietl element)
        {
            listBox.Items.Add(element.PobierzIdentyfikator());
        }
    }
}
