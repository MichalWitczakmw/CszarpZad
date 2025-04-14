using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3;
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
    public double ObliczMasę => ObliczObjętość * Gęstość;
    public double ObliczCenę => ObliczMasę * CenaZaKg;
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
public class Kula : Bryła, IWyświetl
{
    public double Promień { get; }
    public Kula(double promień, double gęstość, double cenaZaKg)
        : base("Kula", gęstość, cenaZaKg)
    {
        Promień = promień;
    }
    public override double ObliczObjętość => (4.0 / 3.0) * Math.PI * Math.Pow(Promień, 3);

    public string PobierzIdentyfikator()
    {
        return $"Kula: Promień = {Promień} m";
    }
}
public class Stożek : Bryła, IWyświetl
{
    public double Promień;
    public double Wysokość;

    public Stożek(double promień, double wysokość, double gęstość, double cenaZaKg)
        : base("Stożek", gęstość, cenaZaKg)
    {
        Promień = promień;
        Wysokość = wysokość;
    }

    public override double ObliczObjętość => (1.0 / 3.0) * Math.PI * Math.Pow(Promień, 2) * Wysokość;

    public string PobierzIdentyfikator()
    {
        return $"Stożek: Promień = {Promień} m, Wysokość = {Wysokość} m";
    }
}