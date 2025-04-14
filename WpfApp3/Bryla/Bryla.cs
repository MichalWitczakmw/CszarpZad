using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bryła;
public abstract class Bryła
{
    public string Nazwa { get; }
    public double Gęstość { get; }
    public double CenaZaKg { get; }

    public Bryła(string nazwa, double gęstość, double cenaZaKg)
    {
        Nazwa = nazwa;
        Gęstość = gęstość;
        CenaZaKg = cenaZaKg;
    }

    public abstract double ObliczObjętość { get; }
    public abstract double ObliczMasę { get; }
    public abstract double ObliczCenę { get; }

    public override string ToString()
    {
        return $"Nazwa: {Nazwa}\n" +
               $"Gęstość: {Gęstość} kg/m³\n" +
               $"Cena za kg: {CenaZaKg} zł/kg\n" +
               $"Objętość: {ObliczObjętość} m³\n" +
               $"Masa: {ObliczMasę} kg\n" +
               $"Cena: {ObliczCenę} zł";
    }
}
public class Kula : Bryła
{
    public double Promień { get; }
    public Kula(double promień, double gęstość, double cenaZaKg)
        : base("Kula", gęstość, cenaZaKg)
    {
        Promień = promień;
    }
    public override double ObliczObjętość => (4.0 / 3.0) * Math.PI * Math.Pow(Promień, 3);
    public override double ObliczMasę => ObliczObjętość * Gęstość;
    public override double ObliczCenę => ObliczMasę * CenaZaKg;
}
public class Stożek : Bryła
{
    public double Promień { get; }
    public double Wysokość { get; }
    public Stożek(double promień, double wysokość, double gęstość, double cenaZaKg)
        : base("Stożek", gęstość, cenaZaKg)
    {
        Promień = promień;
        Wysokość = wysokość;
    }
    public override double ObliczObjętość => (1.0 / 3.0) * 3.14 * Math.Pow(Promień, 2) * Wysokość;
    public override double ObliczMasę => ObliczObjętość * Gęstość;
    public override double ObliczCenę => ObliczMasę * CenaZaKg;
}