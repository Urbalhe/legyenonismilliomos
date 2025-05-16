using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyenonismilliomos
{
    internal class Jatek
    {
        public static void jatek()
        {
            if (!sorkerdes()) { return; }
        }

        static bool sorkerdes()
        {
            Random rnd = new Random();

            List<Sorkerdes> kerdesek = Kerdesek.SKBeolvasas();
            int index = rnd.Next(0, kerdesek.Count);
            Sorkerdes kerdes = kerdesek[index];
            Console.WriteLine(kerdes.KerdesSzoveg);
            Console.WriteLine("a: " + kerdes.Valaszok[0]);
            Console.WriteLine("b: " + kerdes.Valaszok[1]);
            Console.WriteLine("c: " + kerdes.Valaszok[2]);
            Console.WriteLine("d: " + kerdes.Valaszok[3]);
            Console.WriteLine("Helyes válasz: " + kerdes.HelyesValaszKod);
            Console.WriteLine("Kategória: " + kerdes.Kategoria);
            Console.WriteLine("Kérlek válassz egy választ: ");
            string valasz = Console.ReadLine();

            return valasz.ToLower() == kerdes.HelyesValaszKod.ToLower();
        }
    }
}
