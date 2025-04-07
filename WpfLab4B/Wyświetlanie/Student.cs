using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyświetlanie
{
    public class Student : IWyświetl
    {
        public string Imię { get; set; }
        public string Nazwisko { get; set; }

        public Student(string imię, string nazwisko)
        {
            Imię = imię;
            Nazwisko = nazwisko;
        }

        public string PobierzIdentyfikator()
        {
            return $"Student: {Imię} {Nazwisko}";
        }
    }
}
