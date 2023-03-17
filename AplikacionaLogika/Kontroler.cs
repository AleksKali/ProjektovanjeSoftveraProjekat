using DBBroker;
using Domen;
using Repozitorijum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacionaLogika
{
    public class Kontroler
    {
        #region Singleton
        private static Kontroler instance;
        private Kontroler()
        {
        }

        public static Kontroler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Kontroler();
                }
                return instance;
            }
        }
        
    



        #endregion

        public Korisnik Korisnik { get; private set; }

        

        private Broker broker = new Broker();
        private KorisnikRepozitorijum korisnikRepozitorijum = new KorisnikRepozitorijum();
        private ClanRepozitorijum clanRepozitorijum = new ClanRepozitorijum();

       

        private IgricaRepozitorijum igricaRepozitorijum = new IgricaRepozitorijum();
        private ClanarinaRepozitorijum clanarinaRepozitorijum = new ClanarinaRepozitorijum();
        private ZaduzenjeRepozitorijum zaduzenjeRepozitorijum = new ZaduzenjeRepozitorijum();


        public List<Primerak> VratiPrimerkeZaduzenja(int zaduzenjeId)
        {
            return igricaRepozitorijum.VratiPrimerkeZaduzenja(zaduzenjeId);
        }

        public void StatusClanarine(Label lblNemaClanarine, Label lblClanarinaIstekla, Label lblClanarinaNijeIstekla, Clan c)
        {
            List<Clanarina> lista = clanarinaRepozitorijum.VratiClanarine();

            foreach (Clanarina cla in lista)
            {
                if (cla.Clan.ClanskiBroj == c.ClanskiBroj)
                {
                    if (cla.DatumDo > DateTime.Now)
                    {
                        lblClanarinaNijeIstekla.Visible = true;
                        return;
                    }
                    else
                    {
                        lblClanarinaIstekla.Visible = true;
                        return;
                    }
                }
            }
            lblNemaClanarine.Visible = true;
        }

        public List<ZaduzenjePrimerak> VratiZaduzenja()
        {
            return zaduzenjeRepozitorijum.VratiZaduzenja();
        }


        public int DodajClana(Clan clan) 
        {
            return clanRepozitorijum.DodajClana(clan);
        }

        public List<Primerak> VratiPrimerke(ComboBox cbIgrica)
        {
            return igricaRepozitorijum.VratiPrimerke((Igrica)cbIgrica.SelectedItem);
            return new List<Primerak>();
        }

        public void Razduzi(Zaduzenje z)
        {
            try
            {
                zaduzenjeRepozitorijum.Razduzi(z);
                MessageBox.Show("Uspesno razduzivanje.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesno razduzivanje.");
                Debug.WriteLine(">>>>>>>>> " + ex.Message);
            }
        }

        public void SacuvajClanarinu(ComboBox cbIzborClana, DateTimePicker dtpDatumOd, DateTimePicker dtpDatumDo)
        {
            Clanarina c = new Clanarina
            {
                Clan = (Clan)cbIzborClana.SelectedItem,
                DatumDo = dtpDatumDo.Value,
                DatumOd = dtpDatumOd.Value
            };
            if (c.DatumDo < c.DatumOd)
            {
                MessageBox.Show("Datum do mora biti veci od datuma od. ");
                return;
            }

            List < Clanarina > clanarine = clanarinaRepozitorijum.VratiClanarine();
            if (clanarine.Contains(c))
            {
                foreach (Clanarina cl in clanarine)
                {
                    if (cl.Clan.ClanskiBroj == c.Clan.ClanskiBroj)
                    {
                        if (cl.DatumDo > c.DatumOd)
                        {

                            MessageBox.Show("Clanarina istice tek " + cl.DatumDo.ToShortDateString() + ". Sledecu clanarinu evidentirajte nakon tog datuma.");
                            return;
                        }
                        else
                        {
                            try
                            {

                                clanarinaRepozitorijum.IzbrisiClanarinu(cl);
                                clanarinaRepozitorijum.SacuvajClanarinu(c);
                                MessageBox.Show("Clanarina uspesno sacuvana!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Greska pri skladistenju u bazu. ");
                                Debug.WriteLine(">>>>>>>>> " + ex.Message);
                            }

                        }
                    }

                }
            }
            else
            {
                try
                {

                    clanarinaRepozitorijum.SacuvajClanarinu(c);
                    MessageBox.Show("Clanarina uspesno sacuvana!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri skladistenju u bazu. ");
                    Debug.WriteLine(">>>>>>>>> " + ex.Message);
                }
            }
           


            
        }

        public void SacuvajZaduzenje(Zaduzenje zaduzenje)
        {
            try
            {
                zaduzenjeRepozitorijum.SacuvajZaduzenje(zaduzenje);
                MessageBox.Show("Uspesno sacuvano zaduzenje!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Zaduzenje nije sacuvano."+ex.Message);
            }
        }

        public Korisnik Login(Korisnik user)
        {
            
            List<Korisnik> users = korisnikRepozitorijum.GetUsers();

            foreach (Korisnik u in users)
            {
                if (u.KorisnickoIme == user.KorisnickoIme && u.KorisnickaSifra == user.KorisnickaSifra)
                {
                    Korisnik = u;
                    return u;
                }
            }
            return null;
        }

        public int DodajClana(string ime, string prezime, string jmbg, string kontakt, string mail, string ulica, string broj)
        {
            Clan c = new Clan { };
            return clanRepozitorijum.DodajClana(c);
        }
            
        public List<Clan> VratiClanove(string ime)
        {

            List<Clan> clanovi = clanRepozitorijum.VratiClanove(ime);
            return clanovi;
        }

        public void IzmeniClana(Clan c)
        {
            clanRepozitorijum.IzmeniClana(c);
        }

        public void ObrisiClana(Clan c)
        {
            clanRepozitorijum.ObrisiClana(c);
        }
        public List<Clan> VratiClanove()
        {
            return clanRepozitorijum.VratiClanove();
        }
        public List<ZaduzenjePrimerak> VratiZaduzenjaClana(int clanskiBroj)
        {
            List<ZaduzenjePrimerak> zaduzenja = zaduzenjeRepozitorijum.VratiZaduzenjaClana(clanskiBroj);
            return zaduzenja;
        }
        public List<Igrica> VratiIgrice(string ime)
        {
            List<Igrica> igrice = igricaRepozitorijum.VratiIgrice(ime);
            return igrice;
        }
        public List<Igrica> VratiIgrice()
        {
           
                List<Igrica> igrice = igricaRepozitorijum.VratiIgrice();
                return igrice;
           
           
        }

        public List<Clanarina> VratiClanarine()
        {
            List<Clanarina> clanarine = clanarinaRepozitorijum.VratiClanarine();

            return clanarine;
        }

    }
}
