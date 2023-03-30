using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiZaduzenjaClanaSO : SOBase
    {
        public List<ZaduzenjePrimerak> Rezultat { get; private set; }

        private readonly ZaduzenjePrimerak zp;

        public VratiZaduzenjaClanaSO(ZaduzenjePrimerak zp)
        {
            this.zp = zp;
        }
        protected override void Execute()
        {
            List<ZaduzenjePrimerak> lista = repozitorijum.Search(zp).OfType<ZaduzenjePrimerak>().ToList();
            Zaduzenje z;
            List<ZaduzenjePrimerak> pomocna = new List<ZaduzenjePrimerak>();

            foreach (ZaduzenjePrimerak zaduzenjePrimerak in lista)
            {
                z = new Zaduzenje
                {
                    ZaduzenjeID = zaduzenjePrimerak.ZaduzenjeId
                };

               zaduzenjePrimerak.BrojPrimeraka =  (repozitorijum.Search(z).OfType<Zaduzenje>().ToList())[0].brojPrimeraka;

                if (!pomocna.Contains(zaduzenjePrimerak))
                {
                    pomocna.Add(zaduzenjePrimerak);
                }
            }


            

            //lista = lista.Distinct().ToList();
            Rezultat = pomocna;
        }
    }
}
