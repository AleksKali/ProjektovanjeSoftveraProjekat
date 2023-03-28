using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class VratiPrimerkeSO : SOBase
    {
        public List<Primerak> Rezultat { get; private set; }

        private readonly Primerak p;

        public VratiPrimerkeSO(Primerak p)
        {
            this.p = p;
        }
        protected override void Execute()
        {
            Rezultat = repozitorijum.GetAll(p).OfType<Primerak>().ToList();
        }
    }
}
