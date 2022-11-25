using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    public class Czlowiek
    {
        public string Imie{ get; set; }
        public string Nazwisko { get; set; }

        private protected string drugieImie;

        protected string trzecieImie;

        public void PrzedstawSie()
        {
            Console.WriteLine(Imie + " " + Nazwisko);
        }
    }
}
