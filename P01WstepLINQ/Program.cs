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

        }
    }
}
