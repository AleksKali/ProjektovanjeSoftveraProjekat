using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class PretraziClanoveSO : SOBase
    {

        public List<Clan> Rezultat { get; private set; }

        private readonly Clan c;

        public PretraziClanoveSO(Clan c)
        {
            this.c = c;
        }
        protected override void Execute()
        {
            Rezultat = repozitorijum.Search(c).OfType<Clan>().ToList();
        }
    }
}
