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
            Rezultat = repozitorijum.Search(zp).OfType<ZaduzenjePrimerak>().ToList();
        }
    }
}
