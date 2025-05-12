namespace Geometria
{
    public class Koło
    {
        private double promień;

        public double Promień
        {
            get => promień;

            set
            {
                if(value < 0) throw new ArgumentOutOfRangeException();
                else promień = value;
            }

        }
        public double Pole() => Math.PI * promień * promień;

    }
}
