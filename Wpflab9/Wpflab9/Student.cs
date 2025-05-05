using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpflab9
{
    public class Student:IDisposable
    {
        public string Nazwisko { get; set; } = "";

        ~Student() {
            MessageBox.Show($"Zwalniam Zasoby dla {Nazwisko}");
        }

        public void Dispose()
        {
            MessageBox.Show($"Zwalniam Zasoby dla {Nazwisko}");
            GC.SuppressFinalize( this );
        }
    }
}
