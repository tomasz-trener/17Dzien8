using P06BibliotekaPolaczenieZBaza;
using P02AplikacjaZawodnicy.Domain;
using P02AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace P02AplikacjaZawodnicy
{
    public partial class FrmStartowy : Form
    {
        public FrmSzczegoly frmSzczegoly { get; set; }
        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
            ZasilWykres();
        }

        private void ZasilWykres()
        {
            chWykres.Series.Clear();

            Series seria = new Series("Wzrost");
            seria.ChartType = SeriesChartType.Column;

            Zawodnik[] dane = (Zawodnik[])lbDane.DataSource;

            var grupy = dane.GroupBy(x => x.Kraj)
                .Select(x => new
                {
                    osX = x.Key,
                    osY = x.Average(y => y.Wzrost)
                });

            string[] wartosci_x = grupy.Select(x=>x.osX).ToArray();
            double?[] wartosci_y = grupy.Select(x => x.osY).ToArray();

            seria.Points.DataBindXY(wartosci_x, wartosci_y);
            chWykres.Series.Add(seria);

        }

        public void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            int nrStrony = Convert.ToInt32(numStrona.Value);
            int wielkoscStrony = 4;

            ZawodnicyResult wynik = zr.PodajZawodnikow(txtSzukaj.Text, nrStrony, wielkoscStrony);
            lbDane.DataSource = wynik.Zawodnicy;
            lbDane.DisplayMember = "DaneRaportowe";



            decimal maksStrona = Math.Ceiling(wynik.MaksymalnaLiczbaElementow / Convert.ToDecimal(wielkoscStrony));
            lblLiczbaStron.Text = maksStrona.ToString();
            numStrona.Maximum = maksStrona;
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony =
                (Zawodnik)lbDane.SelectedItem;

            if (frmSzczegoly==null)
            {
                frmSzczegoly = new FrmSzczegoly(zaznaczony, this);
                frmSzczegoly.Show();
            }
            else
                frmSzczegoly.UzupelnijFormularz(zaznaczony);       
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (frmSzczegoly == null)
            {
                frmSzczegoly = new FrmSzczegoly(this);
                frmSzczegoly.Show();
            }
        }

        private void rbSortuj_CheckedChanged(object sender, EventArgs e)
        {
            Zawodnik[] dane = (Zawodnik[])lbDane.DataSource;
            if (rbSortujImie.Checked)
            {
                //Odswiez();
                lbDane.DataSource = dane.OrderBy(x => x.Imie).ToArray();
            }
            else if (rbSortujNazwisko.Checked)
            {
               // Odswiez();
                lbDane.DataSource = dane.OrderBy(x => x.Nazwisko).ToArray();
            }
            else if (rbSortujKraj.Checked)
            {
              //  Odswiez();
                lbDane.DataSource = dane.OrderBy(x => x.Kraj).ToArray();
            }
        }

        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            //Odswiez();
            //ZasilWykres();
        }

        private void numStrona_ValueChanged(object sender, EventArgs e)
        {
            Odswiez();
            ZasilWykres();
        }

        private void txtSzukaj_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Odswiez();
                ZasilWykres();
                //e.Handled = true;
            }
        }
    }
}
