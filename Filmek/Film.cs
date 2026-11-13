using System;
using System.Collections.Generic;
using System.Text;

namespace Filmek
{
    public class Film
    {
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public int Hossz { get; set; }
        public double Ertekeles { get; set; }

        public Film(string cim, string mufaj, int hossz, double ertekeles)
        {
            Cim = cim;
            Mufaj = mufaj;
            Hossz = hossz;
            Ertekeles = ertekeles;
        }
        public class FilmCim
        {
            public string Cim { get; set; }
            public FilmCim(string cim)
            {
                Cim = cim;
            }
        }
    }
}
