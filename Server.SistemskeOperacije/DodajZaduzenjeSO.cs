using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class DodajZaduzenjeSO : SOBase
    {
        private readonly Zaduzenje z;

        public DodajZaduzenjeSO(Zaduzenje z)
        {
            this.z = z;
        }
        protected override void Execute()
        {
            ZaduzenjePrimerak zp;
            int id = repozitorijum.SaveWithOutput(z);
            foreach (Primerak p in z.Primerci)
            {

                zp = new ZaduzenjePrimerak
                {
                    ZaduzenjeId = id,
                    InventarskiBrojPrimerka = p.InventarskiBroj,
                    IgricaID = p.Igrica.IgricaId
                };
                repozitorijum.Save(zp);

                p.izdat = 1;
                repozitorijum.Update(p);

            }
        }
    }
}
