using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Stożek
    {
        public delegate void ObsługaBłędu(string opisBłedu);

        public event ObsługaBłędu Błąd;

        private double wysokość;
        private double promień;
        public double Wysokość
        {

            get => wysokość;

            set
            {
                if (value < 0)
                {
                    Błąd?.Invoke("Wysokość nie może być ujemna.");
                }
                else
                {
                    wysokość = value;
                }
            }
        }
        public double Promień
        {

            get => promień;

            set
            {
                if (value < 0)
                {
                    Błąd?.Invoke("Promień nie może być ujemna.");
                }
                else
                {
                    wysokość = value;
                }
            }
        }
    }
}
