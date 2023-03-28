using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class PrijaviKorisnikaSO : SOBase
    {
        public Korisnik Rezultat { get; private set; }
        private readonly Korisnik k;

        public PrijaviKorisnikaSO(Korisnik k)
        {
            this.k = k;
        }
        protected override void Execute()
        {
            List<Korisnik> users = repozitorijum.GetAll(new Korisnik()).OfType<Korisnik>().ToList();
            Rezultat = null;

            foreach (Korisnik u in users)
            {
                if (u.KorisnickoIme == k.KorisnickoIme && u.KorisnickaSifra == k.KorisnickaSifra)
                {
                    Rezultat = u;
                }
            }

        }
    }
}
