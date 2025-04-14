using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Student : IWyświetl
    {
        public string Imię { get; }
        public string Nazwisko { get; }

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
