using DBBroker;
using Domen;
using Repozitorijum;
using System;
using System.Collections.Generic;
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

        public int DodajClana(Clan clan) //fja dodata 4.marta
        {
            return clanRepozitorijum.DodajClana(clan); //moze da baci exception moras to da obradis
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

        public List<Zaduzenje> VratiZaduzenjaClana(Clan c)
        {
            List<Zaduzenje> zaduzenja = clanRepozitorijum.VratiZaduzenjaClana(c);
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
