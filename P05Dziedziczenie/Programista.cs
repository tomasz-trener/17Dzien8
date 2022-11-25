using P04Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Dziedziczenie
{
    internal class Programista : Czlowiek
    {
        public Programista()
        {
            trzecieImie = "jan";
        }

        public void Programuj()
        {
            Console.WriteLine("programuje");
        }
    }
}
