using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Stozek : Bryla
    {
        public double Promień {  get; }
        public double Wysokość {  get; }

        public override string Nazwa { get { return "Stozek"; } }

        public Stozek(double promień,double wysokość, double gęstość,double cenaZaKg): base(gęstość,cenaZaKg) 
        {
            Promień = promień;
            Wysokość = wysokość;
        }

        public override double ObliczObjetosc()
        {
            return (1.0/3.0)*Math.PI*Math.Pow(Promień,2)*Wysokość;
        }
    }
}
