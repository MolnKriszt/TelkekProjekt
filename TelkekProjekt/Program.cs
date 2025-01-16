﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Telek> telkek = new List<Telek>
            {
                new Téglalap("T1", true,true, 13.95, 12.9),
                new Négyszög("T2", true,true, 13.95, 16.38, 14.24, 19.26, 21.52),
                new Négyszög("T3", false,true, 14.24, 26.4, 23.1, 41.9, 27.32),
                new Háromszög("T4", false,false, 23.1, 18.36, 13.95),
                new Téglalap("T5", true,true, 13.95, 12.9),
                new Négyszög("T6", false,true, 13.95, 23.13, 14.48, 19.26, 27),
                new Háromszög("T7", false,true, 14.48, 22.84, 22.14),
                new Négyszög("T8", false,false, 22.84, 38, 13.95, 19.71, 24.15),
            };

            double összesÁr = 0;
            double összesKerítés = 0;
            foreach (var telek in telkek)
            {
                telek.InformációKözlő();
                összesÁr += telek.ÁratSzámol();
                összesKerítés += telek.KerítésSzámol();
            }
            Console.WriteLine("Összes Ár: {0:N0} Ft",összesÁr);
            Console.WriteLine("Összes Kerítés: {0} m", összesKerítés);

            Console.ReadLine();
        }
    }
}
