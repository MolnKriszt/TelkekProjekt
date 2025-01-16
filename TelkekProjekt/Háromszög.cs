using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Háromszög : Telek
    {
        private double a;
        private double b;
        private double c;

        public Háromszög(string helyrajziSzám, bool vanKözmű,bool vanSzomszéd, double a, double b, double c) : base(helyrajziSzám, vanKözmű,vanSzomszéd)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void InformációKözlő()
        {
            Console.WriteLine("{0} Telek: a = {1}, b = {2},c = {3}, Ára = {4:F2} Ft, Kerülete = {5:F2}, Területe = {6:F2}, Kerítés = {7:F2}m", helyrajziSzám, a, b, c, ÁratSzámol(), KerületSzámol(), TerületSzámol(), KerítésSzámol());
        }

        public override double KerítésSzámol()
        {
            if (vanSzomszéd)
            {
                return a + b;
            }
            else 
            {
                return KerületSzámol();
            }
        }

        public override double KerületSzámol()
        {
            return a + b + c;
        }

        public override double TerületSzámol()
        {
            return HáromszögTerületSzámol(a, b, c);
        }

        public override double ÁratSzámol()
        {
            return TerületSzámol() * NégyzetméterÁrSzámol();
        }
    }
}
