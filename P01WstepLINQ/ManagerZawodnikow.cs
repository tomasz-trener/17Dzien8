 
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
//using P02ZadanieZawodnicy.Domain;

namespace P01WstepLINQ
{
    public enum TypImportu
    {
        Lokalny,
        Zdalny
    }

    public class ManagerZawodnikow
    {
        // public List<string> BlednieSformatowaneWiersze { get;  }

        private List<string> blednieSformatowaneWiersze; // pole 
        public List<string> BlednieSformatowaneWiersze // właściwość
        {
            get { return blednieSformatowaneWiersze; }
            // set { blednieSformatowaneWiersze = value; }
        }

        public TypImportu TypImportu { get; } // z zewnatrz tylko do odczytu 
        public string Path { get; }

        public Zawodnik[] Zawodnicy => zawodnicy;

        private Zawodnik[] zawodnicy;

        public ManagerZawodnikow(TypImportu typImportu, string path)
        {
            TypImportu = typImportu;
            Path = path;
        }

        public Zawodnik[] WczytajZawodnikow()
        {
            // string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string wiersze;
            if (TypImportu == TypImportu.Zdalny)
            {
                WebClient wc = new WebClient();
                wiersze = wc.DownloadString(Path);
            }
            else if (TypImportu == TypImportu.Lokalny)
                wiersze = File.ReadAllText(Path);
            else
                throw new Exception("Nieznany typ importu");
       
            string[] tabWierszy = wiersze.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Zawodnik[] zawodnicy = new Zawodnik[tabWierszy.Length - 1];

            blednieSformatowaneWiersze = new List<string>();
            List<Zawodnik> zawodnicy = new List<Zawodnik>();

            for (int i = 1; i < tabWierszy.Length; i++)
            {
                string[] komorki = tabWierszy[i].Split(';');

                Zawodnik z = new Zawodnik();

                try
                {
                    z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                    if (!string.IsNullOrEmpty(komorki[1]))
                        z.Id_trenera = Convert.ToInt32(komorki[1]);

                    z.Imie = komorki[2];
                    z.Nazwisko = komorki[3];
                    z.Kraj = komorki[4];

                    z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                    z.Wzrost = Convert.ToInt32(komorki[6]);
                    z.Waga = Convert.ToInt32(komorki[7]);
                }
                catch (Exception)
                {
                    blednieSformatowaneWiersze.Add(tabWierszy[i]);
                    continue;
                }

                //zawodnicy[i - 1] = z;
                zawodnicy.Add(z);
            }

            this.zawodnicy = zawodnicy.ToArray();
            return this.zawodnicy;
        }


        public int PodajLiczbeZawodnikow(string kraj)
        {
            //Zawodnik[] zawodnicy = WczytajZawodnikow();

            int sum = 0;
            kraj = kraj.ToLower();

            foreach (var z in zawodnicy)
                if (z.Kraj.ToLower() == kraj)
                    sum++;

            return sum;
        }

        public GrupaKraj[] PodajSredniWzrost()
        {
            string[] kraje = podajKraje();

            List<GrupaKraj> gk = new List<GrupaKraj>();

            foreach (var k in kraje)
            {
                Zawodnik[] zk = PodajZawodnikow(k);

                int suma = 0;
                foreach (var z in zk)
                    suma += z.Wzrost;

                gk.Add(new GrupaKraj()
                {
                    NazwaKraju = k,
                    SredniWzrost = Convert.ToDouble(suma) / zk.Length
                });

            }

            return gk.ToArray();

        }

        /// <summary>
        /// Zwraca unikalna kolekcje krajow 
        /// </summary>
        /// <returns></returns>
        private string[] podajKraje()
        {
            List<string> kraje = new List<string>();
            foreach (var z in zawodnicy)
                if (!kraje.Contains(z.Kraj.ToLower()))
                    kraje.Add(z.Kraj.ToLower());

            return kraje.ToArray();
        }

        public Zawodnik[] PodajZawodnikow(string kraj)
        {
            List<Zawodnik> zawodnicy = new List<Zawodnik>();
             
            kraj = kraj.ToLower();

            foreach (var z in this.zawodnicy)
                if (z.Kraj.ToLower() == kraj)
                    zawodnicy.Add(z);
            return zawodnicy.ToArray();

        }

        public void Zapisz(Zawodnik z)
        {
            for (int i = 0; i < zawodnicy.Length; i++)
                if (zawodnicy[i].Id_zawodnika == z.Id_zawodnika)
                    zawodnicy[i] = z;

            string[] dane = new string[zawodnicy.Length+1];
            dane[0] = "id_zawodnika;id_trenera;imie;nazwisko;kraj;data urodzenia;wzrost;waga";

            for (int i = 0; i < zawodnicy.Length; i++)
                dane[i+1] = zawodnicy[i].Wiersz;

            File.WriteAllLines("c:\\dane\\zawodnicy.txt", dane,Encoding.UTF8);
        }

        //Microsoft® SQL Server® 2019 Express 
        //SQL Server Management Studio (SSMS)



    }
}
