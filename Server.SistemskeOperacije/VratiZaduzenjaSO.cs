using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiZaduzenjaSO : SOBase
    {
        public List<ZaduzenjePrimerak> Rezultat { get; private set; }
        protected override void Execute()
        {
            Rezultat = repozitorijum.GetAll(new ZaduzenjePrimerak()).OfType<ZaduzenjePrimerak>().ToList();
        }
    }
}
