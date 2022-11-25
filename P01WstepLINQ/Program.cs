using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01WstepLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //linq składnia umożliwiąca wydobywanie informacji z danych. 
            // źródło to dowolna kolekcji 

            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            ManagerZawodnikow mz = new ManagerZawodnikow(TypImportu.Zdalny, url);

            Zawodnik[] dane = mz.WczytajZawodnikow();


            string[] napisy = { "BACHLEDA", "MATEJA", "HERR" };

            string[] wynik = napisy.Where(cokolowiek => cokolowiek.Length > 4).ToArray();

            int[] liczby = { 4, 6, 33, 2, 30, 20, 22 };

            int[] wynik2 = liczby
                .Where(x => x > 10)
                .OrderBy(x=>x)
                .ToArray();

            // znajdz zawodników, któych nazwisko konczy się na litere a 
            // oraz wzrost jest ponad 2 razy wiekszy niz waga
            // urodzonych w II polowie roku, i posortouj po dlugosci imienia 

            Zawodnik[] wynik3 = dane
                .Where(x => x.Nazwisko.ToLower().EndsWith("a") &&
                        x.Wzrost > x.Waga * 2 &&
                        x.DataUrodzenia.Month > 6
                        )
                .OrderBy(x=>x.Kraj)
                .ThenBy(x => x.Imie.Length)
                .ThenByDescending(x=>x.Wzrost)
                .ToArray();
            /*
               select * from zawodnicy
               --where right(nazwisko,1) = 'a'
               where nazwisko like '%a' and wzrost > waga*2 and month(data_ur) > 6
               order by kraj, len(imie), wzrost desc
               */
            string[] wynik4 = dane
              .Where(x => x.Nazwisko.ToLower().EndsWith("a") &&
                      x.Wzrost > x.Waga * 2 &&
                      x.DataUrodzenia.Month > 6
                      )
              .OrderBy(x => x.Kraj)
              .ThenBy(x => x.Imie.Length)
              .ThenByDescending(x => x.Wzrost)
              .Select(x=>x.Nazwisko + ' ' + x.Imie)
              .ToArray();

            ZawodnikMini[] wynik5 = dane.Select(x => new ZawodnikMini()
            {
                Imie = x.Imie,
                Nazwisko = x.Nazwisko,
                Kraj = x.Kraj,
                BMI = x.Waga / Math.Pow(x.Wzrost/100.0,2)
            }).ToArray();

            foreach (var z in wynik5)
                Console.WriteLine(z.Imie + " " + z.Nazwisko + " " + z.Kraj + " "+ z.BMI);

            Console.ReadKey();
            // dodaj do zawodnika mini właściwość BMI i ją uzupełnij 

        }
    }
}
