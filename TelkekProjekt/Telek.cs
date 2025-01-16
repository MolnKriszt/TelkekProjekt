using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    abstract internal class Telek
    {
        public string helyrajziSzám;
        public bool vanKözmű;
        public bool vanSzomszéd;

        public Telek(string helyrajziSzám, bool vanKözmű, bool vanSzomszéd)
        {
            this.helyrajziSzám = helyrajziSzám;
            this.vanKözmű = vanKözmű;
            this.vanSzomszéd = vanSzomszéd;
        }

        abstract public double TerületSzámol();
        abstract public double KerületSzámol();
        abstract public double ÁratSzámol();
        abstract public double KerítésSzámol();
        abstract public void InformációKözlő();

        public double NégyzetméterÁrSzámol()
        {
            return vanKözmű ? 30000 : 10000;
        }

        public static double HáromszögTerületSzámol(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public void InformációKözlőAdatokNélkül()
        {
            Console.WriteLine($"| {helyrajziSzám,-5} | {ÁratSzámol(),10:N0} Ft | {KerületSzámol(),10:N2} m | {TerületSzámol(),10:N2} m² | {KerítésSzámol(),10:N2} m |");
        }

    }
}
