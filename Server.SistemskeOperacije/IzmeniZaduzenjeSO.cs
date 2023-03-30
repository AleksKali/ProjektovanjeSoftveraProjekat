using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class IzmeniZaduzenjeSO : SOBase
    {
        private readonly Zaduzenje z;

        public IzmeniZaduzenjeSO(Zaduzenje z)
        {
            this.z = z;
        }
        protected override void Execute()
        {
            List<Zaduzenje> lista = repozitorijum.Search(z).OfType<Zaduzenje>().ToList();

            int brojPrimeraka = lista[0].brojPrimeraka;

            ZaduzenjePrimerak zp = new ZaduzenjePrimerak();

            if (brojPrimeraka == z.Primerci.Count)
            {
                repozitorijum.Update(z);
            }

            foreach (Primerak p in z.Primerci)
            {
                zp.ZaduzenjeId = z.ZaduzenjeID;
                zp.IgricaID = p.Igrica.IgricaId;
                zp.InventarskiBrojPrimerka = p.InventarskiBroj;

                repozitorijum.Update(zp);

                p.izdat = 0;
                repozitorijum.Update(p);

            }
        }
    }
}
