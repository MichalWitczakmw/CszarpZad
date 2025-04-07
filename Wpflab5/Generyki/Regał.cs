using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyki
{
    public class Regał<T>
    {
        public T Półka1 { get; set; }
        public T Półka2 { get; set; }
        public T Półka3 { get; set; }

        public Regał()
        {
            Półka1 = default(T);
            Półka2 = default(T);
            Półka3 = default(T);
        }

        public override string ToString()
        {
            return $"Półka1: {Półka1}, Półka2: {Półka2}, Półka3: {Półka3}";
        }

        public void WstawNaWolnąPółkę(T value)
        {
            if (Equals(Półka1, default(T)))
                Półka1 = value;
            else if(Equals(Półka2, default(T)))
                Półka2 = value;
            else if (Equals(Półka3, default(T)))
                Półka3 = value;
            else
                throw new InvalidOperationException("Brak wolnej półki.");
        }

        public T WolnaPółka
        { 
            set 
            { 
                WstawNaWolnąPółkę(value); 
            } 
        }



    }
}
