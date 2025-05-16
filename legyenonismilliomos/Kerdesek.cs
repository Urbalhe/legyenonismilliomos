using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyenonismilliomos
{
    internal class Kerdesek
    {
        public static List<Sorkerdes> SKBeolvasas()
        {
            List<Sorkerdes> Kerdesek = [];

            string[] lines = File.ReadAllLines("sorkerdes.txt");

            foreach (string line in lines)
            {
                string[] reszek = line.Split(';');
                Sorkerdes kerdes = new Sorkerdes(reszek[0], new string[] { reszek[1], reszek[2], reszek[3], reszek[4] }, reszek[5], reszek[6]);
                Kerdesek.Add(kerdes);
            }
            return Kerdesek;
        }
        
        public static List<Kerdes> KBeolvasas()
        {
            List<Kerdes> Kerdesek = new List<Kerdes>();

            string[] lines = File.ReadAllLines("kerdes.txt");

            foreach (string line in lines)
            {
                string[] reszek = line.Split(';');
                Kerdes kerdes = new Kerdes(int.Parse(reszek[0]), reszek[1], new string[] { reszek[2], reszek[3], reszek[4], reszek[5] }, char.Parse(reszek[6]), reszek[7]);
                Kerdesek.Add(kerdes);
            }
            return Kerdesek;
        }

    }
}
