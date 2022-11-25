using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01WstepLINQ
{
    public class Zawodnik
    {
        public int  Id_zawodnika { get; set; }
        public int? Id_trenera { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public int Wzrost { get; set; }
        public int Waga { get; set; }

        public string ImieNazwisko
        {
            get
            {
                return  Nazwisko + " " + Imie.Substring(0,1) + ".";
            }
        }

        public string DataSformatowana => DataUrodzenia.ToString("yyyy-MM-dd");

        public string Wiersz =>
                    $"{Id_zawodnika};{Id_trenera};{Imie};{Nazwisko};{Kraj};" +
                    $"{DataSformatowana};{Wzrost};{Waga}";

        public string DaneRaportowe =>
            $"{Imie} {Nazwisko} {Kraj} {DataSformatowana}";
        
    }
}
