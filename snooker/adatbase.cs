using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snooker
{
    class adatbase
    {
        public int helyezes;
        public string Nev;
        public string Orszag;
        public int nyeremeny;

        public adatbase(string sor)
        {
            string[] adatsorelem = sor.Split(';');
            this.helyezes = int.Parse(adatsorelem[0]);
            this.Nev = adatsorelem[1];
            this.Orszag = adatsorelem[2];
            this.nyeremeny = int.Parse(adatsorelem[3]);
        }
    }
}
