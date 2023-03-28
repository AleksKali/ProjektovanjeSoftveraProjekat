using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class PretraziPrimerkeSO : SOBase
    {
        public List<Primerak> Rezultat { get; private set; }

        private readonly Primerak p;

        public PretraziPrimerkeSO(ZaduzenjePrimerak zp)
        {
            p = new Primerak
            {
                uslovPretrage = zp.ZaduzenjeId
            };
        }
        protected override void Execute()
        {
            Rezultat = repozitorijum.Search(p).OfType<Primerak>().ToList();
        }
    }
}
