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
                .OrderBy(x => x)
                .ToArray();

            // znajdz zawodników, któych nazwisko konczy się na litere a 
            // oraz wzrost jest ponad 2 razy wiekszy niz waga
            // urodzonych w II polowie roku, i posortouj po dlugosci imienia 

            Zawodnik[] wynik3 = dane
                .Where(x => x.Nazwisko.ToLower().EndsWith("a") &&
                        x.Wzrost > x.Waga * 2 &&
                        x.DataUrodzenia.Month > 6
                        )
                .OrderBy(x => x.Kraj)
                .ThenBy(x => x.Imie.Length)
                .ThenByDescending(x => x.Wzrost)
                .ToArray();
            /*
               select * from zawodnicy
               --where right(nazwisko,1) = 'a'
               where nazwisko like '%a' and wzrost > waga*2 and month(data_ur) > 6
               order by kraj, len(imie), wzrost desc
               */
            var wynik4 = dane
              .Where(x => x.Nazwisko.ToLower().EndsWith("a") &&
                      x.Wzrost > x.Waga * 2 &&
                      x.DataUrodzenia.Month > 6
                      )
              .OrderBy(x => x.Kraj)
              .ThenBy(x => x.Imie.Length)
              .ThenByDescending(x => x.Wzrost)
              .Select(x => x.Nazwisko + ' ' + x.Imie)
              .ToArray();
            // dodaj do zawodnika mini właściwość BMI i ją uzupełnij 

            //select imie, nazwisko, kraj, waga/ power(wzrost / 100.0, 2) as bmi
            //from zawodnicy
            ZawodnikMini[] wynik5 = dane.Select(x => new ZawodnikMini()
            {
                Imie = x.Imie,
                Nazwisko = x.Nazwisko,
                Kraj = x.Kraj,
                BMI = x.Waga / Math.Pow(x.Wzrost / 100.0, 2)
            }).ToArray();

            foreach (var z in wynik5)
                // Console.WriteLine(z.Imie + " " + z.Nazwisko + " " + z.Kraj + " "+ String.Format("{0:0.00}", z.BMI));
                Console.WriteLine(z.Imie + " " + z.Nazwisko + " " + z.Kraj + " " + Math.Round(z.BMI, 2));

            // Console.ReadKey();


            // przygotuj zestaw obiektów zawierjacych pole "ImieNazwisko" oraz Współczynnik 
            // określonyjako suma wagi i wzrostu. 


            var wynik6 = dane.Select(x => new
            {
                ImieNazwisko = x.Imie + " " + x.Nazwisko,
                Wspolczynnik = x.Waga + x.Wzrost,
                Zagadka = x.Waga > x.Wzrost
            }).ToArray();

            //foreach (var jakisZawodnik in wynik6)
            //    Console.WriteLine(jakisZawodnik.ImieNazwisko + " " + jakisZawodnik.Wspolczynnik);

            int wspolczynnik = wynik6[wynik6.Length - 1].Wspolczynnik;

            // grupowanie

            dane[0].Kraj = null;

            var wynik7 = dane.GroupBy(x => x.Kraj).Select(x => new
            {
                MojKraj = x.Key,
                SredniWZrost = x.Average(y => y.Wzrost)
            }).ToArray();

            // jakiego typu jest wynik ? tablica obiektów anonimowych , co do których wiemy , że
            // kazy element tej tablicy to obiekt anonimowy, który posiada właściwosći : "MojKraj" i "SredniWzrost"

            foreach (var g in wynik7)
            {
                Console.WriteLine(g.MojKraj + " " + g.SredniWZrost);
            }

            // wypisz wszystkie wartości długości nazwiska, wraz z informacją ile osób posiada
            // nazwisko o podanej długości 
            //np:
            // nazwisko o długości 5 ma 4 osoby
            // nazwisko o długości 7 ma 6 osoby
            // nazwisko o długości 6 ma 6 osoby
            //.... itd..
            // wyniki posortuj po liczibie osób w grupie rosnąco
            // , a jeżeli liczba osób jest taka sama to po długości nazwiska malejąco

            // * uwzgędnij tylko zawodników, których nazwisko nie zaczyna się na "a"
            // i wypisz tylko te grupy, które zawierają co najmniej 2 osoby 


            var wynik8 = dane
                .Where(x => !x.Nazwisko.ToLower().StartsWith("a"))
                .GroupBy(x => x.Nazwisko.Length)
                .Select(x => new
                {
                    DlugoscNazwiska = x.Key,
                    LiczbaOsob = x.Count()
                })
                .Where(x => x.LiczbaOsob >= 2)
                .OrderBy(x => x.LiczbaOsob).ThenByDescending(x => x.DlugoscNazwiska)
                .ToArray();

            //select len(nazwisko) dlugosc, count(*) liczbaOsob
            //from zawodnicy
            //where left(nazwisko, 1) != 'a'
            // group by len(nazwisko)
            // having count(*)>= 2
            // order by liczbaOsob, dlugosc desc

            foreach (var g in wynik8)
                Console.WriteLine($"nazwisko o długości {g.DlugoscNazwiska} ma {g.LiczbaOsob} osoby");

            // zad 2 
            // wypisz zawodników , których waga jest o dokładnie 1 kilogram mniejsza
            // od wagi najwyższego zawodnika

            //int maksymlanyWzrost = dane.Select(x => x.Wzrost).ToArray().Max();
            int maksWzrost1 = dane.Select(x => x.Wzrost).Max();

            int maksWzrost2= dane.Select(x => x.Wzrost).OrderByDescending(x => x).FirstOrDefault();

            int maksWzrost3 = dane.Select(x => x.Wzrost).OrderByDescending(x => x).ToArray()[0];




            Console.ReadKey();
        }
    }
}
