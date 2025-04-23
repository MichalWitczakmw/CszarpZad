using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wpflab7
{
    [Serializable]
    public class Student
    {
        public string Nazwisko { get; set; }
        public double Ocena { get; set; }
        public List<string> Przedmioty { get; set; } = new List<string>();
    }

    [Serializable]
    public class Grupa
    {
        public string Nazwa { get; set; }
        public List<Student> Studenci { get; set; } = new List<Student>();
    }


}
