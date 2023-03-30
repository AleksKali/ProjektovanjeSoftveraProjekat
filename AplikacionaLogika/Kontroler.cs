using DBBroker;
using Domen;
using Repozitorijum;
using Server.SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
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



        public List<Primerak> VratiPrimerkeZaduzenja(ZaduzenjePrimerak zp)
        {
            SOBase so = new PretraziPrimerkeSO(zp);
            so.ExecuteTemplate();
            return ((PretraziPrimerkeSO)so).Rezultat;
        }

        

        public List<ZaduzenjePrimerak> VratiZaduzenja()
        {

            SOBase so = new VratiZaduzenjaSO();
            so.ExecuteTemplate();
            return ((VratiZaduzenjaSO)so).Rezultat;

        }


        public int DodajClana(Clan clan) 
        {

            SOBase so = new DodajClanaSO(clan);
            so.ExecuteTemplate();
            return ((DodajClanaSO)so).Rezultat;
        }

        public List<Primerak> VratiPrimerke(Primerak p)
        {
            SOBase so = new VratiPrimerkeSO(p);
            so.ExecuteTemplate();
            return ((VratiPrimerkeSO)so).Rezultat;

        }

        public void Razduzi(Zaduzenje z)
        {
            SOBase so = new IzmeniZaduzenjeSO(z);
            so.ExecuteTemplate();
            
        }


        public void IzbrisiClanarinu(Clanarina c)
        {

            SOBase so = new IzbrisiClanarinuSO(c);
            so.ExecuteTemplate();
        }
        public void EvidentirajClanarinu(Clanarina c)
        {
            SOBase so = new EvidentirajClanarinuSO(c);
            so.ExecuteTemplate();
        }
       

        public void SacuvajZaduzenje(Zaduzenje zaduzenje)
        {
                SOBase so = new DodajZaduzenjeSO(zaduzenje);
                so.ExecuteTemplate();
          
        }

        public Korisnik Login(Korisnik user)
        {
            SOBase so = new PrijaviKorisnikaSO(user);
            so.ExecuteTemplate();
            return ((PrijaviKorisnikaSO)so).Rezultat;
        }

      
            
        public List<Clan> PretraziClanove(Clan c)
        {
            SOBase so = new PretraziClanoveSO(c);
            so.ExecuteTemplate();
            return ((PretraziClanoveSO)so).Rezultat;

           
        }

        public void IzmeniClana(Clan c)
        {
            SOBase so = new IzmeniClanaSO(c);
            so.ExecuteTemplate();
        }

        public void ObrisiClana(Clan c)
        {
                SOBase so = new ObrisiClanaSO(c);
                so.ExecuteTemplate();
          
            
            
        }
        public List<Clan> VratiClanove()
        {
            SOBase so = new VratiClanoveSO();
            so.ExecuteTemplate();
            return ((VratiClanoveSO)so).Rezultat;
        }
        public List<ZaduzenjePrimerak> VratiZaduzenjaClana(ZaduzenjePrimerak zp)
        {

            SOBase so = new VratiZaduzenjaClanaSO(zp);
            so.ExecuteTemplate();
            return ((VratiZaduzenjaClanaSO)so).Rezultat;

        }
        public List<Igrica> PretraziIgrice(Igrica i)
        {
            
            SOBase so = new PretraziIgriceSO(i);
            so.ExecuteTemplate();
            return ((PretraziIgriceSO)so).Rezultat;

        }
        public List<Igrica> VratiIgrice()
        {
            SOBase so = new VratiIgriceSO();
            so.ExecuteTemplate();
            return ((VratiIgriceSO)so).Rezultat;
           
        }

        public List<Clanarina> VratiClanarine()
        {
            SOBase so = new VratiClanarineSO();
            so.ExecuteTemplate();
            return ((VratiClanarineSO)so).Rezultat;
        }

    }
}
