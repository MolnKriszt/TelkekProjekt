using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Négyszög : Telek
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double e;

        public Négyszög(string helyrajziSzám, bool vanKözmű,bool vanSzomszéd, double a, double b, double c, double d, double e) : base(helyrajziSzám, vanKözmű, vanSzomszéd)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public override void InformációKözlő()
        {
            Console.WriteLine("{0} Telek: a = {1}, b = {2},c = {3},d = {4},d = {5}, Ára = {6:F2} Ft, Kerülete = {7:F2}, Területe = {8:F2}, Kerítés = {9:F2}m", helyrajziSzám, a, b, c, d, e, ÁratSzámol(), KerületSzámol(), TerületSzámol(), KerítésSzámol());
        }

        public override double KerítésSzámol()
        {
            if (vanSzomszéd)
            {
                return a + b + d;
            }
            else
            {
                return KerületSzámol();
            }
        }

        public override double KerületSzámol()
        {
            return a + b + c + d;
        }

        public override double TerületSzámol()
        {
            return HáromszögTerületSzámol(a, b, e) + HáromszögTerületSzámol(c, d, e);
        }

        public override double ÁratSzámol()
        {
            return TerületSzámol() * NégyzetméterÁrSzámol();
        }
    }
}
