using System.Xml.Serialization;

namespace Generyki
{
    public class Student : IComparable<Student>
    {
        public string Nazwisko { get; set; }
        public double Ocena {  get; set; }

        public Student(string nazwisko, double ocena)
        {
            Nazwisko = nazwisko;
            Ocena = ocena;
        }   

        public int CompareTO(Student inny)
        {
            if(inny == null) return 1;
            return this.Ocena.CompareTo(inny.Ocena);
        }
    }
}
