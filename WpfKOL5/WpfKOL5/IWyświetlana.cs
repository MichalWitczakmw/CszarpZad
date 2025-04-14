using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfKOL5
{
    public interface IWyświetlana
    {
        void  WyświetlDane(ListBox listBox);
    }

    public class Towar : IWyświetlana
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public Towar(string nazwa, double cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }

        void IWyświetlDane(ListBox listBox) 
        {
            listBox.Items.Add($"Towar: {Nazwa}, Cena: {Cena:C}");
        }
    }

    public class Mieszkanie : IWyświetlana
    {
        public string Adres { get; set; }
        public int LiczbaPokoi { get; set; }

        public Mieszkanie(string adres, int liczbaPokoi)
        {
            Adres = adres;
            LiczbaPokoi = liczbaPokoi;
        }

        void IWyświetlDane(ListBox listBox)
        {
            listBox.Items.Add($"Mieszkanie: {Adres}, Liczba pokoi: {LiczbaPokoi}");
        }
    }
}
