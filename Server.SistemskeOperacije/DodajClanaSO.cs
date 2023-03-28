using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class DodajClanaSO : SOBase
    {
        public int Rezultat { get; private set; }

        private readonly Clan c;

        public DodajClanaSO(Clan c)
        {
            this.c = c;
        }
        protected override void Execute()
        {
            Rezultat = repozitorijum.SaveWithOutput(c);
        }
    }
}
