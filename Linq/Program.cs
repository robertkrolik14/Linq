using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var warzywa = new List<Warzywo>
            {
                new Warzywo{Cena = 15.00, Nazwa ="cebula"},
                new Warzywo{Cena = 25.00, Nazwa = "marchewka" },
                new Warzywo{Cena = 8.00, Nazwa = "cukinia"},
                new Warzywo{Cena = 2.00, Nazwa = "Burak" },
                new Warzywo{Cena = 3.00, Nazwa = "Seler" },
                new Warzywo{Cena = 7.90, Nazwa = "Batat" },
                new Warzywo{Cena = 2.00, Nazwa = "Mango"},
                new Warzywo{Cena = 3.99, Nazwa = "Porzeczka"},
                new Warzywo{Cena = 11.50, Nazwa = "Brukiew"},
                new Warzywo{Cena = 2.00, Nazwa = "Burak" },
                new Warzywo{Cena = 2.00, Nazwa = "pietruszka" },
                new Warzywo{Cena = 5.99, Nazwa = "marchew"},
                new Warzywo{Cena = 3.99, Nazwa = "ziemniak"}
            };

            var warzywaPonizej3zl = (from zmienna in warzywa where zmienna.Cena <= 3 select zmienna).ToList();

            foreach(var warzywo in warzywaPonizej3zl)
            {
                Console.WriteLine(warzywo.Nazwa + " " + warzywo.Cena);
            }
            var warzywazrz = (from a in warzywa where a.Nazwa.Contains("rz") select a.Nazwa).ToList();

            Console.WriteLine();
            foreach (var warzywo in warzywazrz)
            {
                Console.WriteLine(warzywo);
            }
            Console.ReadLine();

        }
    }
}
