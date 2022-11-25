using P04Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zawodnik[] zawodnicy =
            {
                new Zawodnik() { Imie = "Jan", Nazwisko ="Kowalsi"},
                new Zawodnik() { Imie = "Adam", Nazwisko ="Nowak"},
            };

            Programista[] programisci =
           {
                new Programista() { Imie = "Ola", Nazwisko ="Kowalska"},
                new Programista() { Imie = "Ala", Nazwisko ="Nowak"},
            };

            Czlowiek[] osoby =
            {
                new Zawodnik() { Imie = "Jan", Nazwisko ="Kowalsi"},
                new Zawodnik() { Imie = "Adam", Nazwisko ="Nowak"},
                new Programista() { Imie = "Ola", Nazwisko ="Kowalska"},
                new Programista() { Imie = "Ala", Nazwisko ="Nowak"},
            };


            foreach (var item in osoby)
            { 
                if(item is Programista)
                {
                    ((Programista)item).Programuj();
                }
                item.PrzedstawSie();
            }

            foreach (var item in zawodnicy)
                item.PrzedstawSie();

            foreach (var item in programisci)
                item.PrzedstawSie();

        }
    }
}
