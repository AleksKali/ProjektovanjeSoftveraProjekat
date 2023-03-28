using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public class ObrisiClanaSO : SOBase
    {
        private readonly Clan c;

        public ObrisiClanaSO(Clan c)
        {
            this.c = c;
        }
        protected override void Execute()
        {
            repozitorijum.Delete(c);
        }
    }
}
