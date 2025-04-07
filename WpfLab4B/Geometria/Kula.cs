using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Kula : Bryla
    {
        public double Promien {  get;}
        public Kula(double promien, double gestość, double cenaZaKg) :base(gestość,cenaZaKg)
        { 
            Promien = promien;
        }
        public override string Nazwa { get { return "Kula"; } }
        public override double ObliczObjetosc()
        {
            return (4.0/3.0)*Math.PI*Math.Pow(Promien,3);
        }
    }
}
