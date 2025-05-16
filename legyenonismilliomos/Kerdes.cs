using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyenonismilliomos
{
    public class Kerdes

    {
        private int nehezseg;
        private string kerdesSzoveg;
        private string[] valaszok = new string[4];
        private char helyesValaszKod;
        private string kategoria;


        public Kerdes(int nehezseg, string kerdesSzoveg, string[] valaszok, char helyesValaszKod, string kategoria)
        {
            this.nehezseg = nehezseg;
            this.kerdesSzoveg = kerdesSzoveg;
            this.valaszok = valaszok;
            this.helyesValaszKod = helyesValaszKod;
            this.kategoria = kategoria;
            
        }
        public int Nehezseg { get => nehezseg; set => nehezseg = value; }
        public string KerdesSzoveg { get => kerdesSzoveg; set => kerdesSzoveg = value; }
        public string[] Valaszok { get => valaszok; set => valaszok = value; }
        public char HelyesValaszKod { get => helyesValaszKod; set => helyesValaszKod = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
    }
}