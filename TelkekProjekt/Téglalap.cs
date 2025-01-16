using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Téglalap : Telek
    {

        private double a;
        private double b;

        public Téglalap(string helyrajziSzám, bool vanKözmű, bool vanSzomszéd, double a, double b) : base(helyrajziSzám, vanKözmű,vanSzomszéd)
        {


            this.a = a;
            this.b = b;
        }

        public override void InformációKözlő()
        {
            Console.WriteLine("{0} Telek: a = {1}, b = {2}, Ára = {3:F2} Ft, Kerülete = {4:F2}, Területe = {5:F2}, Kerítés = {6:F2}m", helyrajziSzám, a, b, ÁratSzámol(), KerületSzámol(), TerületSzámol(), KerítésSzámol());
        }

        public override double KerítésSzámol()
        {
            if (vanSzomszéd)
            {
                return b * 2 + a;
            }
            else
            {
                return KerületSzámol();
            }
        }

        public override double KerületSzámol()
        {
            return 2 * (a + b);
        }

        public override double TerületSzámol()
        {
            return a * b;
        }

        public override double ÁratSzámol()
        {
            return TerületSzámol() * NégyzetméterÁrSzámol();  
        }
    }
}
