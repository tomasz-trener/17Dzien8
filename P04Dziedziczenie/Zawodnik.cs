using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    public class Zawodnik : Czlowiek
    {
        public Zawodnik()
        {

        }

        public void PodajSwojeDane()
        {
            PrzedstawSie();
        }

        public Zawodnik(string imie)
        {
           drugieImie = "ala";
           Imie = imie;
        }
    }
}
